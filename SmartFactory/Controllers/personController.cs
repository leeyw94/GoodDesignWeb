using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartFactory.Models;
using static SmartFactory.Controllers.SysController;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using System.IO;
using SmartFactory.Util;
using LazZiya.ImageResize;

namespace SmartFactory.Controllers
{
    public class personController : Controller
    {
        private readonly db_e db = new db_e();

        #region 첨부파일 변수
        private IHttpContextAccessor _accessor;
        // public static string company_id = "GoodDegign";
        private readonly long _fileSizeLimit;
        private readonly string[] _permittedExtensions = { ".txt", ".pdf", ".jpg", ".png", ".zip", ".gif", ".jpeg", ".hwp" };
        private readonly string _targetFilePath;
        public static IConfigurationRoot Configuration { get; set; }
        public personController(IConfiguration config)
        {
            _fileSizeLimit = config.GetValue<long>("FileSizeLimit");

            // To save physical files to a path provided by configuration:
            _targetFilePath = config.GetValue<string>("StoredFilesPath");

            // To save physical files to the temporary files folder, use:
            //_targetFilePath = Path.GetTempPath();
        }
        #endregion
        // 작성 및 수정
        public IActionResult person_set(person doc, int? idx)
        {
            #region 기본 사용자 정보
            string user_id = User.Identity.Name;
            int department_idx = Convert.ToInt32(UserData.user_get(user_id, "department_idx"));
            int company_idx = Convert.ToInt32(UserData.user_get(user_id, "company_idx"));
            int auth = Convert.ToInt32(UserData.user_get(user_id, "auth"));
            #endregion


            //======================================================================================================================================================== 
            var company =
                db.company.Where(
                    p =>
                    (p.idx == company_idx)).
                    OrderBy(o => o.company_name).Select(c => new { 값 = c.idx, 이름 = c.company_name });
            ViewBag.회사 = new SelectList(company.AsEnumerable(), "값", "이름");
            //======================================================================================================================================================== 


            //======================================================================================================================================================== 
            var department =
                db.department.Where(p => (p.company_idx == company_idx && p.use_yn == "Y")).OrderBy(
                    o => o.department_name).Select(c => new { 값 = c.idx, 이름 = c.department_name });
            ViewBag.부서 = new SelectList(department.AsEnumerable(), "값", "이름");
            //======================================================================================================================================================== 


            //======================================================================================================================================================== 
            var code_position =
                db.code_position.Where(p => (p.company_idx == company_idx && p.use_yn == "Y")).OrderBy(
                    o => o.index_order).Select(c => new { 값 = c.code_id, 이름 = c.code_name });
            ViewBag.직책 = new SelectList(code_position.AsEnumerable(), "값", "이름");
            //======================================================================================================================================================== 

            if (idx != null)
            {
                doc = db.person.Single(x => x.idx == idx);
                var _list = (from a in db.Md_Image where a.Md_id == doc.fileId && a.use_yn != "N" select a).OrderByDescending(p => p.id).ToList();

                ViewBag.이미지리스트 = _list;
                ViewBag.이미지리스트카운트 = _list.Count();
            }

                     
            else
            {
                ViewBag.이미지리스트 = "";
                ViewBag.이미지리스트카운트 = 0;

            }

            return View(doc);
        }

        public async Task<IActionResult> person_set_action(person doc, int? idx, string mode_type, List<IFormFile> ImageFile)
        {
            string file_id = "";

            #region 기본 사용자 정보
            string user_id = User.Identity.Name;
            int department_idx = Convert.ToInt32(UserData.user_get(user_id, "department_idx"));
            int company_idx = Convert.ToInt32(UserData.user_get(user_id, "company_idx"));
            int auth = Convert.ToInt32(UserData.user_get(user_id, "auth"));
            #endregion

            string msg = "";



            if (doc.use_yn == "on")
            {
                doc.use_yn = "Y";
            }
            else
            {
                doc.use_yn = "N";
            }


            if (idx == null)
            {
                #region 저장
                msg = "입력";
                file_id = user_id + DateTime.Now.ToShortDateString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString();

                doc.write_date = DateTime.Now;
                doc.fileId = file_id;
                db.person.Add(doc);
                db.SaveChanges(); // 실제로 저장 


                msg = Util.msg.msg_insert;

                #endregion
            }
            else
            {


                if (mode_type == "D")
                {
                    #region 삭제



                    person _update =
                      (from a in db.person where a.idx == idx select a).Single();
                    _update.use_yn = "N";


                    db.SaveChanges(); // 실제로 저장 



                    #endregion
                }
                else
                {
                    #region 수정
                    msg = "수정";
                    file_id = doc.fileId;

                    if (string.IsNullOrEmpty(file_id))
                    {

                        file_id = user_id + DateTime.Now.ToShortDateString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString();

                        doc.fileId = file_id;
                    }

                    doc.edit_date = DateTime.Now;
                   

                    db.Entry(doc).State = EntityState.Modified;

                    //idx 제외 업데이트=================================
                    db.Entry(doc).Property("write_date").IsModified = false;
                    db.Entry(doc).Property("work_end_date").IsModified = false;
                    //==================================================


                    db.SaveChanges();

                    msg = Util.msg.msg_edit;

                    #endregion
                }
            }
            #region 파일 올리기


            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            Configuration = builder.Build();
            string Models_photo = Configuration["user_app:file_list_url"];
            string company_id = UserData.user_get(user_id, "company_id");


            int s = 1;
            foreach (var formFile in ImageFile)
            {
                double file_size = formFile.Length;
                if (file_size < _fileSizeLimit)
                {

                    var formFileContent =
                        await FileHelpers
                            .ProcessFormFile<IFormFile>(
                                formFile, ModelState, _permittedExtensions,
                                _fileSizeLimit);


                    #region 변수
                    // 변수 =========================================================================================================================
                    string only = user_id + DateTime.Today.ToShortDateString().Replace("-", "") + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString();
                    //  var trustedFileNameForFileStorage = Path.GetRandomFileName();   //랜덤이름                      

                    string file_ex = ""; // 확장자

                    try { file_ex = Path.GetFileName(formFile.FileName).Split('.').Last(); }
                    catch
                    {

                    }
                    var _fileName = only + "." + file_ex;     // 신규 파일 이름   



                    var _local_path = _targetFilePath + company_id + "/";           // 신규 파일 경로
                    var filePath = Path.Combine(_local_path, _fileName);            // 전체 경로
                    string desiredThumbPath = _local_path + "s/";                   // 작은 이미지 전체 경로

                    string ore_fileName = Path.GetFileName(formFile.FileName);
                    #endregion




                    //경로에 폴더가 없으면 만들어준다.=============================================
                    var dInfo = new DirectoryInfo(_local_path);
                    var dInfo_s = new DirectoryInfo(desiredThumbPath);
                    if (!dInfo.Exists)
                    {
                        dInfo.Create();
                    }
                    if (!dInfo_s.Exists)
                    {
                        dInfo_s.Create();
                    }
                    //=================================================================================



                    using (var fileStream = System.IO.File.Create(filePath))
                    {
                        await fileStream.WriteAsync(formFileContent);

                    }

                    if (get_word.img_check(file_ex) == "img")
                    {
                        // 세로 기준
                        ResizeImage(desiredThumbPath, formFile, _fileName, 300, 0);
                    }


                    var _insert = new Md_Image()
                    {
                        Md_id = file_id,
                        ImagePath = Models_photo + company_id + "/" + _fileName,
                        fileName = ore_fileName,
                        use_yn = "Y",
                        file_ex = file_ex,
                        file_size = file_size,
                        r_date = DateTime.Now,
                        write_id = User.Identity.Name,
                        sImagePath = Models_photo + company_id + "/s/" + _fileName,
                    };

                    db.Md_Image.Add(_insert);
                    db.SaveChanges();


                }
                s++;
            }


            #endregion
            return Redirect("/person/person_set_list");

        }
        public void ResizeImage(string _path, IFormFile uploadedFile, string file_name, int desiredWidth, int desiredHeight)
        {
            string webroot = _path;
            try
            {
                if (uploadedFile.Length > 0)
                {
                    using (var stream = uploadedFile.OpenReadStream())
                    {
                        var uploadedImage = System.Drawing.Image.FromStream(stream);

                        //decide how to scale dimensions
                        if (desiredHeight == 0 && desiredWidth > 0)
                        {
                            var img = ImageResize.ScaleByWidth(uploadedImage, desiredWidth); // returns System.Drawing.Image file
                            img.SaveAs(Path.Combine(webroot, file_name));
                        }
                        else if (desiredWidth == 0 && desiredHeight > 0)
                        {
                            var img = ImageResize.ScaleByHeight(uploadedImage, desiredHeight); // returns System.Drawing.Image file
                            img.SaveAs(Path.Combine(webroot, file_name));
                        }
                        else
                        {
                            var img = ImageResize.Scale(uploadedImage, desiredWidth, desiredHeight); // returns System.Drawing.Image file
                            img.SaveAs(Path.Combine(webroot, file_name));
                        }
                    }
                }
            }
            catch { }
            return;
        }

    }


}
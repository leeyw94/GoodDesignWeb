using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartFactory.Models;
using Newtonsoft.Json;
using System.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Headers;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using LazZiya.ImageResize;
using System.IO;
using SmartFactory.Util;
using ReflectionIT.Mvc.Paging;
using Microsoft.AspNetCore.Routing;

namespace SmartFactory.Controllers
{
    public class SysController : Controller
    {
        // GET: Sys
        private readonly db_e db = new db_e();


        #region 첨부파일 변수
        private IHttpContextAccessor _accessor;
        // public static string company_id = "GoodDegign";
        private readonly long _fileSizeLimit;
        private readonly string[] _permittedExtensions = { ".txt", ".pdf", ".jpg", ".png", ".zip", ".gif", ".jpeg", ".hwp" };
        private readonly string _targetFilePath;
        public static IConfigurationRoot Configuration { get; set; }
        public SysController(IConfiguration config)
        {
            _fileSizeLimit = config.GetValue<long>("FileSizeLimit");

            // To save physical files to a path provided by configuration:
            _targetFilePath = config.GetValue<string>("StoredFilesPath");

            // To save physical files to the temporary files folder, use:
            //_targetFilePath = Path.GetTempPath();
        } 
        #endregion

        /// <summary>
        /// / 로그인 정보
        // / </summary>
        public class UserData
        {
            public static string user_get(string user_id, string what)
            {



                db_e db = new db_e();
               
                string company_id = "BlueEye";
                string company_name = "BlueEye";
                string user_name = "";
                int department_idx = 0;
                int company_idx = 0;
                string department_name = "";
                int auth = 0; //초기 :0
                string user_auth = "";
                var _list = (from a in db.user.Include(p=>p.company_idxNavigation).Include(p=>p.department_idxNavigation) where a.user_id == user_id select a).Single();
               


                if (_list != null)
                {
                    company_id = _list.company_idxNavigation.company_id;
                    company_name = _list.company_idxNavigation.company_name;
                    company_idx = _list.company_idxNavigation.idx;
                    department_name = _list.department_idxNavigation.department_name;
                    user_name = _list.user_name;
                    department_idx = _list.department_idx;
                    auth = _list.check_auth; //최고 권한 관리자 :9 , 회사별 권한 관리자 : 8 , 부서장 : 7
                    user_auth = _list.user_auth; //페이지 권한 

                }

                string str = "";


                if (what == "user_id")
                {
                    str = user_id;


                }
                else if (what == "user_name")
                {
                    str = user_name;

                }
                else if (what == "company_id")
                {
                    str = company_id;

                }
                else if (what == "company_idx")
                {
                    str = company_idx.ToString();

                }
                else if (what == "company_name")
                {
                    str = company_name;

                }
                else if (what == "department_idx")
                {
                    str = department_idx.ToString();

                }
                else if (what == "department_name")
                {
                    str = department_name;

                }
                else if (what == "auth")
                {
                    str = auth.ToString();

                }
                else if (what == "user_auth")
                {
                    str = user_auth.ToString();

                }

                return str;

            }


            public void History_write(string user_id, string _page, string _state)
            {
                db_e db = new db_e();

                string user_name = UserData.user_get(user_id, "user_name");
                string department_id = UserData.user_get(user_id, "department_id");
                string department_name = UserData.user_get(user_id, "department_name");
                string company_id = UserData.user_get(user_id, "company_id");
                string company_name = UserData.user_get(user_id, "company_name");
                string auth = UserData.user_get(user_id, "auth");

                var _insert = new history
                {
                    user_id = user_id,
                    company_id = company_id,
                    department_id = department_id,
                    user_ip = "",
                    pre_page = "",
                    connect_agent = company_name,
                    connect_host = auth,
                    connect_path = user_name,
                    memo = department_name,
                    connect_date = DateTime.Now,
                    state = _state,
                    page = _page
                };

                db.history.Add(_insert);
                db.SaveChanges(); // 실제로 저장 


            }
        }





        #region 사용자 개인 정보 수정

        public ActionResult user_info(user doc)
        {
            #region 기본 사용자 정보
            string user_id = User.Identity.Name;
            string company_id    = UserData.user_get(user_id, "company_id");
            int company_idx = Convert.ToInt32(UserData.user_get(user_id, "company_idx"));
            string department_idx = UserData.user_get(user_id, "department_idx");
            string auth = UserData.user_get(user_id, "auth");
            #endregion

         
                       


            //========================================================================================================================================================
            var _code_nationality = db.code_nationality.Where(p => p.use_yn == "Y").OrderBy(P => P.index_order).Select(c => new { 값 = c.code_id, 이름 = c.code_name });
            ViewBag.언어 = new SelectList(_code_nationality.AsEnumerable(), "값", "이름");

            //========================================================================================================================================================

            //========================================================================================================================================================
            var _department = db.department.Where(p => p.company_idx == company_idx && p.use_yn != "N").OrderBy(P => P.index_order).Select(c => new { 값 = c.idx, 이름 = c.department_name });
            ViewBag.부서 = new SelectList(_department.AsEnumerable(), "값", "이름");

            //========================================================================================================================================================


            doc = db.user.Single(x => x.user_id == user_id);


            return View(doc);
        }


        [HttpPost]
        public async Task<IActionResult> userinfo_action(user doc)
        {
            #region 사용자 정보 수정
            user _update =
                     (from a in db.user where a.user_id == User.Identity.Name select a).Single();

            _update.user_tel = doc.user_tel;
            // _update.user_password = doc.user_password;
            _update.edit_date = DateTime.Now;
            _update.main_bg_color = doc.main_bg_color;
            _update.language = doc.language;
            _update.user_email = doc.user_email;


            db.SaveChanges(); // 실제로 저장  
            #endregion

            //==================================================================
            UserData UserData = new UserData();
            UserData.History_write(User.Identity.Name, "/sys/user_info", "수정");
            //===================================================================

           
            return Redirect("/sys/user_info");

        }
        #endregion
        #region 회사 설정

        public ActionResult company_set_check(string doc_it)
        {
           

            int _doc = (from a in db.company where a.company_id == doc_it select a.company_id).Count();
            var sb = new StringBuilder();
            if (_doc > 0)
            {

                sb.AppendFormat("<script>");
                sb.AppendFormat("$('#company_id').attr('value' ,'') ; ");
                sb.AppendFormat("demo.showSwal('auto-close');");
                sb.AppendFormat("$('#id_check').attr('value' ,'N') ;");
                sb.AppendFormat("$('#company_id').css('border' ,'solid 1px red') ; ");
                sb.AppendFormat("$('#company_id').focus() ; ");
                sb.AppendFormat("</script>");
                 Response.WriteAsync(sb.ToString());
            }
            else
            {
                sb.AppendFormat("<script>");

                sb.AppendFormat("$('#id_check').attr('value' ,'Y') ;");
                sb.AppendFormat("$('#company_id').css('border' ,'solid 1px green') ; ");
                sb.AppendFormat("</script>");
                Response.WriteAsync(sb.ToString());
            }


            return null;
        }



        #region company

        [Authorize]
        public ActionResult company_set(company doc, int? idx)
        {
            //======================================================================================================================================================== 
            var Code_nation =
                db.code_nationality.Where(p => p.use_yn == "Y").OrderBy(o => o.index_order).Select(
                    c => new { 값 = c.code_id, 이름 = c.code_name });
            ViewBag.국적 = new SelectList(Code_nation.AsEnumerable(), "값", "이름");

            //========================================================================================================================================================
            var code_company = db.code_company.Where(p => p.use_yn == "Y").OrderBy(P => P.index_order).Select(c => new { 값 = c.code_id, 이름 = c.code_name });
            ViewBag.회사구분 = new SelectList(code_company.AsEnumerable(), "값", "이름");

            //========================================================================================================================================================

            if(idx != null)
            {
            
                doc = db.company.Single(x => x.idx == idx);
               

                var _list = (from a in db.Md_Image where a.Md_id == doc.file_id && a.use_yn != "N" select a).OrderByDescending(p => p.id).ToList();

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

        [Authorize]
        public ActionResult company_set_list()
        {

            #region 기본 사용자 정보
            string user_id = User.Identity.Name;          
            string company_id = UserData.user_get(user_id, "company_id");
            string auth = UserData.user_get(user_id, "auth"); 
            #endregion


            IQueryable<company> _list = Enumerable.Empty<company>().AsQueryable();


            if (auth == "9")
            {
                _list = db.company.Where(p=>p.use_yn == "Y").OrderBy(o => o.idx);
            }
            else
            {
                _list =
                    db.company.Where(p => p.company_id == company_id || p.use_yn == "Y").OrderBy(o => o.idx);
            }


            return View(_list.ToList());
        }

        public async Task<IActionResult> company_set_action(List<IFormFile> ImageFile, company doc, string mode_type, string idx)
        {
            
          
            string msg = "";
          

            #region 기본 사용자 정보
            string user_id = User.Identity.Name;
            string company_id = UserData.user_get(user_id, "company_id");
            string department_idx = UserData.user_get(user_id, "department_idx");
            string auth = UserData.user_get(user_id, "auth");
            string file_id = ""; 
            #endregion


            int _id = 1;

            try
            {
                _id = (from a in db.company select a.idx).Max() + 1;
            }
            catch
            {
            }

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
                file_id = company_id + department_idx + DateTime.Now.ToShortDateString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString();
                doc.write_date = DateTime.Now;

                doc.file_id = file_id;
                doc.index_order = _id;
                db.company.Add(doc);
                db.SaveChanges(); // 실제로 저장 


                msg = Util.msg.msg_insert;

                #endregion
            }
            else
            {
               

                if (mode_type == "D")
                {
                    #region 삭제

                    //int _idx = Convert.ToInt32(idx);
                    //company doc_del = db.company.Single(x => x.idx == _idx);
                    //db.company.Remove(doc_del);
                    //db.SaveChanges();
                   
                    doc.write_date = DateTime.Now;
                    doc.use_yn = "N";
                    db.Entry(doc).State = EntityState.Modified;
                    //idx 제외 업데이트=================================
                    db.Entry(doc).Property("company_id").IsModified = false;
                    db.Entry(doc).Property("company_name").IsModified = false;
                    db.Entry(doc).Property("nationality").IsModified = false;
                    //==================================================
                    db.SaveChanges();

                    msg = Util.msg.msg_del;

                    #endregion
                }
                else
                {
                    #region 수정

                    file_id = doc.file_id;

                    if (string.IsNullOrEmpty(file_id))
                    {

                        file_id = company_id + department_idx + DateTime.Now.ToShortDateString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString();

                        doc.file_id = file_id;
                    }
                   
                    doc.write_date = DateTime.Now;
                    doc.index_order = _id;
                    db.Entry(doc).State = EntityState.Modified;

                    //idx 제외 업데이트=================================
                    db.Entry(doc).Property("company_id").IsModified = false;
                  

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
                    string only = user_id+ DateTime.Today.ToShortDateString().Replace("-", "") + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString();
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
                        write_id = doc.company_id,
                        sImagePath = Models_photo + company_id + "/s/" + _fileName,
                    };

                    db.Md_Image.Add(_insert);
                    db.SaveChanges();


                }
                    s++;
                }
           

            #endregion


            return Redirect("/sys/company_set_list");
        }

        #endregion








        #endregion


        #region department

        [Authorize]
        public ActionResult department_set(department doc, int? idx)
        {

            #region 기본 사용자 정보
            string user_id = User.Identity.Name;
            string company_id = UserData.user_get(user_id, "company_id");
            string department_idx = UserData.user_get(user_id, "department_idx");
            int auth = Convert.ToInt32(UserData.user_get(user_id, "auth"));
            #endregion


            if (auth >= 9)
            {
                //======================================================================================================================================================== 
                var Code_company =
                    db.company.Where(p => p.use_yn == "Y").OrderBy(o => o.index_order).Select(
                        c => new { 값 = c.idx, 이름 = c.company_name });
                ViewBag.회사 = new SelectList(Code_company.AsEnumerable(), "값", "이름");
                //======================================================================================================================================================== 

                //======================================================================================================================================================== 
                var Code_auth =
                    db.CategoryMenus.Where(p => p.company_id == company_id && p.step_dept == 2).OrderBy(o => o.step_auth)
                        .Select(c => new { 값 = c.step_auth, 이름 = c.step_name });
                ViewBag.권한 = new SelectList(Code_auth.AsEnumerable(), "값", "이름");
                //======================================================================================================================================================== 
            }
            else
            {
                //======================================================================================================================================================== 
                var Code_company =
                    db.company.Where(p => p.company_id == company_id).OrderBy(
                        o => o.index_order).Select(c => new { 값 = c.idx, 이름 = c.company_name });
                ViewBag.회사 = new SelectList(Code_company.AsEnumerable(), "값", "이름");
                //======================================================================================================================================================== 
            }





            if (idx != null)
            {

                doc = db.department.Single(x => x.idx == idx);
            }

            return View(doc);
        }

        [Authorize]
        public ActionResult department_set_list(string companyidx)
        {
            #region 기본 사용자 정보
            string user_id = User.Identity.Name;
            string company_id = UserData.user_get(user_id, "company_id");
            int company_idx = Convert.ToInt32(UserData.user_get(user_id, "company_idx"));
            int department_idx = Convert.ToInt32(UserData.user_get(user_id, "department_idx"));
            int auth = Convert.ToInt32(UserData.user_get(user_id, "auth"));
            #endregion



            //IQueryable<department> _list = Enumerable.Empty<department>().AsQueryable();

           
           

                //======================================================================================================================================================== 
                var Code_company =   db.company.Where(p => p.use_yn == "Y").OrderBy(o => o.index_order).Select(
                        c => new { 값 = c.idx, 이름 = c.company_name });
                ViewBag.회사 = new SelectList(Code_company.AsEnumerable(), "값", "이름");
                //======================================================================================================================================================== 
              
                
                IOrderedQueryable<department> _list =  db.department.Include(p => p.company_idxNavigation).OrderBy(o => o.index_order).ThenBy( o => o.department_name);


                if (!string.IsNullOrEmpty(companyidx))
                {
                    int _company_idx_int = 0;

                    try
                    {
                        _company_idx_int = Convert.ToInt32(companyidx);
                    }
                    catch
                    {


                    }


                    _list = _list.Where(p => p.company_idx == _company_idx_int).OrderBy(o => o.index_order).ThenBy(
                            o => o.department_name);



                }
            if (auth < 9) {
                //======================================================================================================================================================== 
                Code_company =
                   db.company.Where(p => p.company_id == company_id && p.use_yn == "Y").OrderBy(
                       o => o.index_order).Select(c => new { 값 = c.idx, 이름 = c.company_name });
                ViewBag.회사 = new SelectList(Code_company.AsEnumerable(), "값", "이름");
                //======================================================================================================================================================== 

                _list = db.department.Where(p => p.company_idx == company_idx).OrderBy(o => o.index_order).ThenBy(o => o.department_name);
            }
         
                   

            return View(_list.ToList());
        }

        public ActionResult department_set_action(department doc, string mode_type, int? idx )
        {
           
         
            string msg = "";
       

            #region 기본 사용자 정보
            string user_id = User.Identity.Name;
            string company_id = UserData.user_get(user_id, "company_id");
           
            int auth = Convert.ToInt32(UserData.user_get(user_id, "auth"));
            #endregion




            if (doc.use_yn == "on")
            {
                doc.use_yn = "Y";
            }
            else
            {
                doc.use_yn = "N";
            }

            int department_idx = 1;


            try
            {
                department_idx = (from a in db.department select a.idx).Max() + 1;
            }
            catch
            {
            }


            if (idx == null)
            {
                #region 저장

                doc.write_date = DateTime.Now;
                doc.department_auth = "";
                      

                db.department.Add(doc);
                db.SaveChanges(); // 실제로 저장 


                msg = Util.msg.msg_insert;

                #endregion
            }
            else
            {
              

                if (mode_type == "D")
                {
                    #region 삭제


                    doc.use_yn = "N";
                    doc.write_date = DateTime.Now;
                    db.Entry(doc).State = EntityState.Modified;
                    db.SaveChanges();

                    msg = Util.msg.msg_del;

                    #endregion
                }
                else
                {
                    #region 수정

                    doc.write_date = DateTime.Now;                   
                    db.Entry(doc).State = EntityState.Modified;
                    db.SaveChanges();

                    msg = Util.msg.msg_edit;

                    #endregion
                }
            }


            return Redirect("/sys/department_set_list");
        }

        #endregion
        #region 사용자 관리 : 추가 ,변경, 삭제

        public ActionResult user_set(user doc, string idx, string my,int? company_idx_q)
        {
            #region 기본 사용자 정보
            string user_id = User.Identity.Name;
            int company_idx = Convert.ToInt32(UserData.user_get(user_id, "company_idx"));
            int department_idx = Convert.ToInt32(UserData.user_get(user_id, "department_idx"));
            int auth = Convert.ToInt32(UserData.user_get(user_id, "auth"));
            string user_auth = UserData.user_get(user_id, "user_auth");
            #endregion


            #region 관리자 권한

            if (auth >= 8)
            {
                ViewBag.관리자 = "Y";
            }
            else { ViewBag.관리자 = "N"; }
            #endregion




            // 최고 관리자 권한 
            if (auth > 8)
            {
                //======================================================================================================================================================== 
                var Code_company =
                    db.company.Where(p => (p.use_yn == "Y")).OrderBy(o => o.index_order).Select(
                        c => new { 값 = c.idx, 이름 = c.company_name });
                ViewBag.회사 = new SelectList(Code_company.AsEnumerable(), "값", "이름");
                //======================================================================================================================================================== 

                if(company_idx_q == null)
                {
                    company_idx_q = company_idx;

                }

                //======================================================================================================================================================== 
                var Code_department =
                    db.department.Where(p => (p.company_idx == company_idx_q && p.use_yn == "Y")).OrderBy(
                        o => o.department_name).Select(c => new { 값 = c.idx, 이름 = c.department_name });
                ViewBag.부서 = new SelectList(Code_department.AsEnumerable(), "값", "이름");
                //======================================================================================================================================================== 


                //========================================================================================================================================================
                var Code_auth = db.code_auth.Where(p => p.use_yn == "Y").OrderBy(P => P.index_order).Select(c => new { 값 = c.url, 이름 = c.code_name });
                ViewBag.권한 = new SelectList(Code_auth.AsEnumerable(), "값", "이름");
                ViewBag.권한수 = Code_auth.Count();
                //========================================================================================================================================================

                //========================================================================================================================================================
                var code_auth_ex = db.code_auth_ex.Where(p => p.use_yn != "N").OrderBy(P => P.index_order).Select(c => new { 값 = c.url, 이름 = c.code_name });
                ViewBag.특수권한 = new SelectList(Code_auth.AsEnumerable(), "값", "이름");
                ViewBag.특수권한수 = code_auth_ex.Count();
                //========================================================================================================================================================



            }


            else
            {
                //======================================================================================================================================================== 
                var Code_company =
                    db.company.Where(
                        p =>
                        (p.idx == company_idx)).
                        OrderBy(o => o.company_name).Select(c => new { 값 = c.idx, 이름 = c.company_name });
                ViewBag.회사 = new SelectList(Code_company.AsEnumerable(), "값", "이름");
                //======================================================================================================================================================== 

                //======================================================================================================================================================== 
                var Code_department =
                    db.department.Where(p => (p.company_idx == company_idx && p.use_yn == "Y")).OrderBy(
                        o => o.department_name).Select(c => new { 값 = c.idx, 이름 = c.department_name });
                ViewBag.부서 = new SelectList(Code_department.AsEnumerable(), "값", "이름");
                //======================================================================================================================================================== 

                //========================================================================================================================================================
                var Code_auth = db.code_auth.Where(p => p.use_yn == "Y" && p.index_order < 9).OrderBy(P => P.index_order).Select(c => new { 값 = c.url, 이름 = c.code_name });
                ViewBag.권한 = new SelectList(Code_auth.AsEnumerable(), "값", "이름");
                ViewBag.권한수 = Code_auth.Count();
                //========================================================================================================================================================

                //========================================================================================================================================================
                var code_auth_ex = db.code_auth_ex.Where(p => p.use_yn == "Y").OrderBy(P => P.index_order).Select(c => new { 값 = c.url, 이름 = c.code_name });
                ViewBag.특수권한 = new SelectList(Code_auth.AsEnumerable(), "값", "이름");
                ViewBag.특수권한수 = code_auth_ex.Count();
                //========================================================================================================================================================



            }
            //======================================================================================================================================================== 
            var code_position =
                db.code_position.Where(p => (p.company_idx == company_idx && p.use_yn == "Y")).OrderBy(
                    o => o.index_order).Select(c => new { 값 = c.code_id, 이름 = c.code_name });
            ViewBag.직책 = new SelectList(code_position.AsEnumerable(), "값", "이름");
            //======================================================================================================================================================== 






            if (!string.IsNullOrEmpty(idx))
            {
                int _idx = Convert.ToInt32(idx);

                doc = db.user.Single(x => x.idx == _idx);
            }
            else if (my == "Y")
            {
                string _user_id = User.Identity.Name;
                doc = db.user.Single(x => x.user_id == _user_id);
            }

            return View(doc);
        }


        public ActionResult user_set_list(string search_all, string order_check, string target_check)
        {
            #region 변수


            #region 기본 사용자 정보
            string user_id = User.Identity.Name;
            int company_idx = Convert.ToInt32(UserData.user_get(user_id, "company_idx"));
            int department_idx = Convert.ToInt32(UserData.user_get(user_id, "department_idx"));
            int auth = Convert.ToInt32(UserData.user_get(user_id, "auth"));
            string user_auth = UserData.user_get(user_id, "user_auth");
            #endregion



            #region 관리자 권한

            if (auth >= 8)
            {
                ViewBag.관리자 = "Y";
            }
            else { ViewBag.관리자 = "N"; }

            // 개인 리스트 수정 삭제 권한
            if (user_auth.Contains("user_set_list"))
            {
                ViewBag.관리자 = "Y";
            }

            #endregion
            ViewBag.search_all = search_all;


            #endregion

            #region 검색 리스트
            IQueryable<user> _list = Enumerable.Empty<user>().AsQueryable();

            if (auth >= 8)
            {
                _list = db.user.Include(p=>p.company_idxNavigation).OrderBy(o => o.user_name).OrderBy(o => o.user_name);
            }
            else
            {
                _list =
                    db.user.Include(p => p.company_idxNavigation).Where(o => o.department_idx == department_idx).OrderBy(o => o.user_name).OrderBy(
                        o => o.user_name);
            }
            if (!string.IsNullOrEmpty(search_all))
            {
                _list = _list.Where(p => p.company_idxNavigation.company_name.Contains(search_all) || p.user_id.StartsWith(search_all) || p.user_name.StartsWith(search_all) || p.department_idxNavigation.department_name.StartsWith(search_all)).OrderBy(p => p.company_idxNavigation.company_name);
            }
            #endregion

            #region 정렬 변수


            if (string.IsNullOrEmpty(order_check))
            {
                order_check = "asc";
            }

            if (order_check == "asc")
            {
                ViewBag.정렬 = "desc";
            }
            else
            {
                ViewBag.정렬 = "asc";
            }
            ViewBag.대상 = target_check;

            #endregion

            #region 정렬 하기

            if (!string.IsNullOrEmpty(target_check) && order_check == "desc")
            {
                if (target_check == "company_name")
                {
                    _list = _list.OrderByDescending(o => o.company_idxNavigation.company_name);
                }

                if (target_check == "user_id")
                {
                    _list = _list.OrderByDescending(o => o.user_id);
                }
                if (target_check == "user_name")
                {
                    _list = _list.OrderByDescending(o => o.user_name);
                }

                if (target_check == "department_name")
                {
                    _list = _list.OrderByDescending(o => o.department_idxNavigation.department_name);
                }

                if (target_check == "write_date")
                {
                    _list = _list.OrderByDescending(o => o.write_date);
                }
            }
            if (!string.IsNullOrEmpty(target_check) && order_check == "asc")
            {
                if (target_check == "company_name")
                {
                    _list = _list.OrderBy(o => o.company_idxNavigation.company_name);
                }

                if (target_check == "user_id")
                {
                    _list = _list.OrderBy(o => o.user_id);
                }
                if (target_check == "user_name")
                {
                    _list = _list.OrderBy(o => o.user_name);
                }

                if (target_check == "department_name")
                {
                    _list = _list.OrderBy(o => o.department_idxNavigation.department_name);
                }

                if (target_check == "write_date")
                {
                    _list = _list.OrderBy(o => o.write_date);
                }
            }

            #endregion



            return View(_list.ToList());
        }
        public ActionResult user_set_check(string doc_it)
        {


            var sb = new StringBuilder();


            int _doc = (from a in db.AspNetUsers where a.Email == doc_it select a.Email).Count();

            int _doc2 = (from a in db.user where a.user_id == doc_it select a.user_id).Count();

            if (_doc < 1)
            {
                sb.AppendFormat("<script>");
                sb.AppendFormat("$('#user_id').attr('value' ,'') ; ");
                sb.AppendFormat("demo.showSwal('id-check');");
                sb.AppendFormat("$('#user_id_check').attr('value' ,'N') ;");
                sb.AppendFormat("$('#user_id').css('border' ,'solid 1px red') ; ");
                sb.AppendFormat("$('#user_id').focus() ; ");
                sb.AppendFormat("</script>");
                Response.WriteAsync(sb.ToString());
            }
            else
            {
                sb.AppendFormat("<script>");

                sb.AppendFormat("$('#user_id_check').attr('value' ,'Y') ;");
                sb.AppendFormat("$('#user_id').css('border' ,'solid 1px green') ; ");
                sb.AppendFormat("</script>");
                Response.WriteAsync(sb.ToString());
            }


            if (_doc2 > 0)
            {
                sb.AppendFormat("<script>");
                sb.AppendFormat("$('#user_id').attr('value' ,'') ; ");
                sb.AppendFormat("demo.showSwal('auto-close');");
                sb.AppendFormat("$('#user_id_check').attr('value' ,'N') ;");
                sb.AppendFormat("$('#user_id').css('border' ,'solid 1px red') ; ");
                sb.AppendFormat("$('#user_id').focus() ; ");
                sb.AppendFormat("</script>");
                Response.WriteAsync(sb.ToString());
            }
            else
            {
                sb.AppendFormat("<script>");

                sb.AppendFormat("$('#user_id_check').attr('value' ,'Y') ;");
                sb.AppendFormat("$('#user_id').css('border' ,'solid 1px green') ; ");
                sb.AppendFormat("</script>");
                Response.WriteAsync(sb.ToString());
            }


            return null;
        }
        public ActionResult user_set_action(user doc, string mode_type, string idx)
        {


            string msg = "";
            #region 기본 사용자 정보
            string user_id = User.Identity.Name;
            string company_id = UserData.user_get(user_id, "company_id");
            int company_idx = Convert.ToInt32(UserData.user_get(user_id, "company_idx"));
            int department_idx = Convert.ToInt32(UserData.user_get(user_id, "department_idx"));
            int auth = Convert.ToInt32(UserData.user_get(user_id, "auth"));
            #endregion



            int new_user_index = 1;
            try
            {
                new_user_index = (from a in db.user select a.idx).Max() + 1;
            }
            catch
            {
            }


            if (doc.use_yn == "on")
            {
                doc.use_yn = "Y";
            }
            else
            {
                doc.use_yn = "N";
            }


            if (string.IsNullOrEmpty(idx))
            {
                #region 저장

                doc.write_date = DateTime.Now;
                doc.edit_date = DateTime.Now;
                db.user.Add(doc);
                db.SaveChanges(); // 실제로 저장 


                msg = Util.msg.msg_insert;

                #endregion
            }
            else
            {
                int _idx = Convert.ToInt32(idx);

                if (mode_type == "D")
                {
                    #region 삭제

                    user doc_del = db.user.Single(x => x.idx == _idx);
                    db.user.Remove(doc_del);
                    db.SaveChanges();

                    msg = Util.msg.msg_del;

                    #endregion
                }
                else
                {
                    #region 수정



                    doc.edit_date = DateTime.Now;
                    doc.write_date = DateTime.Now;
                    db.Entry(doc).State = EntityState.Modified;
                    
                    //idx 제외 업데이트=================================
                    db.Entry(doc).Property("idx").IsModified = false;
                    //==================================================
                    db.SaveChanges();

                    msg = Util.msg.msg_edit;

                    #endregion
                }
            }

            return Redirect("/sys/user_set_list");
            
        }

        #endregion
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

        #region 기록 히스토리
        /// <summary>
        /// 
        /// </summary>
        /// <param name="user_id">아이디</param>
        /// <param name="_page">해당 페이지</param>
        /// <param name="_state">처리상태(입력,수정,삭제)</param>
        /// 



        #endregion


        #region 언어등록
            // 리스트
        public async Task<IActionResult> language_list()
        {
            return View(await db.language.ToListAsync());
        }


 
        public async Task<IActionResult> language_set(language doc, int? idx, string sortExpression = "-idx", int page = 1)
        {


         


            if (idx != null)
            {


                doc = db.language.Single(x => x.idx == idx);
            }


            var query = db.language.AsNoTracking();
            var model = await PagingList.CreateAsync(query, 100, page, sortExpression, "-idx");

          
          
            ViewBag.리스트 = model;

            return View(doc);
        }


        public async Task<IActionResult> language_action(language doc, int? idx, string mode_type)
        {



            if (idx == null)
            {
                #region 저장
              
                db.language.Add(doc);
                await db.SaveChangesAsync();


                #endregion
            }
            else
            {
                if (mode_type == "D")
                {
                    #region 삭제

                    language doc_del = db.language.Single(x => x.idx == idx);
                    db.language.Remove(doc_del);
                    db.SaveChanges();

                 

                    #endregion
                }
                else
                {


                    #region 수정


                    language _update =
                        (from a in db.language where a.idx == idx select a).Single();

                    _update.korea = doc.korea;
                    _update.english = doc.english;


                    await db.SaveChangesAsync();

                    #endregion
                }
            }


            return Redirect("/sys/language_set");
        }

        #endregion
    }


}
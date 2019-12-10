using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmartFactory.Models;

namespace SmartFactory.Controllers
{
    public class codeController : Controller
    {
        private readonly db_e db = new db_e();
        #region Nationality

        [Authorize]
        public ActionResult code_nationality(code_nationality doc, string idx)
        {
            if (!string.IsNullOrEmpty(idx))
            {
                
                doc = db.code_nationality.Single(x => x.code_id == idx);
            }

            return View(doc);
        }


        public ActionResult code_nationality_check( string doc_it)
        {
          

            var sb = new StringBuilder();


            int _doc = (from a in db.code_nationality where a.code_id == doc_it select a.code_id).Count();

            if (_doc > 0)
            {
                sb.AppendFormat("<script>");
                sb.AppendFormat("$('#code_id').attr('value' ,'') ; ");
                sb.AppendFormat("demo.showSwal('auto-close');");
                sb.AppendFormat("$('#code_id_check').attr('value' ,'N') ;");
                sb.AppendFormat("$('#code_id').css('border' ,'solid 1px red') ; ");
                sb.AppendFormat("$('#code_id').focus() ; ");
                sb.AppendFormat("</script>");
                Response.WriteAsync(sb.ToString());
            }
            else
            {
                sb.AppendFormat("<script>");

                sb.AppendFormat("$('#code_id_check').attr('value' ,'Y') ;");
                sb.AppendFormat("$('#code_id').css('border' ,'solid 1px green') ; ");

                Response.WriteAsync(sb.ToString());
            }


            return null;
        }

     
        public ActionResult code_nationality_action(code_nationality doc , string mode_type, string idx)
        {
         
            string msg = "";


            if (string.IsNullOrEmpty(idx))
            {
                #region 저장

                doc.write_date = DateTime.Now;
                doc.writer_id = User.Identity.Name;
                doc.index_order = 9;
                doc.use_yn = "Y";
                db.code_nationality.Add(doc);
                db.SaveChanges(); // 실제로 저장 


                msg = Util.msg.msg_insert;

                #endregion
            }
            else
            {
               

                if (mode_type == "D")
                {
                    #region 삭제

                    code_nationality doc_del = db.code_nationality.Single(x => x.code_id == idx);
                    db.code_nationality.Remove(doc_del);
                    db.SaveChanges();

                    msg = Util.msg.msg_del;

                    #endregion
                }
                else
                {
                    #region 수정

                    doc.writer_id = User.Identity.Name;
                    doc.write_date = DateTime.Now;
                    doc.index_order = 9;
                    doc.use_yn = "Y";
                    db.Entry(doc).State = EntityState.Modified;
                    db.SaveChanges();

                    msg = Util.msg.msg_edit;

                    #endregion
                }
            }

            return Redirect("/code/code_nationality_list");
            
        }

      
        public ActionResult code_nationality_list()
        {



            IOrderedQueryable<code_nationality> _list = db.code_nationality.OrderBy(o => o.code_name);
            return View(_list.ToList());
        }

        #endregion


        public IActionResult code_index()
        {

            return View();
        }




            public ActionResult code_position(code_position doc, int? idx)
        {

          
            ViewBag.타이틀 = "직책 코드";

            //======================================================================================================================================================== 
            var Code_company = db.company.Where(p => p.use_yn == "Y").OrderBy(o => o.index_order).Select(
                    c => new { 값 = c.idx, 이름 = c.company_name });
            ViewBag.회사 = new SelectList(Code_company.AsEnumerable(), "값", "이름");
            //======================================================================================================================================================== 


            if (idx != null)
            {
              

                    doc = db.code_position.Single(x => x.code_id == idx);
            }

            var _list = db.code_position.Include(p=>p.company_idxNavigation).Where(p => p.use_yn != "N").OrderBy(o => o.index_order);
            ViewBag.리스트 = _list;

            return View(doc);
        }

        /// <summary>
        /// 코드 표준 : 직책
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="mode_type"></param>
        /// <param name="idx"></param>
        /// <returns></returns>
        public ActionResult code_position_action(code_position doc, string mode_type, int? idx, string re_url)
        {
          

            if (idx == null)
            {
                             

                #region 저장
                doc.use_yn = "Y";
                db.code_position.Add(doc);
                db.SaveChanges(); // 실제로 저장 
 

                #endregion
            }
            else
            {


                if (mode_type == "D")
                {
                    #region 사용안함
                    int _idx_ = Convert.ToInt32(idx);
                    var _data = (from a in db.code_position where a.code_id == idx select a).Single();

                    _data.use_yn = "N";

                    db.SaveChanges();
                  

                    #endregion
                }
                else
                {
                    #region 수정

                    doc.use_yn = "Y";
                    db.Entry(doc).State = EntityState.Modified;
                    db.SaveChanges();

                  

                    #endregion
                }
            }

            return Redirect(re_url);
           
        }

    }
}
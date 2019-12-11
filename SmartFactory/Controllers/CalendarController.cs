using System;
using System.Collections.Generic;

using System.Linq;

using Newtonsoft.Json;
using WebSkill.Util;
using SmartFactory.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using static SmartFactory.Controllers.SysController;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace SmartFactory.Controllers
{
    public class CalendarController : Controller
    {
        // GET: Calendar

        private readonly db_e db = new db_e();

        [Authorize]
        public ActionResult calendar_view(calendar doc, string open, string s_date, string e_date, int? idx)
        {


            #region 기본 사용자 정보
            string user_id = User.Identity.Name;
            int department_idx = Convert.ToInt32(UserData.user_get(user_id, "department_idx"));
            int company_idx = Convert.ToInt32(UserData.user_get(user_id, "company_idx"));
            int auth = Convert.ToInt32(UserData.user_get(user_id, "auth"));
            #endregion


            // 날짜 초기화
            DateTime _s_date = DateTime.Today;
            DateTime _e_date = DateTime.Today.AddDays(1);


            if (!string.IsNullOrEmpty(s_date) && !string.IsNullOrEmpty(e_date))
            {
                try
                {
                    _s_date = Convert.ToDateTime(s_date).Date;
                    _e_date = Convert.ToDateTime(e_date).Date;

                    ViewBag.s_date = _s_date.ToShortDateString();
                    ViewBag.e_date = _e_date.ToShortDateString();
                }
                catch
                {
                    ViewBag.s_date = "";
                    ViewBag.e_date = "";
                }
            }
            else
            {
                ViewBag.s_date = _s_date.ToShortDateString();
                ViewBag.e_date = _e_date.ToShortDateString();

            }


            //======================================================================================================================================================== 
            var project_main =
                db.project_main.Where(o => (o.company_idx == company_idx && o.use_yn != "D")).OrderBy(
                    o => o.index_order).Select( c => new { 값 = c.project_id, 이름 =  c.project_name  });
            ViewBag.프로젝트 = new SelectList(project_main.AsEnumerable(), "값", "이름");
            //======================================================================================================================================================== 

            //========================================================================================================================================================
            var _department = db.department.Where(p => p.company_idx == company_idx && p.use_yn != "N").OrderBy(P => P.index_order).Select(c => new { 값 = c.idx, 이름 = c.department_name });
            ViewBag.부서 = new SelectList(_department.AsEnumerable(), "값", "이름");

            //========================================================================================================================================================



            if (!string.IsNullOrEmpty(open))
            {
                int _open = Convert.ToInt32(open);
                ViewBag.시작일 =   (from a in db.project_main where a.project_id == _open select a.start_date).FirstOrDefault();
                ViewBag.마감일 = (from a in db.project_main where a.project_id == _open select a.end_date).FirstOrDefault();
                     
            }
            else
            {
                ViewBag.시작일 = "";
                ViewBag.마감일 = "";
            }


            List<calendar> _list = db.calendar.OrderByDescending(o => o.idx).ToList();

            if (!string.IsNullOrEmpty(open))
            {
                int project_idx = Convert.ToInt32(open);
                _list = _list.Where(p => p.project_idx == project_idx).OrderByDescending(o => o.write_date).ToList();
                
            }


            ViewBag.리스트 = _list;

            if (idx != null)
            {
             

                doc = db.calendar.Single(x => x.idx == idx);


                ViewBag.s_date = doc.start_date.ToShortDateString();
                ViewBag.e_date = doc.end_date.ToShortDateString();
            }


            return View(doc);
        }

        [Authorize]
        public ActionResult calendar_set(calendar doc, string sdate, string mode , int? idx)
        {
            #region 변수
                   
            DateTime _sdate = DateTime.Now;

            if (!string.IsNullOrEmpty(sdate))
            {
                _sdate = Convert.ToDateTime(sdate);
            }

            #region 기본 사용자 정보
            string user_id = User.Identity.Name;
            int department_idx = Convert.ToInt32(UserData.user_get(user_id, "department_idx"));
            int company_idx = Convert.ToInt32(UserData.user_get(user_id, "company_idx"));
            int auth = Convert.ToInt32(UserData.user_get(user_id, "auth"));
            #endregion

            ViewBag.company_idx = company_idx;
            ViewBag.department_idx = department_idx;






            // 최고 관리자 권한 
            if (auth >= 9)
            {
                //======================================================================================================================================================== 
                var Code_department =
                    db.department.Where(p => (p.company_idx == company_idx  &&  p.use_yn == "Y")).OrderBy(
                        o => o.index_order).Select(c => new { 값 = c.idx, 이름 = c.department_name });
                ViewBag.부서 = new SelectList(Code_department.AsEnumerable(), "값", "이름");
                //======================================================================================================================================================== 

                //======================================================================================================================================================== 
                var Code_project_main =
                    db.project_main.Where(p => (p.company_idx == company_idx && p.use_yn == "Y")).OrderBy(
                        o => o.project_name).Select(c => new { 값 = c.project_id, 이름 = c.project_name });
                ViewBag.프로젝트 = new SelectList(Code_project_main.AsEnumerable(), "값", "이름");
                //======================================================================================================================================================== 
            }
            else
            {
                //======================================================================================================================================================== 
                var Code_department =
                    db.department.Where(
                        p => (p.company_idx == company_idx && p.idx == department_idx && p.use_yn == "Y"))
                        .OrderBy(o => o.index_order).Select(c => new { 값 = c.idx, 이름 = c.department_name });
                ViewBag.부서 = new SelectList(Code_department.AsEnumerable(), "값", "이름");
                //======================================================================================================================================================== 

                //======================================================================================================================================================== 
                var Code_project_main =
                    db.project_main.Where(
                        p => (p.company_idx == company_idx && p.department_idx == department_idx && p.use_yn != "D"))
                        .OrderBy(o => o.project_name).Select(c => new { 값 = c.project_id, 이름 = c.project_name });
                ViewBag.프로젝트 = new SelectList(Code_project_main.AsEnumerable(), "값", "이름");
                //======================================================================================================================================================== 
            }

            //======================================================================================================================================================== 
            var Code_company =
                db.company.Where(p => (p.idx == company_idx && p.use_yn == "Y")).OrderBy(o => o.company_name).
                    Select(c => new { 값 = c.company_id, 이름 = c.company_name });
            ViewBag.회사 = new SelectList(Code_company.AsEnumerable(), "값", "이름");
            //======================================================================================================================================================== 


            //======================================================================================================================================================== 
            var Code_project_state =
                db.code_project_state.OrderBy(o => o.index_order).Select(c => new { 값 = c.code_id, 이름 = c.code_name });
            ViewBag.프로젝트코드 = new SelectList(Code_project_state.AsEnumerable(), "값", "이름");
            //======================================================================================================================================================== 

            //======================================================================================================================================================== 
            var code_work_state =
                db.code_work_state.OrderBy(o => o.index_order).Select(c => new { 값 = c.code_id, 이름 = c.code_name });
            ViewBag.작업상태 = new SelectList(code_work_state.AsEnumerable(), "값", "이름");
            //========================================================================================================================================================
            //======================================================================================================================================================== 
            var Code_index =
                db.code_index.Where(o => o.use_yn == "Y").OrderBy(o => o.index_order).Select(
                    c => new { 값 = c.code_id, 이름 = c.code_name });
            ViewBag.색인 = new SelectList(Code_index.AsEnumerable(), "값", "이름");
            //======================================================================================================================================================== 


            ViewBag.mode = mode;

            #endregion

            if (mode == "W")
            {
                ViewBag.start_date = _sdate.ToShortDateString();

                ViewBag.end_date = _sdate.ToShortDateString(); 

                ViewBag.pagetitle = "등록";
            }
            else if (mode == "M")
            {
                #region 모델 저장

                doc = db.calendar.FirstOrDefault(x => x.idx == idx);

                #endregion

                ViewBag.pagetitle = "수정";
                ViewBag.state = doc.code_work_idx;
                ViewBag.start_date = doc.start_date;
                ViewBag.end_date = doc.end_date;
            }


            return View(doc);
        }

        [Authorize]
        public ActionResult calendar_action(calendar doc, string mode, string _type)
        {

            #region 기본 사용자 정보
            string user_id = User.Identity.Name;
            int department_idx = Convert.ToInt32(UserData.user_get(user_id, "department_idx"));
            int company_idx = Convert.ToInt32(UserData.user_get(user_id, "company_idx"));
            int auth = Convert.ToInt32(UserData.user_get(user_id, "auth"));
            #endregion

          
                       

            if (doc.open_it == "on")
            {
                doc.open_it = "Y";
            }
            else
            {
                doc.open_it = "N";
            }


            DateTime sdate = doc.start_date;
            DateTime edate = doc.end_date;

            TimeSpan ts = edate - sdate;

            double run_time = ts.Hours;

            if (mode == "W")
            {
                #region 저장

                doc.company_idx = company_idx;
                doc.user_id = User.Identity.Name;
                doc.write_date = DateTime.Now;
                doc.use_yn = "Y";

                db.calendar.Add(doc);
                db.SaveChanges(); // 실제로 저장 

                           

                #endregion

               
             
               
            }
            else if (mode == "M")
            {
                //수정일경우

                #region 권한체크

                string user = User.Identity.Name;

            

                string ok_auth = "N";

                if (doc.user_id == user)
                {
                    ok_auth = "Y";
                }
                if (auth >= 8)
                {
                    ok_auth = "Y";
                }
                if (department_idx == doc.department_idx)
                {
                    ok_auth = "Y";
                }

                #endregion

                if (ok_auth == "Y")
                {
                    #region 기본 수정

                    doc.user_id = User.Identity.Name;
                    doc.who = User.Identity.Name;
                    doc.company_idx = company_idx;
                    doc.write_date = DateTime.Now;
                    doc.edit_date = DateTime.Now;
                    db.Entry(doc).State = EntityState.Modified;
                    db.SaveChanges();

                

                    #endregion

                   
                }
                else
                {
                    return Unauthorized();
                }
            }

            return Redirect("/Calendar/calendar_view");
        }


        //[Authorize]
        //public ActionResult _SaveCal(work_list doc)
        //{
        //    string mode = Request["mode"];
        //    string _type = Request["_type"];
        //    string web_company_id = Request.Cookies["web_company_id"].Value ?? "";
        //    string web_department_id = Request.Cookies["web_department_id"].Value ?? "";
        //    string title = Request["title"] ?? "";
        //    string msg = "";
        //    if (string.IsNullOrEmpty(web_department_id))
        //    {
        //        web_department_id = "";
        //    }
        //    doc.open_it = "Y";


        //    DateTime sdate = doc.work_date;
        //    DateTime edate = doc.end_date;

        //    TimeSpan ts = edate - sdate;

        //    double run_time = ts.Hours;

        //    if (mode == "W")
        //    {
        //        #region 저장

        //        doc.title = title;
        //        doc.department_id = web_department_id;
        //        doc.company_id = web_company_id;
        //        doc.user_id = User.Identity.Name;
        //        doc.write_date = DateTime.Now;
        //        doc.use_yn = "Y";
        //        doc.index = 1;
        //        doc.who = User.Identity.Name;
        //        doc.state = 1;

        //        db.work_list.Add(doc);
        //        db.SaveChanges(); // 실제로 저장 


        //        msg = Util.msg.msg_insert;

        //        #endregion
        //    }
        //    else if (mode == "M")
        //    {
        //        //수정일경우

        //        #region 권한체크

        //        string user = User.Identity.Name;

        //        int idx_it = Convert.ToInt32(Request["idx"]);
        //        int auth = Convert.ToInt16(Request.Cookies["check_auth"].Value);



        //        string ok_auth = "N";

        //        if (doc.user_id == user)
        //        {
        //            ok_auth = "Y";
        //        }
        //        if (auth >= 8)
        //        {
        //            ok_auth = "Y";
        //        }

        //        #endregion

        //        if (ok_auth == "Y")
        //        {
        //            #region 기본 수정

        //            doc.user_id = User.Identity.Name;
        //            doc.who = User.Identity.Name;
        //            doc.company_id = web_company_id;
        //            doc.write_date = DateTime.Now;
        //            doc.edit_date = DateTime.Now;
        //            doc.department_id = web_department_id;
        //            doc.state = 1;
        //            doc.use_yn = "Y";
        //            db.Entry(doc).State = EntityState.Modified;
        //            db.SaveChanges();

        //            msg = Util.msg.msg_edit;

        //            #endregion
        //        }
        //        else
        //        {
        //            return Content("<script>alert('권한이 없습니다.');  location.href='/Calendar/workcal';</script>");
        //        }
        //    }


        //    return
        //        Content("<script>alert('" + msg + "');  location.href='/Calendar/workcal?open=" + doc.project_idx +
        //                "&idx=" + doc.idx + "';</script>");
        //}


        [HttpPost]
        public string cal_update(string start, string end, string w, string d, int idx)
        {
            DateTime _start = Convert.ToDateTime(start.Replace("T", " "));
            DateTime _end = Convert.ToDateTime(end.Replace("T", " "));

            string user = User.Identity.Name;
            string state = "N";
            string user_id = w;
            string department_id = d;

            int idx_it = idx;

            #region 기본 사용자 정보
        
            int department_idx = Convert.ToInt32(UserData.user_get(user_id, "department_idx"));
            int company_idx = Convert.ToInt32(UserData.user_get(user_id, "company_idx"));
            int auth = Convert.ToInt32(UserData.user_get(user_id, "auth"));
            #endregion


            string ok_auth = "N";

            if (user_id == user)
            {
                ok_auth = "Y";
            }
            if (auth >= 8)
            {
                ok_auth = "Y";
            }
           


            if (ok_auth == "Y")
            {
                #region 칼린더 드래그 수정

                calendar _update =
                    (from a in db.calendar where a.idx == idx_it select a).FirstOrDefault();

                _update.start_date = _start;
                _update.end_date = _end;
                _update.edit_date = DateTime.Now;

                db.SaveChanges(); // 실제로 저장  
                state = "Y";

                #endregion
            }
            return state;
        }



        //[Authorize]
        //public ActionResult DelCal(CalPopModel Calp)
        //{
        //    string who = Request["who"] ?? "";
        //    string msg = Util.msg.msg_del;
        //    string open = Request["open"];
        //    int idx = Convert.ToInt32(Request["idx"]);
        //    work_list Cdata = (from a in db.work_list where a.idx == idx select a).First();

        //    #region 권한체크

        //    string user = User.Identity.Name;
        //    int auth = 0;
        //    try
        //    {
        //        auth = Convert.ToInt16(Request.Cookies["check_auth"].Value);
        //    }
        //    catch
        //    {
        //    }

        //    string ok_auth = "N";

        //    if (Cdata.user_id == user)
        //    {
        //        ok_auth = "Y";
        //    }

        //    if (auth >= 8)
        //    {
        //        ok_auth = "Y";
        //    }

        //    #endregion

        //    if (ok_auth == "Y")
        //    {
        //        db.work_list.Remove(Cdata);
        //        db.SaveChanges();

        //        return
        //            Content("<script>alert('" + msg + "'); location.href='/Calendar/workcal?open=" + open +
        //                    "';</script>");
        //    }
        //    else
        //    {
        //        return
        //            Content("<script>alert('"+ Util.msg.msg_no+ "'); location.href='/Calendar/workcal?open=" + open + "';</script>");
        //    }
        //}

        ////캘린더 아이템을 가져온다.
        public string GetCalendarItem(string _type, string open, string d)
        {
            string json = "";
        


            #region 기본 사용자 정보
            string user_id = User.Identity.Name;
            int department_idx = Convert.ToInt32(UserData.user_get(user_id, "department_idx"));
            int company_idx = Convert.ToInt32(UserData.user_get(user_id, "company_idx"));
            int auth = Convert.ToInt32(UserData.user_get(user_id, "auth"));
            #endregion




            int project = 0;
            int category = 0;


            if (!string.IsNullOrEmpty(open))
            {
                project = Convert.ToInt32(open);
            }
            if (!string.IsNullOrEmpty(_type))
            {
                category = Convert.ToInt32(_type);
            }


           

            var calData = (from a in db.calendar
                           where a.company_idx == company_idx && (a.open_it == "Y" || a.department_idx == department_idx)
                           select new
                           {
                               id = a.idx,
                               a.title,
                               start = a.start_date,
                               end = a.end_date,
                               who = user_id,
                               project = a.project_idx,
                               a.code_work_idx,
                               a.code_index_idx,
                               a.user_id,
                               a.department_idxNavigation.department_name,
                               a.department_idx 
                           }).ToList();

            if (!string.IsNullOrEmpty(open))
            {
                calData = calData.Where(s => s.project == project).ToList();
            }

            if (!string.IsNullOrEmpty(_type))
            {
                calData = calData.Where(s => s.code_work_idx == category).ToList();
            }

            if (!string.IsNullOrEmpty(d))
            {
                department_idx = Convert.ToInt32(d);
                calData = calData.Where(s => s.department_idx == department_idx).ToList();
            }
            json = JsonConvert.SerializeObject(calData);


            //json
            string stop = string.Empty;

            return json;
        }



        #region Nested type: CalPopModel

        public class CalPopModel
        {
            public int idx { get; set; }
            public string sday { get; set; }
            public string stimeh { get; set; }
            public string stimem { get; set; }
            public string eday { get; set; }
            public string etimeh { get; set; }
            public string etimem { get; set; }
            public string title { get; set; }
            public string content { get; set; }
            public string category { get; set; }
        }

        #endregion
    }
}
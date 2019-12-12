using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmartFactory.Models;
using static SmartFactory.Controllers.SysController;

namespace SmartFactory.Controllers
{
    public class ProductionController : Controller
    {
        private readonly db_e db = new db_e();


        #region 장비 사용자 수정
        // 리스트
        public async Task<IActionResult> Order_list()
        {

            //var _model = db.order.Where(p => p.use_yn != "N").ToListAsync();

            var _modle2 = (from a in db.order.Include(p => p.company_idxNavigation) where a.use_yn != "N" select a).OrderByDescending(p => p.idx).ToListAsync();


            return View(await _modle2);
        }


        // 작성 및 수정
        public IActionResult Order_set(order doc, int? idx)
        {
            //========================================================================================================================================================
            var code_order_step = db.code_order_step.Where(p => p.use_yn != "N").OrderBy(P => P.index_order).Select(c => new { 값 = c.code_id, 이름 = c.code_name });
            ViewBag.코드 = new SelectList(code_order_step.AsEnumerable(), "값", "이름");

            //========================================================================================================================================================

            //========================================================================================================================================================
            var company = db.company.Where(p => p.use_yn != "N" && p.gubun_idx == 3).OrderBy(P => P.index_order).Select(c => new { 값 = c.idx, 이름 = c.company_name });
            ViewBag.거래처 = new SelectList(company.AsEnumerable(), "값", "이름");

            //========================================================================================================================================================
            //======================================================================================================================================================== 
            var code_work_state =
                db.code_work_state.OrderBy(o => o.index_order).Select(c => new { 값 = c.code_id, 이름 = c.code_name });
            ViewBag.작업상태 = new SelectList(code_work_state.AsEnumerable(), "값", "이름");
            //========================================================================================================================================================


            if (idx != null)
            {
                doc = db.order.Single(x => x.idx == idx);

            }


            return View(doc);
        }


        public async Task<IActionResult> Order_action(order doc, int? idx, string mode_type)
        {

            #region 기본 사용자 정보
            string user_id = User.Identity.Name;
            int company_idx = Convert.ToInt32(UserData.user_get(user_id, "company_idx"));
            int auth = Convert.ToInt32(UserData.user_get(user_id, "auth"));
            #endregion

            if (idx == null)
            {


                #region 저장
                doc.company_idx = company_idx;
                doc.use_yn = "Y";
                doc.writeDate = DateTime.Now;
                db.order.Add(doc);
                await db.SaveChangesAsync();

                #endregion



            }
            else
            {


                if (mode_type == "D")
                {
                    #region 사용안함



                    order _update =
                      (from a in db.order where a.idx == idx select a).Single();

                    _update.use_yn = "N";
                    await db.SaveChangesAsync();



                    #endregion
                }
                else
                {
                    #region 수정

                    doc.writeDate = DateTime.Now;
                    db.Entry(doc).State = EntityState.Modified;
                    await db.SaveChangesAsync();

                    return Redirect("/Production/Order_set?idx=" + idx);

                    #endregion
                }
            }


            return Redirect("/Production/Order_list");
        }

        #endregion







    }
}
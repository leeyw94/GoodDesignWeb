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
    public class managementController : Controller
    {
        private readonly db_e db = new db_e();


        #region 장비 사용자 수정
        // 리스트
        public async Task <IActionResult> Machine_list()
        {

          //  var _model = db.machine.Where(p => p.use_yn != "N").ToListAsync();

            var _modle2 = (from a in db.machine.Include(p=> p.company_idxNavigation) where a.use_yn != "N" select a).OrderByDescending(p => p.idx ).ToListAsync();


            return View(await _modle2);
        }


        // 작성 및 수정
        public IActionResult Machine_set(machine doc, int? idx)
        {
            //========================================================================================================================================================
            var code_machine = db.code_machine_spec.Where(p => p.use_yn != "N").OrderBy(P => P.index_order).Select(c => new { 값 = c.code_id, 이름 = c.code_name });
            ViewBag.코드 = new SelectList(code_machine.AsEnumerable(), "값", "이름");

            //========================================================================================================================================================

            //========================================================================================================================================================
            var company = db.company.Where(p => p.use_yn != "N" && p.gubun_idx == 3).OrderBy(P => P.index_order).Select(c => new { 값 = c.idx, 이름 = c.company_name });
            ViewBag.거래처 = new SelectList(company.AsEnumerable(), "값", "이름");

            //========================================================================================================================================================



            if (idx != null)
            {
                doc = db.machine.Single(x => x.idx == idx);

            }


            return View(doc);
        }


        public async Task<IActionResult> Machine_action(machine doc, int? idx, string mode_type)
        {

            #region 기본 사용자 정보
            string user_id = User.Identity.Name;
            int department_idx = Convert.ToInt32(UserData.user_get(user_id, "department_idx"));
            int company_idx = Convert.ToInt32(UserData.user_get(user_id, "company_idx"));
            int auth = Convert.ToInt32(UserData.user_get(user_id, "auth"));
            #endregion

            if (idx == null)
            {


                #region 저장
                doc.company_idx = company_idx;
                doc.use_yn = "Y";
                doc.writeDate = DateTime.Now;
                db.machine.Add(doc);
                await db.SaveChangesAsync(); 

                #endregion



            }
            else
            {


                if (mode_type == "D")
                {
                    #region 사용안함



                    machine _update =
                      (from a in db.machine where a.idx == idx select a).Single();

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

                    return Redirect("/management/Machine_set?idx=" + idx);

                    #endregion
                }
            }


            return Redirect("/management/Machine_list");
        }

        #endregion

        #region 원자재 사용자 수정
        // 리스트
        public async Task<IActionResult> Material_list()
        {
            return View(await db.material.Where(p => p.use_yn != "N").ToListAsync());
        }


        // 작성 및 수정
        public IActionResult Material_set(material doc, int? idx)
        {
            //========================================================================================================================================================
            var code_material = db.code_material_spec.Where(p => p.use_yn != "N").OrderBy(P => P.index_order).Select(c => new { 값 = c.code_id, 이름 = c.code_name });
            ViewBag.코드 = new SelectList(code_material.AsEnumerable(), "값", "이름");

            //========================================================================================================================================================

            if (idx != null)
            {
                doc = db.material.Single(x => x.idx == idx);

            }


            return View(doc);
        }


        public async Task<IActionResult> Material_action(material doc, int? idx, string mode_type)
        {



            if (idx == null)
            {
                #region 저장
                doc.use_yn = "Y";
                doc.writeDate = DateTime.Now;
                db.material.Add(doc);
                await db.SaveChangesAsync();


                #endregion
            }
            else
            {


                if (mode_type == "D")
                {
                    #region 사용안함



                    material _update =
                      (from a in db.material where a.idx == idx select a).Single();

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

                    return Redirect("/management/Material_set?idx=" + idx);

                    #endregion
                }
            }


            return Redirect("/management/Material_list");
        }

        #endregion

        #region 제품 사용자 수정
        // 리스트
        public async Task<IActionResult> Product_list()
        {
            return View(await db.Product.Where(p => p.use_yn != "N").ToListAsync());
        }


        // 작성 및 수정
        public IActionResult Product_set(Product doc, int? idx)
        {
            //========================================================================================================================================================
            var code_product = db.code_product_spec.Where(p => p.use_yn != "N").OrderBy(P => P.index_order).Select(c => new { 값 = c.code_id, 이름 = c.code_name });
            ViewBag.코드 = new SelectList(code_product.AsEnumerable(), "값", "이름");

            //========================================================================================================================================================

            if (idx != null)
            {
                doc = db.Product.Single(x => x.idx == idx);

            }


            return View(doc);
        }


        public async Task<IActionResult> Product_action(Product doc, int? idx, string mode_type)
        {



            if (idx == null)
            {
                #region 저장
                doc.use_yn = "Y";
                doc.writeDate = DateTime.Now;
                db.Product.Add(doc);
                await db.SaveChangesAsync();


                #endregion
            }
            else
            {


                if (mode_type == "D")
                {
                    #region 사용안함



                    Product _update =
                      (from a in db.Product where a.idx == idx select a).Single();

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

                    return Redirect("/management/Product_set?idx=" + idx);

                    #endregion
                }
            }


            return Redirect("/management/Product_list");
        }

        #endregion




       
    }
}
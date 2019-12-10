using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmartFactory.Models;

namespace SmartFactory.Controllers
{
    public class samplesController : Controller
    {
        private readonly db_e db = new db_e();


        // GET: samples
        public async Task<IActionResult> sample_list()
        {
            return View(await db.sample.ToListAsync());
        }

        // GET: samples/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sample = await db.sample
                .FirstOrDefaultAsync(m => m.idx == id);
            if (sample == null)
            {
                return NotFound();
            }

            return View(sample);
        }

        // GET: samples/Create
        public IActionResult sample_set()
        {
            //========================================================================================================================================================
            var code_sample = db.code_sample.Where(p => p.use_yn != "N").OrderBy(P => P.index_order).Select(c => new { 값 = c.code_id, 이름 = c.code_name });
            ViewBag.코드 = new SelectList(code_sample.AsEnumerable(), "값", "이름");

            //========================================================================================================================================================


            return View();
        }

        // POST: samples/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idx,title,userName,writeDate")] sample sample)
        {
            if (ModelState.IsValid)
            {
                db.Add(sample);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sample);
        }

        // GET: samples/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sample = await db.sample.FindAsync(id);
            if (sample == null)
            {
                return NotFound();
            }
            return View(sample);
        }

        // POST: samples/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idx,title,userName,writeDate")] sample sample)
        {
            if (id != sample.idx)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(sample);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!sampleExists(sample.idx))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(sample);
        }

        // GET: samples/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sample = await db.sample
                .FirstOrDefaultAsync(m => m.idx == id);
            if (sample == null)
            {
                return NotFound();
            }

            return View(sample);
        }

        // POST: samples/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sample = await db.sample.FindAsync(id);
            db.sample.Remove(sample);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool sampleExists(int id)
        {
            return db.sample.Any(e => e.idx == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HR_OxCode.Data;
using HR_OxCode.Models;

namespace HR_OxCode.Controllers
{
    public class AppraisalsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AppraisalsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Appraisals
        public async Task<IActionResult> Index()
        {
            return View(await _context.Appraisal.ToListAsync());
        }

        // GET: Appraisals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appraisal = await _context.Appraisal
                .FirstOrDefaultAsync(m => m.id == id);
            if (appraisal == null)
            {
                return NotFound();
            }

            return View(appraisal);
        }

        // GET: Appraisals/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Appraisals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,StaffID,Name,Nationality,jobTitle,Department,Qualification,Branch,HireDate,PerformanceAttribute,Recommendation,Comments")] Appraisal appraisal)
        {
            int? maxid = _context.Letters.Max(x => (int?)x.id);

            if (ModelState.IsValid)
            {
                _context.Add(appraisal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(appraisal);
        }

        // GET: Appraisals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appraisal = await _context.Appraisal.FindAsync(id);
            if (appraisal == null)
            {
                return NotFound();
            }
            return View(appraisal);
        }

        // POST: Appraisals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,StaffID,Name,Nationality,jobTitle,Department,Qualification,Branch,HireDate,PerformanceAttribute,Recommendation,Comments")] Appraisal appraisal)
        {
            if (id != appraisal.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(appraisal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppraisalExists(appraisal.id))
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
            return View(appraisal);
        }

        // GET: Appraisals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appraisal = await _context.Appraisal
                .FirstOrDefaultAsync(m => m.id == id);
            if (appraisal == null)
            {
                return NotFound();
            }

            return View(appraisal);
        }

        // POST: Appraisals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var appraisal = await _context.Appraisal.FindAsync(id);
            _context.Appraisal.Remove(appraisal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AppraisalExists(int id)
        {
            return _context.Appraisal.Any(e => e.id == id);
        }
    }
}

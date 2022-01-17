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
    public class ExcuseingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ExcuseingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Excuseings
        public async Task<IActionResult> Index()
        {
            return View(await _context.Excuseing.ToListAsync());
        }

        // GET: Excuseings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var excuseing = await _context.Excuseing
                .FirstOrDefaultAsync(m => m.id == id);
            if (excuseing == null)
            {
                return NotFound();
            }

            return View(excuseing);
        }

        // GET: Excuseings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Excuseings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,StaffID,FullName,ExcuseFrom,ExcuseTo,NoOfHourse,NoOfDays,LeaveReason")] Excuseing excuseing)
        {
            if (ModelState.IsValid)
            {
                _context.Add(excuseing);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(excuseing);
        }

        // GET: Excuseings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var excuseing = await _context.Excuseing.FindAsync(id);
            if (excuseing == null)
            {
                return NotFound();
            }
            return View(excuseing);
        }

        // POST: Excuseings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,StaffID,FullName,ExcuseFrom,ExcuseTo,NoOfHourse,NoOfDays,LeaveReason")] Excuseing excuseing)
        {
            if (id != excuseing.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(excuseing);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExcuseingExists(excuseing.id))
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
            return View(excuseing);
        }

        // GET: Excuseings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var excuseing = await _context.Excuseing
                .FirstOrDefaultAsync(m => m.id == id);
            if (excuseing == null)
            {
                return NotFound();
            }

            return View(excuseing);
        }

        // POST: Excuseings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var excuseing = await _context.Excuseing.FindAsync(id);
            _context.Excuseing.Remove(excuseing);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExcuseingExists(int id)
        {
            return _context.Excuseing.Any(e => e.id == id);
        }
    }
}

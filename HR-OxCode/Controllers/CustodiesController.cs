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
    public class CustodiesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustodiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Custodies
        public async Task<IActionResult> Index()
        {
            return View(await _context.Custody.ToListAsync());
        }

        // GET: Custodies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var custody = await _context.Custody
                .FirstOrDefaultAsync(m => m.id == id);
            if (custody == null)
            {
                return NotFound();
            }

            return View(custody);
        }

        // GET: Custodies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Custodies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,EmpNo,EmpID,EmpName,TheCustody,AdditionInfo")] Custody custody)
        {
            if (ModelState.IsValid)
            {
                _context.Add(custody);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(custody);
        }

        // GET: Custodies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var custody = await _context.Custody.FindAsync(id);
            if (custody == null)
            {
                return NotFound();
            }
            return View(custody);
        }

        // POST: Custodies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,EmpNo,EmpID,EmpName,TheCustody,AdditionInfo")] Custody custody)
        {
            if (id != custody.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(custody);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustodyExists(custody.id))
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
            return View(custody);
        }

        // GET: Custodies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var custody = await _context.Custody
                .FirstOrDefaultAsync(m => m.id == id);
            if (custody == null)
            {
                return NotFound();
            }

            return View(custody);
        }

        // POST: Custodies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var custody = await _context.Custody.FindAsync(id);
            _context.Custody.Remove(custody);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustodyExists(int id)
        {
            return _context.Custody.Any(e => e.id == id);
        }
    }
}

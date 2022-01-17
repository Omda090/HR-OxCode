using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HR_OxCode.Data;

namespace HR_OxCode.Models
{
    public class HRPanelLoansRequestsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HRPanelLoansRequestsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: HRPanelLoansRequests
        public async Task<IActionResult> Index()
        {
            return View(await _context.HRPanelLoansRequest.ToListAsync());
        }

        // GET: HRPanelLoansRequests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hRPanelLoansRequest = await _context.HRPanelLoansRequest
                .FirstOrDefaultAsync(m => m.id == id);
            if (hRPanelLoansRequest == null)
            {
                return NotFound();
            }

            return View(hRPanelLoansRequest);
        }

        // GET: HRPanelLoansRequests/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HRPanelLoansRequests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Notes,LoanAmount,NoOfinstallment,installmentStarts,TotalLoans,TotalPaid,TotalPending")] HRPanelLoansRequest hRPanelLoansRequest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hRPanelLoansRequest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hRPanelLoansRequest);
        }

        // GET: HRPanelLoansRequests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hRPanelLoansRequest = await _context.HRPanelLoansRequest.FindAsync(id);
            if (hRPanelLoansRequest == null)
            {
                return NotFound();
            }
            return View(hRPanelLoansRequest);
        }

        // POST: HRPanelLoansRequests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Notes,LoanAmount,NoOfinstallment,installmentStarts,TotalLoans,TotalPaid,TotalPending")] HRPanelLoansRequest hRPanelLoansRequest)
        {
            if (id != hRPanelLoansRequest.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hRPanelLoansRequest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HRPanelLoansRequestExists(hRPanelLoansRequest.id))
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
            return View(hRPanelLoansRequest);
        }

        // GET: HRPanelLoansRequests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hRPanelLoansRequest = await _context.HRPanelLoansRequest
                .FirstOrDefaultAsync(m => m.id == id);
            if (hRPanelLoansRequest == null)
            {
                return NotFound();
            }

            return View(hRPanelLoansRequest);
        }

        // POST: HRPanelLoansRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hRPanelLoansRequest = await _context.HRPanelLoansRequest.FindAsync(id);
            _context.HRPanelLoansRequest.Remove(hRPanelLoansRequest);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HRPanelLoansRequestExists(int id)
        {
            return _context.HRPanelLoansRequest.Any(e => e.id == id);
        }
    }
}

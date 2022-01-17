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
    public class HRPanelVacationRequestsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HRPanelVacationRequestsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: HRPanelVacationRequests
        public async Task<IActionResult> Index()
        {
            return View(await _context.HRPanelVacationRequest.ToListAsync());
        }

        // GET: HRPanelVacationRequests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hRPanelVacationRequest = await _context.HRPanelVacationRequest
                .FirstOrDefaultAsync(m => m.id == id);
            if (hRPanelVacationRequest == null)
            {
                return NotFound();
            }

            return View(hRPanelVacationRequest);
        }

        // GET: HRPanelVacationRequests/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HRPanelVacationRequests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,LeaveType,LeaveFrom,LeaveTo,NoOfDays,LeaveReason,ContactDetails,SavedBy")] HRPanelVacationRequest hRPanelVacationRequest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hRPanelVacationRequest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hRPanelVacationRequest);
        }

        // GET: HRPanelVacationRequests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hRPanelVacationRequest = await _context.HRPanelVacationRequest.FindAsync(id);
            if (hRPanelVacationRequest == null)
            {
                return NotFound();
            }
            return View(hRPanelVacationRequest);
        }

        // POST: HRPanelVacationRequests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,LeaveType,LeaveFrom,LeaveTo,NoOfDays,LeaveReason,ContactDetails,SavedBy")] HRPanelVacationRequest hRPanelVacationRequest)
        {
            if (id != hRPanelVacationRequest.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hRPanelVacationRequest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HRPanelVacationRequestExists(hRPanelVacationRequest.id))
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
            return View(hRPanelVacationRequest);
        }

        // GET: HRPanelVacationRequests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hRPanelVacationRequest = await _context.HRPanelVacationRequest
                .FirstOrDefaultAsync(m => m.id == id);
            if (hRPanelVacationRequest == null)
            {
                return NotFound();
            }

            return View(hRPanelVacationRequest);
        }

        // POST: HRPanelVacationRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hRPanelVacationRequest = await _context.HRPanelVacationRequest.FindAsync(id);
            _context.HRPanelVacationRequest.Remove(hRPanelVacationRequest);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HRPanelVacationRequestExists(int id)
        {
            return _context.HRPanelVacationRequest.Any(e => e.id == id);
        }
    }
}

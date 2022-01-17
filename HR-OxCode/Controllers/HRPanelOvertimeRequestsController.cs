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
    public class HRPanelOvertimeRequestsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HRPanelOvertimeRequestsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: HRPanelOvertimeRequests
        public async Task<IActionResult> Index()
        {
            return View(await _context.HRPanelOvertimeRequest.ToListAsync());
        }

        // GET: HRPanelOvertimeRequests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hRPanelOvertimeRequest = await _context.HRPanelOvertimeRequest
                .FirstOrDefaultAsync(m => m.id == id);
            if (hRPanelOvertimeRequest == null)
            {
                return NotFound();
            }

            return View(hRPanelOvertimeRequest);
        }

        // GET: HRPanelOvertimeRequests/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HRPanelOvertimeRequests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,DateMonth,NoOfHourse,Amount,OverNotes,CreatedBy,TotalOvertime,Totalpaid,TotalOVPending")] HRPanelOvertimeRequest hRPanelOvertimeRequest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hRPanelOvertimeRequest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hRPanelOvertimeRequest);
        }

        // GET: HRPanelOvertimeRequests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hRPanelOvertimeRequest = await _context.HRPanelOvertimeRequest.FindAsync(id);
            if (hRPanelOvertimeRequest == null)
            {
                return NotFound();
            }
            return View(hRPanelOvertimeRequest);
        }

        // POST: HRPanelOvertimeRequests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,DateMonth,NoOfHourse,Amount,OverNotes,CreatedBy,TotalOvertime,Totalpaid,TotalOVPending")] HRPanelOvertimeRequest hRPanelOvertimeRequest)
        {
            if (id != hRPanelOvertimeRequest.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hRPanelOvertimeRequest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HRPanelOvertimeRequestExists(hRPanelOvertimeRequest.id))
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
            return View(hRPanelOvertimeRequest);
        }

        // GET: HRPanelOvertimeRequests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hRPanelOvertimeRequest = await _context.HRPanelOvertimeRequest
                .FirstOrDefaultAsync(m => m.id == id);
            if (hRPanelOvertimeRequest == null)
            {
                return NotFound();
            }

            return View(hRPanelOvertimeRequest);
        }

        // POST: HRPanelOvertimeRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hRPanelOvertimeRequest = await _context.HRPanelOvertimeRequest.FindAsync(id);
            _context.HRPanelOvertimeRequest.Remove(hRPanelOvertimeRequest);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HRPanelOvertimeRequestExists(int id)
        {
            return _context.HRPanelOvertimeRequest.Any(e => e.id == id);
        }
    }
}

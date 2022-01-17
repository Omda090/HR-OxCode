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
    public class HRPanelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HRPanelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: HRPanels
        public async Task<IActionResult> Index()
        {
            return View(await _context.HRPanel.ToListAsync());
        }

        // GET: HRPanels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hRPanel = await _context.HRPanel
                .FirstOrDefaultAsync(m => m.id == id);
            if (hRPanel == null)
            {
                return NotFound();
            }

            return View(hRPanel);
        }

        // GET: HRPanels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HRPanels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,EmpID,AccessCardNo,FullName,MartialStatus,Nationality,Relegion,Address,Mobile,PassNo,IssuePlace,IssueDate,ExpiryDate,jobtitle,HireDate,Branch,Department,Name,Relation,Phone,BasicSalary,HousingAllownce,TransAllownce,OtherAllownce,TotalSalary,Notes,LoanAmount,NoOfinstallment,installmentStarts,TotalLoans,TotalPaid,TotalPending,DateMonth,NoOfHourse,Amount,OverNotes,CreatedBy,TotalOvertime,Totalpaid,TotalOVPending,LeaveType,LeaveFrom,LeaveTo,NoOfDays,LeaveReason,ContactDetails,SavedBy")] HRPanel hRPanel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hRPanel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hRPanel);
        }

        // GET: HRPanels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hRPanel = await _context.HRPanel.FindAsync(id);
            if (hRPanel == null)
            {
                return NotFound();
            }
            return View(hRPanel);
        }

        // POST: HRPanels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,EmpID,AccessCardNo,FullName,MartialStatus,Nationality,Relegion,Address,Mobile,PassNo,IssuePlace,IssueDate,ExpiryDate,jobtitle,HireDate,Branch,Department,Name,Relation,Phone,BasicSalary,HousingAllownce,TransAllownce,OtherAllownce,TotalSalary,Notes,LoanAmount,NoOfinstallment,installmentStarts,TotalLoans,TotalPaid,TotalPending,DateMonth,NoOfHourse,Amount,OverNotes,CreatedBy,TotalOvertime,Totalpaid,TotalOVPending,LeaveType,LeaveFrom,LeaveTo,NoOfDays,LeaveReason,ContactDetails,SavedBy")] HRPanel hRPanel)
        {
            if (id != hRPanel.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hRPanel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HRPanelExists(hRPanel.id))
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
            return View(hRPanel);
        }

        // GET: HRPanels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hRPanel = await _context.HRPanel
                .FirstOrDefaultAsync(m => m.id == id);
            if (hRPanel == null)
            {
                return NotFound();
            }

            return View(hRPanel);
        }

        // POST: HRPanels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hRPanel = await _context.HRPanel.FindAsync(id);
            _context.HRPanel.Remove(hRPanel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HRPanelExists(int id)
        {
            return _context.HRPanel.Any(e => e.id == id);
        }
    }
}

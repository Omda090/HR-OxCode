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
    public class AirTicketsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AirTicketsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AirTickets
        public async Task<IActionResult> Index()
        {
            return View(await _context.AirTickets.ToListAsync());
        }

        // GET: AirTickets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airTickets = await _context.AirTickets
                .FirstOrDefaultAsync(m => m.id == id);
            if (airTickets == null)
            {
                return NotFound();
            }

            return View(airTickets);
        }

        // GET: AirTickets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AirTickets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,StaffID,Name,jobTitle,Branch,Nationality,Year,FlightDetails,Payment,Adults,Children,Infants,ValuePrice,NoOfinstallment,Dateinstallment,installmentAmount,InsuranceCompany,PolicyNo,EffectiveDate,ExpiryDate,InsuredMemberName,CardNo,Class,Age,Gender,BasicPremium,InsuranceAmount,ExcuseFrom,DateFrom,DateTo,NoOfDays,NoOfHours,LeaveReason")] AirTickets airTickets)
        {
            int? maxid = _context.Letters.Max(x => (int?)x.id);

            if (ModelState.IsValid)
            {
                _context.Add(airTickets);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(airTickets);
        }

        // GET: AirTickets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airTickets = await _context.AirTickets.FindAsync(id);
            if (airTickets == null)
            {
                return NotFound();
            }
            return View(airTickets);
        }

        // POST: AirTickets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,StaffID,Name,jobTitle,Branch,Nationality,Year,FlightDetails,Payment,Adults,Children,Infants,ValuePrice,NoOfinstallment,Dateinstallment,installmentAmount,InsuranceCompany,PolicyNo,EffectiveDate,ExpiryDate,InsuredMemberName,CardNo,Class,Age,Gender,BasicPremium,InsuranceAmount,ExcuseFrom,DateFrom,DateTo,NoOfDays,NoOfHours,LeaveReason")] AirTickets airTickets)
        {
            if (id != airTickets.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(airTickets);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AirTicketsExists(airTickets.id))
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
            return View(airTickets);
        }

        // GET: AirTickets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airTickets = await _context.AirTickets
                .FirstOrDefaultAsync(m => m.id == id);
            if (airTickets == null)
            {
                return NotFound();
            }

            return View(airTickets);
        }

        // POST: AirTickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var airTickets = await _context.AirTickets.FindAsync(id);
            _context.AirTickets.Remove(airTickets);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AirTicketsExists(int id)
        {
            return _context.AirTickets.Any(e => e.id == id);
        }
    }
}

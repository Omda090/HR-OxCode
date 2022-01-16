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
    public class EndOfServicesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EndOfServicesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: EndOfServices
        public async Task<IActionResult> Index()
        {
            return View(await _context.EndOfService.ToListAsync());
        }

        // GET: EndOfServices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var endOfService = await _context.EndOfService
                .FirstOrDefaultAsync(m => m.id == id);
            if (endOfService == null)
            {
                return NotFound();
            }

            return View(endOfService);
        }

        // GET: EndOfServices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EndOfServices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,EmpID,FullName,jobtitle,HireDate,Branch,BasicSalary,HouseingAllownse,TransAllownse,TotalSalary,TypeOfEnd,EndOfServiceDate,Benefits,PeriodHiredYM,Comments")] EndOfService endOfService)
        {
            if (ModelState.IsValid)
            {
                _context.Add(endOfService);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(endOfService);
        }

        // GET: EndOfServices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var endOfService = await _context.EndOfService.FindAsync(id);
            if (endOfService == null)
            {
                return NotFound();
            }
            return View(endOfService);
        }

        // POST: EndOfServices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,EmpID,FullName,jobtitle,HireDate,Branch,BasicSalary,HouseingAllownse,TransAllownse,TotalSalary,TypeOfEnd,EndOfServiceDate,Benefits,PeriodHiredYM,Comments")] EndOfService endOfService)
        {
            if (id != endOfService.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(endOfService);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EndOfServiceExists(endOfService.id))
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
            return View(endOfService);
        }

        // GET: EndOfServices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var endOfService = await _context.EndOfService
                .FirstOrDefaultAsync(m => m.id == id);
            if (endOfService == null)
            {
                return NotFound();
            }

            return View(endOfService);
        }

        // POST: EndOfServices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var endOfService = await _context.EndOfService.FindAsync(id);
            _context.EndOfService.Remove(endOfService);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EndOfServiceExists(int id)
        {
            return _context.EndOfService.Any(e => e.id == id);
        }
    }
}

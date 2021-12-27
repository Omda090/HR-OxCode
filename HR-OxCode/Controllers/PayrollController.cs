using HR_OxCode.Data;
using HR_OxCode.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_OxCode.Controllers
{
    public class PayrollController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PayrollController(ApplicationDbContext context)
        {
            _context = context;
        }


        //public IActionResult Payroll()
        //{
        //    return View();
        //}

        public IActionResult Index()
        {
            var displayData = _context.Payrolles.ToList();
            return View(displayData);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Payroll payroll)
        {
            if (ModelState.IsValid)
            {
                _context.Add(payroll);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(payroll);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var GetpayrollDetails = await _context.Payrolles.FindAsync(id);
            return View(GetpayrollDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Payroll payroll)
        {
            if (ModelState.IsValid)
            {
                _context.Update(payroll);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(payroll);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var GetpayrollDetails = await _context.Payrolles.FindAsync(id);
            return View(GetpayrollDetails);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var GetpayrollDetails = await _context.Payrolles.FindAsync(id);
            return View(GetpayrollDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var GetpayrollDetails = await _context.Payrolles.FindAsync(id);
            _context.Payrolles.Remove(GetpayrollDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}

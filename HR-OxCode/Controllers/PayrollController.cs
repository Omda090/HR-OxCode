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

            //ApplicationDbContext db = new ApplicationDbContext();
        }

        //Here
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
        //----------------------------------------------------------------------------------------
        //OvertimeManagement : 
        public IActionResult Overyimeindex()
        {
            var displayData = _context.overtimes.ToList();
            return View(displayData);
        }
        public IActionResult CreateOveryime()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateOveryime(Overtime overtime)
        {
            if (ModelState.IsValid)
            {
                _context.Add(overtime);
                await _context.SaveChangesAsync();
                return RedirectToAction("Overyimeindex");
            }
            return View(overtime);
        }

        public async Task<IActionResult> EditOveryime(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Overyimeindex");
            }

            var GetOvertimeDetails = await _context.overtimes.FindAsync(id);
            return View(GetOvertimeDetails);
        }

        [HttpPost]
        public async Task<IActionResult> EditOveryime(Overtime overtime)
        {
            if (ModelState.IsValid)
            {
                _context.Update(overtime);
                await _context.SaveChangesAsync();
                return RedirectToAction("Overyimeindex");
            }
            return View(overtime);
        }

        public async Task<IActionResult> DetailsOveryime(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Overyimeindex");
            }

            var GetOvertimeDetails = await _context.overtimes.FindAsync(id);
            return View(GetOvertimeDetails);
        }

        public async Task<IActionResult> DeleteOveryime(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Overyimeindex");
            }

            var GetOvertimeDetails = await _context.overtimes.FindAsync(id);
            return View(GetOvertimeDetails);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteOveryime(int id)
        {
            var GetOvertimeDetails = await _context.overtimes.FindAsync(id);
            _context.overtimes.Remove(GetOvertimeDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction("Overyimeindex");
        }

        //----------------------------------------------------------------------------------------
        //LoansManagement : 
        public IActionResult Loansindex()
        {
            var displayData = _context.loansManagements.ToList();
            return View(displayData);
        }

        public IActionResult CreateLoans()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateLoans(LoansManagement loansManagement)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loansManagement);
                await _context.SaveChangesAsync();
                return RedirectToAction("Loansindex");
            }
            return View(loansManagement);
        }

        public async Task<IActionResult> EditLoans(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Loansindex");
            }

            var GetLoansDetails = await _context.loansManagements.FindAsync(id);
            return View(GetLoansDetails);
        }

        [HttpPost]
        public async Task<IActionResult> EditLoans(LoansManagement loansManagement)
        {
            if (ModelState.IsValid)
            {
                _context.Update(loansManagement);
                await _context.SaveChangesAsync();
                return RedirectToAction("Loansindex");
            }
            return View(loansManagement);
        }

        public async Task<IActionResult> DetailsLoans(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Loansindex");
            }

            var GetLoansDetails = await _context.loansManagements.FindAsync(id);
            return View(GetLoansDetails);
        }

        public async Task<IActionResult> DeleteLoans(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Loansindex");
            }

            var GetLoansDetails = await _context.loansManagements.FindAsync(id);
            return View(GetLoansDetails);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteLoans(int id)
        {
            var GetLoansDetails = await _context.loansManagements.FindAsync(id);
            _context.loansManagements.Remove(GetLoansDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction("Loansindex");
        }

        //-------------------------------------------------------------------------------------------
        //PayLoans : 
        public IActionResult PayLoansindex()
        {

            //PayLoans payLoans= _context.payLoans.ToList();
            //var displayData = _context.payLoans.ToList();
            //Convert.ToString(displayData);
            return View(_context.payLoans.ToList());
        }

        public IActionResult CreatePayLoans()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreatePayLoans(PayLoans payLoans)
        {
            if (ModelState.IsValid)
            {
                _context.Add(payLoans);
                await _context.SaveChangesAsync();
                return RedirectToAction("PayLoansindex");
            }
            return View(payLoans);
        }

        public async Task<IActionResult> EditPayLoans(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("PayLoansindex");
            }

            var GetPayDetails = await _context.payLoans.FindAsync(id);
            return View(GetPayDetails);
        }

        [HttpPost]
        public async Task<IActionResult> EditPayLoans(PayLoans payLoans)
        {
            if (ModelState.IsValid)
            {
                _context.Update(payLoans);
                await _context.SaveChangesAsync();
                return RedirectToAction("PayLoansindex");
            }
            return View(payLoans);
        }

        public async Task<IActionResult> DetailsPayLoans(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("PayLoansindex");
            }

            var GetPayDetails = await _context.payLoans.FindAsync(id);
            return View(GetPayDetails);
        }

        public async Task<IActionResult> DeletePayLoans(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("PayLoansindex");
            }

            var GetPayDetails = await _context.payLoans.FindAsync(id);
            return View(GetPayDetails);
        }

        [HttpPost]
        public async Task<IActionResult> DeletePayLoans(int id)
        {
            var GetPayDetails = await _context.payLoans.FindAsync(id);
            _context.payLoans.Remove(GetPayDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction("PayLoansindex");
        }

        //----------------------------------------------------------------------------------------------
        //Deductiblets(Dely-Absence-Others) : 
        public IActionResult Deductindex()
        {
            var displayData = _context.deductibles.ToList();
            return View(displayData);
        }

        public IActionResult CreateDeduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateDeduct(Deductibles deductibles)
        {
            if (ModelState.IsValid)
            {
                _context.Add(deductibles);
                await _context.SaveChangesAsync();
                return RedirectToAction("Deductindex");
            }
            return View(deductibles);
        }

        public async Task<IActionResult> EditDeduct(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Deductindex");
            }

            var GetDeductDetails = await _context.deductibles.FindAsync(id);
            return View(GetDeductDetails);
        }

        [HttpPost]
        public async Task<IActionResult> EditDeduct(Deductibles deductibles)
        {
            if (ModelState.IsValid)
            {
                _context.Update(deductibles);
                await _context.SaveChangesAsync();
                return RedirectToAction("Deductindex");
            }
            return View(deductibles);
        }

        public async Task<IActionResult> DetailsDeduct(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Deductindex");
            }

            var GetDeductDetails = await _context.deductibles.FindAsync(id);
            return View(GetDeductDetails);
        }

        public async Task<IActionResult> DeleteDeduct(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Deductindex");
            }

            var GetDeductDetails = await _context.deductibles.FindAsync(id);
            return View(GetDeductDetails);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteDeduct(int id)
        {
            var GetDeductDetails = await _context.deductibles.FindAsync(id);
            _context.deductibles.Remove(GetDeductDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction("Deductindex");
        }

    }
}

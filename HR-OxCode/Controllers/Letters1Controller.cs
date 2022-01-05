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
    public class Letters1Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public Letters1Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Letters1
        public IActionResult Index()
        {
            return View( _context.Letters.ToList());
        }

        // GET: Letters1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var letters = await _context.Letters
                .FirstOrDefaultAsync(m => m.id == id);
            if (letters == null)
            {
                return NotFound();
            }

            return View(letters);
        }

        // GET: Letters1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Letters1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Letters letters)
        {
            int? maxid = _context.Letters.Max(x =>(int?) x.id);
            Letters insert = new Letters();
            if (ModelState.IsValid)
            {
                insert.id =Convert.ToInt32(++maxid);
                insert.EmpNo = letters.EmpNo;
                insert.FullName = letters.FullName;
                insert.jobTittle = letters.jobTittle;
                insert.LetterDate = letters.LetterDate.Date;
                insert.EffectiveDate = letters.EffectiveDate.Date;
                insert.Signature = letters.Signature;
                insert.WarningDate = letters.WarningDate.Date;
                insert.ViolationDamage = letters.ViolationDamage;
                insert.Penelty = letters.Penelty;
                insert.WarningType = letters.WarningType;
                insert.BankName = letters.BankName;
                insert.Branch = letters.Branch;
                insert.AccountNumber = letters.AccountNumber;
                insert.SalaryDate = letters.SalaryDate.Date;
                insert.StartingDateOn = letters.StartingDateOn.Date;
                insert.PeriodFrom = letters.PeriodFrom.Date;
                insert.PeriodTo = letters.PeriodTo.Date;
                _context.Letters.Add(insert);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(letters);
        }

        // GET: Letters1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var letters = await _context.Letters.FindAsync(id);
            if (letters == null)
            {
                return NotFound();
            }
            return View(letters);
        }

        // POST: Letters1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,EmpNo,FullName,jobTittle,LetterDate,EffectiveDate,Signature,WarningDate,ViolationDamage,Penelty,WarningType,BankName,Branch,AccountNumber,SalaryDate,StartingDateOn,PeriodFrom,PeriodTo")] Letters letters)
        {
            if (id != letters.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(letters);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LettersExists(letters.id))
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
            return View(letters);
        }

        // GET: Letters1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var letters = await _context.Letters
                .FirstOrDefaultAsync(m => m.id == id);
            if (letters == null)
            {
                return NotFound();
            }

            return View(letters);
        }

        // POST: Letters1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var letters = await _context.Letters.FindAsync(id);
            _context.Letters.Remove(letters);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LettersExists(int id)
        {
            return _context.Letters.Any(e => e.id == id);
        }
    }
}

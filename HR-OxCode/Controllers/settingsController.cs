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
    public class SettingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SettingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Settings
        public async Task<IActionResult> Index()
        {
            return View(await _context.Settings.ToListAsync());
        }

        // GET: Settings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var settings = await _context.Settings
                .FirstOrDefaultAsync(m => m.id == id);
            if (settings == null)
            {
                return NotFound();
            }

            return View(settings);
        }

        // GET: Settings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Settings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,DepartmentAr,DepartmentEn,jobtitle,NationalityAr,NationalityEn,BankName")] Settings settings)
        {
            if (ModelState.IsValid)
            {
                _context.Add(settings);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(settings);
        }

        // GET: Settings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var settings = await _context.Settings.FindAsync(id);
            if (settings == null)
            {
                return NotFound();
            }
            return View(settings);
        }

        // POST: Settings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,DepartmentAr,DepartmentEn,jobtitle,NationalityAr,NationalityEn,BankName")] Settings settings)
        {
            if (id != settings.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(settings);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SettingsExists(settings.id))
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
            return View(settings);
        }

        // GET: Settings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var settings = await _context.Settings
                .FirstOrDefaultAsync(m => m.id == id);
            if (settings == null)
            {
                return NotFound();
            }

            return View(settings);
        }

        // POST: Settings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var settings = await _context.Settings.FindAsync(id);
            _context.Settings.Remove(settings);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SettingsExists(int id)
        {
            return _context.Settings.Any(e => e.id == id);
        }
        //------------------------------------------------------------------------------------
        //jobTitle : 
        public IActionResult Jobtitleindex()
        {
            var displayData = _context.Settings.ToList();
            return View(displayData);
        }

        public IActionResult CreateJobtitle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateJobtitle(Settings settings)
        {
            if (ModelState.IsValid)
            {
                _context.Add(settings);
                await _context.SaveChangesAsync();
                return RedirectToAction("Jobtitleindex");
            }
            return View(settings);
        }

        public async Task<IActionResult> EditJobtitle(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Jobtitleindex");
            }

            var GetLoansDetails = await _context.Settings.FindAsync(id);
            return View(GetLoansDetails);
        }

        [HttpPost]
        public async Task<IActionResult> EditJobtitle(Settings settings)
        {
            if (ModelState.IsValid)
            {
                _context.Update(settings);
                await _context.SaveChangesAsync();
                return RedirectToAction("Jobtitleindex");
            }
            return View(settings);
        }

        public async Task<IActionResult> DetailsJobtitle(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Jobtitleindex");
            }

            var GetLoansDetails = await _context.Settings.FindAsync(id);
            return View(GetLoansDetails);
        }

        public async Task<IActionResult> DeleteJobtitle(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Jobtitleindex");
            }

            var GetLoansDetails = await _context.Settings.FindAsync(id);
            return View(GetLoansDetails);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteJobtitle(int id)
        {
            var GetLoansDetails = await _context.Settings.FindAsync(id);
            _context.Settings.Remove(GetLoansDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction("Jobtitleindex");
        }
        //--------------------------------------------------------------------------------------
        //Nationality : 

        public IActionResult Nationaltyindex()
        {
            var displayData = _context.Settings.ToList();
            return View(displayData);
        }

        public IActionResult CreateNationality()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateNationality(Settings settings)
        {
            if (ModelState.IsValid)
            {
                _context.Add(settings);
                await _context.SaveChangesAsync();
                return RedirectToAction("Nationaltyindex");
            }
            return View(settings);
        }

        public async Task<IActionResult> EditNationality(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Nationaltyindex");
            }

            var GetLoansDetails = await _context.Settings.FindAsync(id);
            return View(GetLoansDetails);
        }

        [HttpPost]
        public async Task<IActionResult> EditNationality(Settings settings)
        {
            if (ModelState.IsValid)
            {
                _context.Update(settings);
                await _context.SaveChangesAsync();
                return RedirectToAction("Nationaltyindex");
            }
            return View(settings);
        }

        public async Task<IActionResult> DetailsNationality(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Nationaltyindex");
            }

            var GetLoansDetails = await _context.Settings.FindAsync(id);
            return View(GetLoansDetails);
        }

        public async Task<IActionResult> DeleteNationality(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Nationaltyindex");
            }

            var GetLoansDetails = await _context.Settings.FindAsync(id);
            return View(GetLoansDetails);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteNationality(int id)
        {
            var GetLoansDetails = await _context.Settings.FindAsync(id);
            _context.Settings.Remove(GetLoansDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction("Nationaltyindex");
        }
        //---------------------------------------------------------------------------------------
        //BankNAme :

        public IActionResult BankNameindex()
        {
            var displayData = _context.Settings.ToList();
            return View(displayData);
        }

        public IActionResult CreateBank()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBank(Settings settings)
        {
            if (ModelState.IsValid)
            {
                _context.Add(settings);
                await _context.SaveChangesAsync();
                return RedirectToAction("BankNameindex");
            }
            return View(settings);
        }

        public async Task<IActionResult> EditBank(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("BankNameindex");
            }

            var GetLoansDetails = await _context.Settings.FindAsync(id);
            return View(GetLoansDetails);
        }

        [HttpPost]
        public async Task<IActionResult> EditBank(Settings settings)
        {
            if (ModelState.IsValid)
            {
                _context.Update(settings);
                await _context.SaveChangesAsync();
                return RedirectToAction("BankNameindex");
            }
            return View(settings);
        }

        public async Task<IActionResult> DetailsBank(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("BankNameindex");
            }

            var GetLoansDetails = await _context.Settings.FindAsync(id);
            return View(GetLoansDetails);
        }

        public async Task<IActionResult> DeleteBank(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("BankNameindex");
            }

            var GetLoansDetails = await _context.Settings.FindAsync(id);
            return View(GetLoansDetails);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteBank(int id)
        {
            var GetLoansDetails = await _context.Settings.FindAsync(id);
            _context.Settings.Remove(GetLoansDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction("BankNameindex");
        }
    }
}

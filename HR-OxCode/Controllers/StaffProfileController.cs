using HR_OxCode.Data;
using HR_OxCode.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_OxCode.Controllers
{
    public class StaffProfileController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StaffProfileController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var displayData = _context.StaffProfiles.ToList();
            return View(displayData);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(StaffProfile stf)
        {
            if(ModelState.IsValid)
            {
                _context.Add(stf);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(stf);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null)
            {
                return RedirectToAction("Index");
            }

            var GetstaffDetails = await _context.StaffProfiles.FindAsync(id);
            return View(GetstaffDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(StaffProfile staff)
        {
            if(ModelState.IsValid)
            {
                _context.Update(staff);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(staff);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var GetstaffDetails = await _context.StaffProfiles.FindAsync(id);
            return View(GetstaffDetails);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var GetstaffDetails = await _context.StaffProfiles.FindAsync(id);
            return View(GetstaffDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var GetstaffDetails = await _context.StaffProfiles.FindAsync(id);
            _context.StaffProfiles.Remove(GetstaffDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        //-------------------------------------------------------------------------------------------------------
        //----------- Attendence Meniu : 

        public IActionResult AttendState()
        {
            var displayData = _context.StaffProfiles.ToList();
            return View(displayData);
        }

        public IActionResult CreateAttend()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAttend(StaffProfile stf)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stf);
                await _context.SaveChangesAsync();
                return RedirectToAction("AttendState");
            }
            return View(stf);
        }

        public async Task<IActionResult> EditAttend(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("AttendState");
            }

            var GetstaffDetails = await _context.StaffProfiles.FindAsync(id);
            return View(GetstaffDetails);
        }

        [HttpPost]
        public async Task<IActionResult> EditAttend(StaffProfile staff)
        {
            if (ModelState.IsValid)
            {
                _context.Update(staff);
                await _context.SaveChangesAsync();
                return RedirectToAction("AttendState");
            }
            return View(staff);
        }

        public async Task<IActionResult> DetailsAttend(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("AttendState");
            }

            var GetstaffDetails = await _context.StaffProfiles.FindAsync(id);
            return View(GetstaffDetails);
        }

        public async Task<IActionResult> DeleteAttend(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("AttendState");
            }

            var GetstaffDetails = await _context.StaffProfiles.FindAsync(id);
            return View(GetstaffDetails);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAttend(int id)
        {
            var GetstaffDetails = await _context.StaffProfiles.FindAsync(id);
            _context.StaffProfiles.Remove(GetstaffDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction("AttendState");
        }
        //---------------------------------------------------------------------------------------------
        //-------------StaffAbsence--------------------------------------------------------------------

        public IActionResult Absence()
        {
            var displayData = _context.StaffProfiles.ToList();
            return View(displayData);
        }

        public IActionResult CreateAbsence()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAbsence(StaffProfile stf)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stf);
                await _context.SaveChangesAsync();
                return RedirectToAction("Absence");
            }
            return View(stf);
        }

        public async Task<IActionResult> EditAbsence(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Absence");
            }

            var GetstaffDetails = await _context.StaffProfiles.FindAsync(id);
            return View(GetstaffDetails);
        }

        [HttpPost]
        public async Task<IActionResult> EditAbsence(StaffProfile staff)
        {
            if (ModelState.IsValid)
            {
                _context.Update(staff);
                await _context.SaveChangesAsync();
                return RedirectToAction("Absence");
            }
            return View(staff);
        }

        public async Task<IActionResult> DetailsAbsence(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Absence");
            }

            var GetstaffDetails = await _context.StaffProfiles.FindAsync(id);
            return View(GetstaffDetails);
        }

        public async Task<IActionResult> DeleteAbsence(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Absence");
            }

            var GetstaffDetails = await _context.StaffProfiles.FindAsync(id);
            return View(GetstaffDetails);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAbsence(int id)
        {
            var GetstaffDetails = await _context.StaffProfiles.FindAsync(id);
            _context.StaffProfiles.Remove(GetstaffDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction("Absence");
        }
        //--------------------------------------------------------------------------------------------------

    }
}

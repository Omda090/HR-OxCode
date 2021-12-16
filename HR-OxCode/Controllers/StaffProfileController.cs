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


        [HttpPost]
        public IActionResult Create(StaffProfile staffProfile)
        {

            _context.Add(staffProfile);
            _context.SaveChanges();
          //  StaffProfile.message = "The record is Saved Successfully....";
            return View();
        }


     

    }
}

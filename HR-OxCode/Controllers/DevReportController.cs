using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_OxCode.Controllers
{
    public class DevReportController : Controller
    {
        public IActionResult PrintDev()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DXWebApplication2.Controllers
{
    public class ReporttController : Controller
    {
        public IActionResult IndexApprisal()
        {
            return View();
        }
    }
}

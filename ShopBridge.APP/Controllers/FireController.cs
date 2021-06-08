using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FireService.APP.Controllers
{
    public class FireController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

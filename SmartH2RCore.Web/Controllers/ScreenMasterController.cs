using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartH2RCore.Web.Controllers
{
    public class ScreenMasterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

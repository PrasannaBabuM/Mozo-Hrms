using Microsoft.AspNetCore.Mvc;

namespace SmartH2RCore.Web.Controllers
{
    public class DashboardController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

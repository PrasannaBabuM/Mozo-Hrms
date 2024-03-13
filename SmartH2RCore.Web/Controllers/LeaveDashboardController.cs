using Microsoft.AspNetCore.Mvc;

namespace SmartH2RCore.Web.Controllers
{

    public class LeaveDashboardController : BaseController
    {
        [Route("leave-dashboard")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

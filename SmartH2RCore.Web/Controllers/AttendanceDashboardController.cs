using Microsoft.AspNetCore.Mvc;

namespace SmartH2RCore.Web.Controllers
{
    public class AttendanceDashboardController : BaseController
    {
        [Route("attendance-dashboard")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

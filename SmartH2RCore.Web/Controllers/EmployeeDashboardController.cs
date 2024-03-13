using Microsoft.AspNetCore.Mvc;

namespace SmartH2RCore.Web.Controllers
{
    public class EmployeeDashboardController : BaseController
    {
        [Route("employee-dashboard")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

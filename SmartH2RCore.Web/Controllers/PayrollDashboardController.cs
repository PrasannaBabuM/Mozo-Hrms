using Microsoft.AspNetCore.Mvc;

namespace SmartH2RCore.Web.Controllers
{
    public class PayrollDashboardController : BaseController
    {
        [Route("payroll-dashboard")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

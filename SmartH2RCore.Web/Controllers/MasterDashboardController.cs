using Microsoft.AspNetCore.Mvc;

namespace SmartH2RCore.Web.Controllers
{
    public class MasterDashboardController : BaseController
    {
        [Route("master-dashboard")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace SmartH2RCore.Web.Controllers
{
    public class SettingsDashboardController : BaseController
    {
        [Route("setting-dashboard")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

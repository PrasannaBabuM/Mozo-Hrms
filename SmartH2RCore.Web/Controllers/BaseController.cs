using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using SmartH2RCore.Models.Identity;
using SmartH2RCore.Services.Interface;

using System.Linq;

namespace SmartH2RCore.Web.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        public BaseController()
        {

        }


        public User LoginUser
        {
            get
            {
                if (User.Identity.IsAuthenticated)
                {
                    var services = this.HttpContext.RequestServices;
                    var userService = (IUserService)services.GetService(typeof(IUserService));
                    return userService.GetAll().Include(v => v.Company).FirstOrDefault(v => v.UserName == User.Identity.Name);

                }
                else
                {
                    return null;
                }
            }
        }
    }
}

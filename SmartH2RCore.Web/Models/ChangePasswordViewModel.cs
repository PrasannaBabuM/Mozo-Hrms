using System.ComponentModel.DataAnnotations;

namespace SmartH2RCore.Web.Models
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "Old Password is require")]
        public string OldPassword { get; set; }
        [Required(ErrorMessage = "Password is require")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Password doesn't match.")]
        public string ConfirmPassword { get; set; }
    }
}

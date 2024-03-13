using System.ComponentModel.DataAnnotations;

namespace SmartH2RCore.Models.DTO
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Email is require!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is require!")]
        public string Password { get; set; } 
    }
}

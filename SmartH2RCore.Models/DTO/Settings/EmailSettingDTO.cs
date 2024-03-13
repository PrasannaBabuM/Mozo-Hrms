using System.ComponentModel.DataAnnotations;

namespace SmartH2RCore.Models.DTO.Settings
{
    public class EmailSettingDTO
    {
        public int? Id { get; set; }
        [Required(ErrorMessage = "Host is require!")]
        public string SmtpHost { get; set; }
        [Required(ErrorMessage = "User is require!")]
        public string SmtpUser { get; set; }
        [Required(ErrorMessage = "Password is require!")]
        public string SmtpPassword { get; set; }
        [Required(ErrorMessage = "Port is require!")]
        public int SmtpPort { get; set; }
        [Required(ErrorMessage = "Security is require!")]
        public string SmtpSecurity { get; set; }
        public string SmtpAuthenticationDomain { get; set; }

    }
}

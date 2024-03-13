using SmartH2RCore.Models.Base;

namespace SmartH2RCore.Models.Common
{
    public class EmailSetting : ArchivableEntity<int>
    {
        public string SmtpHost { get; set; }
        public string SmtpUser { get; set; }
        public string SmtpPassword { get; set; }
        public int SmtpPort { get; set; }
        public string SmtpSecurity { get; set; }
        public string SmtpAuthenticationDomain { get; set; }
    }
}

using SmartH2RCore.Models.Base;
using SmartH2RCore.Models.Identity;

namespace SmartH2RCore.Models.Employee
{
    public class DocumentDetails : ArchivableEntity<int>
    {
        public int EmployeeId { get; set; }
        public User Employee { get; set; }
        public string DocumentCategory { get; set; }
        public string DocumentType { get; set; }
        public string DocumentLink { get; set; }
    }
}

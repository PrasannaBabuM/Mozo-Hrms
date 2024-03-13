using SmartH2RCore.Models.Base;
using SmartH2RCore.Models.Identity;

namespace SmartH2RCore.Models.Employee
{
    public class ContactList : ArchivableEntity<int>
    {
        public int EmployeeId { get; set; }
        public User Employee { get; set; }
        public string PresentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string ModeofTransport { get; set; }
        public string PickUpPoint { get; set; }
    }
}

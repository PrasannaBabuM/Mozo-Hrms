using SmartH2RCore.Models.Base;
using SmartH2RCore.Models.Identity;

namespace SmartH2RCore.Models.Employee
{
    public class EmergencyContactDetails : ArchivableEntity<int>
    {
        public int EmployeeId { get; set; }
        public User Employee { get; set; }
        public string Name { get; set; }
        public int Relation { get; set; }
        public string ContactNumber { get; set; }
        public string LandLineNumber { get; set; }
    }
}

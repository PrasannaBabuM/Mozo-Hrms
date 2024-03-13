using SmartH2RCore.Models.Base;
using SmartH2RCore.Models.Identity;

namespace SmartH2RCore.Models.Employee
{
    public class ProfessionalQualification : ArchivableEntity<int>
    {
        public int EmployeeId { get; set; }
        public User Employee { get; set; }
        public string Education { get; set; }
        public string Specialization { get; set; }
        public string InstituteOrUniversityName { get; set; }
        public string Grade { get; set; }
        public int? YearFrom { get; set; }
        public int? YearTo { get; set; }
    }
}

using SmartH2RCore.Models.Base;
using SmartH2RCore.Models.Identity;

namespace SmartH2RCore.Models.Employee
{
    public class EducationalQualification : ArchivableEntity<int>
    {
        public int EmployeeId { get; set; }
        public User Employee { get; set; }
        public int EducationId { get; set; }
        public string Specialization { get; set; }
        public string SchoolOrInstituteOrUniversityName { get; set; }
        public string Grade { get; set; }
        public int? YearFrom { get; set; }
        public int? YearTo { get; set; }
    }
}

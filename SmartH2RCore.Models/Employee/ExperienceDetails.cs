using SmartH2RCore.Models.Base;
using SmartH2RCore.Models.Identity;

namespace SmartH2RCore.Models.Employee
{
    public class ExperienceDetails : ArchivableEntity<int>
    {
        public int EmployeeId { get; set; }
        public User Employee { get; set; }
        public string CompanyName { get; set; }
        public string AddressOrLocation { get; set; }
        public string Designation { get; set; }
        public decimal? TotalExperience { get; set; }
        public int? YearFrom { get; set; }
        public int? YearTo { get; set; }
    }
}

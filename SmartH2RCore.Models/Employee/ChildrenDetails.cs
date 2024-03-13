using SmartH2RCore.Models.Base;
using SmartH2RCore.Models.Identity;

using System;

namespace SmartH2RCore.Models.Employee
{
    public class ChildrenDetails : ArchivableEntity<int>
    {
        public int EmployeeId { get; set; }
        public User Employee { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime? DOB { get; set; }
    }
}

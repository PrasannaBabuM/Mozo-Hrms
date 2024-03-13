using SmartH2RCore.Models.Base;
using SmartH2RCore.Models.Identity;

using System;

namespace SmartH2RCore.Models.Employee
{
    public class TrainingDetails : ArchivableEntity<int>
    {
        public int EmployeeId { get; set; }
        public User Employee { get; set; }
        public string TrainingName { get; set; }
        public string ConductedBy { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string Remarks { get; set; }

    }
}

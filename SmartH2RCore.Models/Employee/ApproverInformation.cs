using SmartH2RCore.Models.Base;
using SmartH2RCore.Models.Identity;

namespace SmartH2RCore.Models.Employee
{
    public class ApproverInformation : ArchivableEntity<int>
    {
        public int EmployeeId { get; set; }
        public User Employee { get; set; }
        public int? LineManagerId { get; set; }
        public int? DottedLineManagerId { get; set; }
        public int? BusinessHeadId { get; set; }
        public int? FinanceManagerId { get; set; }
        public int? NetworkAdministrationClearanceId { get; set; }
        public int? VirtualHeadId { get; set; }
        public int? AdminId { get; set; }
        public int? HRTAId { get; set; }
        public int? HRCBId { get; set; }
        public int? HRBPId { get; set; }
        public int? ManagementMdId { get; set; }

    }
}

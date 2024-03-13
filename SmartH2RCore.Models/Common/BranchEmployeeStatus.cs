namespace SmartH2RCore.Models.Common
{
    public class BranchEmployeeStatus
    {
        public virtual Branch Branch { get; set; }
        public int BranchId { get; set; }
        public int EmployeeStatusId { get; set; }
        public virtual EmployeeStatus EmployeeStatus { get; set; }
    }
}

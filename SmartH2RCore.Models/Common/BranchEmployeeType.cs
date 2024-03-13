namespace SmartH2RCore.Models.Common
{
    public class BranchEmployeeType
    {
        public virtual Branch Branch { get; set; }
        public int BranchId { get; set; }
        public int EmployeeTypeId { get; set; }
        public virtual EmployeeType EmployeeType { get; set; }
    }
}

namespace SmartH2RCore.Models.Common
{
    public class BranchEmployeeSubType
    {
        public virtual Branch Branch { get; set; }
        public int BranchId { get; set; }
        public int EmployeeSubTypeId { get; set; }
        public virtual EmployeeSubType EmployeeSubType { get; set; }
    }
}

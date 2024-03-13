namespace SmartH2RCore.Models.Common
{
    public class BranchDepartmentType
    {
        public virtual Branch Branch { get; set; }
        public int BranchId { get; set; }
        public int DepartmentTypeId { get; set; }
        public virtual DepartmentType DepartmentType { get; set; }
    }
}

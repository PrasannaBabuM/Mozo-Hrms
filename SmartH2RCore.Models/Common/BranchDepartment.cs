namespace SmartH2RCore.Models.Common
{
    public class BranchDepartment
    {
        public virtual Branch Branch { get; set; }
        public int BranchId { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}

namespace SmartH2RCore.Models.Common
{
    public class BranchRole
    {
        public virtual Branch Branch { get; set; }
        public int BranchId { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
    }
}

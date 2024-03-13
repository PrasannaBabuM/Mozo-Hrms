namespace SmartH2RCore.Models.Common
{
    public class BranchDesignation
    {
        public virtual Branch Branch { get; set; }
        public int BranchId { get; set; }
        public int DesignationId { get; set; }
        public virtual Designation Designation { get; set; }
    }
}

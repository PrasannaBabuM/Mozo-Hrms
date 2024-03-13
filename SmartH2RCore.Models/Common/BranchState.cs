namespace SmartH2RCore.Models.Common
{
    public class BranchState
    {
        public virtual Branch Branch { get; set; }
        public int BranchId { get; set; }
        public int StateId { get; set; }
        public virtual State State { get; set; }
    }
}

namespace SmartH2RCore.Models.Common
{
    public class BranchBank
    {
        public virtual Branch Branch { get; set; }
        public int BranchId { get; set; }
        public int BankId { get; set; }
        public virtual Bank Bank { get; set; }
    }
}

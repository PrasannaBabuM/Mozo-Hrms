namespace SmartH2RCore.Models.Common
{
    public class BranchAccountType
    {
        public virtual Branch Branch { get; set; }
        public int BranchId { get; set; }
        public int AccountTypeId { get; set; }
        public virtual AccountType AccountType { get; set; }
    }
}

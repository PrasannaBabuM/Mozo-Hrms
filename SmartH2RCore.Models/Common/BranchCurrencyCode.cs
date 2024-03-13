namespace SmartH2RCore.Models.Common
{
    public class BranchCurrencyCode
    {
        public virtual Branch Branch { get; set; }
        public int BranchId { get; set; }
        public int CurrencyId { get; set; }
        public virtual Currency Currency { get; set; }
    }
}

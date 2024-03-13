namespace SmartH2RCore.Models.Common
{
    public class BranchCountry
    {
        public virtual Branch Branch { get; set; }
        public int BranchId { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}

namespace SmartH2RCore.Models.Common
{
    public class BranchCity
    {
        public virtual Branch Branch { get; set; }
        public int BranchId { get; set; }
        public int CityId { get; set; }
        public virtual City City { get; set; }
    }
}

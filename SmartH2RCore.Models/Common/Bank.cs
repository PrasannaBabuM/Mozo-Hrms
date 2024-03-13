using SmartH2RCore.Models.Base;

namespace SmartH2RCore.Models.Common
{
    public class Bank : ArchivableEntity<int>
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public bool TDS { get; set; }
        public string Branchaddress { get; set; } = "bengaluru";

    }
}

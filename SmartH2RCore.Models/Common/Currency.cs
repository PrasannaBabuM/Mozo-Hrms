using SmartH2RCore.Models.Base;

namespace SmartH2RCore.Models.Common
{
    public class Currency : ArchivableEntity<int>
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Symbol { get; set; }
    }
}

using SmartH2RCore.Models.Base;

namespace SmartH2RCore.Models.Common
{
    public class City : ArchivableEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int StateId { get; set; }
        public virtual State State { get; set; }
    }
}

using SmartH2RCore.Models.Base;

namespace SmartH2RCore.Models.Common
{
    public class Grade : ArchivableEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

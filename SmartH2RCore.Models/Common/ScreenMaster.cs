using SmartH2RCore.Models.Base;

namespace SmartH2RCore.Models.Common
{
    public class ScreenMaster : ArchivableEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ModuleMasterId { get; set; }
        public ModuleMaster ModuleMaster { get; set; }
    }
}

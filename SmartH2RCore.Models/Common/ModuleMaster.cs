using SmartH2RCore.Models.Base;

using System.Collections.Generic;

namespace SmartH2RCore.Models.Common
{
    public class ModuleMaster : ArchivableEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<ScreenMaster> ScreenMaster { get; set; }
    }
}

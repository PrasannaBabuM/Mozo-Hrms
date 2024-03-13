using SmartH2RCore.Models.Base;

namespace SmartH2RCore.Models.Common
{
    public class RolePermission : ArchivableEntity<int>
    {
        public bool CanRead { get; set; }
        public bool CanAdd { get; set; }
        public bool CanUpdate { get; set; }
        public bool CanDelete { get; set; }
        public bool CanImport { get; set; }
        public bool CanExport { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public int ScreenMasterId { get; set; }
        public ScreenMaster ScreenMaster { get; set; }
    }
}

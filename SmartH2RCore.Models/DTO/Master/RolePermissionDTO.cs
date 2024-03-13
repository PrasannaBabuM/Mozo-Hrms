namespace SmartH2RCore.Models.DTO.Master
{
    public class RolePermissionDTO
    {
        public bool CanRead { get; set; }
        public bool CanAdd { get; set; }
        public bool CanUpdate { get; set; }
        public bool CanDelete { get; set; }
        public bool CanImport { get; set; }
        public bool CanExport { get; set; }
        public int RoleId { get; set; }
        public RoleDTO Role { get; set; }
        public int ScreenId { get; set; }
        public ScreenMasterDTO ScreenMaster { get; set; }
    }
}

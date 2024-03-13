using Fingers10.ExcelExport.Attributes;

using JqueryDataTables.ServerSide.AspNetCoreWeb.Attributes;

namespace SmartH2RCore.Models.DTO.Master
{
    public class RoleDTO
    {
        [JqueryDataTableColumn(Order = 2)]
        public int Id { get; set; }

        [IncludeInReport(Order = 1)]
        [JqueryDataTableColumn(Order = 1)]
        [SearchableString(EntityProperty = "Name")]
        [Sortable(EntityProperty = "Name")]
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}

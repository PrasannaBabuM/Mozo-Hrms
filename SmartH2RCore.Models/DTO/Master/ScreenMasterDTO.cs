using Fingers10.ExcelExport.Attributes;

using JqueryDataTables.ServerSide.AspNetCoreWeb.Attributes;

using System.ComponentModel.DataAnnotations;

namespace SmartH2RCore.Models.DTO.Master
{
    public class ScreenMasterDTO
    {
        [JqueryDataTableColumn(Order = 4)]
        public int? Id { get; set; }

        [Required(ErrorMessage = "Name is require!")]
        [Display(Name = "Name")]
        [IncludeInReport(Order = 1)]
        [JqueryDataTableColumn(Order = 1)]
        [SearchableString(EntityProperty = "Name")]
        [Sortable(EntityProperty = "Name")]
        public string Name { get; set; }
        public string Description { get; set; }

        [Display(Name = "Module Name")]
        [IncludeInReport(Order = 2)]
        [JqueryDataTableColumn(Order = 2)]
        [SearchableString(EntityProperty = "ModuleMaster.Name")]
        [Sortable(EntityProperty = "ModuleMaster.Name")]
        public string ModuleName { get; set; }

        [Required(ErrorMessage = "Module name is require!")]
        public int ModuleId { get; set; }
        public ModuleMasterDTO ModuleMaster { get; set; }
    }
}

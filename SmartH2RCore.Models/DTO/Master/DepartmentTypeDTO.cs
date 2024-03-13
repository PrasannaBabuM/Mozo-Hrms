using Fingers10.ExcelExport.Attributes;

using JqueryDataTables.ServerSide.AspNetCoreWeb.Attributes;

using System.ComponentModel.DataAnnotations;

namespace SmartH2RCore.Models.DTO.Master
{
    public class DepartmentTypeDTO
    {
        [JqueryDataTableColumn(Order = 4)]
        public int? Id { get; set; }

        [Required(ErrorMessage = "Name is require!")]
        [StringLength(50, ErrorMessage = "Name has to be between 2 and 50 characters long", MinimumLength = 2)]
        [Display(Name = "Name")]
        [IncludeInReport(Order = 1)]
        [JqueryDataTableColumn(Order = 1)]
        [SearchableString(EntityProperty = "Name")]
        [Sortable(EntityProperty = "Name")]
        public string Name { get; set; }

        [Display(Name = "Code")]
        [IncludeInReport(Order = 2)]
        [JqueryDataTableColumn(Order = 2)]
        [SearchableString(EntityProperty = "Code")]
        [Sortable(EntityProperty = "Code")]
        [Required(ErrorMessage = "Code is require!")]
        public string Code { get; set; }

        [Display(Name = "Description")]
        [IncludeInReport(Order = 3)]
        [JqueryDataTableColumn(Order = 3)]
        [SearchableString(EntityProperty = "Description")]
        [Sortable(EntityProperty = "Description")]
        [Required(ErrorMessage = "Description is require!")]
        public string Description { get; set; }

        public bool IsActive { get; set; }
    }
}

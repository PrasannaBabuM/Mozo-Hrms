using Fingers10.ExcelExport.Attributes;

using JqueryDataTables.ServerSide.AspNetCoreWeb.Attributes;

using System.ComponentModel.DataAnnotations;

namespace SmartH2RCore.Models.DTO.Master
{
    public class GradeDTO
    {
        [JqueryDataTableColumn(Order = 3)]
        public int? Id { get; set; }

        [Required(ErrorMessage = "Name is require!")]
        [StringLength(50, ErrorMessage = "Name has to be between 2 and 50 characters long", MinimumLength = 2)]
        [Display(Name = "Name")]
        [IncludeInReport(Order = 1)]
        [JqueryDataTableColumn(Order = 1)]
        [SearchableString(EntityProperty = "Name")]
        [Sortable(EntityProperty = "Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [IncludeInReport(Order = 2)]
        [JqueryDataTableColumn(Order = 2)]
        [SearchableString(EntityProperty = "Description")]
        [Sortable(EntityProperty = "Description")]
        [Required(ErrorMessage = "Description is require!")]
        public string Description { get; set; }

        public bool IsActive { get; set; }
    }
}

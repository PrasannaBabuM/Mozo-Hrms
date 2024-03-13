using Fingers10.ExcelExport.Attributes;

using JqueryDataTables.ServerSide.AspNetCoreWeb.Attributes;

using System.ComponentModel.DataAnnotations;

namespace SmartH2RCore.Models.DTO.Master
{
    public class CityDTO
    {
        [JqueryDataTableColumn(Order = 4)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is require!")]
        [StringLength(50, ErrorMessage = "Name has to be between 3 and 50 characters long", MinimumLength = 3)]
        [Display(Name = "Name")]
        [IncludeInReport(Order = 1)]
        [JqueryDataTableColumn(Order = 1)]
        [SearchableString(EntityProperty = "Name")]
        [Sortable(EntityProperty = "Name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "State is require!")]
        public int StateId { get; set; }
        public virtual StateDTO State { get; set; }

        [Display(Name = "Description")]
        [IncludeInReport(Order = 3)]
        [JqueryDataTableColumn(Order = 3)]
        [SearchableString(EntityProperty = "Description")]
        [Sortable(EntityProperty = "Description")]
        public string Description { get; set; }

        [Display(Name = "State Name")]
        [IncludeInReport(Order = 2)]
        [JqueryDataTableColumn(Order = 2)]
        [SearchableString(EntityProperty = "State.Name")]
        [Sortable(EntityProperty = "State.Name")]
        public string StateName { get; set; }
        public bool IsActive { get; set; }
    }
}

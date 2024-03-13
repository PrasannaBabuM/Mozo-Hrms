using Fingers10.ExcelExport.Attributes;

using JqueryDataTables.ServerSide.AspNetCoreWeb.Attributes;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SmartH2RCore.Models.DTO.Master
{
    public class StateDTO
    {
        [JqueryDataTableColumn(Order = 3)]
        public int? Id { get; set; }

        [Required(ErrorMessage = "Name is require!")]
        [StringLength(50, ErrorMessage = "Name has to be between 3 and 50 characters long", MinimumLength = 3)]
        [Display(Name = "Name")]
        [IncludeInReport(Order = 1)]
        [JqueryDataTableColumn(Order = 1)]
        [SearchableString(EntityProperty = "Name")]
        [Sortable(EntityProperty = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Country is require!")]
        public int CountryId { get; set; }
        public CountryDTO Country { get; set; }

        [Display(Name = "Country Name")]
        [IncludeInReport(Order = 2)]
        [JqueryDataTableColumn(Order = 2)]
        [SearchableString(EntityProperty = "Country.Name")]
        [Sortable(EntityProperty = "Country.Name")]
        public string CountryName { get; set; }

        public bool IsActive { get; set; }

        public List<CityDTO> Cities { get; set; }
    }
}

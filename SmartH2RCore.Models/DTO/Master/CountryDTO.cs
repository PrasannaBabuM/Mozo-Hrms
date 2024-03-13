using Fingers10.ExcelExport.Attributes;

using JqueryDataTables.ServerSide.AspNetCoreWeb.Attributes;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SmartH2RCore.Models.DTO.Master
{
    public class CountryDTO
    {

        [JqueryDataTableColumn(Order = 5)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is require!")]
        [Display(Name = "Name")]
        [IncludeInReport(Order = 1)]
        [JqueryDataTableColumn(Order = 1)]
        [SearchableString(EntityProperty = "Name")]
        [Sortable(EntityProperty = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Capital is require!")]
        [Display(Name = "Capital")]
        [IncludeInReport(Order = 2)]
        [JqueryDataTableColumn(Order = 2)]
        [SearchableString(EntityProperty = "Capital")]
        [Sortable(EntityProperty = "Capital")]
        public string Capital { get; set; }

        [Required(ErrorMessage = "ISO31663C Codes is require!")]
        [Display(Name = "ISO31663C")]
        [IncludeInReport(Order = 3)]
        [JqueryDataTableColumn(Order = 3)]
        [SearchableString(EntityProperty = "ISO31663CCodes")]
        [Sortable(EntityProperty = "ISO31663CCodes")]
        public string ISO31663CCodes { get; set; }

        [Display(Name = "Currency Code")]
        [IncludeInReport(Order = 4)]
        [JqueryDataTableColumn(Order = 4)]
        [SearchableString(EntityProperty = "Currency.Code")]
        [Sortable(EntityProperty = "Currency.Code")]
        public string CurrencyCode { get; set; }

        public string Description { get; set; }

        public int? CurrencyId { get; set; }

        public bool IsActive { get; set; }

        public List<StateDTO> States { get; set; }
    }
}

using Fingers10.ExcelExport.Attributes;

using JqueryDataTables.ServerSide.AspNetCoreWeb.Attributes;

using System.ComponentModel.DataAnnotations;

namespace SmartH2RCore.Models.DTO.Master
{
    public class BankDTO
    {
        [JqueryDataTableColumn(Order = 5)]
        public int? Id { get; set; }

        [Required(ErrorMessage = "Name is require!")]
        [Display(Name = "Name")]
        [IncludeInReport(Order = 1)]
        [JqueryDataTableColumn(Order = 1)]
        [SearchableString(EntityProperty = "Name")]
        [Sortable(EntityProperty = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Code is require!")]
        [Display(Name = "Code")]
        [IncludeInReport(Order = 2)]
        [JqueryDataTableColumn(Order = 2)]
        [SearchableString(EntityProperty = "Code")]
        [Sortable(EntityProperty = "Code")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Address is require!")]
        [Display(Name = "Address")]
        [IncludeInReport(Order = 3)]
        [JqueryDataTableColumn(Order = 3)]
        [SearchableString(EntityProperty = "Address")]
        [Sortable(EntityProperty = "Address")]
        public string Address { get; set; }

        [Display(Name = "TDS")]
        [IncludeInReport(Order = 4)]
        [JqueryDataTableColumn(Order = 4)]
        [SearchableString(EntityProperty = "TDS")]
        [Sortable(EntityProperty = "TDS")]
        public bool TDS { get; set; }
        public bool IsActive { get; set; }
    }
}

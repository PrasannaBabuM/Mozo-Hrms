using Fingers10.ExcelExport.Attributes;

using JqueryDataTables.ServerSide.AspNetCoreWeb.Attributes;

using SmartH2RCore.Models.Common;

using System.ComponentModel.DataAnnotations;

namespace SmartH2RCore.Models.DTO.Master
{
    public class EmployeeSubTypeDTO
    {
        [JqueryDataTableColumn(Order = 3)]
        public int? Id { get; set; }

        [Required(ErrorMessage = "Name is require!")]
        [Display(Name = "Name")]
        [IncludeInReport(Order = 1)]
        [JqueryDataTableColumn(Order = 1)]
        [SearchableString(EntityProperty = "Name")]
        [Sortable(EntityProperty = "Name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "State is require!")]
        public int EmployeeTypeId { get; set; }
        public virtual EmployeeType EmployeeType { get; set; }


        [Display(Name = "Employee Type")]
        [IncludeInReport(Order = 2)]
        [JqueryDataTableColumn(Order = 2)]
        [SearchableString(EntityProperty = "EmployeeType.Name")]
        [Sortable(EntityProperty = "EmployeeType.Name")]
        public string EmployeeTypeName { get; set; }
        public bool IsActive { get; set; }
    }
}

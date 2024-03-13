using Fingers10.ExcelExport.Attributes;

using JqueryDataTables.ServerSide.AspNetCoreWeb.Attributes;

using System;
using System.ComponentModel.DataAnnotations;

namespace SmartH2RCore.Models.DTO.Master
{
    public class BranchDTO
    {
        [JqueryDataTableColumn(Order = 6)]
        public int Id { get; set; }

        [Display(Name = "Company Name")]
        [IncludeInReport(Order = 1)]
        [JqueryDataTableColumn(Order = 1)]
        [SearchableString(EntityProperty = "Company.CompanyName")]
        [Sortable(EntityProperty = "Company.CompanyName")]
        public string CompanyName { get; set; }


        [Required(ErrorMessage = "Company name is require!")]
        public int CompanyId { get; set; }

        [Required(ErrorMessage = "Region is require!")]
        [Display(Name = "Region Name")]
        [IncludeInReport(Order = 2)]
        [JqueryDataTableColumn(Order = 2)]
        [SearchableString(EntityProperty = "RegionName")]
        [Sortable(EntityProperty = "RegionName")]
        public string RegionName { get; set; }

        [Display(Name = "Location Name")]
        [IncludeInReport(Order = 3)]
        [JqueryDataTableColumn(Order = 3)]
        [SearchableString(EntityProperty = "LocationName")]
        [Sortable(EntityProperty = "LocationName")]
        public string LocationName { get; set; }
        public string LocationCode { get; set; }
        public DateTime? EstablishmentDate { get; set; }
        public string ESICodeNo { get; set; }
        public string ESIWorkLocationOffice { get; set; }
        public string ESIContactNo { get; set; }
        public string PTCircle { get; set; }

        [IncludeInReport(Order = 4)]
        [JqueryDataTableColumn(Order = 4)]
        [SearchableString(EntityProperty = "Address")]
        [Sortable(EntityProperty = "Address")]
        public string Address { get; set; }
        public int? Country { get; set; }
        public int? State { get; set; }
        public int? City { get; set; }

        [Display(Name = "Zip Code")]
        [IncludeInReport(Order = 5)]
        [JqueryDataTableColumn(Order = 5)]
        [SearchableString(EntityProperty = "ZipCode")]
        [Sortable(EntityProperty = "ZipCode")]
        public int? ZipCode { get; set; }
        public string EPFCodeNo { get; set; }
        public string EPFWorkLocationOffice { get; set; }
        public string EPFContactNo { get; set; }
        public string TDSCircle { get; set; }
    }
}

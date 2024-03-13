using Fingers10.ExcelExport.Attributes;

using JqueryDataTables.ServerSide.AspNetCoreWeb.Attributes;

using System;
using System.ComponentModel.DataAnnotations;

namespace SmartH2RCore.Models.DTO.Master
{
    public class CompanyDTO
    {
        [JqueryDataTableColumn(Order = 8)]
        public int Id { get; set; }


        [Required(ErrorMessage = "Name is require!")]
        [Display(Name = "Company Name")]
        [IncludeInReport(Order = 1)]
        [JqueryDataTableColumn(Order = 1)]
        [SearchableString(EntityProperty = "CompanyName")]
        [Sortable(EntityProperty = "CompanyName")]
        public string CompanyName { get; set; }

        public string CompanyType { get; set; }

        [Required(ErrorMessage = "Establish Date is require!")]
        [Display(Name = "Establish Date")]
        [IncludeInReport(Order = 2)]
        [JqueryDataTableColumn(Order = 2)]
        [SearchableString(EntityProperty = "EstablishDate")]
        [Sortable(EntityProperty = "EstablishDate")]
        public DateTime? EstablishDate { get; set; }


        [Display(Name = "Pan No")]
        [IncludeInReport(Order = 4)]
        [JqueryDataTableColumn(Order = 4)]
        [SearchableString(EntityProperty = "PanNo")]
        [Sortable(EntityProperty = "PanNo")]
        public string PanNo { get; set; }


        [Display(Name = "Tin No")]
        [IncludeInReport(Order = 6)]
        [JqueryDataTableColumn(Order = 6)]
        [SearchableString(EntityProperty = "TinNo")]
        [Sortable(EntityProperty = "TinNo")]
        public string TinNo { get; set; }

        [Display(Name = "Registration No")]
        [IncludeInReport(Order = 5)]
        [JqueryDataTableColumn(Order = 5)]
        [SearchableString(EntityProperty = "RegistrationNo")]
        [Sortable(EntityProperty = "RegistrationNo")]
        public string RegistrationNo { get; set; }

        [Display(Name = "Tan No")]
        [IncludeInReport(Order = 4)]
        [JqueryDataTableColumn(Order = 4)]
        [SearchableString(EntityProperty = "TanNo")]
        [Sortable(EntityProperty = "TanNo")]
        public string TanNo { get; set; }
        public string TdsCircle { get; set; }
        public string PfTrust { get; set; }

        [Required(ErrorMessage = "Company URL is require!")]
        [Display(Name = "Company URL")]
        [IncludeInReport(Order = 3)]
        [JqueryDataTableColumn(Order = 3)]
        [SearchableString(EntityProperty = "Url")]
        [Sortable(EntityProperty = "Url")]
        public string Url { get; set; }
        public string Logo { get; set; }


        [Required(ErrorMessage = "Address1 is require!")]


        public string CorporateAddress1 { get; set; }

        [Required(ErrorMessage = "Address2 is require!")]
        public string CorporateAddress2 { get; set; }



        public string CorporateCity { get; set; }

        [Required(ErrorMessage = "City is require!")]
        public int CorporateCityId { get; set; }


        public string CorporateState { get; set; }

        [Required(ErrorMessage = "State is require!")]
        public int CorporateStateId { get; set; }


        public string CorporateCountry { get; set; }

        [Required(ErrorMessage = "Country is require!")]
        public int CorporateCountryId { get; set; }

        [Required(ErrorMessage = "Zip Code is require!")]
        public string CorporateZip { get; set; }
        public string CorporatePhone { get; set; }

        [Required(ErrorMessage = "Address1 is require!")]
        public string CorrespondanceAddress1 { get; set; }

        [Required(ErrorMessage = "Address2 is require!")]
        public string CorrespondanceAddress2 { get; set; }
        public string CorrespondanceCity { get; set; }

        [Required(ErrorMessage = "City is require!")]
        public int CorrespondanceCityId { get; set; }
        public string CorrespondanceState { get; set; }

        [Required(ErrorMessage = "State is require!")]
        public int CorrespondanceStateId { get; set; }
        public string CorrespondanceCountry { get; set; }

        [Required(ErrorMessage = "Country is require!")]
        public int CorrespondanceCountryId { get; set; }

        [Required(ErrorMessage = "Zip Code is require!")]
        public string CorrespondanceZip { get; set; }
        public string CorrespondancePhone { get; set; }
        public string ResponsiblePerson { get; set; }
        public int OwnerId { get; set; }
        public bool IsActive { get; set; }
        public string NatureOfBusiness { get; set; }
        public string EPFEmployerCode { get; set; }
        public string SubEPFEmployerCode { get; set; }
        public string ESIEmployerCode { get; set; }
        public string SubESIEmployerCode { get; set; }

        //public CountryDTO Country { get; set; }
        //public  StateDTO State { get; set; }
        //public  CityDTO City { get; set; }


    }
}

using JqueryDataTables.ServerSide.AspNetCoreWeb.Attributes;
using SmartH2RCore.Models.Common;
using SmartH2RCore.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartH2RCore.Models.DTO.Employee
{
   public class PersonalDetailsDTO
    {
        [JqueryDataTableColumn (Order = 16)]

        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int CompanyId { get; set; }
        public string LocationName { get; set; }
        public string FirstName { get; set; }
        public string Suffix { get; set; }
        public User Employee { get; set; }
        public int BranchId { get; set; }
        public string MiddelName { get; set; }
        public string Alias { get; set; }
        public DateTime? DateofJoining { get; set; }
        public string Salutation { get; set; }
        public string LastName { get; set; }
        //public string EmployeeCode { get; set; }
        public string SystemsPayableNumber { get; set; }



        /// Personal Information
        public string PassportNo { get; set; }
        public DateTime? PassportExpiryDate { get; set; }
        public string Religion { get; set; }
        public int MaritalStatus { get; set; }
        public string SpouseName { get; set; }



        ////Emergency Contact
       
        public string Name { get; set; }
        public string Relationship { get; set; }
        public int Phone { get;set; }


        /// Bank information
        public string BankBranchName { get; set; }
        public string IfscCode { get; set; }

        /// Family Information







        ///Education Informations
        public string Specialization { get; set; }
        public string SchoolOrInstituteOrUniversityName { get; set; }
        public string Grade { get; set; }
        public int? YearFrom { get; set; }
        public int? YearTo { get; set; }

        ////Experience
        

    }
}

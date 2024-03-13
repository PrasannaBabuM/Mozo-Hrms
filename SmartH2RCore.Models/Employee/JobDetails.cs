using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using SmartH2RCore.Models.Base;
using SmartH2RCore.Models.Common;
using SmartH2RCore.Models.Identity;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SmartH2RCore.Models.Employee
{
    public class JobDetails : ArchivableEntity<int>
    {
                                                          /// Work Inforamtion Primary 
        public int EmployeeId { get; set; }
        public User Employee { get; set; }
        public Branch Branch { get; set; } 
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int DepartmentTypeId { get; set; }
        public int DepartmentId { get; set; }
        public int DesignationId { get; set; }
        public int EmployeeStatusId { get; set; }
        //public int EmploytypeId { get; set; }
        public int EmployeeTypeId { get; set; }
        public int EmployeeSubTypeId { get; set; }
    


                                                       /// Work Information Secoundary
        public string OfficialEmailId { get; set; }
        public string OfficialMobileNo { get; set; }
        public string ExtNo { get; set; }
        public Int64 UanNumber { get; set; }
        public string PanNumber { get; set; }

        /// Skill Set
        public string Proficiency { get; set; }
        public string Percentage { get; set; }



        /// upper part 
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string MiddelName { get; set; }
        public string Suffix { get; set; }
        public string Alias { get; set; }
        public string EmployeeCode { get; set; }
        public string SystemsPayableNumber { get; set; }
        public DateTime? DateofJoining { get; set; }
        public string Salutation {  get; set; }



        public int? NoticePeriod { get; set; }
        public decimal CTCPerAnnum { get; set; }
        public string PFNo { get; set; }
        public string EsiDispensary { get; set; }
        public string PfrEgionOffice { get; set; }
        public long? EsiNumber { get; set; }

        

  

        //public int RoleId { get; set; }

        //public string UserName { get; set; }
        //public string PasswordHash { get; set; }


        public JobDetails()
        {

        }
       
    }
}

using DocumentFormat.OpenXml.Drawing.Charts;
using Fingers10.ExcelExport.Attributes;
using JqueryDataTables.ServerSide.AspNetCoreWeb.Attributes;
using Microsoft.AspNetCore.Http;
using SmartH2RCore.Models.Common;
using SmartH2RCore.Models.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
 

namespace SmartH2RCore.Models.DTO.EmployeeDTO
{
    public class JobDetailsDTO
    {
        [JqueryDataTableColumn(Order =25)]
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
        public string EmployeeCode { get; set; }
        public string SystemsPayableNumber { get; set; }



       // This  columns Work Information (primary)
        public int DepartmentId { get; set; }
        public int DesignationId { get; set; }
        public int EmployeeTypeId { get; set; }
        public int EmployeeStatusId { get; set; }
        //public int RoleId { get; set; }  //naku doubt uvndhi
        //public string Grade {  get; set; } this column table is not there,but view part column is there how add this column DTO & Tabl ?



        // This Column Work Information (Secoundary)
        
        public string OfficialEmailId { get; set; }
        public string OfficialMobileNo { get; set; }
        public string ExtNo { get; set; }
        public string PanNumber { get; set; }
        public Int64 UanNumber { get; set; }

        // This Columns Skil Set 
        public string Proficiency { get; set; }
        public string Percentage { get; set; }

        //public string UserCode { get; set; }
        
        
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        //public string NormalizedUserName { get; set; }
        // public HttpPostedFileBase ImageFile { get; set; }

    }
}

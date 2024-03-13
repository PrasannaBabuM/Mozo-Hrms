using SmartH2RCore.Models.Base;
using SmartH2RCore.Models.Identity;

using System;

namespace SmartH2RCore.Models.Employee
{
    public class PersonalDetails : ArchivableEntity<int>
    {
        public int EmployeeId { get; set; }
        public User Employee { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string PaymentMode { get; set; }
        public string BankNameforSalary { get; set; }
        public string BankBranchName { get; set; }
        public string MobileNo { get; set; }
        public string LandLineNo { get; set; }
        public string PassportNo { get; set; }
        public DateTime? PassportExpiryDate { get; set; }
        public string Religion { get; set; }
        public int? BloodGroup { get; set; }
        public string AccountNoforSalary { get; set; }
        public string IfscCode { get; set; }
        public string PersonalEmailId { get; set; }
        public string DrivingLicenceNo { get; set; }
        public DateTime? PassportIssuedDate { get; set; }
        public string FatherOrHusbandName { get; set; }
        public string MotherName { get; set; }
        public int MaritalStatus { get; set; }
        public string SpouseName { get; set; }
        public DateTime? DateofAnniversary { get; set; }
        public string Gender { get; set; }

        public string Relationship { get; set; }
    }
}

using SmartH2RCore.Models.Base;

using System;
using System.Collections.Generic;

namespace SmartH2RCore.Models.Common
{
    public class Branch : ArchivableEntity<int>
    {
        public virtual Company Company { get; set; }
        public int CompanyId { get; set; }
        public string RegionName { get; set; }
        public string LocationName { get; set; }
        public string LocationCode { get; set; }
        public DateTime? EstablishmentDate { get; set; }
        public string ESICodeNo { get; set; }
        public string ESIWorkLocationOffice { get; set; }
        public string ESIContactNo { get; set; }
        public string PTCircle { get; set; }
        public string Address { get; set; }
        public int Country { get; set; }
        public int State { get; set; }
        public int City { get; set; }
        public int ZipCode { get; set; }
        public string EPFCodeNo { get; set; }
        public string EPFWorkLocationOffice { get; set; }
        public string EPFContactNo { get; set; }
        public string TDSCircle { get; set; }

        public virtual ICollection<BranchCity> BranchCitye { get; set; }
        public virtual ICollection<BranchCountry> BranchCountry { get; set; }
        public virtual ICollection<BranchState> CompanyState { get; set; }
        public virtual ICollection<BranchCurrencyCode> BranchCurrencyCode { get; set; }
        public virtual ICollection<BranchDepartment> BranchDepartment { get; set; }
        public virtual ICollection<BranchDepartmentType> BranchDepartmentType { get; set; }
        public virtual ICollection<BranchDesignation> BranchDesignation { get; set; }
        public virtual ICollection<BranchEmployeeStatus> BranchEmployeeStatus { get; set; }
        public virtual ICollection<BranchEmployeeType> BranchEmployeeType { get; set; }
        public virtual ICollection<BranchEmployeeSubType> BranchEmployeeSubType { get; set; }
        public virtual ICollection<BranchGrade> BranchGrade { get; set; }
        public virtual ICollection<BranchRole> BranchRole { get; set; }

        public Branch()
        {
            
        }
    }
}

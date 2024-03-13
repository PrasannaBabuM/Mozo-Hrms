using SmartH2RCore.Models.Base;

namespace SmartH2RCore.Models.Common
{
    public class EmployeeSubType : ArchivableEntity<int>
    {
        public string Name { get; set; }
        public bool Status { get; set; }
        public int Code { get; set; }
        public int EmployeeTypeId { get; set; }

        public virtual EmployeeType EmployeeType { get; set; }
        public EmployeeSubType()
        {
            
        }
    }
}

using SmartH2RCore.Models.Base;

using System.Collections.Generic;

namespace SmartH2RCore.Models.Common
{
    public class EmployeeType : ArchivableEntity<int>
    {
        public string Name { get; set; }
        public string Code { get; set; }

        public virtual ICollection<EmployeeSubType> EmployeeSubType { get; set; }
        public EmployeeType()
        {
            
        }

    }
}

using SmartH2RCore.Models.Base;

namespace SmartH2RCore.Models.Common
{
    public class Department : ArchivableEntity<int>
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int DepartmentTypeId { get; set; }
        public virtual DepartmentType DepartmentType { get; set; }

        public Department()
        {
            
        }
    }
}

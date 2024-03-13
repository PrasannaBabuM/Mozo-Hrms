using SmartH2RCore.Models.Base;

namespace SmartH2RCore.Models.Common
{
    public class DepartmentType : ArchivableEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public DepartmentType()
        {
            
        }
    }
}

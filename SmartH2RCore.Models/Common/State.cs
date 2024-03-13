using SmartH2RCore.Models.Base;

using System.Collections.Generic;

namespace SmartH2RCore.Models.Common
{
    public class State : ArchivableEntity<int>
    {
        public string Name { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<City> Cities { get; set; }

    }
}

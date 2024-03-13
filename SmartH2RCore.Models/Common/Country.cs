using SmartH2RCore.Models.Base;

using System.Collections.Generic;

namespace SmartH2RCore.Models.Common
{
    public class Country : ArchivableEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Capital { get; set; }
        public int? CurrencyId { get; set; }
        public virtual Currency Currency { get; set; }
        public string ISO31663CCodes { get; set; }
        public virtual ICollection<State> States { get; set; }
    }
}

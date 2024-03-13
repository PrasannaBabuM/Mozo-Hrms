using System;

namespace SmartH2RCore.Models.Base
{
    public abstract class ArchivableEntity<T> : Entity<T>, IArchivableEntity
    {

        public bool IsArchived { get; set; }


        public DateTime? ArchiveDate { get; set; }

        protected ArchivableEntity()
        {
            IsArchived = false;
            ArchiveDate = null;
        }
    }
}

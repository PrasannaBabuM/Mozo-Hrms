using System;

namespace SmartH2RCore.Models.Base
{
    public interface IArchivableEntity
    {
        bool IsArchived { get; set; }
        DateTime? ArchiveDate { get; set; }
    }
}

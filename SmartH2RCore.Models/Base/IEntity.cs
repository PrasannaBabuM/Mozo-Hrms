using System;

namespace SmartH2RCore.Models.Base
{
    public interface IEntity<T>
    {
        T Id { get; set; }
        DateTime CreatedDate { get; set; }
        int CreatedBy { get; set; }
        DateTime? UpdatedDate { get; set; }
        int? UpdatedBy { get; set; }
        bool IsActive { get; set; }
        Guid Guid { get; set; }
    }
}

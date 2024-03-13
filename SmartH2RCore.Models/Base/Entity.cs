using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartH2RCore.Models.Base
{
    public abstract class BaseEntity
    {

    }

    public abstract class Entity<T> : BaseEntity, IEntity<T>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public virtual T Id { get; set; }

        [ScaffoldColumn(false)]
        [Column(TypeName = "DateTime2")]
        public DateTime CreatedDate { get; set; }

        [ScaffoldColumn(false)]
        public int CreatedBy { get; set; }

        [ScaffoldColumn(false)]
        [Column(TypeName = "DateTime2")]
        public DateTime? UpdatedDate { get; set; }

        [ScaffoldColumn(false)]
        public int? UpdatedBy { get; set; }

        [ScaffoldColumn(false)]
        public bool IsActive { get; set; }

        [ScaffoldColumn(false)]
        public Guid Guid { get; set; }
        protected Entity()
        {
            Guid = Guid.NewGuid();
            CreatedDate = DateTime.Now.ToLocalTime();
            IsActive = true;
        }
    }
}

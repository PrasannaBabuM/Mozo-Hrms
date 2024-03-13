using Microsoft.AspNetCore.Identity;

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartH2RCore.Models.Common
{
    public class Role : IdentityRole<int>
    {
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
    }
}

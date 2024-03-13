using Microsoft.AspNetCore.Antiforgery.Internal;
using Microsoft.AspNetCore.Identity;

using SmartH2RCore.Models.Common;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartH2RCore.Models.Identity
{
    public class User : IdentityUser<int>
    {
      
        public string UserCode { get; set; }
        public string UserNo { get; set; }
        public string Title { get; set; }
        public string Gender { get; set; }
        public string Photo { get; set; }
        //public string UserName { get; set; }
        //public string PasswordHash { get; set; }
        public List<Company> Company { get; set; }

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

       
    }
}

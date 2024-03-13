using Microsoft.AspNetCore.Mvc.Rendering;

using SmartH2RCore.Models.Enumes;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SmartH2RCore.Web.Models
{
    public class CompanySettingViewModel
    {
        [Required(ErrorMessage = "Please select company!")]
        public int CompanyId { get; set; }
        [Required(ErrorMessage = "Please select branch!")]
        public int BranchId { get; set; }
        [Required(ErrorMessage = "Please master type!")]
        public MasterType MasterType { get; set; }
        public List<SelectListItem> SourceItems { get; set; }
        public List<SelectListItem> DestinationItems { get; set; }
    }
}

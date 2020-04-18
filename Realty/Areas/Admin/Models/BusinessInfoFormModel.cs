using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Realty.Areas.Admin.Models
{
    public class BusinessInfoFormModel
    {
        public string Id { get; set; }

        [Display(Name = "Business Name")]
        [Required(ErrorMessage ="Business Name is required.")]
        public string Name { get; set; }

        public string Address { get; set; }

        [Display(Name = "Business Email")]
        [Required(ErrorMessage = "Business Email is required.")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Email is invalid")]
        public string Email { get; set; }

        public bool Active { get; set; } = true;
        public string CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? DateModified { get; set; }
    }
}

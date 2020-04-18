using System;
using System.Collections.Generic;
using System.Text;

namespace Realty.Services.Models
{
    public class BusinessInfoServiceModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; } = true;
        public string CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? DateModified { get; set; }
    }
}

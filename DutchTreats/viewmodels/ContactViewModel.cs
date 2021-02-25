using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DutchTreats.viewmodels
{
    public class ContactViewModel
    {
        [Required]
        [MinLength(5, ErrorMessage ="name should be more than 5 characters")]
        public string name { get; set; }

        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        public string subject { get; set; }

        [Required]
        [MaxLength(200)]
        public string message { get; set; }
    }
}

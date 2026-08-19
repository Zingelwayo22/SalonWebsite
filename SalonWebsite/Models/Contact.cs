using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SalonWebsite.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        [Required]
        [Display(Name = "Salon Name")]
        public string SalonName { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

        public string OpeningHours { get; set; }

        public string Facebook { get; set; }

        public string Instagram { get; set; }

        public string TikTok { get; set; }
    }
}
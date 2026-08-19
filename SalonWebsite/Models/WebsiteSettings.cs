using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalonWebsite.Models
{
    public class WebsiteSettings
    {
        [Key]
        public int WebsiteSettingsId { get; set; }

        [Required]
        [Display(Name = "Salon Name")]
        public string SalonName { get; set; }

        [Display(Name = "Tagline")]
        public string Tagline { get; set; }

        [Display(Name = "Hero Heading")]
        public string HeroHeading { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Hero Description")]
        public string HeroDescription { get; set; }

        public string Logo { get; set; }

        public string HeroImage { get; set; }

        [NotMapped]
        public HttpPostedFileBase LogoFile { get; set; }

        [NotMapped]
        public HttpPostedFileBase HeroImageFile { get; set; }
    }
}
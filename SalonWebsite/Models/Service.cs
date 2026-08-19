using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace SalonWebsite.Models
{
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }

        [Required]
        [Display(Name = "Service Name")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        public string Image { get; set; }

        [NotMapped]
        [Display(Name = "Upload Image")]
        public HttpPostedFileBase ImageFile { get; set; }
    }
}
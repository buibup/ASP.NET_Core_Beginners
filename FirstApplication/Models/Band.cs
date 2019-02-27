using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApplication.Models
{
    public class Band
    {
        [Required(ErrorMessage = "Title is required")]
        [Display(Name ="name of musician")]
        public string Title { get; set; }

        [Required(ErrorMessage ="Genre is required")]
        [Display(Name = "name of genre")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "Origin is required")]
        [Display(Name = "name of origin")]
        [RegularExpression(@"\d", ErrorMessage = "you stupid")]
        public string Origin { get; set; }

        public string Biography { get; set; }
    }
}

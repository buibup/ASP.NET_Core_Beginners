using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApplication.Models
{
    public class Band
    {
        [Display(Name ="Enter the name of musician")]
        public string Title { get; set; }

        [Display(Name = "Enter the name of genre")]
        public string Genre { get; set; }

        [Display(Name = "Enter the name of origin")]
        public string Origin { get; set; }

        [Display(Name = "write a biography")]
        public string Biography { get; set; }
    }
}

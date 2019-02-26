using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApplication.Models
{
    public class Band
    {
        [Display(Name ="name of musician")]
        public string Title { get; set; }

        [Display(Name = "name of genre")]
        public string Genre { get; set; }

        [Display(Name = "name of origin")]
        public string Origin { get; set; }

        public string Biography { get; set; }
    }
}

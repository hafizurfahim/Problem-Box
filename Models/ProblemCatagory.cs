using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Problem_Box.Models
{
    public class ProblemCatagory
    {
        public int id { get; set; }
        [Required]
        [Display(Name ="Problem Catagory")]
        public string problemcatagory { get; set; }
    }
}

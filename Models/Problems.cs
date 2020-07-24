using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Problem_Box.Models
{
    public class Problems
    {
        public int id { get; set; }
        [Required]
        [Display(Name ="Problem Name")]
        
        public string complainName { get; set; }
    [Required]
    [Display(Name ="Problem Duration")]
        public string problemDuration { get; set; }
        [Required]
        [Display(Name ="Problem Description ")]
        public string problemDescription { get; set; }
        [Display(Name ="Image ")]
        public string image { get; set; }
        [Required]
        [Display(Name =" Currently Available")]
       public bool isAvailable { get; set; }
        [Display(Name ="Problem Catagory")]
        public int problemCatagoryId { get; set; }
        [ForeignKey("problemCatagoryId")]
        public ProblemCatagory problemCatagory { get; set; }

    
    }
}

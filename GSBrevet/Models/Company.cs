using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndGSBrevet.Models
{
    public class Company
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string zip_code { get; set; }

    }
}

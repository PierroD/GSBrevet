using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndGSBrevet.Models
{
    public class Utility
    {
        [Key, Column(Order = 0)]
        public int id { get; set; }
        [Required]  
        [Key, Column(Order = 1)]
        public int molecule_id { get; set; }
        [Required]
        public string name { get; set; }
        public string description { get; set; }
    }
}

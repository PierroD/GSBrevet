using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndGSBrevet.Models
{
    public class Molecule
    {
        [Key]
        public int id {get; set;}
        [Required]
        public string generic_name { get; set; }
        public string real_name { get; set; }
        public string formula { get; set; }
    }
}

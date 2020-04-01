using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndGSBrevet.Models
{
    public class Contract
    {
        [Key, Column(Order = 0)]
        public int id { get; set; }
        [Required]
        [Key, Column(Order = 1)]
        public int company_id { get; set; }
        [Required]
        [Key, Column(Order = 2)]
        public int patent_id { get; set; }
        [Required]
        public DateTime create_date { get; set; }
        public int duration { get; set; }
        public double price { get; set; }

    }
}

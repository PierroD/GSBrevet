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
        public int company_id { get; set; }
        public int patent_id { get; set; }
        public DateTime create_date { get; set; }
        public int duration { get; set; }
        public double price { get; set; }

    }
}

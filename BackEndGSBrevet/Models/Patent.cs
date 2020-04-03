using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndGSBrevet.Models
{
    public class Patent
    {
        [Key]
        public int id { get; set; }
        [Required]
        public int molecule_id { get; set; }
        public int company_id { get; set; }
        public string country { get; set; }
        public string number { get; set; }
        public DateTime deposit_date { get; set; }
        public int duration { get; set; }

    }
}

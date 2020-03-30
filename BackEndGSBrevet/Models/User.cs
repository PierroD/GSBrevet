using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndGSBrevet.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string last_name { get; set; }
        public string first_name { get; set; }
        public DateTime birth_date { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}

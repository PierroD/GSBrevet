﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BackEndGSBrevet.Models
{
    public class Role
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string libelle { get; set; }
    }
}

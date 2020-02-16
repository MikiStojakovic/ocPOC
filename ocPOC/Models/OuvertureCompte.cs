using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ocPOC.Models
{
    public class OuvertureCompte
    {
        [Key]
        public int Id { get; set; }
        public string OcRef { get; set; }
        public string PropertyOne { get; set; }
    }
}

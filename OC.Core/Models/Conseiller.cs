using System;
using System.Collections.Generic;
using System.Text;

namespace OC.Core.Models
{
    public class Conseiller
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
    }
}

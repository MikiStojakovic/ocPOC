using System;
using System.Collections.Generic;
using System.Text;

namespace OC.Core.Models
{
    public class OuvertureCompte
    { 
        public Guid Id { get; set; }
        public string OcRef { get; set; }
        public string DocPath { get; set; }
        public OuvertureCompteDetails OcDetails { get; set; }
        public Guid ConseillerId { get; set; }
        public Conseiller conseiller { get; set; }
    }    
}

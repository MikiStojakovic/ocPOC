using System;
using System.Collections.Generic;
using System.Text;

namespace OC.Core.Models
{
    public class OuvertureCompte
    { 
        public int Id { get; set; }
        public string OcRef { get; set; }
        public string DocPath { get; set; }
        public Guid IdFourisseur { get; set; }        
    }    
}

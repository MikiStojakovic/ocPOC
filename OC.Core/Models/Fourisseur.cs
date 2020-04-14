using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace OC.Core.Models
{
    public class Fourisseur
    {
        public Fourisseur()
        {
            Ocs = new Collection<OuvertureCompte>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<OuvertureCompte> Ocs { get; set; }
    }
}

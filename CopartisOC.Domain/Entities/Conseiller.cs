using CopartisOC.Domain.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CopartisOC.Domain.Entities
{
    public class Conseiller : AuditableEntity
    {
        public Conseiller()
        {
            Ocs = new Collection<OuvertureCompte>();
        }
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public ICollection<OuvertureCompte> Ocs { get; set; }
        public Fourisseur Fourisseur { get; set; }
        public Guid FourisseurId { get; set; }
    }
}

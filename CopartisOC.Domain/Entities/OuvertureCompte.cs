using CopartisOC.Domain.Common;
using CopartisOC.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopartisOC.Domain.Entities
{
    public class OuvertureCompte : AuditableEntity
    {
        public OuvertureCompte()
        {
            OcDetails = new OuvertureCompteDetails();
        }
        public Guid Id { get; set; }
        public string OcRef { get; set; }
        public string DocPath { get; set; }
        public ModeSoumission ModeSoumission { get; set; }
        public OuvertureCompteDetails OcDetails { get; private set; }
        public Guid ConseillerId { get; set; }
        public Conseiller conseiller { get; set; }
    }
}

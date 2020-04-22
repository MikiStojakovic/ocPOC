using System;
using System.Collections.Generic;
using System.Text;

namespace CopartisOC.Domain.Entities
{
    public class OuvertureCompteDetails
    {
        public Guid Id { get; set; }
        public string TypeCompte { get; set; }
        public string NatureCompte { get; set; }
        public string TypeOuverture { get; set; }
        public string ModeSoumission { get; set; }
        public Guid OuvertureCompteId { get; set; }
        public OuvertureCompte OuvertureCompte { get; set; }
    }
}

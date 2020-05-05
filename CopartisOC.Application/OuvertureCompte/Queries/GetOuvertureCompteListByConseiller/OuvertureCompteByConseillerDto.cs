using CopartisOC.Application.Common.Mappings;
using CopartisOC.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using DomainEntities = CopartisOC.Domain.Entities;

namespace CopartisOC.Application.OuvertureCompte.Queries.GetOuvertureCompteListByConseiller
{
    public class OuvertureCompteByConseillerDto : IMapFrom<DomainEntities.OuvertureCompte>
    {
        public Guid OuvertureCompteId { get; set; }
        public string OcRef { get; set; }
        public string DocPath { get; set; }
        public ModeSoumission ModeSoumission { get; set; }
        public Guid ConseillerId { get; set; }
    }
}

using CopartisOC.Application.Common.Mappings;
using DomainEntities = CopartisOC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopartisOC.Application.Conseiller.Queries.GetConseillerList
{
    public class ConseillerDto : IMapFrom<DomainEntities.Conseiller>
    {
        public Guid ConseillerId { get; set; }
        public string Code { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public Guid FourisseurId { get; set; }
    }
}

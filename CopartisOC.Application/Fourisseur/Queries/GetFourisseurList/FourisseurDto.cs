using CopartisOC.Application.Common.Mappings;
using System;
using DomainEntities = CopartisOC.Domain.Entities;

namespace CopartisOC.Application.Fourisseur.Queries.GetFourisseurList
{
    public class FourisseurDto : IMapFrom<DomainEntities.Fourisseur>
    {
        public Guid FourisseurId { get; set; }
        public string Name { get; set; }
    }
}

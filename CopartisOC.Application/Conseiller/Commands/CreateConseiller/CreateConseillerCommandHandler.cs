using CopartisOC.Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CoreDomainEntities = CopartisOC.Domain.Entities;

namespace CopartisOC.Application.Conseiller.Commands.CreateConseiller
{
    public class CreateConseillerCommandHandler : IRequestHandler<CreateConseillerCommand, Guid>
    {
        private readonly IApplicationDbContext _context;
        public CreateConseillerCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateConseillerCommand request, CancellationToken cancellationToken)
        {
            var entity = new CoreDomainEntities.Conseiller
            {
                ConseillerId = Guid.NewGuid(),
                Code = request.Code,
                Nom = request.Nom,
                Prenom = request.Prenom,
                FourisseurId = request.FourisseurId
            };

            _context.Conseillers.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.ConseillerId;
        }
    }
}

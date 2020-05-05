using CopartisOC.Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CoreDomainEntities = CopartisOC.Domain.Entities;

namespace CopartisOC.Application.OuvertureCompte.Commands.CreateOuvertureCompte
{
    public class CreateOuvertureCompteCommandHandler : IRequestHandler<CreateOuvertureCompteCommand, Guid>
    {
        private readonly IApplicationDbContext _context;
        public CreateOuvertureCompteCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateOuvertureCompteCommand request, CancellationToken cancellationToken)
        {
            var entity = new CoreDomainEntities.OuvertureCompte
            {
                OuvertureCompteId = Guid.NewGuid(),
                OcRef = request.OcRef,
                DocPath = null,
                ModeSoumission = Domain.Enums.ModeSoumission.Electronic,
                ConseillerId = Guid.Empty //todo curent user
            };

            _context.OuvertureComptes.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.OuvertureCompteId;
        }
    }
}

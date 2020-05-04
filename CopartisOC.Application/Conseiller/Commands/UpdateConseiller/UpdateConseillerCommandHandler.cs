using CopartisOC.Application.Common.Exceptions;
using CopartisOC.Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CopartisOC.Application.Conseiller.Commands.UpdateConseiller
{
    class UpdateConseillerCommandHandler : IRequestHandler<UpdateConseillerCommand, Guid>
    {
        private readonly IApplicationDbContext _context;

        public UpdateConseillerCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(UpdateConseillerCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Conseillers.FindAsync(request.ConseillerId);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Conseiller), request.ConseillerId);
            }

            entity.ConseillerId = request.ConseillerId;
            entity.Code = request.Code;
            entity.Nom = request.Nom;
            entity.Prenom = request.Prenom;
            entity.FourisseurId = request.FourisseurId;
            entity.LastModified = DateTime.Now; //IDateTime.Now;
            entity.LastModifiedBy = "current user";

            await _context.SaveChangesAsync(cancellationToken);

            return entity.ConseillerId;
        }
    }
}

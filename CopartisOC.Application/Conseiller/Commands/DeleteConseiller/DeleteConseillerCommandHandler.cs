using CopartisOC.Application.Common.Exceptions;
using CopartisOC.Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CopartisOC.Application.Conseiller.Commands.DeleteConseiller
{    
    public class DeleteConseillerCommandHandler : IRequestHandler<DeleteConseillerCommand>
    {
        private readonly IApplicationDbContext _context;

        public DeleteConseillerCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteConseillerCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Conseillers.FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Conseiller), request.Id);
            }

            _context.Conseillers.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}

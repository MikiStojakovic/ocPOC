using AutoMapper;
using AutoMapper.QueryableExtensions;
using CopartisOC.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CopartisOC.Application.Conseiller.Queries.GetConseillerList
{
    public class GetConseillerListQueryHandler : IRequestHandler<GetConseillerListQuery, ConseillerListVm>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetConseillerListQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ConseillerListVm> Handle(GetConseillerListQuery request, CancellationToken cancellationToken)
        {
            var conseillers = await _context.Conseillers
                .ProjectTo<ConseillerDto>(_mapper.ConfigurationProvider)
                .OrderBy(p => p.Prenom)
                .ToListAsync(cancellationToken);

            var vm = new ConseillerListVm
            {
                Conseillers = conseillers,
                CreateEnabled = true // TODO: Set based on user permissions.
            };

            return vm;
        }
    }
}

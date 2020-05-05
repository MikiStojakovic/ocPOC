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

namespace CopartisOC.Application.OuvertureCompte.Queries.GetOuvertureCompteListByConseiller
{
    public class GetOuvertureCompteListByConseillerQueryHandler : IRequestHandler<GetOuvertureCompteListByConseillerQuery, OuvertureCompteListVm>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        public GetOuvertureCompteListByConseillerQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<OuvertureCompteListVm> Handle(GetOuvertureCompteListByConseillerQuery request, CancellationToken cancellationToken)
        {
            var ouvertureComptes = await _context.OuvertureComptes
                .ProjectTo<OuvertureCompteByConseillerDto>(_mapper.ConfigurationProvider)
                .OrderBy(p => p.OcRef)
                .ToListAsync(cancellationToken);

            var vm = new OuvertureCompteListVm
            {
                OuvertureComptes = ouvertureComptes,
                CreateEnabled = true // TODO: Set based on user permissions.
            };

            return vm;
        }
    }
}

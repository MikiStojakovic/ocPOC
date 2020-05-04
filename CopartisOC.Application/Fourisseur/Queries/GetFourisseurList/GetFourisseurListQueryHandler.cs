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

namespace CopartisOC.Application.Fourisseur.Queries.GetFourisseurList
{
    public class GetFourisseurListQueryHandler : IRequestHandler<GetFourisseurListQuery, FourisseurListVm>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetFourisseurListQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<FourisseurListVm> Handle(GetFourisseurListQuery request, CancellationToken cancellationToken)
        {
            var fourisseurs = await _context.Fourisseurs
                .ProjectTo<FourisseurDto>(_mapper.ConfigurationProvider)
                .OrderBy(t => t.Name)
                .ToListAsync(cancellationToken);

            var vm = new FourisseurListVm
            {
                Fourisseurs = fourisseurs,
                CreateEnabled = true // TODO: Set based on user permissions.
            };

            return vm;
        }
    }
}

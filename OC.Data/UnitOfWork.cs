using OC.Core.Repositories;
using OC.Core.UnitOfWork;
using OC.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OC.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly NatixisDbContext _context;
        private IOuvertureCompteRepository _overtureCompteRepository;
        private IOuvertureCompteDetailsRepository _overtureCompteDetailsRepository;

        public UnitOfWork(NatixisDbContext context)
        {
            _context = context;
        }
        public IOuvertureCompteRepository Ocs => _overtureCompteRepository = _overtureCompteRepository ?? new OuvertureCompteRepository(_context);

        public IOuvertureCompteDetailsRepository OcsDetails => _overtureCompteDetailsRepository = _overtureCompteDetailsRepository ?? new OuvertureCompteDetailsRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

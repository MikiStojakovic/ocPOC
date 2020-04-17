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
        private readonly NatixisDbContext context;
        private IOuvertureCompteRepository overtureCompteRepository;
        private IOuvertureCompteDetailsRepository overtureCompteDetailsRepository;
        private IFourisseurRepository fourisseurRepository;
        private IConseillerRepository conseillerRepository;

        public UnitOfWork(NatixisDbContext context)
        {
            this.context = context;
        }
        public IOuvertureCompteRepository Ocs => overtureCompteRepository = overtureCompteRepository ?? new OuvertureCompteRepository(context);

        public IOuvertureCompteDetailsRepository OcsDetails => overtureCompteDetailsRepository = overtureCompteDetailsRepository ?? new OuvertureCompteDetailsRepository(context);

        public IFourisseurRepository Fourisseurs => fourisseurRepository = fourisseurRepository ?? new FourisseurRepository(context);
        public IConseillerRepository Conseillers => conseillerRepository = conseillerRepository ?? new ConseillerRepository(context);

        public async Task<int> CommitAsync()
        {
            return await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}

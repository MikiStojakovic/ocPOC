using OC.Core.Models;
using OC.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OC.Data.Repositories
{
    internal class FourisseurRepository : Repository<Fourisseur>, IFourisseurRepository
    {
        private NatixisDbContext NatixisDbContext
        {
            get { return Context as NatixisDbContext; }
        }
        public FourisseurRepository(NatixisDbContext context)
            : base(context)
        {

        }

    }
}
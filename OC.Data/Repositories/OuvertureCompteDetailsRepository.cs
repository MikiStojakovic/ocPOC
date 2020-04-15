using OC.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using OC.Core.Models;

namespace OC.Data.Repositories
{
    public class OuvertureCompteDetailsRepository : Repository<OuvertureCompteDetails>, IOuvertureCompteDetailsRepository
    {
        private NatixisDbContext NatixisDbContext
        {
            get { return Context as NatixisDbContext; }
        }

        public OuvertureCompteDetailsRepository(NatixisDbContext context)
            : base(context)
        {

        }
    }
}

using OC.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using OC.Core.Models;
using System.Threading.Tasks;
using System.Linq;

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

        public async Task<OuvertureCompteDetails> GetOuvertureCompteDetailsByOcId(Guid ouvertureCompteId)
        {
            return NatixisDbContext.OuvertureCompteDetails.Where(ocd => ocd.OuvertureCompteId == ouvertureCompteId).FirstOrDefault();
        }
    }
}

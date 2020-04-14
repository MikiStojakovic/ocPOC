using OC.Core.Models;
using OC.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC.Data.Repositories
{
    public class OuvertureCompteRepository : Repository<OuvertureCompte>, IOuvertureCompteRepository
    {
        private NatixisDbContext NatixisDbContext 
        {
            get { return Context as NatixisDbContext; }
        }
        public OuvertureCompteRepository(NatixisDbContext context)
            : base(context)
        {

        }
        public async Task<IEnumerable<OuvertureCompte>> GetAllByConseillerId(Guid conseillerId)
        {            
            return NatixisDbContext.OuvertureComptes.Where(oc => oc.ConseillerId == conseillerId).ToList();
        }
    }
}

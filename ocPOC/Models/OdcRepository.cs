using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ocPOC.Models
{
    public class OdcRepository : IOdcRepository
    {
        public OdcRepository(ocDbContext context)
        {
            Context = context;
        }

        public ocDbContext Context { get; }

        public OuvertureCompte Add(OuvertureCompte ouvertureCompte)
        {
            Context.OuvertureComptes.Add(ouvertureCompte);
            Context.SaveChanges();
            return ouvertureCompte;
        }

        public OuvertureCompte Delete(int id)
        {
            var ouvertureCompte = Context.OuvertureComptes.Find(id);
            if (ouvertureCompte != null)
            {
                Context.OuvertureComptes.Remove(ouvertureCompte);
                Context.SaveChanges();
            }
            return ouvertureCompte;
        }

        public IEnumerable<OuvertureCompte> GetAllOc()
        {
            return Context.OuvertureComptes;
        }

        public OuvertureCompte GetOc(int id)
        {
            return Context.OuvertureComptes.Find(id);
        }

        public OuvertureCompte Update(OuvertureCompte ouvertureCompteChanges)
        {
            var ouvertureCompte = Context.OuvertureComptes.Attach(ouvertureCompteChanges);
            ouvertureCompte.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Context.SaveChanges();

            return ouvertureCompteChanges;
        }
    }
}

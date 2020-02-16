using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ocPOC.Models
{
    public interface IOdcRepository
    {
        OuvertureCompte GetOc(int id);
        IEnumerable<OuvertureCompte> GetAllOc();
        OuvertureCompte Add(OuvertureCompte ovuertureCompte);
        OuvertureCompte Update(OuvertureCompte ouvertureCompteChanges);
        OuvertureCompte Delete(int id);
    }
}

using OC.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OC.Core.Services
{
    public interface IOuvertureCompteServices
    {
        Task<Tuple<OuvertureCompte, OuvertureCompteDetails>> GetOuvertureCompteById(Guid id);
        Task<IEnumerable<OuvertureCompte>> GetAllOuvertureCompte();
        Task<IEnumerable<OuvertureCompte>> GetAllOuvertureCompteByFourisseurId(Guid fourisseurId);
        Task<IEnumerable<OuvertureCompte>> GetAllOuvertureCompteByConseillerId(Guid ConseillerId);
        Task<OuvertureCompte> CreateOuvertureCompte(OuvertureCompte ouvertureCompte, OuvertureCompteDetails ouvertureCompteDetails);
        Task UpdateOuvertureCompte(OuvertureCompte ouvertureCompteToBeUpdated, OuvertureCompte ouvertureCompte,
            OuvertureCompteDetails ouvertureCompteDetailsToBeUpdated, OuvertureCompteDetails ouvertureCompteDetails);
        Task DeleteOuvertureCompte(OuvertureCompte ouvertureCompte);
    }
}

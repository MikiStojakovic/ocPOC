using OC.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OC.Core.Services
{
    public interface IOuvertureCompteServices
    {
        Task<OuvertureCompte> GetOuvertureCompteById(Guid id);
        Task<IEnumerable<OuvertureCompte>> GetAllOuvertureCompte();
        Task<IEnumerable<OuvertureCompte>> GetAllOuvertureCompteByFoursseur();
        Task<IEnumerable<OuvertureCompte>> GetAllOuvertureCompteByConseiller();
        Task<OuvertureCompte> CreateOuvertureCompte(OuvertureCompte ouvertureCompte);
        Task UpdateOuvertureCompte(OuvertureCompte ouvertureCompteToBeUpdated, OuvertureCompte ouvertureCompte);
        Task DeleteOuvertureCompte(OuvertureCompte ouvertureCompte);
    }
}

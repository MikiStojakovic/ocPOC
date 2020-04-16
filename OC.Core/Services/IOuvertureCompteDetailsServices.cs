using OC.Core.Models;
using OC.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OC.Core.Services
{
    public interface IOuvertureCompteDetailsServices
    {
        Task<OuvertureCompteDetails> GetOuvertureCompteDetailsById(Guid id);
        Task<OuvertureCompteDetails> GetOuvertureCompteDetailsByOcId(Guid ocId);
        Task<OuvertureCompte> CreateOuvertureCompteDetails(OuvertureCompteDetails ouvertureCompteDetails);
        Task UpdateOuvertureCompte(OuvertureCompteDetails ouvertureCompteDetailsToBeUpdated, OuvertureCompteDetails ouvertureCompteDetails);
        Task DeleteOuvertureCompte(OuvertureCompteDetails ouvertureCompteDetails);
    }
}

using OC.Core.Models;
using OC.Core.Services;
using OC.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OC.Services.Services
{    
    public class OuvertureCompteService : IOuvertureCompteServices
    {
        private readonly IUnitOfWork unitOfWork;
        public OuvertureCompteService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<OuvertureCompte> CreateOuvertureCompte(OuvertureCompte ouvertureCompte, OuvertureCompteDetails ouvertureCompteDetails)
        {
            await unitOfWork.Ocs.AddAsync(ouvertureCompte);
            await unitOfWork.OcsDetails.AddAsync(ouvertureCompteDetails);
            await unitOfWork.CommitAsync();
            return ouvertureCompte;
        }

        public async Task DeleteOuvertureCompte(OuvertureCompte ouvertureCompte)
        {
            unitOfWork.Ocs.Remove(ouvertureCompte);
            var ouvertureCompteDetails = await unitOfWork.OcsDetails.GetOuvertureCompteDetailsByOcId(ouvertureCompte.Id);
            unitOfWork.OcsDetails.Remove(ouvertureCompteDetails);
            await unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<OuvertureCompte>> GetAllOuvertureCompte()
        {
            return await unitOfWork.Ocs.GetAllAsync();
        }

        public async Task<IEnumerable<OuvertureCompte>> GetAllOuvertureCompteByConseillerId(Guid conseillerId)
        {
            return await unitOfWork.Ocs.GetAllByConseillerId(conseillerId);
        }

        public async Task<IEnumerable<OuvertureCompte>> GetAllOuvertureCompteByFourisseurId(Guid fourisseruId)
        {
            return await unitOfWork.Ocs.GetAllOuvertureCompteByFourisseurId(fourisseruId);
        }

        public async Task<Tuple<OuvertureCompte, OuvertureCompteDetails>> GetOuvertureCompteById(Guid id)
        {
            var ouvertureCompte = await unitOfWork.Ocs.GetByIdAsync(id);
            var ouvertureCompteDetails = await unitOfWork.OcsDetails.GetOuvertureCompteDetailsByOcId(id);
            return new Tuple<OuvertureCompte, OuvertureCompteDetails>(ouvertureCompte, ouvertureCompteDetails);
        }

        public async Task UpdateOuvertureCompte(OuvertureCompte ouvertureCompteToBeUpdated, OuvertureCompte ouvertureCompte, 
            OuvertureCompteDetails ouvertureCompteDetailsToBeUpdated, OuvertureCompteDetails ouvertureCompteDetails)
        {
            await unitOfWork.Ocs.UpdateOuvertureCompte(ouvertureCompteToBeUpdated, ouvertureCompte, ouvertureCompteDetailsToBeUpdated, ouvertureCompteDetails);
        }
    }
}

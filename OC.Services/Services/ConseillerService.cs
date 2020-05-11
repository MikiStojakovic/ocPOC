using OC.Core.Models;
using OC.Core.Services;
using OC.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OC.Services.Services
{
    public class ConseillerService : IConseillerServices
    {
        private readonly IUnitOfWork unitOfWork;
        public ConseillerService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<Conseiller> CreateConseiller(Conseiller conseiller)
        {
            await unitOfWork.Conseillers.AddAsync(conseiller);
            await unitOfWork.CommitAsync();

            return conseiller;
        }

        public async Task DeleteConseiller(Conseiller conseiller)
        {
            unitOfWork.Conseillers.Remove(conseiller);
            await unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Conseiller>> GetAllConseiller()
        {
            return await unitOfWork.Conseillers.GetAllAsync();
        }

        public Task<IEnumerable<Conseiller>> GetAllConseillerByFoursseur()
        {
            throw new NotImplementedException();
        }

        public async Task<Conseiller> GetConseillerById(Guid id)
        {
            return await unitOfWork.Conseillers.GetByIdAsync(id);
        }

        public Task UpdateConseiller(Conseiller conseillerToBeUpdated, Conseiller conseiller)
        {
            throw new NotImplementedException();
        }
    }
}

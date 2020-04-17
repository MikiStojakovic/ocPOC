using OC.Core.Models;
using OC.Core.Services;
using OC.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OC.Services.Services
{
    public class FourisseurService : IFourisseurSevices
    {
        private readonly IUnitOfWork unitOfWork;
        public FourisseurService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<Fourisseur> CreateFourisseur(Fourisseur fourisseur)
        {
            await unitOfWork.Fourisseurs.AddAsync(fourisseur);
            await unitOfWork.CommitAsync();

            return fourisseur;
        }

        public async Task DeleteFourisseur(Fourisseur fourisseur)
        {
            unitOfWork.Fourisseurs.Remove(fourisseur);
            await unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Fourisseur>> GetAllFourisseur()
        {
            return await unitOfWork.Fourisseurs.GetAllAsync();
        }

        public async Task<Fourisseur> GetFourisseurById(Guid id)
        {
            return await unitOfWork.Fourisseurs.GetByIdAsync(id);
        }

        public async Task UpdateFourisseur(Fourisseur fourisseurToBeUpdated, Fourisseur fourisseur)
        {
            throw new NotImplementedException();
        }
    }
}

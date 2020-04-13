using OC.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OC.Core.Services
{
    public interface IFourisseurSevices
    {
        Task<Fourisseur> GetFourisseurById(Guid id);
        Task<IEnumerable<Fourisseur>> GetAllFourisseur();
        Task<Fourisseur> CreateFourisseur(Fourisseur fourisseur);
        Task UpdateFourisseur(Fourisseur fourisseurToBeUpdated, Fourisseur fourisseur);
        Task DeleteFourisseur(Fourisseur fourisseur);
    }
}

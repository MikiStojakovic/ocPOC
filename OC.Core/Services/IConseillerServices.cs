using OC.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OC.Core.Services
{
    public interface IConseillerServices
    {
        Task<Conseiller> GetConseillerById(Guid id);
        Task<IEnumerable<Conseiller>> GetAllConseiller();
        Task<IEnumerable<Conseiller>> GetAllConseillerByFoursseur();
        Task<Conseiller> CreateConseiller(Conseiller conseiller);
        Task UpdateConseiller(Conseiller conseillerToBeUpdated, Conseiller conseiller);
        Task DeleteConseiller(Conseiller conseiller);
    }
}

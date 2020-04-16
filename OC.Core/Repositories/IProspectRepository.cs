using OC.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OC.Core.Repositories
{
    public interface IProspectRepository
    {
        Task<IEnumerable<Prospect>> GetAllProspect();
        Task<Prospect> GetProspectById(Guid id);
        Task<IEnumerable<Prospect>> GetAllProspectByConseillerId();
        Task<Prospect> Create(Prospect prospect);
        Task<bool> Delete(string id);
        void Update(string id, Prospect prospect);
    }
}

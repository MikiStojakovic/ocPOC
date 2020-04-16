using OC.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OC.Core.Repositories
{
    public interface IOuvertureCompteDetailsRepository: IRepository<OuvertureCompteDetails>
    {
        Task<OuvertureCompteDetails> GetOuvertureCompteDetailsByOcId(Guid ouvertureCompteId);
    }
}

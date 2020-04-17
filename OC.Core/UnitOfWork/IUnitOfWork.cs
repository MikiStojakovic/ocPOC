using OC.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OC.Core.UnitOfWork
{
    public interface IUnitOfWork
    {
        IOuvertureCompteRepository Ocs { get; }
        IOuvertureCompteDetailsRepository OcsDetails { get; }
        IFourisseurRepository Fourisseurs { get; }
        IConseillerRepository Conseillers { get;  }
        Task<int> CommitAsync();
    }
}

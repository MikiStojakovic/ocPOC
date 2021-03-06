﻿using OC.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OC.Core.Repositories
{
    public interface IOuvertureCompteRepository: IRepository<OuvertureCompte>
    {
        Task<IEnumerable<OuvertureCompte>> GetAllByConseillerId(Guid conseillerId);
        Task<IEnumerable<OuvertureCompte>> GetAllOuvertureCompteByFourisseurId(Guid fourisseurId);
        Task UpdateOuvertureCompte(OuvertureCompte ouvertureCompteToBeUpdate, OuvertureCompte ouvertureCompte, 
                OuvertureCompteDetails ouvertureCompteDetailsToBeUpdate, OuvertureCompteDetails ouvertureCompteDetails);
    }
}

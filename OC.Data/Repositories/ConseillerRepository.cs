using OC.Core.Models;
using OC.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OC.Data.Repositories
{
    public class ConseillerRepository : Repository<Conseiller>, IConseillerRepository
    {
        public ConseillerRepository(NatixisDbContext context)
            : base(context)
        {

        }
    }
}

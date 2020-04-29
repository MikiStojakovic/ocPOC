using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CopartisOC.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Conseiller> Conseillers { get; set; }
        DbSet<Fourisseur> Fourisseurs { get; set; }
        DbSet<OuvertureCompte> OuvertureComptes { get; set; }
        DbSet<Prospect> Prospects { get; set; }
        
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}

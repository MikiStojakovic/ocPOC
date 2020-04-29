using Microsoft.EntityFrameworkCore;
using DomainEntities = CopartisOC.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace CopartisOC.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<DomainEntities.Fourisseur> Fourisseurs { get; set; }
        DbSet<DomainEntities.Conseiller> Conseillers { get; set; }
        DbSet<DomainEntities.OuvertureCompte> OuvertureComptes { get; set; }
        DbSet<DomainEntities.Prospect> Prospects { get; set; }
        
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}

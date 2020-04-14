using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using OC.Core.Models;
using OC.Data.Configurations;

namespace OC.Data
{
    public class NatixisDbContext : DbContext
    {
        public DbSet<OuvertureCompte> OuvertureComptes { get; set; }
        public DbSet<OuvertureCompteDetails> OuvertureCompteDetails { get; set; }
        public DbSet<Conseiller> Conseillers { get; set; }
        public DbSet<Fourisseur> Fourisseurs { get; set; }

        public NatixisDbContext(DbContextOptions<NatixisDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .ApplyConfiguration(new OuvertureCompteConfiguration());

            builder
                .ApplyConfiguration(new OuvertureCompteDetailsConfiguration());

            builder
                .ApplyConfiguration(new ConseillerConfiguration());

            builder
                .ApplyConfiguration(new FourisseurConfiguration());
        }
    }
}

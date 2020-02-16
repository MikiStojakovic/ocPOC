using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ocPOC.Models
{
    public class ocDbContext : DbContext
    {
        public ocDbContext(DbContextOptions<ocDbContext> options) : base(options)
        {

        }

        public DbSet<OuvertureCompte> OuvertureComptes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}

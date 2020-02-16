using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ocPOC.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OuvertureCompte>().HasData(
                    new OuvertureCompte
                    {
                        Id = 1,
                        OcRef = "Ref1",
                        PropertyOne = "prop1"
                    },
                    new OuvertureCompte
                    {
                        Id = 2,
                        OcRef = "Ref2",
                        PropertyOne = "prop2"
                    },
                    new OuvertureCompte
                    {
                        Id = 3,
                        OcRef = "Ref3",
                        PropertyOne = "prop3"
                    }
                );
        }
    }
}

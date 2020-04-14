using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OC.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OC.Data.Configurations
{
    public class ConseillerConfiguration : IEntityTypeConfiguration<Conseiller>
    {
        public void Configure(EntityTypeBuilder<Conseiller> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Code);

            builder
                .Property(m => m.Nom);

            builder
                .Property(m => m.Prenom);
        }
    }
}

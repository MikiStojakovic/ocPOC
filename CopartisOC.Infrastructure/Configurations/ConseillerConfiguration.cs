using CopartisOC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopartisOC.Infrastructure.Configurations
{
    public class ConseillerConfiguration : IEntityTypeConfiguration<Conseiller>
    {
        public void Configure(EntityTypeBuilder<Conseiller> builder)
        {
            builder.Property(c => c.ConseillerId)
                .IsRequired();

            builder.Property(c => c.Code)
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(c => c.Nom)
                .IsRequired();

            builder.Property(c => c.Prenom)
                .IsRequired();

            builder.Property(c => c.FourisseurId);                
        }
    }
}

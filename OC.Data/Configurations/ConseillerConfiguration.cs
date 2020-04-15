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
                .HasKey(c => c.Id);

            builder
                .Property(c => c.Code);

            builder
                .Property(c => c.Nom);

            builder
                .Property(c => c.Prenom);

            builder
                .HasOne(c => c.Fourisseur)
                .WithMany(f => f.Conseillers)
                .HasForeignKey(c => c.FourisseurId);
        }
    }
}

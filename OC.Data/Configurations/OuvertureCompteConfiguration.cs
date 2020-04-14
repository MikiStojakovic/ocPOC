using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OC.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OC.Data.Configurations
{
    public class OuvertureCompteConfiguration : IEntityTypeConfiguration<OuvertureCompte>
    {
        public void Configure(EntityTypeBuilder<OuvertureCompte> builder)
        {
            builder
                .HasKey(oc => oc.Id);

            builder
                .Property(oc => oc.OcRef)
                .IsRequired();

            builder
                .Property(oc => oc.DocPath)
                .IsRequired();

            builder
                .HasOne(oc => oc.conseiller)
                .WithMany(c => c.Ocs)
                .HasForeignKey(oc => oc.ConseillerId);

            builder
                .HasOne(oc => oc.fourisseur)
                .WithMany(f => f.Ocs)
                .HasForeignKey(oc => oc.FourisseurId);

            builder
                .ToTable("OuvertureComptes");
        }
    }
}

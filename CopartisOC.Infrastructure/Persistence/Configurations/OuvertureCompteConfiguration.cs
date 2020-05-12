using CopartisOC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopartisOC.Infrastructure.Persistence.Configurations
{
    public class OuvertureCompteConfiguration : IEntityTypeConfiguration<OuvertureCompte>
    {
        public void Configure(EntityTypeBuilder<OuvertureCompte> builder)
        {
            builder.HasKey(oc => oc.OuvertureCompteId);

            builder.Property(oc => oc.OcRef)
                .HasMaxLength(15)
                .IsRequired();

            builder.Property(oc => oc.DocPath);

            builder.Property(oc => oc.ModeSoumission);

            builder
                .HasOne(oc => oc.conseiller)
                .WithMany(c => c.Ocs)
                .HasForeignKey(oc => oc.ConseillerId);

            builder
                .OwnsOne(oc => oc.OcDetails);
        }
    }
}

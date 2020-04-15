using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OC.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OC.Data.Configurations
{
    class OuvertureCompteDetailsConfiguration : IEntityTypeConfiguration<OuvertureCompteDetails>
    {
        public void Configure(EntityTypeBuilder<OuvertureCompteDetails> builder)
        {
            builder
                .HasKey(ocd => ocd.Id);

            builder
                .Property(ocd => ocd.TypeOuverture)
                .IsRequired();

            builder
                .Property(ocd => ocd.TypeCompte);

            builder
                .Property(ocd => ocd.NatureCompte);

            builder
                .Property(ocd => ocd.ModeSoumission);

            //builder
            //    .HasOne(ocd => ocd.OuvertureCompte)
            //    .WithOne(oc => oc.OcDetails);
                
        }
    }
}

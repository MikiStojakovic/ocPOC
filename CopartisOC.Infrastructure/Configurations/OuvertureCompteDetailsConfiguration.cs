using CopartisOC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopartisOC.Infrastructure.Configurations
{
    public class OuvertureCompteDetailsConfiguration : IEntityTypeConfiguration<OuvertureCompteDetails>
    {
        public void Configure(EntityTypeBuilder<OuvertureCompteDetails> builder)
        {
            builder.Property(ocd => ocd.Id)
                .IsRequired();

            builder.Property(ocd => ocd.TypeCompte)
                .IsRequired();

            builder.Property(ocd => ocd.NatureCompte);

            builder.Property(ocd => ocd.TypeOuverture);

            builder.Property(ocd => ocd.OuvertureCompteId)
                .IsRequired();
        }
    }
}

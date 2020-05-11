using CopartisOC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopartisOC.Infrastructure.Persistence.Configurations
{
    public class ProspectConfiguration : IEntityTypeConfiguration<Prospect>
    {
        public void Configure(EntityTypeBuilder<Prospect> builder)
        {
            builder.Property(p => p.ProspectId)
                .IsRequired();

            builder.Property(p => p.FirstName)
                .IsRequired();

            builder.Property(p => p.LastName)
                .IsRequired();

            builder.Property(p => p.ConseillerId);
        }
    }
}

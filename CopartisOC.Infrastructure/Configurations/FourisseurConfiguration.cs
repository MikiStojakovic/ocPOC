using CopartisOC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopartisOC.Infrastructure.Configurations
{
    public class FourisseurConfiguration : IEntityTypeConfiguration<Fourisseur>
    {
        public FourisseurConfiguration()
        {

        }

        public void Configure(EntityTypeBuilder<Fourisseur> builder)
        {
            builder.Property(f => f.Name)
                .IsRequired();                
        }
    }
}

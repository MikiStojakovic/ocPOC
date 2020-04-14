using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OC.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OC.Data.Configurations
{
    public class FourisseurConfiguration : IEntityTypeConfiguration<Fourisseur>
    {
        public void Configure(EntityTypeBuilder<Fourisseur> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Name);

            builder
                .ToTable("Fourisseur");
                   
        }
    }
}

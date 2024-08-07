using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RV24.PMA.CrossCutting.DataClasses;

namespace RV24.PMA.CrossCutting.Configuration.Data.Mappings
{
    internal class ConfigEntryMappings : IEntityTypeConfiguration<ConfigEntry>
    {
        public void Configure(EntityTypeBuilder<ConfigEntry> builder)
        {
            builder.ToTable("Configurations");

            builder.HasAlternateKey(c => c.Id);

            builder
                .Property(c => c.Key)
                .HasColumnName("Key")
                .IsRequired()
                .HasMaxLength(255);

            builder
                .Property(c => c.Value)
                .HasColumnName("Value")
                .IsRequired();

            builder
                .Property(c => c.DataType)
                .HasColumnName("DataType")
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}

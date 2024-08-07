using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RV24.PMA.CrossCutting.DataClasses;

namespace RV24.PMA.Data.DataStoring.Mappings
{
    internal class AuditEntryMappings : EntityBaseMapping<AuditEntry>
    {
        public override void Configure(EntityTypeBuilder<AuditEntry> builder)
        {
            base.Configure(builder);

            builder.ToTable("AuditEntries");

            builder
                .Property(p => p.Date)
                .HasColumnName("Time")
                .IsRequired();

            builder
                .Property(a => a.Message)
                .HasColumnName("Message")
                .HasMaxLength(255)
                .IsRequired();

            builder
                .Property(a => a.Level)
                .HasConversion(o => (int)o, 
                    l => (AuditLevels)l)
                .HasColumnName("Level")
                .IsRequired();
        }
    }
}

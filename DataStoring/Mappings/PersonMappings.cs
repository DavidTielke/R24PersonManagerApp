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
    internal class PersonMappings : EntityBaseMapping<Person>
    {
        public override void Configure(EntityTypeBuilder<Person> builder)
        {
            base.Configure(builder);

            builder.ToTable("Persons");

            builder
                .Property(p => p.Name)
                .HasColumnName("Name")
                .HasMaxLength(255)
                .IsRequired();

            builder
                .Property(p => p.Age)
                .IsRequired();

            builder
                .Property(p => p.FK_CategoryId)
                .HasColumnName("FK_CategoryId")
                .IsRequired();

            builder
                .HasOne(p => p.Category)
                .WithMany(c => c.Persons)
                .HasForeignKey(p => p.FK_CategoryId);
        }
    }
}

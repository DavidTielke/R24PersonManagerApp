using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RV24.PMA.CrossCutting.DataClasses;

namespace RV24.PMA.Data.DataStoring.Mappings;

public class CategoryMapping : EntityBaseMapping<Category>
{
    public override void Configure(EntityTypeBuilder<Category> builder)
    {
        base.Configure(builder);

        builder.ToTable("Categories");

        builder
            .Property(c => c.Name)
            .HasColumnName("Name")
            .HasMaxLength(255)
            .IsRequired();
    }
}
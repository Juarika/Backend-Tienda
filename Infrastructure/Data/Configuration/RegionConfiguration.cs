using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class RegionConfiguration : IEntityTypeConfiguration<Region>
{
    public void Configure(EntityTypeBuilder<Region> builder)
    {
        builder.ToTable("Region");
        
        builder.Property(p => p.NombreRegion)
        .IsRequired()
        .HasMaxLength(50);

        builder.HasOne(p => p.Estado)
        .WithMany(p => p.Regiones)
        .HasForeignKey(p => p.Id);
    }
}
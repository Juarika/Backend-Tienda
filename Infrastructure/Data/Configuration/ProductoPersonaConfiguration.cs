using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class ProductoPersonaConfiguration : IEntityTypeConfiguration<ProductoPersona>
{
    public void Configure(EntityTypeBuilder<ProductoPersona> builder)
    {
        builder.ToTable("ProductoPersona");

        builder.HasOne(p => p.Persona)
        .WithMany(p => p.ProductosPersona)
        .HasForeignKey(f => f.IdPersonaFk);
    
        builder.HasOne(p => p.Producto)
        .WithMany(p => p.ProductosPersona)
        .HasForeignKey(f => f.IdProductoFk);
    }
}
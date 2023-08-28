using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
{
    public void Configure(EntityTypeBuilder<Producto> builder)
    {
        builder.ToTable("Producto");
        
        builder.Property(p => p.Nombre)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.CodInterno)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.StockMin)
        .IsRequired()
        .HasColumnType("int");

        builder.Property(p => p.StockMax)
        .IsRequired()
        .HasColumnType("int");

        builder.Property(p => p.Stock)
        .IsRequired()
        .HasColumnType("int");

        builder.Property(p => p.ValorVta)
        .IsRequired()
        .HasColumnType("decimal");

        builder
        .HasMany(p => p.Personas)
        .WithMany(p => p.Productos)
        .UsingEntity<ProductoPersona>(
            j => j
                .HasOne(pt => pt.Persona)
                .WithMany(t => t.ProductosPersona)
                .HasForeignKey(pt => pt.IdPersonaFk),
            j => j
                .HasOne(pt => pt.Producto)
                .WithMany(p => p.ProductosPersona)
                .HasForeignKey(pt => pt.IdProductoFk),
            j => 
            {
                j.HasKey(pt => new { pt.IdProductoFk, pt.IdPersonaFk });
            }
        );
    }
}
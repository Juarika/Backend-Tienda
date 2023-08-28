using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
{
    public void Configure(EntityTypeBuilder<Persona> builder)
    {
        builder.ToTable("Persona");
        
        builder.Property(p => p.NombrePersona)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.IdPersona)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.FechaNac)
        .IsRequired()
        .HasMaxLength(50);

        builder.HasOne(p => p.Region)
        .WithMany(r => r.Personas)
        .HasForeignKey(f => f.Id);

        builder.HasOne(p => p.TipoPersona)
        .WithMany(e => e.Personas)
        .HasForeignKey(f => f.Id);

        builder
        .HasMany(p => p.Productos)
        .WithMany(p => p.Personas)
        .UsingEntity<ProductoPersona>(
            j => j
                .HasOne(pt => pt.Producto)
                .WithMany(t => t.ProductosPersona)
                .HasForeignKey(pt => pt.IdProductoFk),
            j => j
                .HasOne(pt => pt.Persona)
                .WithMany(p => p.ProductosPersona)
                .HasForeignKey(pt => pt.IdPersonaFk),
            j => 
            {
                j.HasKey(pt => new { pt.IdProductoFk, pt.IdPersonaFk });
            }
        );
    }
}
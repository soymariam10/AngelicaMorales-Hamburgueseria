using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class IngredienteConfiguration : IEntityTypeConfiguration<Ingrediente>
    {
        public void Configure(EntityTypeBuilder<Ingrediente> builder)
        {
            builder.ToTable("Ingredientes");

            builder.Property(x => x.IngredienteId)
            .HasAnnotation("MySqlValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasMaxLength(30)
            .IsRequired();

            builder.Property(x => x.NombreIngrediente)
            .HasColumnName("Ingrediente")
            .HasMaxLength(30)
            .IsRequired();

            builder.Property(x => x.DescripcionIngrediente)
            .HasColumnName("Descripcion")
            .HasMaxLength(30)
            .IsRequired();

            builder.Property(x => x.PrecioIngrediente)
            .HasColumnName("Precio")
            .HasColumnType("int")
            .HasMaxLength(10)
            .IsRequired();

            builder.Property(x => x.Stock)
            .HasColumnName("Stock")
            .HasColumnType("int")
            .HasMaxLength(5)
            .IsRequired();

            builder.HasOne(p => p.HamburgueseriaIngredientes)
            .WithMany(p => p.Ingredientes)
            .HasForeignKey(p => p.HamburgueseriaIngredientesId);
        }
    }
}
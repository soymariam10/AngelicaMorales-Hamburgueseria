using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class HamburguesaConfiguration : IEntityTypeConfiguration<Hamburguesa>
    {
        public void Configure(EntityTypeBuilder<Hamburguesa> builder)
        {
            builder.ToTable("Hamburguesas");

            builder.Property(e => e.HamburguesaId)
            .HasAnnotation("MySqlValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("HamburguesaId")
            .HasColumnType("int")
            .HasMaxLength(30)
            .IsRequired();

            builder.Property(e => e.NombreHamburguesa)
            .HasColumnName("Hamburguesa")
            .HasColumnType("varchar")
            .HasMaxLength(30);

            builder.Property(e => e.PrecioHamburguesa)
            .HasColumnName("Precio")
            .HasColumnType("int")
            .HasMaxLength(10)
            .IsRequired();

            builder.HasOne(e => e.HamburgueseriaIngredientes)
            .WithMany(e => e.Hamburguesas)
            .HasForeignKey(e => e.HamburgueseriaIngredientesId);
            
            builder.HasOne(e => e.Categorias)
            .WithMany(e => e.Hamburguesas)
            .HasForeignKey(e => e.CategoriaId);


        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class ChefConfiguration : IEntityTypeConfiguration<Chef>
    {
        public void Configure(EntityTypeBuilder<Chef> builder)
        {
            builder.ToTable ("Chefs");

            builder.HasKey(e => e.Id)
            .HasAnnotation("MySqlValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            builder.Property(e => e.NombreChef)
            .HasColumnName("Nombre")
            .HasMaxLength(50)
            .IsRequired();

            builder.Property(e => e.Especialidad)
            .HasColumnName("Especialidad")
            .HasMaxLength(30)
            .IsRequired();

            builder.HasOne(e => e.Hamburguesas)
            .WithMany (e => e.Chefs)
            .HasForeignKey (e => e.Hamburguesas);
        }
    }
}
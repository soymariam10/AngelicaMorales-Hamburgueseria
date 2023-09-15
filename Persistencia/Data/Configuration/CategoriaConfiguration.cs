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
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categoria");

            builder.Property(x => x.Id)
            .HasAnnotation("MySqlValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Categoria")
            .HasMaxLength(20)
            .IsRequired();

            builder.Property(x => x.NombreCategoria)
            .HasColumnName("Nombre")
            .HasMaxLength(30)
            .IsRequired();

            builder.Property(x=> x.DescripcionCategoria)
            .HasColumnName("Descripcion")
            .HasMaxLength(30);

        }
    }
}
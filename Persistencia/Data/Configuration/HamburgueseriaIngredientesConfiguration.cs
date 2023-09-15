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
    public class HamburgueseriaIngredientesConfiguration : IEntityTypeConfiguration<HamburgueseriaIngredientes>
    {
        public void Configure(EntityTypeBuilder<HamburgueseriaIngredientes> builder)
        {
            builder.ToTable("Ingredientes");

            builder.Property(x => x.Id)
            .HasAnnotation("MySqlValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnType("int")
            .HasMaxLength(30);

        }
    }
}
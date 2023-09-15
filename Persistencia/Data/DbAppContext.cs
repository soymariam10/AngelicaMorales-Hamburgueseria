using System.Reflection;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistencia.Data;
    public class DbAppContext : DbContext{
        public DbAppContext(DbContextOptions<DbAppContext> options) : base (options){

        }
        public DbSet<Categoria> Categorias{ get; set; } 
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Hamburguesa> Hamburguesas { get; set; }
        public DbSet<HamburgueseriaIngredientes> HamburgueseriaIngredientes {get; set;}
        public DbSet<Ingrediente> Ingredientes { get; set;}


        protected override void OnModelCreating(ModelBuilder modelBuilder){

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            
        }
        
    }
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Hamburguesa : BaseEntity
    {
        public int HamburguesaId { get; set; }
        public string NombreHamburguesa { get; set; }
        public int PrecioHamburguesa {get; set; }
        public int HamburgueseriaIngredientesId { get; set; }
        public HamburgueseriaIngredientes HamburgueseriaIngredientes { get; set; } = new HamburgueseriaIngredientes();
        public int CategoriaId { get; set; }
        public Categoria Categorias { get; set; } = new Categoria();
        public ICollection<Chef> Chefs{ get; set; }
    }
}
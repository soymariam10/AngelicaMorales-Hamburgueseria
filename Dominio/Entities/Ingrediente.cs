using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Ingrediente : BaseEntity
    {
        public string NombreIngrediente { get; set; }
        public string DescripcionIngrediente {get; set; }
        public int PrecioIngrediente {get; set;}
        public int Stock { get; set; }
        public int HamburgueseriaIngredientesId { get; set; }
        public HamburgueseriaIngredientes HamburgueseriaIngredientes { get; set; }
    }
}
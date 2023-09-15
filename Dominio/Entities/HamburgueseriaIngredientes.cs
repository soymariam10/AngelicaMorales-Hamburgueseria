using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class HamburgueseriaIngredientes : BaseEntity
    {
        public ICollection<Hamburguesa> Hamburguesas { get; set;}
        public ICollection<Ingrediente> Ingredientes { get; set; }
    }
}
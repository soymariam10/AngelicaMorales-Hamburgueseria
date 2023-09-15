using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Categoria : BaseEntity
    {
        public string NombreCategoria { get; set; }
        public string DescripcionCategoria { get; set; }
        public ICollection<Hamburguesa> Hamburguesas{ get; set; }
    }
}
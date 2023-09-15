using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Chef : BaseEntity
    {
        public int ChefId { get; set; }
        public string NombreChef { get; set; }
        public string Especialidad { get; set; }
        public int HamburguesaId { get; set; }
        public Hamburguesa Hamburguesas { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Dominio.Entities
{
    public class Chef : BaseEntity
    {
        public string NombreChef { get; set; }
        public string Especialidad { get; set; }
        public int HamburguesaIdFk { get; set; }
        public Hamburguesa Hamburguesas { get; set; }
    }
}
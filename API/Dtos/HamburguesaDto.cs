using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class HamburguesaDto
    {
        public int Id { get; set; }
        public string NombreHamburguesa { get; set; }
        public int PrecioHamburguesa {get; set; }
    }
}
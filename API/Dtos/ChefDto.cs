using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class ChefDto
    {
        public int Id { get; set; }
        public string NombreChef { get; set; }
        public string Especialidad { get; set; }
    }
}
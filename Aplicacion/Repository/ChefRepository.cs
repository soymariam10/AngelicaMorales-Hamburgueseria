using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;

namespace Aplicacion.Repository
{
    public class ChefRepository : GenericRepository<Chef>, IChefRepository
    {
        public ChefRepository(HamburgueseriaContext context) : base(context)
        {
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;

namespace Aplicacion.Repository
{
    public class IngredienteRepository : GenericRepository<Ingrediente>, IIngredienteRepository
    {
        public IngredienteRepository(HamburgueseriaContext context) : base(context)
        {
        }
    }
}
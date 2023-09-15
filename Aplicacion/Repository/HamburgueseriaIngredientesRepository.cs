using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;

namespace Aplicacion.Repository
{
    public class HamburgueseriaIngredientesRepository : GenericRepository<HamburgueseriaIngredientes>, IHamburgueseriaIngredientesRepository
    {
        public HamburgueseriaIngredientesRepository(HamburgueseriaContext context) : base(context)
        {
        }
    }
}
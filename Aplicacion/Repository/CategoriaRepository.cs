using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Interfaces;
using iText.Commons.Actions.Contexts;
using Microsoft.EntityFrameworkCore;
using Persistencia.Data;

namespace Aplicacion.Repository
{
    public class CategoriaRepository : GenericRepository<Categoria>, ICategoriaRepository
    {
        private readonly HamburgueseriaContext _context;
        public CategoriaRepository(HamburgueseriaContext context) : base(context)
        {
            _context = context;
        }
        public override async Task<IEnumerable<Categoria>> GetAllAsync()
        {
            return await _context.Categorias
                    .Include(p => p.Hamburguesas)
                    .ToListAsync();
        }
    }

}
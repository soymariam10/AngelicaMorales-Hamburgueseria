using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicacion.Repository;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;

namespace Aplicacion.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly HamburgueseriaContext context;
        private CategoriaRepository  _categorias;
            public UnitOfWork(HamburgueseriaContext _context)
            {
                context = _context;
            }
            public CategoriaRepository Categoria
            {
                get
                {
                    if (_categorias == null)
                    {
                        _categorias = new CategoriaRepository(context);
                    }
                    return _categorias;
                }
            }
            public int Save(){
                return context.SaveChanges();
            }

            public void Dispose()
            {
                context.Dispose();
            }

        public IHamburguesaRepository Hamburguesa { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IHamburgueseriaIngredientesRepository HamburgueseriaIngredientes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IIngredienteRepository IngredienteRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        ICategoriaRepository IUnitOfWork.Categoria { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IChefRepository Chef { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
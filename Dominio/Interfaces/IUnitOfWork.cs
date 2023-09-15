using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface IUnitOfWork
    {
        ICategoriaRepository Categoria { get; set; }
        IChefRepository Chef { get; set; }
        IHamburguesaRepository Hamburguesa { get; set; }
        IHamburgueseriaIngredientesRepository HamburgueseriaIngredientes { get; set; }
        IIngredienteRepository IngredienteRepository { get; set; }
        Task SaveAsync();
    }
}
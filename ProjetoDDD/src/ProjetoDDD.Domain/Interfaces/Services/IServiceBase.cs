using System;
using System.Linq;

namespace ProjetoDDD.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> : IDisposable where TEntity : class
    {
        void Incluir(TEntity obj);
        void Atualizar(TEntity obj);
        void Excluir(TEntity obj);
        IQueryable BuscarTodos();
        TEntity BuscaPorId(int id);
        int SaveChanges();
    }
}
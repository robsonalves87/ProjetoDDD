using System;
using System.Collections.Generic;

namespace ProjetoDDD.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> : IDisposable where TEntity : class
    {
        void Incluir(TEntity obj);
        void Atualizar(TEntity obj);
        void Excluir(TEntity obj);
        IList<TEntity> BuscarTodos();
        IList<TEntity> BuscarTodosAtivos();
        TEntity BuscaPorId(Guid id);
        int SaveChanges();

    }
}

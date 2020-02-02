using System;
using System.Collections.Generic;

namespace ProjetoDDD.Application.Interfaces
{
    public interface IAppServiceBase<TEntity> : IDisposable where TEntity : class
    {
        void Incluir(TEntity obj);
        void Atualizar(TEntity obj);
        void Excluir(TEntity obj);
        IList<TEntity> BuscarTodos();
        TEntity BuscaPorId(Guid id);
        int SaveChanges();
    }
}

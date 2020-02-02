using System.Collections.Generic;

namespace ProjetoDDD.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Incluir(TEntity obj);
        void Atualizar(TEntity obj);
        void Excluir(TEntity obj);
        IEnumerable<TEntity> BuscarTodos();
        TEntity BuscaPorId(int id);
    }
}

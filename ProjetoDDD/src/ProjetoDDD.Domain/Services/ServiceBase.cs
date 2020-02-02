using System.Linq;
using ProjetoDDD.Domain.Interfaces.Repositories;
using ProjetoDDD.Domain.Interfaces.Services;

namespace ProjetoDDD.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public virtual void Incluir(TEntity obj)
        {
            _repository.Incluir(obj);
        }

        public virtual void Atualizar(TEntity obj)
        {
            _repository.Atualizar(obj);
        }

        public virtual void Excluir(TEntity obj)
        {
            _repository.Excluir(obj);
        }

        public virtual IQueryable BuscarTodos()
        {
            return _repository.BuscarTodos();
        }

        public virtual TEntity BuscaPorId(int id)
        {
            return _repository.BuscaPorId(id);
        }

        public int SaveChanges()
        {
            return _repository.SaveChanges();
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}

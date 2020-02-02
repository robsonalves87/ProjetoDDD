using System.Linq;
using ProjetoDDD.Application.Interfaces;
using ProjetoDDD.Domain.Interfaces.Services;

namespace ProjetoDDD.Application.Services
{
    public class AppServiceBase<TEntity> : IAppServiceBase<TEntity> where TEntity : class
    {
        private IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }

        public void Incluir(TEntity obj)
        {
            _serviceBase.Incluir(obj);
        }

        public void Atualizar(TEntity obj)
        {
            _serviceBase.Atualizar(obj);
        }

        public void Excluir(TEntity obj)
        {
            _serviceBase.Excluir(obj);
        }

        public IQueryable BuscarTodos()
        {
            return _serviceBase.BuscarTodos();
        }

        public TEntity BuscaPorId(int id)
        {
            return _serviceBase.BuscaPorId();
        }

        public int SaveChanges()
        {
            return _serviceBase.SaveChanges();
        }
    }
}

using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProjetoDDD.Domain.Interfaces.Repositories;
using ProjetoDDD.Infrastructure.Data.Context;

namespace ProjetoDDD.Infrastructure.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected readonly ProjetoDDDContext Db;
        protected readonly DbSet<TEntity> dbSet;

        public RepositoryBase(ProjetoDDDContext context)
        {
            Db = context;
            dbSet = Db.Set<TEntity>();
        }

        public virtual void Dispose()
        {
            Db.Dispose();
        }

        public virtual void Incluir(TEntity obj)
        {
            dbSet.Add(obj);
        }

        public virtual void Atualizar(TEntity obj)
        {
            dbSet.Update(obj);
        }

        public virtual void Excluir(TEntity obj)
        {
            dbSet.Remove(obj);
        }

        public virtual IQueryable<TEntity> BuscarTodos()
        {
            return dbSet;
        }

        public virtual TEntity BuscaPorId(int id)
        {
            return dbSet.Find(id);
        }

        public virtual int SaveChanges()
        {
            return Db.SaveChanges();
        }
    }
}

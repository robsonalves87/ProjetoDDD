﻿using System;
using System.Linq;

namespace ProjetoDDD.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> : IDisposable where TEntity : class
    {
        void Incluir(TEntity obj);
        void Atualizar(TEntity obj);
        void Excluir(TEntity obj);
        IQueryable<TEntity> BuscarTodos();
        TEntity BuscaPorId(int id);
        int SaveChanges();

    }
}

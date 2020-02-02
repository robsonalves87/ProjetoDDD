using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProjetoDDD.Domain.Interfaces.Repositories;
using ProjetoDDD.Domain.Models;
using ProjetoDDD.Infrastructure.Data.Context;

namespace ProjetoDDD.Infrastructure.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ProjetoDDDContext context) : base(context)
        {
        }

        public override IList<Produto> BuscarTodos()
        {
            return dbSet
                        .Include(p => p.CategoriaProduto)
                    .ToList();
        }

        public override Produto BuscaPorId(Guid id)
        {
            return dbSet
                        .Include(p => p.CategoriaProduto)
                    .Where(p => p.Id == id)
                    .FirstOrDefault();
        }
    }
}

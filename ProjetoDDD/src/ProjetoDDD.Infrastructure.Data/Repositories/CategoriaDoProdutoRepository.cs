using Microsoft.EntityFrameworkCore;
using ProjetoDDD.Domain.Interfaces.Repositories;
using ProjetoDDD.Domain.Models;
using ProjetoDDD.Infrastructure.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoDDD.Infrastructure.Data.Repositories
{
    public class CategoriaDoProdutoRepository : RepositoryBase<CategoriaDoProduto>, ICategoriaDoProdutoRepository
    {
        public CategoriaDoProdutoRepository(ProjetoDDDContext context) : base(context)
        {
        }

        //BuscarTodosAtivos direto do banco
        public override IList<CategoriaDoProduto> BuscarTodosAtivos()
        {
            return dbSet
                .Where(cp => cp.Ativo == true)
                .ToList();
        }

    }
}

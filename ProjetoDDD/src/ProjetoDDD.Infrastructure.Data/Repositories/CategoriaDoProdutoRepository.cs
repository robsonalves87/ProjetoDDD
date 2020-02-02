using ProjetoDDD.Domain.Interfaces.Repositories;
using ProjetoDDD.Domain.Models;
using ProjetoDDD.Infrastructure.Data.Context;

namespace ProjetoDDD.Infrastructure.Data.Repositories
{
    public class CategoriaDoProdutoRepository : RepositoryBase<CategoriaDoProduto>, ICategoriaDoProdutoRepository
    {
        public CategoriaDoProdutoRepository(ProjetoDDDContext context) : base(context)
        {
        }
    }
}

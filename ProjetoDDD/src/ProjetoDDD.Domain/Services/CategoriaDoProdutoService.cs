using ProjetoDDD.Domain.Interfaces.Repositories;
using ProjetoDDD.Domain.Interfaces.Services;
using ProjetoDDD.Domain.Models;

namespace ProjetoDDD.Domain.Services
{
    public class CategoriaDoProdutoService : ServiceBase<CategoriaDoProduto>, ICategoriaDoProdutoService
    {
        private ICategoriaDoProdutoRepository _categoriaDoProdutoRepository;

        public CategoriaDoProdutoService(ICategoriaDoProdutoRepository categoriaDoProdutoRepository) : base(categoriaDoProdutoRepository)
        {
            _categoriaDoProdutoRepository = categoriaDoProdutoRepository;
        }
    }
}

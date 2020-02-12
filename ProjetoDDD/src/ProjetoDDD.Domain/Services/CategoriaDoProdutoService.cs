using ProjetoDDD.Domain.Interfaces.Repositories;
using ProjetoDDD.Domain.Interfaces.Services;
using ProjetoDDD.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoDDD.Domain.Services
{
    public class CategoriaDoProdutoService : ServiceBase<CategoriaDoProduto>, ICategoriaDoProdutoService
    {
        private ICategoriaDoProdutoRepository _categoriaDoProdutoRepository;

        public CategoriaDoProdutoService(ICategoriaDoProdutoRepository categoriaDoProdutoRepository) : base(categoriaDoProdutoRepository)
        {
            _categoriaDoProdutoRepository = categoriaDoProdutoRepository;
        }

        public IList<CategoriaDoProduto> ObterCategoriasDoProdutoAtivas(IList<CategoriaDoProduto> categoriaDoProdutos)
        {
            return categoriaDoProdutos.Where(cp => cp.CategoriaDoProdutoAtiva(cp)).ToList();
        }
    }
}

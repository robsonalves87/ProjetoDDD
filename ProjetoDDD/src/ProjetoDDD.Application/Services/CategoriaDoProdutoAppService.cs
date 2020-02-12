using ProjetoDDD.Application.Interfaces;
using ProjetoDDD.Domain.Interfaces.Services;
using ProjetoDDD.Domain.Models;
using System.Collections.Generic;

namespace ProjetoDDD.Application.Services
{
    public class CategoriaDoProdutoAppService : AppServiceBase<CategoriaDoProduto>, ICategoriaDoProdutoAppService
    {
        private readonly ICategoriaDoProdutoService _categoriaDoProdutoService;

        public CategoriaDoProdutoAppService(ICategoriaDoProdutoService categoriaDoProdutoService) : base(categoriaDoProdutoService)
        {
            _categoriaDoProdutoService = categoriaDoProdutoService;
        }

        public IList<CategoriaDoProduto> ObterCategoriasDoProdutoAtivas()
        {
            return _categoriaDoProdutoService.ObterCategoriasDoProdutoAtivas(_categoriaDoProdutoService.BuscarTodos());
        }
    }
}

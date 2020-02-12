using ProjetoDDD.Domain.Models;
using System.Collections.Generic;

namespace ProjetoDDD.Domain.Interfaces.Services
{
    public interface ICategoriaDoProdutoService : IServiceBase<CategoriaDoProduto>
    {
        IList<CategoriaDoProduto> ObterCategoriasDoProdutoAtivas(IList<CategoriaDoProduto> categoriaDoProdutos);
    }
}

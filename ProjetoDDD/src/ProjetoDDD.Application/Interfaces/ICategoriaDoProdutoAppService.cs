using ProjetoDDD.Domain.Models;
using System.Collections.Generic;

namespace ProjetoDDD.Application.Interfaces
{
    public interface ICategoriaDoProdutoAppService : IAppServiceBase<CategoriaDoProduto>
    {
        IList<CategoriaDoProduto> ObterCategoriasDoProdutoAtivas();
    }
}

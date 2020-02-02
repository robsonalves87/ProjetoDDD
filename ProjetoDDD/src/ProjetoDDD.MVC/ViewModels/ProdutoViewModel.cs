using System;

namespace ProjetoDDD.MVC.ViewModels
{
    public class ProdutoViewModel : EntityViewModel
    {

        public string Nome { get; set; }
        public string Descricao { get; set; }

        public CategoriaDoProdutoViewModel CategoriaProduto { get; set; }
        public Guid CategoriaProdutoId { get; set; }

        public decimal Valor { get; set; }
        public DateTime DataInclusao { get; set; }
        public bool Ativo { get; set; }
    }
}

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoDDD.MVC.ViewModels
{
    public class ProdutoViewModel : EntityViewModel
    {
        [Required(ErrorMessage = "Preencha o Campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo 150 caracteres")]
        [MinLength(2, ErrorMessage = "Minimo 2 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Descrição")]
        [MaxLength(500, ErrorMessage = "Máximo 500 caracteres")]
        [MinLength(2, ErrorMessage = "Minimo 2 caracteres")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Categoria do Produto")]
        [DisplayName("Categoria do Produto")]
        public Guid CategoriaProdutoId { get; set; }

        public virtual CategoriaDoProdutoViewModel CategoriaProduto { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Valor")]
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999999")]
        public decimal Valor { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataInclusao { get; set; }

        public bool Ativo { get; set; }
    }
}

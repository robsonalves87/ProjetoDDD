using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoDDD.MVC.ViewModels
{
    public class ClienteViewModel : EntityViewModel
    {

        [Required(ErrorMessage = "Preencha o Campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Sobrenome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Preencha o Campo CPF")]
        [MaxLength(11, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(11, ErrorMessage = "Minimo {0} caracteres")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Preencha o Campo CPF")]
        [MaxLength(15, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(5, ErrorMessage = "Minimo {0} caracteres")]
        public string RG { get; set; }

        [Required(ErrorMessage = "Preencha o Campo E-mail")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Data de Nascimento")]
        [DisplayName("Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataInclusao { get; set; }

        public bool Ativo { get; set; }
    }
}

using System;

namespace ProjetoDDD.Domain.Models
{
    public class CategoriaDoProduto : Entity
    {
        public CategoriaDoProduto (Guid id, string nome, string descricao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
        }

        protected CategoriaDoProduto() { }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
    }
}

using System;

namespace ProjetoDDD.Domain.Models
{
    public class Produto : Entity
    {
        public Produto(Guid id,string nome, string descricao, decimal valor, bool ativo)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            Ativo = ativo;
        }

        protected Produto() {}

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataInclusao { get; set; }
        public bool Ativo { get; set; }
    }
}

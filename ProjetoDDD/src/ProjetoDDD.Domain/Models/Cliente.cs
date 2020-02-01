using System;

namespace ProjetoDDD.Domain.Models
{
    public class Cliente : Entity
    {
        public Cliente (Guid id, string name, string sobrenome, string cpf, string rg, string email, DateTime dataNascimento, bool ativo)
        {
            Id = id;
            Nome = name;
            Sobrenome = sobrenome;
            CPF = cpf;
            RG = rg;
            Email = email;
            DataNascimento = dataNascimento;
            Ativo = ativo;
        }

        protected Cliente() { }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataInclusao { get; set; }
        public bool Ativo { get; set; }
    }
}

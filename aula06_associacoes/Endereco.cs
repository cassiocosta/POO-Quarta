using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula06_associacoes
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }

        public Pessoa Pessoa { get; private set; }

        public Endereco(int id, string logragouro)
        {
            this.Id = id;
            this.Logradouro = logragouro;
        }

        public Endereco(int id, string logragouro, Pessoa pessoa)
        {
            this.Id = id;
            this.Logradouro = logragouro;
            this.Pessoa = pessoa;
        }

    }
}
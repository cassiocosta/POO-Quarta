using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula11_interfaces_exercicios.Exercicio02
{
    public class Escola
    {
        public void ApresentarPessoa(IPessoa pessoa)
        {
            pessoa.Falar(); 
        }

        public void ApresentarPessoaAcessibilidade()
        {
            Console.WriteLine("teste");
        }

    }
}
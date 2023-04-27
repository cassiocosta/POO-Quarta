using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula11_interfaces_exercicios.Exercicio02
{
    public class Aluno : IPessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Falar()
        {
            Console.WriteLine($"Oi, meu nome é {Nome} e eu tenho {Idade} anos.");
        }

        public void Aprender()
        {
            Console.WriteLine($"{Nome} está aprendendo a matéria POO.");
        }


    }
}
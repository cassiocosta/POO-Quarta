using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula11_interfaces_exercicios.Exercicio02
{
    public class Professor : IPessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Falar()
        {
            Console.WriteLine($"Olá, eu sou o professor {Nome} e tenho {Idade} anos.");
        }
        public void Ensinar()
        {
            Console.WriteLine($"{Nome} está ensinando a matéria POO.");
        }

    }
}
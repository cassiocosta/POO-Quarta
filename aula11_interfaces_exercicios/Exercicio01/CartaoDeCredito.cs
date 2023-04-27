using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula11_interfaces_exercicios.Exercicio01
{
    public class CartaoDeCredito : IPagamento
    {
        public void Pagar(double valor)
        {
            Console.WriteLine($"Pagamento de R${valor} realizado com cartão de crédito.");
        }

    }
}
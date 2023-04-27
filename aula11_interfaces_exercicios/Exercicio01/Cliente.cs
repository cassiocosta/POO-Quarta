using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula11_interfaces_exercicios.Exercicio01
{
    public class Cliente
    {
        private IPagamento metodoPagamento; 

        public Cliente(IPagamento metodoPagamento)
        {
            this.metodoPagamento = metodoPagamento; 
        }

        public void Comprar(double valor)
        {
            metodoPagamento.Pagar(valor); 
        }

    }
}
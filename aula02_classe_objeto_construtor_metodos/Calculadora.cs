using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula02_classe_objeto_construtor_metodos
{
    public class Calculadora
    {


        public double Somar(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Calcular(double num1, double num2, string oper)
        {
            double result = 0;
            switch (oper)
            {
                case "+":
                    result = num1 + num2;
                    break;
                default:
                    result = 0;
                    break;
            }
            return result;
        }
    }
}
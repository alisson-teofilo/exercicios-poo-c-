using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_poo
{
    internal class Calculadora
    {
        public double RealizarOperacao(string operador, double n1, double n2)
        {
            double resultado = 0;

            switch (operador)
            {
                case "*":
                    resultado = n1 * n2;
                    break;
                case "/":
                    resultado = n1 / n2;
                    break;
                case "+":
                    resultado = n1 + n2;
                    break;
                case "-":
                    resultado = n1 - n2;
                    break;
                default:
                    Console.WriteLine("Operador Inválido!");
                    break;
            }

            return resultado;
        }
    }
}

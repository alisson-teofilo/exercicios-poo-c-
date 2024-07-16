using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_poo.Criatividade
{
    internal class Gerente : Funcionario
    {
        private const double ValorHora = 50;

        public Gerente(string Nome, string Setor, string RE)
            : base(Nome, Setor, RE) { }

        public override double CalcularSalario(int diasTrabalhados)
        {
            return (ValorHora * 8) * diasTrabalhados;
        }
    }
}

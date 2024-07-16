using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_poo.Criatividade
{
    internal class Vendedor : Funcionario
    {
        private const double ValorHora = 15;
        private string Cargo;
        public Vendedor(string Nome, string Setor, string Re) : base(Nome, Setor, Re) { }

        public override double CalcularSalario(int diasTrabalhados)
        {
            return ValorHora * diasTrabalhados;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_poo.Criatividade
{
      abstract class Funcionario
    {
        private string Nome { get; set; }
        private string Setor { get; set; }
        private string RE { get; set; }

        static List<Funcionario> ListaFuncionarios  = new List<Funcionario>();

        public Funcionario(string nome, string setor, string re)
        {
            Nome = nome;
            Setor = setor;
            RE = re;
        }

        public abstract double CalcularSalario(int diasTrabalhados);

        public static List<Funcionario> GetFuncionarios()
        {
            return ListaFuncionarios;
        }

        public void SetFuncionario(Funcionario funcionario)
        {
            ListaFuncionarios.Add(funcionario);
        }

        public override string ToString()
        {
            return $"RE: {RE}, Nome: {Nome}, Setor: {Setor}";
        }

        public string GetRe()
        {
            return RE;
        }

        public string GetNome()
        {
            return Nome;
        }
    }
}

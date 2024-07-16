using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_poo
{
    internal class Cassino
    {
        Random rd = new Random();
        public void IniciarJogo(string[] tentativas)
        {
            double numeroSorteado = rd.Next(1, 100);

            Console.Clear();
            Console.WriteLine("Bem vindo ao Cassino");
            Console.WriteLine("Você terá 3 chances para adivinhar o número sorteado.");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Tentativa número " +(i + 1) + ": ");
                tentativas[i] = Console.ReadLine();

                if (int.Parse(tentativas[i]) == numeroSorteado)
                {
                    Console.WriteLine("Parabéns! você acertou o número!");
                    JogarNovamente(tentativas);
                    return;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Infelizmente não foi dessa vez...");
            Console.WriteLine("O número sorteado foi: " + numeroSorteado);
            LimparConsole();

            JogarNovamente(tentativas);

        }

        void LimparConsole()
        {
            Console.WriteLine("Aperte ENTER para continuar...");
            string continuar = Console.ReadLine();
            Console.Clear();
        }

        void JogarNovamente(string[] tentativas)
        {
            Console.WriteLine("");
            Console.WriteLine("Digite 1 para jogar novamente.");
            Console.WriteLine("Digite 2 para sair do jogo.");

            string response = Console.ReadLine();
            if (response.Equals("1"))
            {
                IniciarJogo (tentativas);
            }
        }
    }
}

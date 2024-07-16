using Exercicios_poo;
using Exercicios_poo.Criatividade;

internal class Program
{
    private static void Main(string[] args)
    {

        /*
        //Exercicio 1
        Console.Write("Digite um numero: ");
        string numeroEscolhido = Console.ReadLine();

        EhPar ehPar = new EhPar();

        Console.WriteLine(ehPar.IdentificarNumero(int.Parse(numeroEscolhido)));

        
         //Exercicio 2
        int[] numerosParaOperacao = new int[2];
        Calculadora calculadora = new Calculadora();

        Console.WriteLine("Bem vindo a calculadora!");
        Console.WriteLine("Escolha a operação que deseja realizar: '*', '/', '+' ou '-' ");
        string operador = Console.ReadLine();

        Console.Write("Digite o primeiro número da operação: ");
        numerosParaOperacao[0] = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número da operação: ");
        numerosParaOperacao[1] = int.Parse(Console.ReadLine());

        double resultado = calculadora.RealizarOperacao(operador, numerosParaOperacao[0], numerosParaOperacao[1]);

        Console.WriteLine("O resultado da " + operador + " entre os numeros " + numerosParaOperacao[0] + " e " + numerosParaOperacao[1] + " é: " + resultado);

        
         //Exercicio 3
        Cassino cassino = new Cassino();

        string[] tentativas = new string[3];
        cassino.IniciarJogo(tentativas);


        */

        //Exercicio 4
        Gerente gerente;
        Vendedor vendedor;
        string opcaoMenu;

        Console.WriteLine("Bem vindo a  sistema de gerenciamento de Funcionários.");
        do
        {
            Console.WriteLine("");
            Console.WriteLine("Digite o número da opção desejada: ");
            Console.WriteLine("");
            Console.WriteLine("1 - Cadastro de funcionário");
            Console.WriteLine("2 - Consulta  de funcionário");
            Console.WriteLine("3 - Finalizar programa");
            opcaoMenu = Console.ReadLine();

            Console.Clear();
            if (opcaoMenu.Equals("1"))
            {
                Console.WriteLine("Cadastro de funcionário");
                Console.WriteLine("Digite 1 para cadastrar um Gerente, 2 para cadastrar Vendedor: ");
                string opcaoCadastro = Console.ReadLine();

                if (opcaoCadastro.Equals("1"))
                {
                    string[] dadosGerente = new string[3];

                    Console.Write("Informe o nome do Gerente: ");
                    dadosGerente[0] = Console.ReadLine();

                    Console.Write("Informe o departamento do Gerente: ");
                    dadosGerente[1] = Console.ReadLine();

                    Console.Write("Informe o RE do Gerente: ");
                    dadosGerente[2] = Console.ReadLine();

                    gerente = new Gerente(dadosGerente[0], dadosGerente[1], dadosGerente[2]);
                    gerente.SetFuncionario(gerente);

                    CadastroRealizado();
                }
                else
                {
                    string[] dadosVendedor = new string[3];

                    Console.Write("Informe o nome do Vendedor: ");
                    dadosVendedor[0] = Console.ReadLine();

                    Console.Write("Informe o departamento do Vendedor: ");
                    dadosVendedor[1] = Console.ReadLine();

                    Console.Write("Informe o RE do Vendedor: ");
                    dadosVendedor[2] = Console.ReadLine();

                    vendedor = new Vendedor(dadosVendedor[0], dadosVendedor[1], dadosVendedor[2]);
                    vendedor.SetFuncionario(vendedor);

                    CadastroRealizado();
                }
            }
            else if (opcaoMenu.Equals("2"))
            {
                
                Console.WriteLine("Digite 1 para consulta simples e 2 para consulta completa");
                string opcaoConsulta = Console.ReadLine();

                if (opcaoConsulta.Equals("1"))
                {
                    Console.WriteLine("Consulta de funcionários.");

                    List<Funcionario> Lista = Funcionario.GetFuncionarios();

                    Console.WriteLine("");
                    foreach (Funcionario funcionario in Lista)
                    {
                        Console.WriteLine(funcionario.ToString());
                    }

                    LimparConsole();
                }

                else if (opcaoConsulta.Equals("2"))
                {
                    string[] dadosUsuario = new string[2];

                    Console.WriteLine("Consulta completa de funcionários.");
                    Console.WriteLine("");

                    Console.Write("Informe o RE do usuário a ser consulado: ");
                    dadosUsuario[0] = Console.ReadLine();

                    Console.Write("Informe o total de dias trabalhados no mês: ");
                    dadosUsuario[1] = Console.ReadLine();

                    List<Funcionario> Lista = Funcionario.GetFuncionarios();

                    Console.WriteLine("");
                    foreach (Funcionario funcionario in Lista)
                    {
                        if (funcionario.GetRe().Equals(dadosUsuario[0]))
                        {
                            Console.WriteLine(funcionario.ToString());
                            Console.WriteLine($"O salário do funcionário {funcionario.GetNome()} é R$: { funcionario.CalcularSalario(int.Parse(dadosUsuario[1]))} ");
                        }
                    }
                    LimparConsole();
                }

            }

        } while (opcaoMenu != "3");

        void LimparConsole()
        {
            Console.WriteLine("");
            Console.Write("Aperte Enter para continuar...");
            Console.ReadLine();
            Console.Clear();
        }

        void CadastroRealizado()
        {
            Console.WriteLine("");
            Console.Write("Cadastro Realizado com Sucesso. Aperte Enter para continuar.");
            Console.ReadLine();
            Console.Clear();
        }





    }

    
}

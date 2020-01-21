using System;

namespace TI_segunda_tentativa
{
    class Program
    {
        static void Main(string[] args)
        {
            string base2, base10 = " ", sair = " ";
            int binario, decimais;
            string opçao;
            do
            {
                Console.WriteLine("               PROGRAMA BÁSICO DE CONVERSÃO DE BASES");
                Console.WriteLine("                  Aluno: André Luiz Mendes Corrêa \n");
                Console.WriteLine("Bem vindo ao programa de conversões de bases. \n");
                Console.WriteLine("Deseja qual tipo de conversão?");
                Console.WriteLine("Para converter de Binario para Decimal, digite 1 e aperte Enter.");
                Console.WriteLine("Para converter de Decimal para Binario, digite 2 e aperte Enter.");
                Console.WriteLine("Para encerrar o programa, digite 3 e aperte Enter.");
                Console.Write("Opção escolhida: ");
                opçao = Console.ReadLine();
                Console.Clear();

                switch (opçao)
                {
                    case "1":
                        do
                        {
                            Console.Write("Insira um numero binario: ");
                            base2 = Console.ReadLine();
                            binario = Convert.ToInt32(base2, 2);
                            Console.WriteLine("A conversão do numero é: " + binario + "\n");
                            Console.WriteLine("Deseja continuar a converter números binarios?");
                            Console.WriteLine("Digite 'Não' para voltar e 'Sim' para continuar.");
                            sair = Console.ReadLine();
                            Console.Clear();
                        } while (sair == "Sim" || sair == "sim" || sair == "SIM");
                        break;

                    case "2":
                        do
                        {
                            Console.Write("Insira um numero decimal: ");
                            decimais = Convert.ToInt32(Console.ReadLine());
                            while (decimais / 2 >= 1)
                            {
                                base10 = Convert.ToString(decimais % 2) + base10;
                                decimais = decimais / 2;
                            }
                            base10 = Convert.ToString(decimais) + base10;
                            Console.Write("A conversão do numero é: " + base10 + "\n");
                            Console.WriteLine("Deseja continuar a converter números decimais?");
                            Console.WriteLine("Digite 'Não' para voltar e 'Sim' para continuar.");
                            sair = Console.ReadLine();
                            Console.Clear();
                        } while (sair == "Sim" || sair == "sim" || sair == "SIM");
                        break;

                    case "3":
                        Console.WriteLine("Obrigado por usar o programa básico de conversões e até a próxima!");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;

                    default:
                            Console.WriteLine("Opção invalida. \n");
                            Console.WriteLine("Deseja sair do programa?");
                            Console.WriteLine("Digite 'Sim' para sair e 'Não' para continuar.");
                            sair = Console.ReadLine();
                            Console.Clear();
                        if(sair == "Sim" || sair == "sim" || sair == "SIM")
                        {
                            Environment.Exit(1);
                        }
                        break;
                }
            } while (opçao != "1" || opçao != "2" || opçao != "3");
            Console.ReadKey();
        }
    }
}

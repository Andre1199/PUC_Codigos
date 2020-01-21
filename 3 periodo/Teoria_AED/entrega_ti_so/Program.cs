using System;
using System.Threading;
using System.IO;

namespace TI_AED_SO
{
    class Program
    {
        public static void ProcessarOsDados(ListaProcesso[] processos)
        {
            Processo p;
            for (int i = 31; i >= 0; i--)
            {
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.Write("|                           ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("PROCESSO PRIORIDADE ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(i);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                              |");
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.WriteLine(processos[i].ToString());
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.Write("|                           ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("EXECUTANDO PROCESSOS... ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                           |");
                Console.WriteLine("--------------------------------------------------------------------------------");
                while (!processos[i].Vazia())
                {
                    p = (Processo)processos[i].Retirar();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Processo em execução: " + p.Nome);
                    Console.ResetColor();
                    if (p.ProcessarDados() > 0)
                    {

                        if (i == 0) processos[i].Inserir(p);
                        if (i != 0)
                        {
                            p.DiminuirPrioridade();
                            processos[i - 1].Inserir(p);
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("O processo " + p.Nome + " sofreu redução de prioridade");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("O processo " + p.Nome + " foi concluido e retirado do escalonador");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine(processos[i].ToString());
                    Thread.Sleep(2500);
                    Console.WriteLine("--------------------------------------------------------------------------------");
                }
                if (i == 0)
                {
                    Console.Write("|                     ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("APERTE ENTER PARA FINALIZAR A SIMULAÇÃO");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("                  | ");
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    Console.ReadKey();
                }
                else
                {
                    Console.Write("|           ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("APERTE ENTER PARA PROCESSAR OS PROCESSOS DE PRIORIDADE ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(i - 1);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("           |");
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    Console.ReadKey();
                }
                Console.Clear();
            }
        }
        static void Main(string[] args)
        {
            ListaProcesso[] processos = new ListaProcesso[33];
            Processo p;

            for (int i = 0; i < processos.Length; i++)
            {
                processos[i] = new ListaProcesso();
            }
            string arq = "dados_AED_SO_TI.txt";
            if (File.Exists(arq))
            {
                string linha;
                string[] aux;
                StreamReader leitura = new StreamReader(arq);
                while (!leitura.EndOfStream)
                {
                    linha = leitura.ReadLine();
                    aux = linha.Split(';');

                    p = new Processo(int.Parse(aux[0]), aux[1], int.Parse(aux[2]), int.Parse(aux[3]));
                    processos[int.Parse(aux[2])].Inserir(p);
                }

                leitura.Close();
            }
            ProcessarOsDados(processos);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("        ____ ____ ____ ____ ____ ____ ____ ____ ____ ");
            Console.WriteLine("       ||S |||i |||m |||u |||l |||a |||ç |||ã |||o ||");
            Console.WriteLine("       ||__|||__|||__|||__|||__|||__|||__|||__|||__||");
            Console.WriteLine(@"       |/__\|/__\|/__\|/__\|/__\|/__\|/__\|/__\|/__\|");
            Console.WriteLine("");
            Console.WriteLine("        ____ ____ ____ ____ ____ ____ ____ ____ ____ ");
            Console.WriteLine("       ||C |||o |||n |||c |||l |||u |||í |||d |||a ||");
            Console.WriteLine("       ||__|||__|||__|||__|||__|||__|||__|||__|||__||");
            Console.WriteLine(@"       |/__\|/__\|/__\|/__\|/__\|/__\|/__\|/__\|/__\|");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n                          Alunos:");
            Console.WriteLine("                    Andre Luiz Mendes");
            Console.WriteLine("                   Pedro Augusto de Melo");
            Console.WriteLine("                    Gabriel Atene Silva");
            Console.ReadKey();
        }
    }
}
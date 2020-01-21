using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        public static char Menu()
        {
            Console.WriteLine("Escolha uma opção para iniciarmos: ");
            Console.WriteLine("\n1- Inserir uma nova data.");
            Console.WriteLine("2- Somar dias a uma data.");
            Console.WriteLine("3- Dizer o dia da data do ano.");
            Console.WriteLine("4- Qual a diferença entre duas datas.");
            Console.WriteLine("5- Imprimir a data.");
            Console.WriteLine("6- Ano é bisexto ou não?");
            Console.WriteLine("7- Encerrar o programa.");

            char opc = Console.ReadKey().KeyChar;
            return opc;
        }

        static Data CriarDatas()
        {
            Console.Clear();
            
            Console.WriteLine("\nInsira o dia: ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInsira o mês: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInsira o ano: ");
            int a = int.Parse(Console.ReadLine());
            Data Ndate = new Data(d, m, a);

            if (Ndate.VerificarData())
            {
                return Ndate;
            }
            else
            {
                Console.WriteLine("A data é invalida.");
                Console.ReadKey();
                Console.Clear();
                return null;
            }         
        }

        static bool VerificarObjeito(Data date)
        {
            if (date == null)
            {
                Console.Clear();
                Console.WriteLine("Crie uma data.");
                Console.ReadKey();
                return false;
            }
            else
                return true;
        }

        static void Main(string[] args)
        {
            Data date = null;
            char opc = Menu();

            while (opc != 6)
            {
                switch (opc)
                {
                    case '1':
                        date = null;
                        GC.Collect();
                        date = CriarDatas();
                        Console.Clear();
                        break;

                    case '2':
                        if (VerificarObjeito(date))
                        {
                            Console.Clear();
                            date.AdicionarDias();
                        }
                        break;

                    case '3':
                        if (VerificarObjeito(date))
                        {
                            Console.Clear();
                            date.DiaAno();
                        }
                        break;

                    case '4':
                        if (VerificarObjeito(date))
                        {
                            Console.Clear();
                            date.DiferençaDias();
                        }
                        break;

                    case '5':
                        if (VerificarObjeito(date))
                        {
                            Console.Clear();
                            date.MostrarData();
                        }
                        break;

                    case '7':
                        Environment.Exit(0);
                        break;

                    case '6':
                        if (VerificarObjeito(date))
                        {
                            if (date.AnoBisexto())
                            {
                                Console.Clear();
                                Console.WriteLine("O ano é bisexto.");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("O ano não é bisexto.");
                                Console.ReadKey();
                            }
                        }
                        break;

                    default:
                        Console.Clear();
                        Console.Write("Opção invalida.");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
                opc = Menu();
            }   
        }
    }
}

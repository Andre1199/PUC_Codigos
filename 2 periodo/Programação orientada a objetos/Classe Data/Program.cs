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
            try
            {
                Console.WriteLine("\nInsira o dia: ");
                int d = int.Parse(Console.ReadLine());
                Console.WriteLine("\nInsira o mês: ");
                int m = int.Parse(Console.ReadLine());
                Console.WriteLine("\nInsira o ano: ");
                int a = int.Parse(Console.ReadLine());
                Data Ndate = new Data(d, m, a);

                if (Ndate.VerificarData())
                {
                    Console.Clear();
                    Console.WriteLine("Data válida.");
                    Console.ReadKey();
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
            catch
            {
                Console.WriteLine("Dado inválido.");
                Console.ReadKey();
                return null;
            }         
        }

        static bool VerificarObjeto(Data date)
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

            while (opc != 8)
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
                        if (VerificarObjeto(date))
                        {
                            Console.Clear();
                            Console.WriteLine("Quantos dias deseja somar a data? ");
                            int n = int.Parse(Console.ReadLine());
                            date.AdicionarDias(n);
                        }
                        break;

                    case '3':
                        if (VerificarObjeto(date))
                        {
                            Console.Clear();
                            Console.WriteLine("Esse é o " + date.DiaAno() + "º dia do ano.");
                            Console.ReadKey();
                        }
                        break;

                    case '4':
                        if (VerificarObjeto(date))
                        {
                            Console.Clear();

                            Console.WriteLine("Qual a data desejada para o calculo? ");
                            Console.WriteLine("\nInsira o dia: ");
                            int numd = int.Parse(Console.ReadLine());
                            Console.WriteLine("\nInsira o mês: ");
                            int numm = int.Parse(Console.ReadLine());
                            Console.WriteLine("\nInsira o ano: ");
                            int numa = int.Parse(Console.ReadLine());

                            Data DataCompare = new Data(numd,numm,numa);
                            if (DataCompare.VerificarData())
                            {
                                int difDias = date.DiferençaDias(DataCompare,date);

                                if (difDias == 0)
                                {
                                    Console.WriteLine("As datas são iguais.");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("A diferença é de " + difDias + " dias entre as duas datas.");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Data inválida.");
                                Console.ReadKey();
                            }
                        }
                        break;

                    case '5':
                        if (VerificarObjeto(date))
                        {
                            Console.Clear();
                            date.MostrarData();
                        }
                        break;

                    case '7':
                        Environment.Exit(0);
                        break;

                    case '6':
                        if (VerificarObjeto(date))
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

using System;
using System.IO;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string leitor;
            StreamReader arq = new StreamReader(@"C:\Users\carrefour\Desktop\André\Dados.txt");
            while ((leitor = arq.ReadLine()) != null)
            {

                Console.WriteLine(leitor);
            }
            arq.Close();
            Console.ReadKey();
        }
    }
}

using System;
using System.IO;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string telefone;

            
            StreamWriter arq = new StreamWriter(@"C:\Users\carrefour\Desktop\André\Dados.txt",true);
            Console.Write("Insirar o seu telefone:");
            telefone = Console.ReadLine();
            arq.Write("Telefone:");
            arq.WriteLine(telefone);

            arq.Close();
            Console.ReadKey();
        }
    }
}

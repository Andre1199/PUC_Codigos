using System;
using System.IO;

namespace Dadospessoais
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, email, rg;
            StreamWriter arq = new StreamWriter(@"C:\Users\carrefour\Desktop\André\Dados.txt");
            Console.Write("Digite o seu nome:");
            nome = (Console.ReadLine());
            arq.Write("Nome:");
            arq.WriteLine(nome);

            Console.Write("Digite o seu email:");
            email = (Console.ReadLine());
            arq.Write("Email:");
            arq.WriteLine(email);

            Console.Write("Digite o seu RG:");
            rg = (Console.ReadLine());
            arq.Write("RG:");
            arq.WriteLine(rg);

            arq.Close();

            Console.ReadKey();
        }
    }
}

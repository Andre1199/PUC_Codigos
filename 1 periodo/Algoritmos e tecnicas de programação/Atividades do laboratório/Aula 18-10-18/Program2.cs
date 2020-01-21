using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[12];
            int posX, posY, soma = 0;
            for (int i=0; i<12; i++)
            {
                Console.Write("Insira um numero: ");
                vet[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            Console.Write("Qual posição deseja acessar?");
            posX = int.Parse(Console.ReadLine());
            Console.Write("E até qual posição?");
            posY = int.Parse(Console.ReadLine());
            for (int j=posX; j<posY; j++)
            {
                soma += vet[j];
            }
            Console.WriteLine("A soma dos numeros nesse intervalo é: "+ soma);
            Console.ReadKey();
        }
    }
}

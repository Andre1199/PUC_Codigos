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
            int idade, soma = 0, m = 0;
            float media;
            int [] vet = new int[100];
            int[] vet2 = new int[100];
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Insira a idade desejada: ");
                idade = int.Parse(Console.ReadLine());
                for (int j = 0; j < vet.Length; j++)
                {
                    vet[j] = idade;
                    soma += idade;
                }
            } 
            media = soma / 100;
            for(int l = 0; l < vet.Length; l++)
            {
                 if (vet[l] > media)
                 {
                        vet2[m] = vet[l];
                        m++;
                 }
            }
            Console.Write("A media de idades é: " + media);
            Console.Write("E essas sao as idades maiores que a media: " + vet2);
            Console.ReadKey();
        }
    }
}

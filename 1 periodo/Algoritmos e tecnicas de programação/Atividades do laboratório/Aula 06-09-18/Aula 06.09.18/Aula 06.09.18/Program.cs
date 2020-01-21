using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, soma = 0;
            int i = 0; 

            while (i < 10)
            {
                i++;
                Console.Write("Insira um numero inteiro:");
                num = int.Parse(Console.ReadLine ());

                  if (num < 20)
                {
                    soma = soma + num;
                }
            }

            Console.Write("A soma é igual a:" + soma);

            Console.ReadKey();
        }
    }
}

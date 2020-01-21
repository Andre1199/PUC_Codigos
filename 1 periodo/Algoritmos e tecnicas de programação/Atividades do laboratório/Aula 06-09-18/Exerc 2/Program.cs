using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, par =0, impar =0;
            int i = 0; 

            while (i < 10)
            {
                i++;
                Console.Write("Insira um numero inteiro:");
                num = int.Parse(Console.ReadLine ());

                  if (num%2 != 0)
                {
                    impar = impar + num;
                }
                  else
                {
                    par = par + num;
                }
            }

            Console.Write("A soma é igual a:" + par +" e " +impar);

            Console.ReadKey();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_3
{
    class Program
    {
        static void Main(string[] args)
        {
           double quadrado, x = 1;

            while (x>=1 && x<=20)
            {
                x++;

                quadrado = Math.Pow(x, 2);
                Console.WriteLine("Os quadrados entre 1 e 20 sao:"+ quadrado);
            }
            Console.ReadKey();
        }
    }
}

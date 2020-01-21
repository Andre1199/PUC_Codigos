using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabuada, num, ate;
            int i = 0;

            Console.Write("Insira um numero:");
            num = int.Parse(Console.ReadLine());
            Console.Write("Até que numero?");
            ate = int.Parse(Console.ReadLine());

            while (i != ate)
            {
                i++;

                tabuada = num* i;
                Console.WriteLine(tabuada);
            }
            Console.ReadKey();
        }
    }
}

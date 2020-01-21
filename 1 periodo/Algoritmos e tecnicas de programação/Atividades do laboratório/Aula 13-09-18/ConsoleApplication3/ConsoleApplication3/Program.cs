using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,serie, soma=0 ;
            Console.WriteLine("digite um numerador");
            num = int.Parse(Console.ReadLine());
            for(int i =1;i!= 20; i++)
            {
                serie = num / i;
                soma = +serie;

            }
            Console.WriteLine("a soma da serie e igual" + soma);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;

            do
            {
                cont++;
                if(cont % 2 == 0)
                {
                    Console.Write(cont + "; ");
                }
            }
            while (cont != 100);

            Console.ReadKey();
        }
    }
}

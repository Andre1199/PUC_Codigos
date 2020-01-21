using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0, multi=0;

            while (multi < 145)

            {
                cont++;

                multi = 5 * cont;
                Console.Write(multi + " ");
            }

            Console.ReadKey();
        }
    }
}

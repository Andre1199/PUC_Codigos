using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double bruto, segSocial, irs, liquido;

            Console.Write("Salário bruto:");
            bruto = double.Parse(Console.ReadLine());

            segSocial = bruto * 0.2;
            if (bruto < 500) 
            {
                irs = 0;
            }
            else if (bruto >= 500 && bruto < 1000) 
            { 
            irs = bruto * 0.12;
            }
            else if (bruto >= 1000 && bruto < 1500) 
            {
                irs = bruto * 0.15;
            }
            else
            {
                irs = bruto * 0.18;
            }

            liquido = bruto - segSocial - irs;

            Console.WriteLine("Salario liquido:" + liquido);
            Console.ReadKey();

        }
    }
}

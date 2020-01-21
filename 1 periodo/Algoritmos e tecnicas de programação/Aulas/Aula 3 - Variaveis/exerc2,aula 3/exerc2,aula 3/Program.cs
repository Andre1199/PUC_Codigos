using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc2_aula_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseMaior, baseMenor, altura, area;
            Console.Write("Escreva a base maior do trapezio:");
            baseMaior = double.Parse(Console.ReadLine());
            Console.Write("Escreva a base menor do trapezio");
            baseMenor = double.Parse(Console.ReadLine());
            Console.Write("Escreva a altura do trapezio:");
            altura = double.Parse(Console.ReadLine());

            if (baseMaior <= 0 || baseMenor <= 0 || altura <= 0)
            {
                Console.Write("Impossivel de calcular");
            }
            else
            {
                area = ((baseMaior + baseMenor) * altura) / 2;
                Console.Write("A area do trapezio é igual a:"+area);
            }
            Console.ReadKey();
        }
    }
}
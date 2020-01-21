using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaraçao de variaveis
            int comprime, altura, area;
            //Obtençao de dados
            Console.Write("Digite o comprimento:");
            comprime = int.Parse(Console.ReadLine());
            Console.Write("Digite a altura:");
            altura = int.Parse(Console.ReadLine());
            //Calculo
            area = comprime * altura;
            //Resultado
            Console.WriteLine("A area é:" + area);
            Console.ReadKey();


        }
    }
}

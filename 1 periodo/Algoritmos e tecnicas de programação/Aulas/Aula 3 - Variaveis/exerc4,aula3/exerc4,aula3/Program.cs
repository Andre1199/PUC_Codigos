using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc4_aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double percentB, percentN, percentV, eleitores, votosB, votosN, votosV;

            Console.Write("Insira o numero de eleitores na cidade:");
            eleitores = int.Parse(Console.ReadLine());

            Console.Write("Insira o numero de votos brancos registrados:");
            votosB = double.Parse(Console.ReadLine());

            Console.Write("Insira o numero de votos nulos registrados:");
            votosN = double.Parse(Console.ReadLine());

            Console.Write("Insira o numero de votos validos registrados:");
            votosV = double.Parse(Console.ReadLine());

            percentB = votosB / eleitores * 100;
            percentN = votosN / eleitores * 100;
            percentV = votosV / eleitores * 100;

            Console.WriteLine("");
            Console.Write("O percentual, em relaçao ao total, de votos brancos é de "+percentB+"%, o percentual de votos nulos é de "+percentN+"% e o percentual de votos validos é de "+percentV+"%.");

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double qtdHoras, valorPorhr, salario;
            string numFunc;
            Console.Write("Insira o nº/registro do funcionario:");
            numFunc = Console.ReadLine();
            Console.Write("Insira a quantidade de horas trabalhadas:");
            qtdHoras = double.Parse(Console.ReadLine());
            Console.Write("Insira o valor pago por hora trabalhada:");
            valorPorhr = double.Parse(Console.ReadLine());
            salario = valorPorhr * qtdHoras;
            Console.Write("O funcionario "+numFunc+" recebe R${0} de salario.",salario);
            Console.ReadKey();
        }
    }
}

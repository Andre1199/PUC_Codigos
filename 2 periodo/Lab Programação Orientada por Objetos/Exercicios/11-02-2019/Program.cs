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
            Console.WriteLine("Informe o nome da pessoa: ");
            string n = Console.ReadLine();
            int i=new int();
            Pessoa p1 = new Pessoa(n,new Data(12, 10, 1994), 24);
            Pessoa p2 = new Pessoa("Maria", new Data(15, 11, 1998), 24);
            Pessoa p3 = new Pessoa(null,null,0);

            Console.WriteLine("\n"+i);
            Console.WriteLine(p1.nome + " " + p1.data + " " + p1.idade);
            Console.WriteLine(p2.nome + " " + p2.data + " " + p2.idade);
            Console.WriteLine(p3.nome + " " + p3.data + " " + p3.idade);
            Console.ReadKey();
        }
    }
}

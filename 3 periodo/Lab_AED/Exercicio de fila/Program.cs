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
            Cliente cli;
            FilaCliente filaLanchonete;

            filaLanchonete = new FilaCliente();
            cli = new Cliente("Maria", new DateTime(2018, 4, 14, 10, 41, 10));
            filaLanchonete.enfileirar(cli);
            cli = new Cliente("João", new DateTime(2018, 4, 14, 10, 43, 25));
            filaLanchonete.enfileirar(cli);
            cli = new Cliente("Ana", new DateTime(2018, 4, 14, 10, 44, 17));
            filaLanchonete.enfileirar(cli);
            cli = new Cliente("Andre", new DateTime(2018, 4, 14, 10, 44, 17));
            filaLanchonete.enfileirar(cli);
            cli = new Cliente("Gabriel", new DateTime(2018, 4, 14, 10, 44, 17));
            filaLanchonete.enfileirar(cli);

            
            cli = filaLanchonete.desenfileirar();
            Console.WriteLine("O cliente {0} foi atendido.", cli.nome); // Maria
            Console.WriteLine(filaLanchonete.obterPrimeiro().nome);
            Console.WriteLine();
            Console.WriteLine(filaLanchonete.obterNumeroClientes());
            Console.WriteLine();
            filaLanchonete.imprimir();
            Console.WriteLine();
            filaLanchonete.dividir().imprimir();
            Console.WriteLine();
            filaLanchonete.imprimir();
            filaLanchonete.copiar().imprimir();
            Console.ReadKey();
        }
    }
}
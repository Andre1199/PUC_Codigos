using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta_Corrente cc;
            ListaContaCorrente lista, listaCopia;
            lista = new ListaContaCorrente();
            cc = new Conta_Corrente("Ana", 36, 707, 500.00);
            lista.adicionar(cc);
            cc = new Conta_Corrente("João", 45, 801, 500.00);
            lista.adicionar(cc);
            cc = new Conta_Corrente("José", 71, 917, 1000.00);
            lista.adicionar(cc);
            Console.WriteLine("Contas-correntes presentes na lista encadeada:");
            lista.imprime(); // Titular: Ana, agência: 36, número da conta-corrente: 707 , saldo: 500.00
            // Titular: João, agência: 45, número daconta-corrente: 801, saldo: 500.00
            // Titular: José, agência: 71, número daconta-corrente: 917, saldo: 1000.00
            Console.WriteLine("A instituição financeira apresenta {0} contas-correntes.", lista.obterNumeroElementos());
            // 3 contas correntes.
            lista.trocarElementos(707, 801);
            Console.WriteLine("Contas-correntes presentes na lista encadeada:");
            lista.imprime();
            // Titular: João, agência: 45, número daconta-corrente: 801, saldo: 500.00
            // Titular: Ana, agência: 36, número da conta-corrente: 707, saldo: 500.00
            // Titular: José, agência: 71, número daconta-corrente: 917, saldo: 1000.00
            lista.trocarElementos(917, 801);
            Console.WriteLine("Contas-correntes presentes na lista encadeada:");
            lista.imprime(); // Titular: José, agência: 71, número daconta-corrente: 917, saldo: 1000.00
            // Titular: Ana, agência: 36, número da conta-corrente: 707, saldo: 500.00
            // Titular: João, agência: 45, número daconta-corrente: 801, saldo: 500.00
            listaCopia = lista.copiar();Console.WriteLine("Contas-correntes presentes na cópia da lista encadeada:");
            listaCopia.imprime();
            // Titular: José, agência: 71, número daconta-corrente: 917, saldo: 1000.00
            // Titular: Ana, agência: 36, número da conta-corrente: 707, saldo: 500.00
            // Titular: João, agência: 45, número daconta-corrente: 801, saldo: 500.00
            lista.eliminarElementosPosicoesPares();Console.WriteLine("Contas-correntes presentes na lista encadeada:");
            // Titular: José, agência: 71, número da conta-corrente: 917, saldo: 1000.00
            // Titular: João, agência: 45, número daconta-corrente: 801, saldo: 500.00
            lista.trocarElementos(801, 917);
            Console.WriteLine("Contas-correntes presentes na lista encadeada:");lista.imprime();
        }
    }
}

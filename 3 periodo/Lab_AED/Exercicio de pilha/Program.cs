using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha minhaPilha = new Pilha();
            Elemento aux;

            aux = new Elemento('l');
            minhaPilha.empilhar(aux);
            aux = new Elemento('a');
            minhaPilha.empilhar(aux);
            aux = new Elemento('b');
            minhaPilha.empilhar(aux);

            minhaPilha.Imprimir();

            Console.ReadKey();
        }
    }
}

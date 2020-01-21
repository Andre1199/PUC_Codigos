using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exerc1
{
    class Elemento
    {
        public char letra;    
        public Elemento proximo;

        public Elemento(char l)
        {
            letra = l;
            proximo = null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Pessoa
    {
        public string nome;
        public Data data;
        public int idade;

        public Pessoa(string n, Data d, int i)
        {
            this.nome = n;
            this.data = d;
            this.idade = i;
        }
    }
}

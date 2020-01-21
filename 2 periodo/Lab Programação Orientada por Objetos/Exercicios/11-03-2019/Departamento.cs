using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Departamento
    {
        private int codigo;
        public int _codigo
        {
            get { return codigo; }
            set {if (value >= 0)
                    codigo = value;
                 else
                    codigo = 0;
                }
        }

        private string nome;
        public string _nome
        {
            get { return nome; }
            set {if (value == null)
                    nome = "Ninguem";
                 else if (value == " ")
                    nome = "Ninguem";
                 else
                    nome = value;
                }
        }

        public Departamento(int cod, string name)
        {
            this._codigo = cod;
            this._nome = name;
        }

        public string toString()
        {
            return this._codigo + " " + this._nome;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_AED
{
    class Cliente
    {
        private string _nome;
        public string nomeCliente
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private string _cpf;
        public string cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

        public Cliente(string nome, string cpf)
        {
            this._nome = nome;
            this._cpf = cpf;
        }
    }
}
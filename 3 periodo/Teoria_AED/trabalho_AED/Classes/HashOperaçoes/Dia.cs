using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_AED.HashOperaçoes
{
    class Dia
    {
        private ListaDeOperacao[] _dia;
        public ListaDeOperacao[] dia
        {
            get { return _dia; }
            set { _dia = value; }
        }
        public Dia()
        {
            _dia = new ListaDeOperacao[32];
            for (int i = 0; i < _dia.Length; i++)
            {
                _dia[i] = new ListaDeOperacao();
            }
        }
    }
}

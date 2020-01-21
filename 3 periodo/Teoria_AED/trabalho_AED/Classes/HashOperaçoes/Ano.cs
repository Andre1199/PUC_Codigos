using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_AED.HashOperaçoes
{
    class Ano
    {
        private Mes[] _ano;
        public Mes[] ano
        {
            get { return _ano; }
            set { _ano = value; }
        }
        public Ano()
        {
            _ano = new Mes[3];
            for (int i = 0; i < _ano.Length; i++)
            {
                _ano[i] = new Mes();
            }
        }
    }
}

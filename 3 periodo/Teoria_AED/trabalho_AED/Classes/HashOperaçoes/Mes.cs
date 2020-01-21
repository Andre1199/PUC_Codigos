using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_AED.HashOperaçoes
{
    class Mes
    {
        private Dia[] _mes;
        public Dia[] mes
        {
            get { return _mes; }
            set { _mes = value; }
        }
        public Mes()
        {
            _mes = new Dia[13];
            for (int i = 0; i < _mes.Length; i++)
            {
                _mes[i] = new Dia();
            }
        }
    }
}

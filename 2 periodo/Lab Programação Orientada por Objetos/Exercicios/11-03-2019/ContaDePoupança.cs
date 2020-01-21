using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class ContaDePoupança
    {
        private static float taxaDeJurosAnual;
        public static float _taxaDeJurosAnual
        {
            get { return taxaDeJurosAnual; }
            set { taxaDeJurosAnual = value; }
        }

        private float saldoPoupança;
        public float _saldoPoupança
        {
            get { return saldoPoupança; }
            set { saldoPoupança = value; }
        }

        public float CalcularJurosMensal()
        {
            float jurosMensal = 0;

            jurosMensal = (this._saldoPoupança * ContaDePoupança._taxaDeJurosAnual)/12;

            _saldoPoupança += jurosMensal; 

            return jurosMensal;
        }

        public static void AlterarTaxaDeJuros(float nTaxa)
        {
            ContaDePoupança._taxaDeJurosAnual = nTaxa;
        }
    }
}

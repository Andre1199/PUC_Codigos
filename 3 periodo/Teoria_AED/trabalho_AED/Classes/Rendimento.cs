using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_AED
{
    class Rendimento : Operacao
    {
        public Rendimento(DateTime dataDaOp, double valorDaOp, int numCo) : base(dataDaOp, valorDaOp, numCo) { }

        public double RendimentoAnual()
        {
            return this.valor = this.valor + ((valor * 1) / 100); ;
        }
    }
}
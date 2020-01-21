using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_AED
{
    class Saque : Operacao
    {
        public Saque(DateTime dataDaOp, double valorDaOp,int numCo) : base(dataDaOp, valorDaOp, numCo) { }
        public override void OperacaoPrincipal(double valorTrans)
        {
            this.valor -= valorTrans;
        }
    }
}
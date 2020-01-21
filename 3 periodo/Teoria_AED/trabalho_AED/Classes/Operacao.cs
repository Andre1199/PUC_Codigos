using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_AED
{
    class Operacao
    {
        public Operacao proximo;

        private DateTime _data;
        public DateTime data
        {
            get { return _data; }
            set { _data = value; }
        }

        private double _valor;
        public double valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        private int _numConta;
        public int numConta
        {
            get { return _numConta; }
            set { _numConta = value; }
        }

        public Operacao()
        {

        }

        public Operacao(DateTime dataDaOp, double valorDaOp,int numCo)
        {
            this._data = dataDaOp;
            this._valor = valorDaOp;
            this.numConta = numCo;
        }

        public virtual void OperacaoPrincipal(double valor)
        {
        }
    }
}
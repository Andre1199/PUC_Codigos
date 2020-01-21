using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_AED
{
    class ContaBancaria
    {
        private int _numeroDaConta;
        public int numConta
        {
            get { return _numeroDaConta; }
            set { _numeroDaConta = value; }
        }

        private double _saldo;
        public double saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        private string _cpfCliente;
        public string cpfCliente
        {
            get { return _cpfCliente; }
            set { _cpfCliente = value; }
        }


        public ContaBancaria(int conta, double saldoIni,string cpfcli)
        {
            this._numeroDaConta = conta;
            this._saldo = saldoIni;
            this._cpfCliente = cpfcli;
        }

        public void Sacar(double valorTrans)
        {
            this.saldo -= valorTrans;
        }
        public void Deposita(double valorTrans)
        {
            this.saldo += valorTrans;
        }
        public void Rendimento()
        {
            this.saldo = this.saldo + ((saldo * 1) / 100);
        }
    }
}
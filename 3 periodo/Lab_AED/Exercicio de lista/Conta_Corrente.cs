using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Conta_Corrente
    {
        private string _nome;
        public string nomeDoTitula
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private int _numeroAg;
        public int numeroDaAgencia
        {
            get { return _numeroAg; }
            set { _numeroAg = value; }
        }

        private int _numeroConta;
        public int numeroDaConta
        {
            get { return _numeroConta; }
            set { _numeroConta = value; }
        }

        private double _saldo;
        public double saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        private Conta_Corrente _proximo;
        public Conta_Corrente proximo
        {
            get { return _proximo; }
            set { _proximo = value; }
        }


        /// <summary>
        /// Construtor Conta Corrente  
        /// </summary>
        /// <param name="nome">nome do titular</param>
        /// <param name="ag">numero da agencia do titular</param>
        /// <param name="numCC">numero da conta corrente</param>
        /// <param name="saldoInicial">saldo atual</param>
        public Conta_Corrente(string nome, int ag, int numCC, double saldoInicial)
        {
            nomeDoTitula = nome;
            numeroDaAgencia = ag;
            numeroDaConta = numCC;
            saldo = saldoInicial;
        }

        /// <summary>
        /// Metodo para depositar credito a conta 
        /// </summary>
        /// <param name="credito">valor a ser depositado</param>
        public void depositar(double credito)
        {
            if (credito>0)
            {
                saldo = saldo + credito;
            }
        }

        /// <summary>
        /// Metodo obter saldo atual
        /// </summary>
        /// <returns>saldo</returns>
        public double obterSaldo()
        {
            return saldo;
        }

        /// <summary>
        /// Metodo para sacar dinheiro
        /// </summary>
        /// <param name="quantia">quantia desejada para sacar</param>
        public void sacar(double quantia)
        {
            if (quantia> 0 || saldo >= quantia)
            {
                saldo = saldo - quantia;
            }
        }

    }
}

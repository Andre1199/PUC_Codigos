using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class ListaContaCorrente
    {
        private Conta_Corrente primeiro; // referência a conta corrente que está anterior a conta da lista.
        private Conta_Corrente ultima;   // referência a conta corrente que é o atual da lista.

        public ListaContaCorrente()
        {
            this.ultima = this.primeiro;
            this.primeiro = this.ultima;
            this.ultima.proximo = this.ultima;
        }
        public void adicionar(Conta_Corrente cc)
        {
            if (this.listaVazia()) primeiro.proximo = cc;

            else ultima.proximo = cc;

            ultima = cc;
        }
        public Conta_Corrente retirar(int numContaCorrente)
        {
            Conta_Corrente aux = this.primeiro.proximo;
            Conta_Corrente aux2;
            while (aux != null)
            {
                if(aux.proximo.numeroDaConta == numContaCorrente)
                {
                    aux2 = aux.proximo;
                    aux.proximo = aux2.proximo;
                    return aux2;
                }
                aux = aux.proximo;
            }
            return null;
        }
        public Conta_Corrente buscar(int numContaCorrente)
        {
            int posAux = 0;
            Conta_Corrente aux = this.primeiro.proximo;

            while ((aux != null))
            {
                if(aux.numeroDaConta == numContaCorrente)
                {
                    return aux;
                } 
                aux = aux.proximo;
                posAux++;
            }
            return null;
        }
        public bool listaVazia()
        {
            if (primeiro == ultima) return true;

            else return false;
        }
        public void imprime()
        {
            Conta_Corrente aux = this.primeiro.proximo;

            while ((aux != null))
            {
                Console.WriteLine(aux.nomeDoTitula +" | "+ aux.numeroDaConta + " | " + aux.numeroDaAgencia + " | " + aux.obterSaldo());
                aux = aux.proximo;
            }
        }
        public void depositar(int numContaCorrente, double credito)
        {
            Conta_Corrente conta = this.buscar(numContaCorrente);
            conta.depositar(credito);
        }
        public void sacar(int numContaCorrente, double quantia)
        {
            Conta_Corrente conta = this.buscar(numContaCorrente);
            conta.sacar(quantia);
        }
        public Conta_Corrente obterCCMaiorSaldo()
        {
            if (this.listaVazia())
            {
                return null;
            }
            else
            {
                Conta_Corrente aux = this.primeiro.proximo;
                Conta_Corrente maior = aux;
                while (aux != null)
                {
                    if (aux.saldo> maior.saldo)
                    {
                        maior = aux;
                    }
                    aux = aux.proximo;
                }
                return maior;
            }
        }
        public void eliminarUltimoElemento()
        {
            Conta_Corrente aux = this.primeiro.proximo;
            while (aux != null)
            {
                if (aux.proximo == ultima)
                {
                    aux = ultima;
                }
                aux = aux.proximo;
            }
        }
        public void concatenar(ListaContaCorrente lista)
        {
            Conta_Corrente aux = lista.primeiro.proximo;
            while (aux != null)
            {
                this.ultima.proximo = aux;
                aux = ultima;
                aux = aux.proximo;
            }
        }
    }

}

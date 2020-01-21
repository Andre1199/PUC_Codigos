using System;

namespace ConsoleApp1
{
    class Program
    {
        public struct CartaoValeTransporte
        {
            public int numero; // número identificador do cartão vale-transporte.
            private double saldo; // saldo do cartão vale-transporte.
            private Boolean bloqueado; // indica se o cartão vale-transporte está desbloqueado, e, portanto, pode ser utilizado; ou não.

            public CartaoValeTransporte(int num, double saldoInicial){
                this.numero = num;
                this.saldo = saldoInicial;
                this.bloqueado = false;
            }

            public void carregar(double credito){
                if ((bloqueado==false) && (credito > 0)) this.saldo += credito;
            }
            public double obterSaldoAtual(){
                return this.saldo;
            }
            public void pagar(double tarifa){
                if ((bloqueado==false) && (tarifa > 0) && (saldo >= tarifa)) saldo -= tarifa;
            }
            public void bloquear(CartaoValeTransporte destino){
                destino.carregar(obterSaldoAtual());
                this.bloqueado = true;
                this.saldo = 0;
            }
        }

        static void Main(string[] args)
        {
            CartaoValeTransporte cartao1, cartao2;

            cartao1 = new CartaoValeTransporte(21074, 50.00);
            Console.WriteLine("Saldo atual do cartão vale-transporte 1: R${0}", cartao1.obterSaldoAtual()); // R$ 50,00 
            cartao1.pagar(2.80);
            Console.WriteLine("Saldo atual do cartão vale-transporte 1: R${0}", cartao1.obterSaldoAtual()); // R$ 47,20 
            cartao1.pagar(1.40);
            Console.WriteLine("Saldo atual do cartão vale-transporte 1: R${0}", cartao1.obterSaldoAtual()); // R$ 45,80 
            cartao1.carregar(5.00);
            Console.WriteLine("Saldo atual do cartão vale-transporte 1: R${0}", cartao1.obterSaldoAtual()); // R$ 50,80 
            cartao2 = new CartaoValeTransporte(390176, 25.00);
            Console.WriteLine("Saldo atual do cartão vale-transporte 2: R${0}", cartao2.obterSaldoAtual()); // R$ 25,00 
            cartao1.bloquear(cartao2);
            Console.WriteLine("Saldo atual do cartão vale-transporte 1: R${0}", cartao1.obterSaldoAtual()); // R$ 0,00
            //Ultimo saldo está dando errado//
            Console.WriteLine("Saldo atual do cartão vale-transporte 2: R${0}", cartao2.obterSaldoAtual()); // R$ 75,80
            Console.ReadKey();
        }
    }
}
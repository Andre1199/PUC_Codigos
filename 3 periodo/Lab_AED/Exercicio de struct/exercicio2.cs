using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExerciciosAEDLab_2_
{
    class Program
    {
        struct Conta
        {
            public String titular; // nome do titular da conta
            public int agencia; // número da agência da conta
            public int numConta; // número da conta
            private int tipoConta; // indica o tipo da conta: conta-corrente,poupança, investimento
            private double saldoBruto; // saldo atual da conta
            public Conta(String nome, int ag, int numC, int tipo, double saldoInicial)
            {
                this.titular = nome;
                this.agencia = ag;
                this.numConta = numC;
                this.tipoConta = tipo;
                this.saldoBruto = saldoInicial;
            }
            public double obterSaldo()
            {
                if (this.tipoConta == 1)
                {
                    return this.saldoBruto;
                }
                else if (this.tipoConta == 2)
                {
                    return (((this.saldoBruto * 0.5) / 100) * this.saldoBruto);
                }
                else
                {
                    return ((((this.saldoBruto * 0.65) / 100) * this.saldoBruto) - ((this.saldoBruto * 15) / 100));
                }
            }
            public void depositar(double credito)
            {
                if (credito > 0)
                {
                    this.saldoBruto = credito;
                }
            }
            public void sacar(double quantia)
            {
                if (quantia <= this.saldoBruto)
                {
                    this.saldoBruto = this.saldoBruto - quantia;
                }
            }
            public static Conta[] LerArquivodeContas()
            {
                string line;
                string[] contas;
                Conta[] VetContas = new Conta[1000000];
                int i = 0;

                StreamReader file = new StreamReader(@"eleitorescompleto.txt");

                while ((line = file.ReadLine()) != null)
                {

                    contas = line.Split(';');

                    VetContas[i] = new Conta(contas[0], int.Parse(contas[1]), int.Parse(contas[2]), int.Parse(contas[3]), Convert.ToDouble(contas[4]));
                    i++;
                }

                return VetContas;
            }
        }
        
        static void Main(string[] args)
        {


        }
    }
}

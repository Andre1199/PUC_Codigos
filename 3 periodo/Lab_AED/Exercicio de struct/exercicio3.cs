using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosAEDLab3
{
    class Program
    {
        struct Pessoa
        {
            public string nome; // nome da pessoa
            public DateTime dataNascimento; // data de nascimento da pessoa
            public double peso; // peso da pessoa
            private double altura; // altura da pessoa
            
            public Pessoa(string nom, DateTime dataNasc, double pes, double alt)
            {
                this.nome = nom;
                this.dataNascimento = dataNasc;
                this.peso = pes;
                this.altura = alt;
            }
            public int IdadeAtual()
            {
                DateTime dataatual = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                return (dataatual - this.dataNascimento);
            }
            public double IMC()
            {
                return (this.peso / (this.altura * this.altura));
            }
        }
        static void Main(string[] args)
        {
        }
    }
}

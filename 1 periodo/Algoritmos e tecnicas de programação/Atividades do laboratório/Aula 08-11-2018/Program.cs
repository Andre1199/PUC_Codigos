using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        struct sAluno
        {
            public string nome;
            public int ID;
            public int[] notas;
        }
        public int SomaNotas(int [] notas)
        {
            int soma = 0;
            for (int i=0; i<notas.Length; i++)
            {
                soma += notas[i];
            }
            return soma; 
        }
        public int MaiorNota(int [] notas)
        {
            int maior = int.MinValue;
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] > maior)
                {
                    maior = notas[i];
                }
            }
            return maior;
        }
        public void PrintNotas(Aluno[] alu)
        {
            for(int i = 0; i < alu.Length; i++)
            {
                Console.WriteLine(alu[i].SomarNotas());
            }
        }
        static void Main(string[] args)
        {
            sAluno [] aluno = new sAluno [3];
            //objeto aluno
            Aluno objAluno = new Aluno(4);
            Console.WriteLine(objAluno.SomarNotas());
            Console.ReadKey();
        }
    }
}

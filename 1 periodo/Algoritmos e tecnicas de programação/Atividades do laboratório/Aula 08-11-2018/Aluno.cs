using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Aluno
    {
        public string nome;
        public int ID;
        public int[] notas;

        public Aluno(int valor)
        {
            nome = " ";
            ID = valor;
            notas = new int[3];
            notas[0] = 1;
            notas[1] = 2;
            notas[2] = 3;
        }
        public int SomarNotas()
        {
            int soma = 0;
            for (int i = 0; i < notas.Length;i++)
            {
                soma = notas[i] + soma;
            }
            return soma;
       }
    }
}

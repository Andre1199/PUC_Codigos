using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercTeor1
{
    class Aluno
    {
        public Serie anoSerie;
        public int[] matricAlunos;
        public Notas notasAluno;

        public float notasTotalAluno(int posAluno, float [,] vetorNotas )
        {
            float somaNotas = 0;

            for (int i = posAluno; i == posAluno; i++)
            {
                for (int j = 0; j <= vetorNotas.GetLength(0); j++)
                {
                    somaNotas += vetorNotas[posAluno, j];
                }
            }
            return somaNotas;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercTeor1
{
    class Turma
    {

        public float mediaDaTurma(float [,] notasAlunos)
        {
            float mediaT = 0;
            float somaMedia = 0;

            for (int i = 0; i < notasAlunos.GetLength(0); i++)
            {
                for (int j = 0; j < notasAlunos.GetLength(1); j++)
                {
                    somaMedia += notasAlunos[i, j];
                }
            }

            mediaT = somaMedia / (qtdAlunos(notasAlunos));

            return mediaT;
        }
        public int qtdAlunos(float[,] notasAlunos)
        {
            int cont = 0;

            for (int i = 0; i < notasAlunos.GetLength(0); i++)
            {
                    cont++;
            }

            return cont;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercTeor1
{
    class Prova
    {
        public string nomeMateria;
        public Notas notasAlunos;

        public void mediaDaProva(int qual, float [,] notasAlunos)
        {
            float somaProva = 0;
            for (int i = qual; i == qual; i++)
            {
                for (int j = 0; j <= notasAlunos.GetLength(0); j++)
                {
                    somaProva += notasAlunos[qual, j];
                }
            }
            Console.WriteLine(somaProva);
            Console.ReadKey();
        }
    }
}

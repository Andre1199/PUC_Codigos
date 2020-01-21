using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercTeor1
{
    class Program
    {
        static void Main(string[] args)
        {
            Turma a1 = new Turma();
            Prova p1 = new Prova();
            Console.WriteLine(a1.mediaDaTurma(p1.notasAlunos));
            Console.ReadKey();
        }
    }
}

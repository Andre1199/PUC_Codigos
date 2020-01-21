using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdAlun = 0, aluno = 0, qtdNota = 0;
            double mediaSala = 0;
            double nota1, nota2, nota3, somaNotaAluno, mediaAluno, mediaTurma;

            Console.Write("Insira a qtd de alunos:");
            qtdAlun = int.Parse(Console.ReadLine());

            do
            {
                aluno++;
                Console.Write("Insira a primeira nota do aluno {0}:", aluno);
                nota1 = int.Parse(Console.ReadLine());
                qtdNota++;
                Console.Write("Insira a segunda nota do aluno {0}:", aluno);
                nota2 = int.Parse(Console.ReadLine());
                qtdNota++;
                Console.Write("Insira a terceira nota do aluno {0}:", aluno);
                nota3 = int.Parse(Console.ReadLine());
                qtdNota++;

                somaNotaAluno = nota1 + nota2 + nota3;
                mediaAluno = somaNotaAluno / 3;
                Console.WriteLine("A media do aluno " + aluno + " é:" + mediaAluno);
                mediaSala = mediaSala + somaNotaAluno;
            } while (aluno != qtdAlun);

            mediaTurma = mediaSala / qtdNota;
            Console.Write("A media da sala é igual a:" + mediaTurma);
            Console.ReadKey();
        }
    }
}

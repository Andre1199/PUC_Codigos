using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static float CalcMedia (int pos, ref float [,] matriz)
        {
            float soma = 0;
            for (int i = 0; i < matriz.GetLength(1); i++)
            {
                soma += matriz[pos, i];
            }
            
            return (soma/matriz.GetLength(1));
        }
       
        static void ApresentaçaoDeResults (ref float [,] matriz, ref string [] vetor)
        {
            for(int i=0; i<15; i++)
            {
                Console.Write(vetor[i]);
                Console.Write("A media é: " + CalcMedia(i, ref matriz));
            }
        }
        static void Main(string[] args)
        {
            float[,] matNotas = new float [15, 5];
            string[] nomes = new string [15];
            float  somaClasse = 0;
            float[] mediaArit = new float[15];
            for (int i = 0; i < matNotas.GetLength(0); i++)
            {
                Console.Write("Insira o nome do aluno: ");
                nomes[i] = Console.ReadLine();

                for (int j = 0; j < matNotas.GetLength(1); j++)
                {
                    Console.Write("Insira a nota da prova do aluno: ");
                    matNotas[i,j] = float.Parse(Console.ReadLine());
                    somaClasse += matNotas[i, j];                
                }
                Console.Clear();
            }

            ApresentaçaoDeResults(ref matNotas);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = 0, c = 0;
            // Pode utilizar uma variavel n = 0 para ficar mais didatico.

            Console.Write("Insira quantas linhas você quer:");
            l = int.Parse(Console.ReadLine());
            Console.Write("Insira quantas colunas você quer:");
            c = int.Parse(Console.ReadLine());

            int[,] num = new int[l, c];

            //Use um for para atribuir um novo número a cada posiçao nova, enquanto o numero de linhas ñ for igual ao digitado.
            for (int i = 1; i <= l; i++)
            {
                //Um outro for para atribuir um novo numero a cada posiçao de coluna, enquanto o numero for diferente do digitado.
                for (int j = 1; j <= c; j++)
                {
                    //Para a tabuada ñ começar no 0, utilize [(i-1),(j-1)], pois assim i e j começam com 1, mas suas posiçoes começam com 0.
                    num[(i-1), (j-1)] = i*j;
                }            
            }

            //Um for para imprimir a linha.
            for (int i = 0; i < l; i++)
            {
                //Outro for para imprimir a coluna.
                for (int j = 0; j < c; j++)
                {
                    //Imprimindo a matrix e dando um espaço em cada vez que imprime.
                    Console.Write(num[i, j] + " ");
                }
                //Manda imprimir tudo
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void PrintMatriz (float [,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.Write("\n");
            }
        }
        static void MediaMatriz(float [,] matriz)
        {
            float media, somatorio=0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    somatorio += matriz[i, j]; 
                }
            }
            media = somatorio / 24;
            Console.WriteLine("A media é: " + media);
        }
        static void Maior(float [,] matriz)
        {
            float maior;
            maior = int.MinValue;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz [i,j] > maior)
                    {
                        maior = matriz[i, j];
                    }
                }
            }
            Console.WriteLine("\nO maior numero é: " + maior);
        }
        static void Main(string[] args)
        {
            float[,] mat = new float[6, 4];
            for(int i=0;i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write("Insira um numero: ");
                    mat[i, j] = float.Parse(Console.ReadLine());
                }
            }

            Console.Clear();
            PrintMatriz(mat);
            MediaMatriz(mat);
            Maior(mat);
            Console.ReadKey();   
        }
    }
}

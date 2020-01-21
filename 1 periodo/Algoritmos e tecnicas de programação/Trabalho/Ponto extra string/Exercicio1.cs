using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra;
            int cont = 0;
            Console.Write("Insira uma palavra: ");
            palavra = Console.ReadLine();
            palavra.ToLower();
            char[] vetPalavraOriginal = palavra.ToCharArray();
            char[] vetPalavraCopia = palavra.ToCharArray();
            Array.Reverse (vetPalavraCopia);
            for(int i = 0; i<vetPalavraOriginal.Length; i++)
            {
                if(vetPalavraOriginal[i] == vetPalavraCopia[i])
                {
                    cont++;
                }
            }
            if (cont == vetPalavraOriginal.Length)
            {
                Console.Write("A palavra é um palíndromo");
            }
            else if (cont != vetPalavraOriginal.Length)
            {
                Console.Write("A palavra não é um palíndromo");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char opçao;
            int tamanhoDecimal = 0, tamanhoFracionario = 0, n = 0, m = 0, resultado=0;
            double binarioConvertido1, binarioConvertido2, novoBinarioConvertido1Convertido, novoNumeroConvertidoDecimal = 0, novoNumeroConvertidoFracionario = 0;
            Console.WriteLine("Bem vindo ao programa de conversão de bases.");

            Console.WriteLine("Para converter de Decimal para Binario, digite 1 e ENTER.");
            Console.WriteLine("Para converter de Binario para Decimal, digite 2 e ENTER.");
            opçao = char.Parse(Console.ReadLine());

            //Numero decimal para binario.
            int num;
            string numBinario = " ";

            switch (opçao)
            {
                case '1':
                    Console.Write("Converter um numero decimal para binario:");
                    Console.Write("Informe o número:");
                    num = Convert.ToInt32(Console.ReadLine());
                    while (num / 2 >= 1)
                    {
                        numBinario = Convert.ToString(num % 2) + numBinario;
                        num = num / 2;
                    }
                    numBinario = Convert.ToString(num) + numBinario;
                    Console.Write("A conversão do numero é: " + numBinario);
                    break;


                //NUMERO BINARIO PARA DECIMAL.
                case '2':

                    Console.Write("Insira o número binario: ");
                    numBinario = Console.ReadLine();

                    string[] binario = numBinario.Split(',');

                    //Definir o tamanho da primeira posiçao.
                    //Converter o numero para realizar a divisão.
                    binarioConvertido1 = double.Parse(binario[0]);
                    binarioConvertido2 = double.Parse(binario[1]);

                    //Para descobrir quantas casas inteiras possui a 1º posiçao do 1º vetor.
                    while (binarioConvertido1 / Math.Pow(10, tamanhoDecimal) > 1)
                    {
                        tamanhoDecimal++;
                    }
                    //Para descobrir quantas casas inteiras possui a 2º posiçao do 1º vetor.
                    while (binarioConvertido2 / Math.Pow(10, tamanhoFracionario) > 1)
                    {
                        tamanhoFracionario++;
                    }

                    //Para separarmos os algarismos do numero informado.
                    //Criamos um vetor que recebe o tamanho da parte decimal para definir o tamanho de posiçoes dentro do vetor algarismo.
                    int[] algarismosDecimal = new int [tamanhoDecimal];
                    double[] algarismosFracionario = new double[tamanhoFracionario];

                    //Agora coloca num for onde vai colocar cada algarismo em uma posiçao do vetor. 
                    for (int k=0; k < binario[0].Length; k++)
                    {
                        algarismosDecimal[k] = binario[0][k];
                    }

                    for (int l = 0; l < binario[1].Length; l++)
                    {
                        algarismosFracionario[l] = binario[1][l];
                    }

                    int[] novoBinarioConvertido1 = new int[tamanhoDecimal];
                    int[] novoBinarioConvertido2 = new int[tamanhoFracionario];

                   

                    //Fazer a conversao de cada posiçao do 1º vetor.
                    for (int i = tamanhoDecimal; i >= 0; i=i-1)
                    {
                        novoNumeroConvertidoDecimal += algarismosDecimal[i]*(2^i);
                        
                    }

                    for(int j = tamanhoFracionario; j <= tamanhoFracionario; j=j+1)
                    {
                        novoNumeroConvertidoFracionario += algarismosFracionario[j] * (2 ^ j);
                    }

                    break;

                default:
                    Console.Write("Opçao inválida.");
                    break;
            }
            Console.Write("O novo número é " + novoNumeroConvertidoDecimal + "," + novoNumeroConvertidoFracionario);
            Console.ReadKey();

        }
    }
}
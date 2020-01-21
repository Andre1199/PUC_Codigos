using System;
using System.IO;

namespace Trabalho
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abrir o arquivo para leitura.
            StreamReader arq = new StreamReader(@"C:\Users\carrefour\Desktop\André\dadosProva.txt");

            //É preciso uma variavel para atribuir leitura ao nome digitado.
            string nome;

            double somaValores = 0, maiorValor = 0, menorValor = 0;

            //Pedir o nome do investigado desejado e fazer a leitura atribuindo a variavel.
            Console.Write("Insira o nome do investigado:");
            nome = Console.ReadLine();

            //Criar uma outra variavel para fazer a leitura e impressao na tela do .txt.
            string linha;

            // Para ter uma variavel que irá receber o numero de vezes que o nome aparece.
            int contLinha = 0;

            //Enquanto a variavel linha for igual ao comando de leitura e diferente de vazio, execute:
            while ((linha = arq.ReadLine()) != null)
            {
                //Criar um vetor para indicar uma posiçao, colocar ele igual a variavel linha que será separada por ";".
                string[] investigado = linha.Split(';');

                //Criar uma condiçao para poder escolher em qual posiçao do .txt, irá está o nome do cara e o que será feito com isso.
                if (investigado[1] == nome)
                {
                    //Toda vez que o nome dele aparece, conta um numero a mais para a variavel.
                    contLinha++;

                    //Para somar os valores da posiçao [3], usou "+=" para sempre somar um novo valor a soma dos anteriores.
                    somaValores += float.Parse(investigado[3]);

                    //Enquanto o vetor foi maior que o maior valor, o maior valor substitui o antigo maior valor.
                    if (float.Parse(investigado[3]) > maiorValor)
                    {
                        maiorValor = float.Parse(investigado[3]);
                    }

                    //Para garantir que ele iria iniciar com um valor para que, depois disso, qualquer outro valor poderia fazer o teste e receber o menor valor.
                    if (menorValor == 0)
                    {
                        menorValor = float.Parse(investigado[3]);
                    }


                    //Idem
                    else if (float.Parse(investigado[3]) < menorValor)
                    {
                        menorValor = float.Parse(investigado[3]);
                    }
                }
            }
            Console.WriteLine("O investigador apareceu " + contLinha + " vezes.");
            Console.WriteLine("Ele recebeu R$" + somaValores);
            Console.WriteLine("E o maior valor recebido foi R$" + maiorValor + " e o menor valor foi R$" + menorValor + ".");

            Console.ReadKey();
        }
    }
}

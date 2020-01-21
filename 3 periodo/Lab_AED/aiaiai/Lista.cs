using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_AED
{
    //OBJETO
    class Inteiro
    {
        //Atributos
        private int numero;
        private Inteiro prox;

        //Construtores
        public Inteiro(int num)
        {
            numero = num;
        }

        //GS
        public int Numero { get { return (numero); } set { numero = value; } }
        public Inteiro Proximo { get { return (prox); } set { prox = value; } }
    }
    //LISTA DE INTEIROS.
    class Lista_Inteiro
    {
        //Atrbutos.
        Inteiro primeiro;
        Inteiro ultimo;


        //Construtor
        public Lista_Inteiro()
        {
            primeiro = new Inteiro(0);
            ultimo = primeiro;
        }

        //Verificar se esta vazio.
        public bool Verifica_Vazio()
        {
            if (primeiro == ultimo)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }

        //Inserir novo elemento no final.
        public Inteiro Inserir(Inteiro num)
        {
            ultimo.Proximo = num;
            num = ultimo;
            return (ultimo);
        }

        //Excluir elemento.
        public void Excluir(Inteiro num)
        {
            if (!Verifica_Vazio())
            {
                Inteiro aux = primeiro;
                while (aux != ultimo)
                {
                    if (aux.Proximo.Numero == num.Numero)
                    {
                        Inteiro aux2;
                        aux2 = aux.Proximo;
                        aux.Proximo = aux2.Proximo;
                        aux2.Proximo = null;
                    }
                }
            }
        }
        
        //Pesquisar por um elemento.
        public Inteiro Pesquisar(Inteiro num)
        {
            Inteiro aux = primeiro;
            while (aux != ultimo)
            {
                if (aux.Proximo.Numero == num.Numero)
                {
                    return (aux.Proximo);
                }
            }
            return (null);
        }
    }
}

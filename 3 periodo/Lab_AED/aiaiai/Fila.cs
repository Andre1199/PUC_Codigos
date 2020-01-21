using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_AED
{
    class CHAR
    {
        //Atributos
        private char carac;
        private CHAR prox;

        //Construtores
        public CHAR(char val)
        {
            carac = val;
        }

        //GS
        public char Carac { get { return (carac); } set { carac = value; } }
        public CHAR Proximo { get { return (prox); } set { prox = value; } }
    }
    //FILA DE INTEIROS.
    class Fila_Char
    {
        //Atrbutos.
        CHAR primeiro;
        CHAR ultimo;


        //Construtor
        public Fila_Char()
        {
            primeiro = new CHAR(' ');
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
        public CHAR Inserir(CHAR val)
        {
            ultimo.Proximo = val;
            val = ultimo;
            return (ultimo);
        }


        //Tirar o primeiro elemento da fila.
        public CHAR Tirar_ele()
        {
            if (!Verifica_Vazio())
            {
                CHAR aux = primeiro.Proximo;
                primeiro.Proximo = aux.Proximo;
                aux.Proximo = null;
                return (aux);
            }
            return (null);
        }

        //Tirar o ultimo elemento da fila.
        public CHAR Tirar_ult_ele()
        {
            if (!Verifica_Vazio())
            {
                CHAR aux = primeiro.Proximo;
                while (aux.Proximo != ultimo)
                {
                    aux = aux.Proximo;
                }
                CHAR aux1= aux.Proximo;
                aux = ultimo;
                return (aux1);
            }
            return (null);
        }
    }
}

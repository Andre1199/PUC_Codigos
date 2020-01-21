using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_AED
{
    class Program
    { 

        static void Main(string[] args)
        {
            Fila_Char FILA;

            //questão 2.
            FILA = new Fila_Char();
            
        }
        //questão 2.
        public string Editor(string palavra,Fila_Char fila)
        {
            for (int i = 0; i < palavra.Length; i++)
            {
                if (palavra[i] == '#')// tirar o ultimo elemento
                {
                    fila.Tirar_ult_ele();
                }
                else if (palavra[i] == '$')//inserir duplicado
                {
                    CHAR aux = new CHAR(palavra[i + 1]);
                    fila.Inserir(aux);
                }
                if (palavra[i] != '#' && palavra[i] != '$') //inserir os restantes dos elementos.
                {
                    CHAR aux = new CHAR(palavra[i]);
                    fila.Inserir(aux);
                }
            }

            string texto;
            //desenfilerar.
            while (!fila.Verifica_Vazio())
            {
                CHAR aux;
                aux = fila.Tirar_ele();
                texto += Convert.ToString(aux.Carac);
            }

            return (texto);
        }

        //extra.

            //A;
        public double Calc(int val1, int val2)
        {
            if (val2 == 0)
            {
                return (0);
            }
            else
            {
                return (val1*Calc(val1,val2-1));
            }
        }
            //B;  ????
        public double Soma(int val1, int val2)
        {
            if (true)
            {
                return (0);
            }
            else
            {
                return (0);
            }
        }
    }
}

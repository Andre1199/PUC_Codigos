using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_AED
{
    class intARVORE
    {
        public int val;
        public intARVORE esqueda;
        public intARVORE direita;
    }
    class Arvore_binaria
    {
        //Atributos.
        private intARVORE raiz;

        
        //GS
        public intARVORE Raiz { get { return (raiz); } set { raiz = value; } }

        //VERIFICAR SE ESTA VAZIA.
        public bool verificar_vazia()
        {
            if (raiz == null)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }

        //inserir na arvore.
        public void Inserir(intARVORE VALOR)
        {
            if (verificar_vazia())
            {
                VALOR = raiz;
            }
            else
            {
                if (VALOR.val < raiz.val)
                {
                    raiz.esqueda = VALOR;
                }
                else if (VALOR.val < raiz.val)
                {
                    raiz.direita = VALOR;
                }
            }
        }

        //???
        private double obtermedia()
        {

        }
        //???
        private int obterSoma()
        {

        }
        //???
        private int Contar()
        {

        }
    }
}

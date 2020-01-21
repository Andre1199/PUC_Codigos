using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_AED_SO
{
    class ListaProcesso
    {
        Elemento prim, ult;

        /// <summary>
        /// Contrutor lista de processos
        /// </summary>
        /// <returns></returns>
        public ListaProcesso()
        {
            this.prim = new Elemento(null);
            this.ult = this.prim;
        }

        /// <summary>
        /// Metodo para inserir processo
        /// </summary>
        /// <param name="d">Processo que a inserir</param>
        public void Inserir(Processo d)
        {
            Elemento novo = new Elemento(d);
            ult.Prox = novo;
            ult = novo;
        }

        /// <summary>
        /// Metodo para verificar se a lista esta vazia
        /// </summary>
        /// <returns></returns>
        public bool Vazia()
        {

            return (this.prim == this.ult);
        }

        /// <summary>
        /// Metodo para retirar Processo
        /// </summary>
        /// <returns></returns>
        public Processo Retirar()
        {

            if (this.Vazia()) return null;

            Elemento aux = this.prim.Prox;
            this.prim.Prox = aux.Prox;
            if (aux.Prox != null)
                aux.Prox = null;
            else
                this.ult = this.prim;

            return aux.Dados;
        }

        public override string ToString()
        {

            if (this.Vazia()) return null;

            StringBuilder auxImpr = new StringBuilder();
            Elemento aux = this.prim.Prox;
            while (aux != null)
            {

                auxImpr.AppendLine(aux.ToString());
                aux = aux.Prox;
            }

            return auxImpr.ToString();
        }
    }
}

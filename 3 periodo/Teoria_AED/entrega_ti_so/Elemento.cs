using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_AED_SO
{
    class Elemento
    {
        private Processo dados;
        private Elemento prox;

        public Elemento Prox
        {
            get { return prox; }
            set { prox = value; }
        }
        public Processo Dados
        {
            get { return dados; }
            set { dados = value; }
        }

        /// <summary>
        /// Construtor do elemento
        /// </summary>
        /// <param name="d">Processo a se inserir</param>
        /// <returns></returns>
        public Elemento(Processo d)
        {
            this.dados = d;
            prox = null;
        }
        public override string ToString()
        {
            return dados.ToString();
        }
    }
}
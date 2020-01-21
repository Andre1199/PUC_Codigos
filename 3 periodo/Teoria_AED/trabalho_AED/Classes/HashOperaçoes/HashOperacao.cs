using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_AED.HashOperaçoes
{
    class HashOperacao
    {
        private Ano codigoOperacao;

        public HashOperacao()
        {
            codigoOperacao = new Ano();
        }

        public void AdcOperacao(Operacao oper)
        {
            DateTime ulti2anos = new DateTime(DateTime.Now.Year - 2, DateTime.Now.Month, DateTime.Now.Day);
            if (oper.data>ulti2anos)
            {
                codigoOperacao.ano[DateTime.Now.Year - oper.data.Year].mes[oper.data.Month].dia[oper.data.Day].enfileirar(oper);
            }
        }

        public ListaDeOperacao PesquisarData(DateTime datapedida)
        {
            return codigoOperacao.ano[DateTime.Now.Year - datapedida.Year].mes[datapedida.Month].dia[datapedida.Day];
        }
    }
}
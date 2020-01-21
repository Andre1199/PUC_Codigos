using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_AED_SO
{
    class Processo
    {
        private int id, prioridade, _quantum;
        private string nome;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Prioridade
        {
            get { return prioridade; }
            set { prioridade = value; }
        }
        public int quantum
        {
            get { return _quantum; }
            set { _quantum = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        /// <summary>
        /// Construtor de Processo
        /// </summary>
        /// <param name="ide">Numero de indentificação do processo</param>
        /// <param name="nome">Nome do processo</param>
        /// <param name="priori">Prioridade do processo</param>
        /// <param name="qtdCi">Quantidade de ciclos do processo</param>
        public Processo(int ide, string nome, int priori, int qtdCi)
        {
            id = ide;
            this.nome = nome;
            Prioridade = priori;
            _quantum = qtdCi;
        }

        public override string ToString()
        {
            return Id + ":" + Nome + ":" + Prioridade + ":" + quantum;
        }

        /// <summary>
        /// Metodo de reduzir o tempo do processo no processador. Usamos 9 como exemplo
        /// </summary>
        /// <returns></returns>
        public int ProcessarDados()
        {
            _quantum -= 9;
            if (_quantum < 0)
                _quantum = 0;
            return _quantum;
        }

        /// <summary>
        /// Metodo de diminuir prioridade do processo
        /// </summary>
        /// <returns></returns>
        public void DiminuirPrioridade()
        {
            prioridade--;
        }
    }
}

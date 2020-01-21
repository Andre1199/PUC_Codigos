using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_AED
{
    class ListaDeOperacao
    {
        private Operacao frente;
        private Operacao tras;
        public int contador;
        public ListaDeOperacao()
        {
            Operacao opera;
            opera = new Operacao();
            frente = opera;
            tras = opera;
            contador = 0;
        }

        public Boolean filaVazia()
        {
            if (frente == tras)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void enfileirar(Operacao opera)
        {
            tras.proximo = opera;
            tras = opera;
            contador++;
        }

        public Operacao desenfileirar()
        {
            Operacao opera = frente.proximo;

            if (!(filaVazia()))
            {
                frente.proximo = opera.proximo;
                opera.proximo = null;
                contador--;
            }
            return (opera);
        }

        public string ImprimirTodos()
        {
            if (!(filaVazia()))
            {
                string impri = "";
                Operacao aux = this.frente.proximo;
                while (aux!= null)
                {
                    string[] nome = aux.GetType().ToString().Split('.');
                    impri = impri + aux.data.ToString("dd/MM/yyyy") + " " + aux.numConta + " " + nome[1] + " " + aux.valor.ToString("c")+";";
                    aux = aux.proximo;
                }
                return impri;
            }
            return "";
        }
    }
}
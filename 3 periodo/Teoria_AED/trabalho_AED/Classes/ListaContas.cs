using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_AED
{
    class ListaContas
    {
        private ContaBancaria[] _vetorContas;
        public ContaBancaria[] vetorContas
        {
            get { return _vetorContas; }
            set { _vetorContas = value; }
        }

        public int contador;

        public ListaContas()
        {
            _vetorContas = new ContaBancaria[40000];
            contador = 0;
        }
        public void Adicionar(ContaBancaria novo)
        {
            vetorContas[contador] = novo;
            contador++;
        }

        public void OrdenarLista()
        {
            QuickSort_Recursive(0, contador - 1);
        }
        private void QuickSort_Recursive(int primeiro, int ultimo)
        {
            int baixo, alto, meio, pivo;
            ContaBancaria repositorio;
            baixo = primeiro;
            alto = ultimo;
            meio = (int)((baixo + alto) / 2);

            pivo = Convert.ToInt32(_vetorContas[meio].numConta);

            while (baixo <= alto)
            {
                while (Convert.ToInt32(_vetorContas[baixo].numConta) < pivo)
                    baixo++;
                while (Convert.ToInt32(_vetorContas[alto].numConta) > pivo)
                    alto--;
                if (baixo < alto)
                {
                    repositorio = _vetorContas[baixo];
                    _vetorContas[baixo++] = _vetorContas[alto];
                    _vetorContas[alto--] = repositorio;
                }
                else
                {
                    if (baixo == alto)
                    {
                        baixo++;
                        alto--;
                    }
                }
            }

            if (alto > primeiro)
                QuickSort_Recursive(primeiro, alto);
            if (baixo < ultimo)
                QuickSort_Recursive(baixo, ultimo);
        }
        public ContaBancaria BuscaBinaria(string numcon)
        {
            return BuscaBinariaRecursiva(numcon, 0, contador - 1);
        }
        private ContaBancaria BuscaBinariaRecursiva(string valorBuscado, int inicio, int fim)
        {
            int i = (inicio + fim) / 2;

            if (inicio > fim)
            {
                return null;
            }
            else if (Convert.ToInt32(valorBuscado) == _vetorContas[i].numConta)
            {
                return _vetorContas[i];
            }
            else if (Convert.ToInt32(valorBuscado) < _vetorContas[i].numConta)
            {
                fim = i - 1;
                return BuscaBinariaRecursiva(valorBuscado, inicio, fim);
            }
            else
            {
                inicio = i + 1;
                return BuscaBinariaRecursiva(valorBuscado, inicio, fim);
            }

        }

    }
}

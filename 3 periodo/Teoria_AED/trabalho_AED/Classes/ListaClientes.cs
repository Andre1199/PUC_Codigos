using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_AED
{
    class ListaClientes
    {
        private Cliente[] _vetorClientes;
        public Cliente[] vetorClientes
        {
            get { return _vetorClientes; }
            set { _vetorClientes = value; }
        }

        public int contador;

        public ListaClientes()
        {
            _vetorClientes = new Cliente[20000];
            contador = 0;
        }
        public void Adicionar(Cliente novo)
        {
            vetorClientes[contador] = novo;
            contador++;
        }

        public void OrdenarLista()
        {
            QuickSort_Recursive(0, contador - 1);
        }
        private void QuickSort_Recursive(int primeiro, int ultimo)
        {
            int baixo, alto, meio, pivo;
            Cliente repositorio;
            baixo = primeiro;
            alto = ultimo;
            meio = (int)((baixo + alto) / 2);

            pivo = Convert.ToInt32(_vetorClientes[meio].cpf);

            while (baixo <= alto)
            {
                while (Convert.ToInt32(_vetorClientes[baixo].cpf) < pivo)
                    baixo++;
                while (Convert.ToInt32(_vetorClientes[alto].cpf) > pivo)
                    alto--;
                if (baixo < alto)
                {
                    repositorio = _vetorClientes[baixo];
                    _vetorClientes[baixo++] = _vetorClientes[alto];
                    _vetorClientes[alto--] = repositorio;
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
        public Cliente BuscaBinaria(string cpf)
        {
            return BuscaBinariaRecursiva(cpf,0,contador-1);
        } 
        private Cliente BuscaBinariaRecursiva(string valorBuscado, int inicio, int fim)
        {
            int i = (inicio + fim) / 2;

            if (inicio > fim)
            {
                return null;
            }
            else if (valorBuscado == _vetorClientes[i].cpf)
            {
                return _vetorClientes[i];
            }
            else if (Convert.ToInt32(valorBuscado) < Convert.ToInt32(_vetorClientes[i].cpf))
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exerc1
{
    class Pilha
    {
        public Elemento fundo;
        public Elemento topo;

        public Pilha()
        {
            Elemento elemento = new Elemento(' ');

            fundo = elemento;
            topo = elemento;
        }

        public void empilhar(Elemento elemento)
        {
            elemento.proximo = topo;

            topo = elemento;
        }

        public Elemento desempilhar()
        {
            Elemento aux = null;

            if (!pilhaVazia())
            {
                aux = topo;

                topo = topo.proximo;

                aux.proximo = null;
            }
            return (aux);
        }

        public Boolean pilhaVazia()
        {
            if (fundo == topo) return (true);
                
            else return (false);
        }

        public Pilha Copiar()
        {
            Elemento letra;
            Pilha aux = new Pilha();
            string copia = this.Imprimir();
            for (int i = copia.Length; i >= 0; i--)
            {
                letra = new Elemento(copia[i]);
                aux.empilhar(letra);
            }
            return aux;
        }

        public string Imprimir()
        {
            string resposta = "";
            Elemento aux = topo;
            while (aux != fundo)
            {
                resposta += aux.letra;
                aux = aux.proximo;
            }
            return resposta;
        }

        public string CancelaCarater(string frase, char cancelaCarater)
        {
            Pilha fraseparacancela = new Pilha();
            Elemento letra;
            string aux = "";
            for (int i = frase.Length; i >= 0; i--)
            {
                letra = new Elemento(frase[i]);
                fraseparacancela.empilhar(letra);
            }
            while (fraseparacancela.desempilhar() != null)
            {
                if (fraseparacancela.desempilhar().letra == cancelaCarater) aux += cancelaCarater;
                    
                else aux += fraseparacancela.desempilhar();
            }
            return aux;
        }

        public bool Polidromo(string frase)
        {
            Pilha aux = new Pilha();
            Elemento letra;
            string comparar = frase.ToLower().Trim().TrimEnd().TrimStart();
            for (int i = 0; i < comparar.Length; i++)
            {
                letra = new Elemento(comparar[i]);
                aux.empilhar(letra);
            }
            if (aux.Imprimir().TrimStart()==comparar) return true;

            else return false;
        }

        public Elemento obterTopo()
        {
            Elemento aux = null;
            if (!pilhaVazia()) return aux;

            else {
                aux = topo;
                return aux;
            }
        }

        public bool verificarExistencia(char l)
        {
            Elemento aux = topo;
            while (aux.proximo != null)
            {
                if (aux.letra == l) return true;
            }
            return false;
        }

        public int obterNumeroElementos()
        {
            Elemento aux = topo;
            int contador = 0;
            while (aux.proximo != null)
            {
                contador++;
            }
            return contador;
        }

        public void concatenar(Pilha pilha)
        {
            Elemento aux = pilha.topo;
            while (aux != fundo)
            {
                empilhar(aux);
                aux = aux.proximo;
            }
        }

        public int obterNumeroElementosAcima(char l)
        {
            Elemento aux = topo;
            int contador = 0;
            while (aux.proximo != null)
            {
                if (aux.letra == l) return contador;

                contador++;
            }
            return -1;
        }
    }
}

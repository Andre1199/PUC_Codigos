using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FilaCliente
    {
        private Cliente frente; // referência ao cliente que está na frente da fila. Esse cliente é utilizado apenas para controle.
        private Cliente tras;   // referência ao cliente que está na última posição da fila.

        // Construtor que cria uma fila vazia inicializando o cliente da frente da fila e os atributos de controle da fila (frente e tras).
        public FilaCliente()
        {
            Cliente cli;
            DateTime horaChegada;

            horaChegada = new DateTime(2018, 4, 14, 10, 40, 0);
            cli = new Cliente(" ", horaChegada);
            frente = cli;
            tras = cli;
        }

        // Verifica se a fila está vazia. Em caso afirmativo, retorna true e em caso negativo retorna false.
        public Boolean filaVazia()
        {
            // se a fila apresentar apenas o elemento de controle, ela está vazia.
            if (frente == tras)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Insere o cliente cli, passado como parâmetro para esse método, no final da fila.
        public void enfileirar(Cliente cli)
        {
            // inserção do novo cliente no final da fila.
            tras.proximo = cli;

            // atualização do atributo de controle tras.
            tras = cli;
        }

        // Retira o cliente que ocupa a primeira posição da fila. Se a fila estiver vazia, esse método deve retornar null; caso contrário, esse método deve retornar o cliente retirado da fila.
        public Cliente desenfileirar()
        {
            // cli aponta para o cliente da fila que será retornado/desenfileirado, ou seja, o primeiro cliente da fila.
            Cliente cli = frente.proximo;

            if (!(filaVazia()))
            {
                // atualização do primeiro cliente da fila.
                frente.proximo = cli.proximo;

                cli.proximo = null;
            }
            return (cli);
        }

        public Cliente obterPrimeiro()
        {
            if (filaVazia()) return null;
            else return frente.proximo;
        }

        public int obterNumeroClientes()
        {
            Cliente aux = frente.proximo;
            if (filaVazia()) return 0;
            else
            {
                int i = 0;
                while (aux != null)
                {
                    aux = aux.proximo;
                    i++;
                }
                return i;
            }
        }

        public void imprimir()
        {
            Cliente aux = frente.proximo;
            if (filaVazia()) Console.WriteLine("Fila vazia");
            else
            {
                while (aux != null)
                {
                    Console.WriteLine(aux.nome);
                    aux = aux.proximo;
                }
            }
        }

        public FilaCliente dividir()
        {
            FilaCliente novaFila = new FilaCliente();
            int i = 1;
            Cliente aux1 = frente.proximo;
            Cliente aux2;
            while(aux1 != null)
            {
                if (i % 2 != 0)
                {
                    novaFila.enfileirar(aux1.proximo);
                    aux2 = aux1.proximo;
                }
                aux1 = aux1.proximo;
                i++; 
            }
            return novaFila;
        }

        public bool verificarExistencia(String nomeCliente)
        {
            Cliente aux = frente.proximo;
            while(aux != null)
            {
                if (nomeCliente.CompareTo(aux.nome) == 0) return true;
            }
            return false;
        }

        public int obterNumClientesAFrente(String nomeCliente){
            Cliente aux = frente.proximo;
            int i = 1;
            while (aux != null)
            {
                if (nomeCliente.CompareTo(aux.nome) == 0) return i;
                i++;
            }
            return -1;
        }

        public FilaCliente copiar()
        {
            Cliente aux = frente.proximo;
            FilaCliente novaFila = new FilaCliente();
            while (aux != null)
            {
                novaFila.enfileirar(aux);
                aux = aux.proximo;
            }
            return novaFila;
        }

        public double obterTempoMedioEspera(DateTime horarioAtual)
        {
            Cliente aux = frente.proximo;
            double hrMedia = 0;
            while (aux != null)
            {
                hrMedia += horarioAtual.Hour - aux.horarioChegada.Hour;
                aux = aux.proximo;
            }

            return hrMedia/obterNumeroClientes();
        }
    }
}

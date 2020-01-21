using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aed_tab_hash
{
    class ListaLinearProduto
    {
        private Produto primeiro; /// referência ao primeiro nodo da lista encadeada de produtos.
                                  /// o primeiro nodo da lista encadeada de produtoscorresponderá ao nodo-cabeça, utilizado apenas para controle.
        private Produto ultimo; /// referência ao último nodo da lista encadeada de produtos.
        /// <summary>
        /// Construtor da classe.
        /// Esse construtor inicializa a lista encadeada de produtos criando o nodocabeça dessa lista.
        /// </summary>
        public ListaLinearProduto()
        {
            /// criação do nodo-cabeça da lista encadeada de produtos. O nodo-cabeça é utilizado apenas para controle.
            /// o nodo-cabeça é o primeiro nodo da lista encadeada de produtos.
            /// o nodo-cabeça da lista encadeada de produtos corresponde a um produto com código de barras 0, nome "" e preço unitário 0.0.
            primeiro = new Produto(0, "", 0.0);
            /// quando a lista encadeada é criada, o nodo-cabeça é também o último nodo dessa lista.
            ultimo = primeiro;
        }
        /// <summary>
        /// Método responsável por verificar se a lista encadeada de produtos está vazia.
        /// </summary>
        /// <returns> se a lista encadeada de produtos estiver vazia, retorna true. Caso contrário, retorna false. </returns> 

        public Boolean vazia()
        {
            /// a lista encadeada de produtos está vazia se ela só apresentar o nodocabeça.
            if (this.primeiro == this.ultimo)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Método responsável por inserir um novo produto no final da lista encadeada de produtos.
        /// </summary>
        /// <param name="produtoNovo"> produto a ser inserido no final da lista encadeada de produtos. </param>
        public void inserir(Produto produtoNovo)
        {
            /// inserção do produto, passado como parâmetro para esse método, no final da lista encadeada de produtos.
            this.ultimo.proximo = produtoNovo;
            /// atualização do ponteiro de controle "ultimo" para o último item da lista encadeada.
            this.ultimo = produtoNovo;
        }
        /// <summary>
        /// Método responsável por localizar, na lista encadeada de produtos,
        /// o produto, cujo código de barras corresponde ao que foi passado como parâmetro para esse método.
        /// </summary>
        /// <param name="codigoBarras"> código de barras do produto que deve ser localizado na lista encadeada de produtos. </param>
        /// <returns> se o produto tiver sido localizado na lista encadeada de produtos, retorna uma referência ao produto encontrado. Implemente então, em C#, a classe TabelaHashProduto, que apresenta a seguinte assinatura:
        /// Caso contrário, retorna null. </returns> public
        public Produto pesquisar(int codigoBarras)
        {
            int comparacoes = 0;
            /// se a lista encadeada de produtos estiver vazia, obviamente o produto desejado não está armazenado na lista.
            /// nesse caso, esse método retorna null.
            if (this.vazia())
                return null;
            else
            {
                /// o ponteiro aux será utilizado para percorrermos a lista encadeada de produtos a procura do item desejado.
                Produto aux = this.primeiro.proximo;
                /// enquanto o ponteiro aux não tiver percorrido toda a lista encadeada...
                while (aux != null)
                {
                    comparacoes++;
                    /// se o ponteiro aux estiver apontando para o item desejado...
                    if (aux.codigoBarras == codigoBarras)
                    {
                        Console.WriteLine("Número de comparações realizadas pelo método de pesquisa: { 0} ", comparacoes);
                        /// esse método retorna o elemento encontrado.
                        return aux;
                    }
                    else
                        /// se ainda não encontramos o item desejado, avançamos na lista encadeada.
                        aux = aux.proximo;
                }
                Console.WriteLine("Número de comparações realizadas pelo método de pesquisa: { 0}", comparacoes);
                /// se o item desejado não tiver sido localizado na lista encadeada de
                /// produtos, esse método retorna null.
                return aux;
            }
        }
        /// <summary>
        /// Método responsável por imprimir, para todos os produtos armazenados na lista encadeada,
        /// seu nome, seu código de barras e seu preço unitário.
        /// A ordem de impressão deve ser do primeiro nodo da lista para o último.
        /// </summary>
        public void imprimir()
        {
            if (this.vazia())
                Console.WriteLine("A lista está vazia.");
            else
            {
                /// o ponteiro aux será utilizado para percorrermos a lista encadeada.
                Produto aux = this.primeiro.proximo;
                /// enquanto o ponteiro aux não tiver percorrido toda a lista encadeada...
                while (aux != null)
                {
                    /// imprimi os dados do produto apontado pelo ponteiro aux.
                    Console.WriteLine("Nome do produto: {0} - Código de barras do produto: { 1} -Preço unitário do produto: { 2}", aux.nome, aux.codigoBarras, aux.precoUnitario);
                    /// avançamos na lista encadeada.
                    aux = aux.proximo;
                }
            }
        }
    }
}

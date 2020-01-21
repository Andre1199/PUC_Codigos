using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aed_tab_hash
{
    class TabelaHashProduto
    {
        private int M; /// tamanho da tabela hash.
                       /// M deve ser um número primo grande para diminuirmos as probabilidades de colisões.
        private ListaLinearProduto[] tabelaProdutos; /// tabela que referenciará todas as listas lineares encadeadas de produtos.
                                                     /// Nesse caso, estamos utilizando uma tabela hash com endereçamento em separado,
                                                     /// ou seja, os produtos são armazenados em listas lineares encadeadas.
        /// <summary>
        /// Construtor da classe.
        /// Esse método é responsável por inicializar a tabela hash de produtos que trabalha com endereçamento em separado.
        /// Assim, esse método atribui, ao atributo M, dessa classe, o valor passado através do parâmetro tamanho.
        /// Esse método também cria um vetor, de tamanho M, de listas lineares de produtos; e o atribui ao atributo tabelaProdutos.
        /// Adicionalmente, cada célula do vetor é inicializada com uma lista linear encadeada de produtos.
        /// </summary>
        /// <param name="tamanho"> tamanho da tabela hash. </param>
        public TabelaHashProduto(int tamanho)
        {
            this.tabelaProdutos = new ListaLinearProduto[tamanho];
        }
        /// <summary>
        /// Esse método implementa a função de transformação da tabela hash,
        /// ou seja, calcula a posição, na tabela hash, em que o produto,
        /// que possui o código de barras informado através do parâmetro chave, deve ser encontrado.
        /// A função de transformação utilizada corresponde ao resto da divisão da chave pelo tamanho da tabela hash.
        /// </summary>
        /// <param name="chave"> chave da qual desejamos saber a posição na tabela hash. </param>
        /// <returns> a posição que o item, cuja chave corresponde a que foi passada como parâmetro para esse método,
        /// deve ocupar na tabela hash. </returns>
        private int funcaoHash(int chave)
        {
            return chave % tabelaProdutos.Length;
        }
        /// <summary>
        /// Método responsável por inserir um novo produto na tabela hash.
        /// Não é permitido inserir, nessa tabela hash, mais de um produto com um mesmo código de barras.
        /// </summary>
        /// <param name="produtoNovo"> referência ao produto que deve ser inserido na tabela hash. </param>
        public void inserir(Produto produtoNovo)
        {
            ListaLinearProduto listaAux = new ListaLinearProduto();
            int aux = funcaoHash(produtoNovo.codigoBarras);

            if(tabelaProdutos[aux] == null)
            {
                listaAux.inserir(produtoNovo);
                tabelaProdutos[aux] = listaAux;
            }
            else
            {
                tabelaProdutos[aux].inserir(produtoNovo);
            }
        }
        /// <summary>
        /// Método responsável por localizar, na tabela hash, o produto,
        /// cujo código de barras corresponde ao que foi passado como parâmetro para esse método.
        /// O número de comparações, realizadas por esse método, para a localização de um produto na tabela hash, também é impresso.
        /// </summary>
        /// <param name="codigoBarras"> código de barras do produto que deve ser localizado na tabela hash. </param>
        /// <returns> uma referência ao produto encontrado; ou null, caso o produto não tenha sido localizado na tabela hash. </returns>
        public Produto pesquisar(int codigoBarras)
        {
            int aux = funcaoHash(codigoBarras);

            if(tabelaProdutos[aux] == null)
            {
                return null;
            }
            else
            {
               return tabelaProdutos[aux].pesquisar(codigoBarras);
            }
        }
        /// <summary>
        /// Método responsável por imprimir todo o conteúdo da tabela hash.
        /// É impresso o índice da tabela hash e seu correspondente conteúdo.
        /// Se a posição da tabela hash estiver vazia, é impressa uma mensagem explicativa.
        /// Caso contrário, para todos os produtos, armazenados na lista linear encadeada de produtos
        /// associada a uma posição da tabela hash, são seus impressos dados.
        /// </summary>
        public void imprimir()
        {
            foreach (var itens in tabelaProdutos)
            {
                if (itens == null) Console.WriteLine("Posição vazia");
                else Console.WriteLine(itens.ToString());
            }
        }
    }
}

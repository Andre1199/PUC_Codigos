using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aed_tab_hash
{
    class Produto
    {
        public int codigoBarras; public String nome;
        public double precoUnitario; /// preço de uma unidade do produto.
        public Produto proximo;/// referência ao próximo produto de uma lista linear encadeada de produtos.
        /// <summary>
        /// Construtor da classe.
        /// Esse construtor cria um novo objeto da classe Produto atribuindo a esse objeto os seguintes valores:
        /// - codigoBarras recebe o valor que foi passado através do parâmetro codigo.
        /// - nome recebe o valor que foi passado através do parâmetro nomeProduto.
        /// - precoUnitario recebe o valor que foi passado através do parâmetro precoUnidade.
        /// - proximo recebe null.
        /// </summary>
        /// <param name="codigo"> código de barras idenƟficador do produto que será criado. </param>
        /// <param name="nomeProduto"> nome do produto que será criado. </param>
        /// <param name="precoUnidade"> preço de uma unidade do produto que está sendo criado. </param>
        public Produto(int codigo, String nomeProduto, double precoUnidade)
        {
            this.codigoBarras = codigo;
            this.nome = nomeProduto;
            this.precoUnitario = precoUnidade;
            this.proximo = null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace aed_tab_hash
{
    class Program
    {
        public const int tamanhoTabelaHash = 11;
        static public void cadastrarProdutos(String nomeArquivoEntrada,
        TabelaHashProduto tabela)
        {
            StreamReader arquivoLeitura;
            String s;
            String[] dadosProdutos;
            if (File.Exists(nomeArquivoEntrada))
            {
                arquivoLeitura = new StreamReader(nomeArquivoEntrada, Encoding.ASCII);
                s = arquivoLeitura.ReadLine();
                while (s != null)
                {
                    dadosProdutos = s.Split('-');
                    tabela.inserir(new Produto(int.Parse(dadosProdutos[0]),
                    dadosProdutos[1], double.Parse(dadosProdutos[2])));
                    s = arquivoLeitura.ReadLine();
                }
                arquivoLeitura.Close();
            }
            else
            {
                Console.WriteLine("O arquivo {0} não existe", nomeArquivoEntrada);
            }
        }
        static void Main(string[] args)
        {
            String nomeArquivoEntrada;
            TabelaHashProduto tabela = new TabelaHashProduto(tamanhoTabelaHash);
            int codigoProdutoPesquisado;
            Produto produtoPesquisado;
            Console.WriteLine("Informe o nome do arquivo texto que apresenta as informações dos produtos a serem cadastrados: ");
            nomeArquivoEntrada = Console.ReadLine();
            cadastrarProdutos(nomeArquivoEntrada, tabela);
            Console.WriteLine("Informe o código de barras do produto a ser pesquisado: ");
            codigoProdutoPesquisado = int.Parse(Console.ReadLine());
            produtoPesquisado = tabela.pesquisar(codigoProdutoPesquisado);
            if (produtoPesquisado != null)
            {
                Console.WriteLine("Nome do produto pesquisado: {0}",
                produtoPesquisado.nome);
                Console.WriteLine("Preço unitário do produto pesquisado: {0}",
                produtoPesquisado.precoUnitario);
            }
            else
            {
                Console.WriteLine("O produto não foi encontrado.");
            }
            tabela.imprimir();
            Console.ReadKey();
        }
    }
}

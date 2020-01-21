using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        struct Estacionamento {
            public const int numMaxVagas = 50; // número máximo de vagas que um estacionamento pode ter.
            public String nome; // nome do estacionamento. 
            private String[] vaga = new String[numMaxVagas]; // vetor que armaze-na cada uma das vagas do estacionamento. Caso a vaga esteja ocupada, este vetor indica a placa do veículo que a ocupa.
            private int numTotalVagas; // número total de vagas que o estacionamento apresenta. 
            private int numVagasLivres; // número de vagas livres no estacionamento.
            public Estacionamento(String nomeEstabelecimento, int totalVagas)
            {

            }
            public int estacionar(String placa)
            {

            }
            public int obterVagaOcupada(String placa)
            {

            }
            public void retirarVeiculo(int numVaga)
            {

            }
            public int obterNumVagasLivres()
            {

            }
            public void exibirOcupacaoEstacionamento()
            {

            }
        }


        static void Main(string[] args)
        {
            int vagaOcupada; Estacionamento objEstacionamento = new Estacionamento("Estaciona-mento Laboratório de Computação II", 10);
            vagaOcupada = objEstacionamento.estacionar("HKT0098");
            vagaOcupada = objEstacionamento.estacionar("OLP4290");
            vagaOcupada = objEstacionamento.estacionar("HJB0495");
            vagaOcupada = objEstacionamento.estacionar("OWB3904");
            Console.WriteLine("Ocupação do estacionamento após as chegadas dequatro clientes:");
            objEstacionamento.exibirOcupacaoEstacionamento(); // HKT0098 OLP4290 HJB0495 OWB3904 vazia vazia vazia vazia vazia vazia            
            vagaOcupada = objEstacionamento.obterVagaOcupada("HKT0098");
            objEstacionamento.retirarVeiculo(vagaOcupada);
            Console.WriteLine("Ocupação do estacionamento após a retirada do veículo de placa HKT0098:");
            objEstacionamento.exibirOcupacaoEstacionamento(); //  vazia OLP4290 HJB0495 OWB3904 vazia vazia vazia vazia vazia vazia            
            vagaOcupada = objEstacionamento.estacionar("HTP5619");
            vagaOcupada = objEstacionamento.estacionar("BOL4861");
            vagaOcupada = objEstacionamento.estacionar("HGT9436");
            Console.WriteLine("Ocupação do estacionamento após as chegadas demais três clientes:");
            objEstacionamento.exibirOcupacaoEstacionamento(); // HTP5619 OLP4290 HJB0495 OWB3904 BOL4861 HGT9436 vazia vazia vazia vazia
            Console.WriteLine("Este estacionamento apresenta {0} vagas li-vres.", objEstacionamento.obterNumVagasLivres()); // 4 vagas livres
            Console.ReadKey();
        }
    }
}
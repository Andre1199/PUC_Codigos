using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        struct Voo
        {
            public const int numMaxAssentos = 300; // número máximo de assentos que um vôo pode ter.
            public int numVoo; // número do vôo.
            public String origem; // cidade de origem do vôo.
            public String destino; // cidade de destino do vôo.
            public DateTime dataHora; // data e horário do vôo.
            private String[] assento; // vetor que armazena cada um dos assentos do vôo.Caso o assento esteja ocupado, este vetor indica o nome de seu ocupante.
            private int numTotalAssentos; // número total de assentos que o vôo apresenta.
            private int numAssentosOcupados; // número de assentos que estão ocupados no vôo.
            public Voo(int num, String orig, String dest, DateTime horario, int totalAssentos)
            {
                if (totalAssentos <= numMaxAssentos)
                {
                    this.numVoo = num;
                    this.origem = orig;
                    this.destino = dest;
                    this.dataHora = horario;
                    this.numTotalAssentos = totalAssentos;
                    this.numAssentosOcupados = 0;
                    this.assento = new String[numMaxAssentos];
                }

                else
                {
                    this.numVoo = -666;
                    this.origem = null;
                    this.destino = null;
                    this.dataHora = DateTime.Now;
                    this.numTotalAssentos = 0;
                    this.numAssentosOcupados = 0;
                    this.assento = null;
                }
            }
            public int reservar(String passageiro)
            {
                for (int i = 0; i < assento.Length; i++)
                {
                    if (assento[i] == "") {
                        assento[i] = passageiro;
                        return i;
                    }
                }
                return 0;
            }
            public int obterPoltrona(String passageiro)
            {
                int i = 0;
                while (assento[i].CompareTo(passageiro) != 0 && i < assento.Length)
                {
                    if (assento[i].CompareTo(passageiro) == 0) return i;
                    else i++;
                }
                if (assento[assento.Length - 1].CompareTo(passageiro) != 0) return -1;
                else return i;
            }
            public void cancelarReserva(String passageiro)
            {
                int i = 0;
                int compare = (assento[i].CompareTo(passageiro));
                while (compare != 0 && i < assento.Length)
                {
                    if (compare == 0)
                    {
                        assento[i] = "";
                    }
                    else
                    {
                        i++;
                        compare = assento[i].CompareTo(passageiro);
                    }
                }
            }
            public int obterNumAssentosOcupados()
            {
                int contLugares = 0;
                for (int i = 0; i < assento.Length; i++)
                {
                    if (assento[i] != "") contLugares++;
                }
                return contLugares;
            }
            public void exibirDistribuicaoReservas()
            {
                for (int i = 0; i < assento.Length; i++)
                {
                    if (assento[i] == "") Console.WriteLine("Poltrona {0} vazia"+i);
                        
                    else Console.WriteLine("Poltrona nº "+i+" - "+assento[i]);
                }
            }
        }


        static void Main(string[] args)
        {
            int poltrona;
            DateTime dataHora;
            dataHora = new DateTime(2018, 3, 1, 10, 40, 0);
            // data e horário do vôo que será criado: 1/3/2018, às 10:40.
            Voo objVoo = new Voo(7149, "Belo Horizonte", "Rio de Janeiro", dataHora, 5); // Criação do vôo número 7149, de Belo Horizonte para o Rio deJaneiro, no dia 1 / 3 / 2018, às 10:40, com 5 assentos disponíveis.
            poltrona = objVoo.reservar("Carlos");
            poltrona = objVoo.reservar("Maria");
            poltrona = objVoo.reservar("Pedro");
            Console.WriteLine("Ocupação do vôo após as três reservas iniciais:");
            objVoo.exibirDistribuicaoReservas(); // Carlos - Maria - Pedro - vazia - vazia
            poltrona = objVoo.obterPoltrona("Maria");
            Console.WriteLine("A passageira Maria ocupa o assento {0}", poltrona);
            objVoo.cancelarReserva("Maria");
            Console.WriteLine("Ocupação do vôo após o cancelamento de uma das reservas: ");

            objVoo.exibirDistribuicaoReservas(); // Carlos - vazia - Pedro - vazia - vazia
            poltrona = objVoo.reservar("Ana");
            Console.WriteLine("Ocupação do vôo após nova reserva:");
            objVoo.exibirDistribuicaoReservas(); // Carlos - Maria - Pedro - vazia - vazia
            Console.WriteLine("Este vôo apresenta {0} assentos ocupados.", objVoo.obterNumAssentosOcupados()); // 3
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Trabalho_AED
{
    class Banco
    {
        private HashOperaçoes.HashOperacao operacoes;
        public HashOperaçoes.HashOperacao _operacoes
        {
            get { return operacoes; }
            set { operacoes = value; }
        }

        private ListaClientes clientes;
        public ListaClientes _clientes
        {
            get { return clientes; }
            set { clientes = value; }
        }

        private ListaContas contas;
        public ListaContas _contas
        {
            get { return contas; }
            set { contas = value; }
        }

        public Banco()
        {
            _operacoes = new HashOperaçoes.HashOperacao();
            _clientes = new ListaClientes();
            _contas = new ListaContas();
        }

        public void LerArquivoDeClientes()
        {
            OpenFileDialog busca = new OpenFileDialog();
            busca.Filter = "Arquivo Texto|*.txt";
            busca.Title = "Arquivo";

            if (busca.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(busca.FileName))
                {
                    string linha;
                    string[] vetlinha;
                    while ((linha = reader.ReadLine()) != null)
                    {
                        vetlinha = linha.Split(';');
                        Cliente novo = new Cliente(vetlinha[1], vetlinha[0]);
                        clientes.Adicionar(novo);
                    }
                }
            }
        }
        public void LerArquivoDeContas()
        {
            OpenFileDialog busca = new OpenFileDialog();
            busca.Filter = "Arquivo Texto|*.txt";
            busca.Title = "Arquivo";

            if (busca.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(busca.FileName))
                {
                    string linha;
                    string[] vetlinha;
                    while ((linha = reader.ReadLine()) != null)
                    {
                        vetlinha = linha.Split(';');
                        ContaBancaria novo = new ContaBancaria(Convert.ToInt32(vetlinha[0]), Convert.ToDouble(vetlinha[3]),vetlinha[2]);
                        contas.Adicionar(novo);
                    }
                }
            }
        }
        public void LerArquivoDeOperações()
        {
            OpenFileDialog busca = new OpenFileDialog();
            busca.Filter = "Arquivo Texto|*.txt";
            busca.Title = "Arquivo";

            if (busca.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(busca.FileName))
                {
                    string linha;
                    string[] vetlinha;
                    while ((linha = reader.ReadLine()) != null)
                    {
                        vetlinha = linha.Split(';');
                        string[] vetdata = vetlinha[3].Split('/');
                        DateTime datanova = new DateTime(Convert.ToInt32(vetdata[2]), Convert.ToInt32(vetdata[1]), Convert.ToInt32(vetdata[0]));
                        if (vetlinha[1] == "1")
                        {
                            Operacao novo = new Deposito(datanova, Convert.ToDouble(vetlinha[2]),Convert.ToInt32(vetlinha[0]));
                            _operacoes.AdcOperacao(novo);
                            _contas.BuscaBinaria(vetlinha[0]).Deposita(Convert.ToDouble(vetlinha[2]));
                            
                        }
                        else if (vetlinha[1] == "2")
                        {
                            Operacao novo = new Saque(datanova, Convert.ToDouble(vetlinha[2]), Convert.ToInt32(vetlinha[0]));
                            _operacoes.AdcOperacao(novo);
                            _contas.BuscaBinaria(vetlinha[0]).Sacar(Convert.ToDouble(vetlinha[2]));
                        }
                        else
                        {
                            Operacao novo = new Rendimento(datanova, Convert.ToDouble(vetlinha[2]), Convert.ToInt32(vetlinha[0]));
                            _operacoes.AdcOperacao(novo);
                            _contas.BuscaBinaria(vetlinha[0]).Rendimento();
                        }
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Trabalho_AED
{
    public partial class Form1 : Form
    {
        Banco banco;
        public Form1()
        {
            InitializeComponent();
            banco = new Banco();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            maskedTextBox1.Enabled = false;
            DesativarBotoes();
        }
        public void DesativarBotoes()
        {
            label1.Visible = false;
            button5.Visible = false;
            maskedTextBox2.Visible = false;
            carregarContasToolStripMenuItem.Enabled = false;
            carregarOperaçõesToolStripMenuItem.Enabled = false;
            label2.Visible = false;
            label3.Visible = false;
            maskedTextBox3.Visible = false;
            button6.Visible = false;
            button4.Visible = false;
            maskedTextBox4.Visible = false;
            maskedTextBox5.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Botão
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DesativarBotoes();
                listBox1.Items.Clear();
                listBox1.Items.Add("Data:       Nº Conta: Operação:  Valor R$:");
                string dataPedida = maskedTextBox1.Text;
                string[] criadata = dataPedida.Split('/');
                DateTime teste = new DateTime(Convert.ToInt32(criadata[2]), Convert.ToInt32(criadata[1]), Convert.ToInt32(criadata[0]));
                string listaDataPedida = banco._operacoes.PesquisarData(teste).ImprimirTodos();
                string[] net = listaDataPedida.Split(';');
                for (int i = 0; i < net.Length; i++)
                {
                    listBox1.Items.Add(net[i]);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Data invalida ou não há operações!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DesativarBotoes();
                listBox1.Items.Clear();
                listBox1.Items.Add("Nº CPF:     Nome:");
                for (int i = 0; i < banco._clientes.contador; i++)
                {
                    listBox1.Items.Add(banco._clientes.vetorClientes[i].cpf + "  " + banco._clientes.vetorClientes[i].nomeCliente);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DesativarBotoes();
                listBox1.Items.Clear();
                listBox1.Items.Add("Nº CPF:   Nº Conta:  Valor R$:");
                for (int i = 0; i < banco._contas.contador; i++)
                {
                    listBox1.Items.Add(banco._contas.vetorContas[i].cpfCliente + "  " + banco._contas.vetorContas[i].numConta + "  " + banco._contas.vetorContas[i].saldo.ToString("c"));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //faltou implementa melhor
            try
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Data:       Nº Conta: Operação:  Valor R$:");
                string dataPedida1 = maskedTextBox4.Text;
                string[] criadata1 = dataPedida1.Split('/');
                DateTime data1 = new DateTime(Convert.ToInt32(criadata1[2]), Convert.ToInt32(criadata1[1]), Convert.ToInt32(criadata1[0]));
                string dataPedida2 = maskedTextBox5.Text;
                string[] criadata2 = dataPedida2.Split('/');
                DateTime data2 = new DateTime(Convert.ToInt32(criadata2[2]), Convert.ToInt32(criadata2[1]), Convert.ToInt32(criadata2[0]));
                while (data1 <= data2)
                {
                    int dias = (int)data2.Subtract(data1).TotalDays;
                    string listaDataPedida = banco._operacoes.PesquisarData(data1).ImprimirTodos();
                    string[] net = listaDataPedida.Split(';');
                    for (int i = 0; i < net.Length - 1; i++)
                    {
                        string[] net2 = net[i].Split(' ');
                        if (Convert.ToInt32(net2[1]) == Convert.ToInt32(maskedTextBox3.Text))
                        {
                            listBox1.Items.Add(net2[0] + "  " + net2[1] + "  " + net2[2] + "  " + net2[3] + " " + net2[4]);
                        }
                    }
                    data1 = data1.AddDays(1);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Data invalida ou Nº invalido!");
                return;
            }


        }

        /// <summary>
        /// Menu "Dados" / "Carregar Clientes"
        /// </summary>
        private void carregarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            banco.LerArquivoDeClientes();
            banco._clientes.OrdenarLista();
            carregarContasToolStripMenuItem.Enabled = true;
            carregarClientesToolStripMenuItem.Enabled = false;
            label4.Text = "Carregue os Arquivos!\n* Clientes✓\n* Contas\n* Operações";
        }

        /// <summary>
        /// Menu "Dados" / "Carregar Contas"
        /// </summary>
        private void carregarContasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            banco.LerArquivoDeContas();
            banco._contas.OrdenarLista();
            carregarOperaçõesToolStripMenuItem.Enabled = true;
            carregarContasToolStripMenuItem.Enabled = false;
            label4.Text = "Carregue os Arquivos!\n* Clientes✓\n* Contas✓\n* Operações";
        }

        /// <summary>
        /// Menu "Dados" / "Carregar Operações"
        /// </summary>
        private void carregarOperaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label4.Text = "Carregue os Arquivos!\n* Clientes✓\n* Contas✓\n* Operações(Carregando...)";
            banco.LerArquivoDeOperações();
            carregarOperaçõesToolStripMenuItem.Enabled = false;
            label4.Text = "Carregue os Arquivos!\n* Clientes✓\n* Contas✓\n* Operações✓";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            maskedTextBox1.Enabled = true;
        }

        /// <summary>
        /// Menu "Buscar"
        /// </summary>
        private void operaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (carregarClientesToolStripMenuItem.Enabled == false && carregarContasToolStripMenuItem.Enabled == false && carregarOperaçõesToolStripMenuItem.Enabled == false)
            {
                buscarClienteToolStripMenuItem.Enabled = true;
                buscarContaToolStripMenuItem.Enabled = true;
                buscarOperaçõesToolStripMenuItem.Enabled = true;
            }
            else
            {
                buscarClienteToolStripMenuItem.Enabled = false;
                buscarContaToolStripMenuItem.Enabled = false;
                buscarOperaçõesToolStripMenuItem.Enabled = false;
                MessageBox.Show("Por favor Carregue os aquivos primeiro, em Dados");
            }
        }

        /// <summary>
        /// Menu "Buscar" / "Buscar Contas de um Cliente"
        /// </summary>
        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DesativarBotoes();
            label1.Text = "Buscar Contas de um Cliente:";
            label1.Visible = true;
            maskedTextBox3.Visible = true;
            button6.Visible = true;
        }

        /// <summary>
        /// Menu "Buscar" / "Buscar Operações de uma Conta"
        /// </summary>
        private void buscarContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DesativarBotoes();
            label1.Text = "Buscar Operações de uma Conta:";
            label1.Visible = true;
            button4.Visible = true;
            maskedTextBox3.Visible = true;
            maskedTextBox4.Visible = true;
            maskedTextBox5.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
        }

        /// <summary>
        /// Menu "Buscar" / "Buscar Operações de Saques e Depositos"
        /// </summary>
        private void buscarOperaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DesativarBotoes();
            label1.Text = "Buscar Operações de Saques e Depositos:";
            label1.Visible = true;
            button5.Visible = true;
            maskedTextBox2.Visible = true;
        }

        /// <summary>
        /// Botão de "Buscar Operações de Saques e Depositos", metodo para buscar as operações
        /// </summary>
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Data:       Nº Conta: Operação:  Valor R$:");
                int contSaq = 0, contDep = 0;
                string dataPedida = maskedTextBox2.Text;
                string[] criadata = dataPedida.Split('/');
                DateTime teste = new DateTime(Convert.ToInt32(criadata[2]), Convert.ToInt32(criadata[1]), Convert.ToInt32(criadata[0]));
                string listaDataPedida = banco._operacoes.PesquisarData(teste).ImprimirTodos();
                string[] net = listaDataPedida.Split(';');
                for (int i = 0; i < net.Length - 1; i++)
                {
                    string[] net2 = net[i].Split(' ');
                    if (net2[2] == "Saque" || net2[2] == "Deposito")
                    {
                        listBox1.Items.Add(net2[0] + "  " + net2[1] + "  " + net2[2] + "  " + net2[3] + " " + net2[4]);
                        if (net2[2] == "Saque")
                        {
                            contSaq++;
                        }
                        else
                        {
                            contDep++;
                        }
                    }
                }
                label2.Text = "Saques: " + contSaq;
                label3.Text = "Depositos: " + contDep;
                label2.Visible = true;
                label3.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Data invalida ou não há operações!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string cpf = maskedTextBox3.Text;
                listBox1.Items.Clear();
                listBox1.Items.Add("Nº CPF: " + cpf);
                listBox1.Items.Add("Nº Conta:  Valor R$:");
                for (int i = 0; i < banco._contas.contador; i++)
                {
                    if (cpf == banco._contas.vetorContas[i].cpfCliente)
                    {
                        listBox1.Items.Add(banco._contas.vetorContas[i].numConta + "  " + banco._contas.vetorContas[i].saldo.ToString("c"));
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace gestao_de_cliente
{
    public partial class frm_pesquisa : Form
    {
        ArrayList nomes = new ArrayList();
        bool state = true;

        public frm_pesquisa()
        {
            InitializeComponent();
        }

        private void Pesquisa_Load(object sender, EventArgs e)
        {
            Listar();
            btn_listagem.Visible = false;
        }

        public void Listar()
        {
            btn_limpar.Enabled = false;

            try
            {
                int qtdCliente = DadosDeContas.QuantCadastro();
                dgv_listaClientes.Rows.Add(qtdCliente);
                btn_limpar.Enabled = true;

                int i = 0;
                foreach (var item in DadosDeContas.nome)
                {
                    dgv_listaClientes[0, i].Value = item;
                    dgv_listaClientes[1, i].Value = DadosDeContas.nConta[i];
                    dgv_listaClientes[2, i].Value = DadosDeContas.IBAN[i];
                    dgv_listaClientes[3, i].Value = DadosDeContas.saldo[i];
                    dgv_listaClientes[4, i].Value = DadosDeContas.senha[i];
                    i++;
                }
                btn_ordenar.Enabled = true;
            }
            catch (Exception) { MessageBox.Show("Não tem nehum cliente cadastrado!"); }
        }

        private void btn_listagem_Click(object sender, EventArgs e)
        {
            Listar();
            btn_limpar.Visible = true;
            btn_ordenar.Visible = true;
            btn_listagem.Enabled = false;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            dgv_listaClientes.Rows.Clear();
            btn_limpar.Enabled = false;
            btn_listagem.Visible = true;
            btn_listagem.Enabled = true;
            btn_ordenar.Enabled = false;
        }

        private void btn_ordenar_Click(object sender, EventArgs e)
        {
           
            int tamanho = DadosDeContas.QuantCadastro();

            for (int i = 0; i < tamanho; i++)
            {
                nomes.Add(DadosDeContas.nome[i]);
            }

            if (state) nomes.Sort();

            int cont = 0;

            for (int i = 0; i < tamanho; i++)
            {
                for (int colecao = 0; colecao < tamanho; colecao++)
                {
                    if (nomes[i] == DadosDeContas.nome[colecao])
                    {
                        int indice = colecao;

                        dgv_listaClientes[0, i].Value = DadosDeContas.nome[indice];
                        dgv_listaClientes[1, i].Value = DadosDeContas.nConta[indice];
                        dgv_listaClientes[2, i].Value = DadosDeContas.IBAN[indice];
                        dgv_listaClientes[3, i].Value = DadosDeContas.saldo[indice];
                        dgv_listaClientes[4, i].Value = DadosDeContas.senha[indice];

                        cont++;
                    }

                }
                state = false;
            }
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            dgv_listaClientes.Rows.Clear();
            string nome = txt_pesquizar.Text.ToLower();

            int k = 0;
            for(int i = 0; i < DadosDeContas.QuantCadastro(); i++)
            {
                string Dnome = DadosDeContas.nome[i].ToString().ToLower();
                for(int j = 0; j < Dnome.Length; j++)
                {
                    if (Dnome.Substring(0, j) == nome)
                    {
                        dgv_listaClientes.Rows.Add();
                        dgv_listaClientes[0, k].Value = DadosDeContas.nome[i];
                        dgv_listaClientes[1, k].Value = DadosDeContas.nConta[i];
                        dgv_listaClientes[2, k].Value = DadosDeContas.IBAN[i];
                        dgv_listaClientes[3, k].Value = DadosDeContas.saldo[i];
                        dgv_listaClientes[4, k].Value = DadosDeContas.senha[i];
                        k++;
                    }
                }
            }
        }
    }
}

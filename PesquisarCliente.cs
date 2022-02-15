using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestao_de_cliente
{
    public partial class frm_pesquisarCliente : Form
    {
        Operacoes operacao = new Operacoes();

        public frm_pesquisarCliente()
        {
            InitializeComponent();
        }
        Form formX;
        Panel panX;
        public frm_pesquisarCliente(Panel pan, Form form)
        {
            InitializeComponent();
            panX = pan;
            formX = form;
        }

        Form formActivo;
        private void abrirForm(Form form)
        {
            if (formActivo != null)
            {
                formActivo.Close();
                panX.Controls.Clear();
            }

            formActivo = form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            panX.Controls.Add(form);
            panX.Tag = form;
            form.BringToFront();
            form.Show();
        }


        int index = -1;
        int indice = -1;

        private void button4_Click(object sender, EventArgs e)
        {
            abrirForm(formX);
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            string nConta = txt_nConta.Text;

            index = operacao.NewBinarySearch(DadosDeContas.nConta,nConta);

            if (index >= 0)
            {
                lbl_nome.Text = DadosDeContas.nome[index].ToString();
                lbl_nConta.Text = DadosDeContas.nConta[index].ToString();
                lbl_saldo.Text = DadosDeContas.saldo[index].ToString();
                MostrarBotoes();
            }
            else
                MessageBox.Show("Cliente não encontrado!");
        }

        private void frm_pesquisarCliente_Load(object sender, EventArgs e)
        {
            EsconderBotoes();
        }

        private void btn_pesquisarIndixe_Click(object sender, EventArgs e)
        {
            try
            {
                indice = int.Parse(txt_indice.Text);

                if (indice >= DadosDeContas.QuantCadastro())
                    MessageBox.Show("Indice inexistente!");
                else
                {
                    lbl_nome.Text = DadosDeContas.nome[indice].ToString();
                    lbl_nConta.Text = DadosDeContas.nConta[indice].ToString();
                    lbl_saldo.Text = DadosDeContas.saldo[indice].ToString();
                    MostrarBotoes();
                }
            }
            catch (Exception) { MessageBox.Show("Por favor insira o indice para poder procurar"); }
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            var resp = DialogResult;

            resp = MessageBox.Show("Tem certeza que quer remover esta conta?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                if (index > -1)
                {
                    DadosDeContas.nome.RemoveAt(index);
                    DadosDeContas.nConta.RemoveAt(index);
                    DadosDeContas.saldo.RemoveAt(index);
                    DadosDeContas.IBAN.RemoveAt(index);
                    DadosDeContas.tel.RemoveAt(index);
                    MessageBox.Show("Conta Removida com Sucesso!");

                    DadosDeContas.ActualizarFicheiro();
                    RefazerPagina();
                }
                else if (indice > -1)
                {
                    DadosDeContas.nome.RemoveAt(indice);
                    DadosDeContas.nConta.RemoveAt(indice);
                    DadosDeContas.saldo.RemoveAt(indice);
                    DadosDeContas.IBAN.RemoveAt(indice);
                    DadosDeContas.tel.RemoveAt(indice);
                    MessageBox.Show("Conta Removida com Sucesso!");

                    DadosDeContas.ActualizarFicheiro();
                    RefazerPagina();
                }
            }else { MessageBox.Show("Operação cancelada"); }
        }

        public void EsconderBotoes()
        {
            btn_remover.Visible = false;
            btn_substituir.Visible = false;
        }
        public void MostrarBotoes()
        {
            btn_remover.Visible = true;
            btn_substituir.Visible = true;
        }
        public void RefazerPagina()
        {
            EsconderBotoes();
            lbl_nome.Text = "--------------------";
            lbl_nConta.Text = "-------------------";
            lbl_saldo.Text = "--------------";
            operacao.LimparTudo(Controls);
        }

        private void btn_substituir_Click(object sender, EventArgs e)
        {
            if(index> -1)
                abrirForm(new frm_substituir(panX, formX,index));
            else
                abrirForm(new frm_substituir(panX, formX, indice));
        }
    }
}

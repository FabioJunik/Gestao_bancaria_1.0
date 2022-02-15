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
    public partial class frm_CSaque : Form
    {
        int index = 0;
        public frm_CSaque()
        {
            InitializeComponent();
        }

        Operacoes operacao = new Operacoes();
        Verificacoes verificacao = new Verificacoes();
        Form formX;
        Panel panX;
        public frm_CSaque(Panel pan, Form form)
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
        private void btn_saquar_Click(object sender, EventArgs e)
        {
            try
            {
                string nConta = txt_nConta.Text;

                index = operacao.NewBinarySearch(DadosDeContas.nConta, nConta);
                if (index >= 0)
                {
                    int saldo = int.Parse(DadosDeContas.saldo[index].ToString());
                    int  saque = int.Parse(txt_valor.Text);
                    int novoSaldo = saldo - saque;

                    if (novoSaldo < 0)
                        MessageBox.Show("Operação invalida\nSaque superior ao Saldo");
                    else
                    {
                        DadosDeContas.saldo.RemoveAt(index);
                        DadosDeContas.saldo.Insert(index, novoSaldo);
                        DadosDeContas.ActualizarFicheiro();
                        MessageBox.Show("-" + saque + "KZ\nRestou agora com " + DadosDeContas.saldo[index], 
                                        DadosDeContas.nome[index].ToString());
                    }
                    operacao.LimparTudo(Controls);
                }
                else
                    MessageBox.Show("Conta Inexistente!");
            }
            catch (Exception)
            { MessageBox.Show("Preencha todos os campos para poder continuar"); }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            abrirForm(formX);
        }

        private void txt_valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificacao.IntNumber(e);
        }
    }
}

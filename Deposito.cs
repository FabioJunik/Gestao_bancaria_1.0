using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace gestao_de_cliente
{
    public partial class frm_deposito : Form
    {
        int index=0;
        
        public frm_deposito()
        {
            InitializeComponent();
        }

        Operacoes operacao = new Operacoes();
        Verificacoes verificacao = new Verificacoes();
        Form formX;
        Panel panX;
        public frm_deposito(Panel pan, Form form)
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
        private void btn_depositar_Click(object sender, EventArgs e)
        {
            try
            {
                string nConta = txt_nConta.Text;

                index = operacao.NewBinarySearch(DadosDeContas.nConta,nConta);
                if (index >= 0)
                {
                    int saldo = int.Parse(DadosDeContas.saldo[index].ToString());
                    int deposito = int.Parse(txt_valor.Text);

                    if (deposito < 0)
                        MessageBox.Show("Valor invalido");
                    else
                    {
                        int novoSaldo = saldo + deposito;

                        DadosDeContas.saldo.RemoveAt(index);
                        DadosDeContas.saldo.Insert(index, novoSaldo);
                    }
                    DadosDeContas.ActualizarFicheiro();
                    MessageBox.Show("Deposito feito com sucesso!\nSaldo Actual: "+DadosDeContas.saldo[index]
                                        ,DadosDeContas.nome[index].ToString());
                    operacao.LimparTudo(Controls);
                }
                else
                    MessageBox.Show("Conta Inexistente!");
            }catch(Exception)
            { MessageBox.Show("Por favor preencha todos os campos!"); }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            abrirForm(formX);
        }

        private void txt_valor_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}

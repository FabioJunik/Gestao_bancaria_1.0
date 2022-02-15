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
    public partial class frm_entrar : Form
    {
        Verificacoes verificacao = new Verificacoes();
        Operacoes operacao = new Operacoes();
        public frm_entrar()
        {
            InitializeComponent();
        }

        private void frm_entrar_Load(object sender, EventArgs e)
        {

        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
           
            string nConta = txt_nConta.Text.Trim();
            string senha = txt_senha.Text;

            if (verificacao.AlgumVazio(Controls))
            {
                int index = operacao.NewBinarySearch(DadosDeContas.nConta, nConta);

                if (index < 0)
                    MessageBox.Show("Conta Inexistente!\nCadastre-se primeiro para poder entrar");
                else if (DadosDeContas.senha[index].ToString() == senha)
                {
                    frm_dentro dentro = new frm_dentro(index);
                    dentro.ShowDialog();
                    Close();
                }
                else
                    MessageBox.Show("Senha incorrecta");
            }
            else { MessageBox.Show("Preencha os dados para poder continuar!","",MessageBoxButtons.OK,MessageBoxIcon.Information);}
        }

        private void txt_nConta_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificacao.IntNumber(e);
            if (txt_senha.Text.Length == 4)
                e.Handled = true;

            if (e.KeyChar == 8)
                e.Handled = false;
        }
    }
}

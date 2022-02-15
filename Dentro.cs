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
    public partial class frm_dentro : Form
    {
        int index=0;
        Operacoes operacao = new Operacoes();

        public frm_dentro(int index)
        {
            InitializeComponent();
            this.index = index;
        }

        private void btn_consultaDados_Click(object sender, EventArgs e)
        {
            frm_dadosDeConta dadosDeConta = new frm_dadosDeConta(index);
            dadosDeConta.ShowDialog();
            Visible = false;
        }

        private void btn_depositos_Click(object sender, EventArgs e)
        {
           
        }
        private void btn_saldo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DadosDeContas.saldo[index].ToString());
        }

        private void btn_saques_Click(object sender, EventArgs e)
        {
            try
            {
                int saldo = int.Parse(DadosDeContas.saldo[index].ToString());
                int saque = int.Parse(Interaction.InputBox("Infome o valor do Deposito"));
                int novoSaldo = saldo - saque;

                if (novoSaldo < 0)
                    MessageBox.Show("Operação invalida\nSaque superior ao Saldo");
                else
                {
                    DadosDeContas.saldo.RemoveAt(index);
                    DadosDeContas.saldo.Insert(index, novoSaldo);
                    MessageBox.Show("-" + saque + "\nRestou agora com " + DadosDeContas.saldo[index]);
                }
            }
            catch (Exception){ MessageBox.Show("Operação invalida\nNão foi informa o valor do saque"); }
        }

        private void frm_dentro_Load(object sender, EventArgs e)
        {
            lbl_nome.Text ="("+operacao.AbreviarNome(DadosDeContas.nome[index].ToString())+")";
            
        }

        private void btn_tranferencias_Click(object sender, EventArgs e)
        {
            Visible = false;
            frm_transferencia transferencia = new frm_transferencia(index);
            transferencia.ShowDialog();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_fe_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Visible = true;
            Close();
        }
    }
}

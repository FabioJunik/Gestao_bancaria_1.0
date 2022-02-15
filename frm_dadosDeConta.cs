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
    public partial class frm_dadosDeConta : Form
    {
        int index = 0;
        Operacoes operacao = new Operacoes();
        frm_cadastrar cadastrar = new frm_cadastrar();
        frm_dentro dentro;

        public frm_dadosDeConta(int index)
        {
            InitializeComponent();
            this.index = index;
        }

        private void frm_dadosDeConta_Load(object sender, EventArgs e)
        {
            lbl_tel.Text = DadosDeContas.tel[index].ToString();
            lbl_nome.Text = DadosDeContas.nome[index].ToString();
            lbl_data.Text = DadosDeContas.data[index].ToString();
            lbl_IBAN.Text = DadosDeContas.IBAN[index].ToString();
            lbl_nConta.Text = DadosDeContas.nConta[index].ToString();
            lbl_senha.Text = DadosDeContas.senha[index].ToString();
            lbl_saldo.Text = DadosDeContas.saldo[index].ToString();

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            operacao.LimparTudo(cadastrar.Controls);
            Close();
            cadastrar.Visible = true;
        }

        private void btn_dentro_Click(object sender, EventArgs e)
        {
            dentro = new frm_dentro(index);
            Close();
            cadastrar.Close();
            dentro.Visible= true;
        }

    }
}
        

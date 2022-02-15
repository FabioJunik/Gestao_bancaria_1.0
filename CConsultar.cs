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
    public partial class frm_CConsultar : Form
    {
        Operacoes operacao = new Operacoes();
        Verificacoes verificacao = new Verificacoes();
        manipulacaoForm abrirForm;
        Form form;

        public frm_CConsultar(Panel pan, Form form)
        {
            InitializeComponent();
            abrirForm = new manipulacaoForm(pan, form);

            this.form = form;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            abrirForm.abrirForm(form);
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            string nConta = txt_nConta.Text;

            int index = operacao.NewBinarySearch(DadosDeContas.nConta,nConta);
            
            if (nConta == "")
            {
                MessageBox.Show("Por favor informe a conta", "Messagem", MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);
            }
            else if (index < 0)
                MessageBox.Show("Conta Inexistente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("O Saldo: " + DadosDeContas.saldo[index], DadosDeContas.nome[index].ToString());
            }

            operacao.LimparTudo(Controls);
        }
        
    }
}

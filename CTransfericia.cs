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
    public partial class frm_CTransfericia : Form
    {
        Operacoes operacao = new Operacoes();
        Verificacoes verificacao = new Verificacoes();
        manipulacaoForm abrir;

        Form form;

        public frm_CTransfericia(Panel pan, Form form)
        {
            InitializeComponent();
            abrir = new manipulacaoForm(pan, form);
            this.form = form;
        }
        
        private void CTransfericia_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrir.abrirForm(form);
        }

        private void btn_depositar_Click(object sender, EventArgs e)
        {
            string nConta = txt_nConta.Text;
            int index = operacao.NewBinarySearch(DadosDeContas.nConta, nConta);

            string IBAN = ("AO06" + txt_IBAN.Text).ToString();
            int indexx = operacao.NewBinarySearch(DadosDeContas.IBAN,IBAN);

            MessageBox.Show(IBAN.ToString() + "\n" + indexx.ToString());
            if (index >= 0)
            {
                int valor = int.Parse(txt_valor.Text);
                int saldo = int.Parse(DadosDeContas.saldo[index].ToString());

                if (saldo >= valor)
                {
                    if (indexx >= 0)
                    {
                        var resposta = DialogResult;
                        resposta = MessageBox.Show("Transferencia sera feita para "+ DadosDeContas.nome[indexx]+
                                          "\nValor da transferencia:" + valor,"Transferência"
                                           , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resposta == DialogResult.No)
                            MessageBox.Show("Operação cancelada");
                        if (resposta == DialogResult.Yes)
                        {
                            int saldoTrans = int.Parse(DadosDeContas.saldo[indexx].ToString()) + valor;

                            operacao.Substituir(index, (saldo - valor).ToString());
                            operacao.Substituir(indexx, saldoTrans.ToString());
                            DadosDeContas.ActualizarFicheiro();
                            MessageBox.Show("Tranferencia feita com sucesso");
                        }
                    }
                    else
                    {
                        var resposta = DialogResult;

                        resposta = MessageBox.Show("Transferencia sendo feita para uma conta disconhecida",
                                        "Transferencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        
                        if (resposta == DialogResult.No)
                            MessageBox.Show("Operação cancelada");

                        if (resposta == DialogResult.Yes)
                        {
                            operacao.Substituir(index, (saldo - valor).ToString());
                        }
                    }
                }
                else
                    MessageBox.Show("Seu saldo actual é menor que o valor de transferencia!");
            }
            else
                MessageBox.Show("Conta inexistente\nCastre primeiro para poder fazer a transferencia!");
        }

        private void txt_nConta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

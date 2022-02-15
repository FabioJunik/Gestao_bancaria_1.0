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
    public partial class frm_transferencia : Form
    {
        int index = 0;
        Verificacoes verificacoes = new Verificacoes();
        Operacoes operacao = new Operacoes();
        frm_dentro dentro;

        public frm_transferencia(int index)
        {
            InitializeComponent();
            this.index = index;
            dentro = new frm_dentro(index);
        }

        private void btn_transferir_Click(object sender, EventArgs e)
        {
            Object IBAN = ("AO06"+txt_IBAN.Text).ToString();
            int indexx = DadosDeContas.IBAN.BinarySearch(IBAN);

            int valor = int.Parse(txt_valor.Text);
            int saldo = int.Parse(DadosDeContas.saldo[index].ToString());

            //MessageBox.Show(IBAN.ToString()+"\n"+indexx.ToString());

            if (saldo >= valor)
            {
                if (indexx >= 0)
                {

                    int saldoTrans = int.Parse(DadosDeContas.saldo[indexx].ToString()) + saldo;

                    operacao.Substituir(index, (saldo - valor).ToString());
                    operacao.Substituir(indexx, saldoTrans.ToString());

                    MessageBox.Show("Transferencia feita para " + DadosDeContas.nome[indexx] +
                                      "\nValor da transferencia:" + valor +
                                      "\nSeu saldo actual: " + DadosDeContas.saldo[index]);

                }
                else
                {
                    operacao.Substituir(index, (saldo - valor).ToString());
                    MessageBox.Show("Transferencia feita com sucesso" +
                                    "\nValor da transferencia:" + valor +
                                      "\nSeu saldo actual: " + DadosDeContas.saldo[index]);
                }
            }
            else
                MessageBox.Show("Seu saldo actual é menor que o valor de transferencia!");
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
            dentro.Visible = true;
        }

        private void txt_valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificacoes.IntNumber(e);
        }

        private void txt_IBAN_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificacoes.IntNumber(e);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace gestao_de_cliente
{
    public partial class frm_cadastrar : Form
    {
        int i = 0;
        Operacoes operacao = new Operacoes();
        Verificacoes vericacao = new Verificacoes();
         
        string nome = "";
        string senha = "";
        string data = "";
        string cSenha = "";
        string nConta = "";
        string IBAN = "";
        string saldoInicial = "";
        string tel = "";

        public frm_cadastrar()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            LerCampo();
            ValidarCadastro();
        }

        public void LerCampo()
        {
            nome =txt_nome.Text;
            senha = txt_senha.Text;
            data = dtp_nascimeto.Text;
            cSenha = txt_confirmar.Text;
            nConta = operacao.GerarNConta();
            IBAN = operacao.GerarIBAM(nConta);
            saldoInicial = txt_saldoInicial.Text;
            tel = txt_tel.Text;
        }

        public void ValidarCadastro()
        {
            if (!vericacao.AlgumVazio(this.Controls))
            {
                MessageBox.Show("CADASTRO ENTERRONPIDO\nPreencha todos os campos!");
            }
            else if (int.Parse(saldoInicial) < 100)
            {
                MessageBox.Show("O valor de entrada tem que ser igual ou superior a 100", "Valor de entrada",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_saldoInicial.Focus();
            }
            else if (!vericacao.SenhaValidar(senha))
            {
                MessageBox.Show("Senha invalida!\nTem que ter 4 digitos");
            }
            else if (senha != cSenha)
            {
                MessageBox.Show("Confirmação de senha invalida\nVerifique os campos para poder para continuar!");
                txt_confirmar.Text = "";
                txt_confirmar.Focus();
            }
            else if (!vericacao.phoneNumber(tel))
            {
                MessageBox.Show("Número de telefone invalido!");
                txt_tel.Text = "";
                txt_tel.Focus();
            }
            else if (!vericacao.NomeValido(txt_nome.Text))
            {
                MessageBox.Show("NOME INVALIDO!\nPor favor verifique se o seu nome esta bem escrito");
            }
            else
            {
                AddDanco();
                MessageBox.Show("Cadastro feito com sucesso agora podes dispor dos nossos serviços");
                this.Visible = false;
                i = DadosDeContas.QuantCadastro()- 1;
                frm_dadosDeConta dadosDeConta = new frm_dadosDeConta(i);
                dadosDeConta.ShowDialog();

            }
        }

        public void AddDanco()
        {
            StreamWriter _nome = new StreamWriter(@"C:\gestão de cliente\nome.txt", true);
            StreamWriter _tel = new StreamWriter(@"C:\gestão de cliente\telefone.txt", true);
            StreamWriter _data = new StreamWriter(@"C:\gestão de cliente\data.txt", true);
            StreamWriter _senha = new StreamWriter(@"C:\gestão de cliente\senha.txt", true);
            StreamWriter _IBAN = new StreamWriter(@"C:\gestão de cliente\IBAN.txt", true);
            StreamWriter _saldo = new StreamWriter(@"C:\gestão de cliente\saldo.txt", true);
            StreamWriter _nConta = new StreamWriter(@"C:\gestão de cliente\nConta.txt", true);

            _nome.WriteLine(operacao.OrganizarNome(nome));
            _nome.Close();
            _tel.WriteLine(tel);
            _tel.Close();
            _data.WriteLine(data);
            _data.Close();
            _saldo.WriteLine(saldoInicial);
            _saldo.Close();
            _senha.WriteLine(senha);
            _senha.Close();               
            _nConta.WriteLine(nConta);
            _nConta.Close();
            _IBAN.WriteLine(IBAN);
            _IBAN.Close();
        }

        private void txt_senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            vericacao.IntNumber(e);

            if (txt_senha.Text.Length == 4)
                e.Handled = true;

            if (e.KeyChar == 8)
                e.Handled = false;
        }
            
        private void txt_confirmar_KeyPress(object sender, KeyPressEventArgs e)
        {
            vericacao.IntNumber(e);
            if (txt_confirmar.Text.Length == 4) e.Handled = true;
            if (e.KeyChar == 8) e.Handled = false;
        }

        private void txt_saldoInicial_KeyPress(object sender, KeyPressEventArgs e)
        {vericacao.IntNumber(e);}

        private void txt_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            vericacao.IntNumber(e);
            if (txt_tel.Text.Length == 9)
                e.Handled = true;

            if (e.KeyChar == 8)
                e.Handled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            Form1 principal = new Form1();
            principal.Visible = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operacao.LimparTudo(Controls);
        }

        private void txt_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            vericacao.ApenasTexto(e);
        }

        private void frm_cadastrar_Load(object sender, EventArgs e)
        {

        }
    }
}

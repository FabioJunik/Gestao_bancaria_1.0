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
    public partial class frm_substituir : Form
    {
        Operacoes operacao = new Operacoes();
        Verificacoes verificacao = new Verificacoes();
        frm_cadastrar cadastrar = new frm_cadastrar();
        public frm_substituir()
        {
            InitializeComponent();
        }
        Form formX;
        Panel panX;
        int index = 0;

        public frm_substituir(Panel pan, Form form, int index)
        {
            InitializeComponent();
            panX = pan;
            formX = form;
            this.index = index;
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

        private void button4_Click(object sender, EventArgs e)
        {
            abrirForm(formX);
        }

        private void frm_substituir_Load(object sender, EventArgs e)
        {
            txt_ANConta.Text = DadosDeContas.nConta[index].ToString();
            txt_ANome.Text = DadosDeContas.nome[index].ToString();
            txt_ANConta.ReadOnly = true;
            txt_ANome.ReadOnly = true;
            
        }

        string nome = "";
        string senha = "";
        string data = "";
        string cSenha = "";
        string nConta = "";
        string IBAN = "";
        string saldoInicial = "";
        string tel = "";

        private void btn_substituir_Click(object sender, EventArgs e)
        {
            LerCampo();
            ValidarCadastro();
        }

        public void LerCampo()
        {
            nome = txt_nome.Text;
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
            if (!verificacao.AlgumVazio(this.Controls))
            {
                MessageBox.Show("CADASTRO ENTERRONPIDO\nPreencha todos os campos!");
            }
            else if (!verificacao.SenhaValidar(senha))
            {
                MessageBox.Show("Senha invalida!\nTem que ter 4 digito");
            }
            else if (senha != cSenha)
            {
                MessageBox.Show("Confirmação de senha invalida\nVerifique os campos para poder para continuar!");
                txt_confirmar.Text = "";
                txt_confirmar.Focus();
            }
            else if (!verificacao.phoneNumber(tel))
            {
                MessageBox.Show("Número de telefone invalido!");
                txt_tel.Text = "";
                txt_tel.Focus();
            }
            else if (!verificacao.NomeValido(txt_nome.Text))
            {
                MessageBox.Show("NOME INVALIDO!\nPor favor verifique se o seu nome esta bem escrito");
            }
            else
            {
                SubstituirDados();
                DadosDeContas.ActualizarFicheiro();
                MessageBox.Show("Conta substituida com sucesso!");
            }
        }

        private void SubstituirDados()
        {
            DadosDeContas.nome.RemoveAt(index);
            DadosDeContas.nome.Insert(index, nome);

            DadosDeContas.data.RemoveAt(index);
            DadosDeContas.data.Insert(index, data);

            DadosDeContas.nConta.RemoveAt(index);
            DadosDeContas.nConta.Insert(index,nConta);

            DadosDeContas.IBAN.RemoveAt(index);
            DadosDeContas.IBAN.Insert(index,IBAN);

            DadosDeContas.saldo.RemoveAt(index);
            DadosDeContas.saldo.Insert(index, saldoInicial);

            DadosDeContas.senha.RemoveAt(index);
            DadosDeContas.senha.Insert(index, senha);

            DadosDeContas.tel.RemoveAt(index);
            DadosDeContas.tel.Insert(index,txt_tel.Text);
        }
    }
}

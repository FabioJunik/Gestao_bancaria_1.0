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
    public partial class frm_controle : Form
    {
        Form formX;
        Panel panX;

        public frm_controle()
        {
            InitializeComponent();
        }
        public frm_controle(Panel pan, Form form)
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
                panX.Update();
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

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            abrirForm(new frm_pesquisarCliente(panX, formX));
        }

        private void btn_deposito_Click(object sender, EventArgs e)
        {
            abrirForm(new frm_deposito(panX,formX));
        }

        private void frm_controle_Load(object sender, EventArgs e)
        {

        }

        private void btn_listagem_Click(object sender, EventArgs e)
        {
            frm_pesquisa pesquisa = new frm_pesquisa();
            pesquisa.ShowDialog();
        }

        private void btn_tranferencia_Click(object sender, EventArgs e)
        {
            abrirForm(new frm_CTransfericia(panX, formX));
        }

        private void saque_Click(object sender, EventArgs e)
        {
            abrirForm(new frm_CSaque(panX, formX));
        }

        private void btn_saldo_Click(object sender, EventArgs e)
        {
            abrirForm(new frm_CConsultar(panX, formX));
        }
    }
}

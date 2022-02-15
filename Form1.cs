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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Visible = false;

            frm_cadastrar cadastrar = new frm_cadastrar();
            cadastrar.Show();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            frm_entrar entrar = new frm_entrar();
            entrar.ShowDialog();
        }

        private void btn_controle_Click(object sender, EventArgs e)
        {
            frm_vazio vazio = new frm_vazio();
            
            vazio.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DadosDeContas.Read();
        }
    }
}

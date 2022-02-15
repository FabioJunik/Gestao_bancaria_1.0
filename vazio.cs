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
    public partial class frm_vazio : Form
    {
      
        public frm_vazio()
        {
            InitializeComponent();
         
        }

        private void pnl_vazio_Paint(object sender, PaintEventArgs e)
        {
        }

        Form formActivo;
        private void abrirForm(Form form)
        {
            if(formActivo != null)
            {
                formActivo.Close();
                pnl_vazio.Controls.Clear();
            }

            formActivo = form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            pnl_vazio.Controls.Add(form);
            pnl_vazio.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void frm_vazio_Load(object sender, EventArgs e)
        {
            abrirForm(new frm_controle(pnl_vazio,new frm_vazio()) );
        }
    }
}

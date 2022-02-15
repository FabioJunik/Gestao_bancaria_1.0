using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestao_de_cliente
{
    class manipulacaoForm
    {

        private Form formActivo;
        private Form form;
        private Panel pan;

        public manipulacaoForm(Panel pan, Form form)
        {
            this.pan = pan;
            this.form = form;
        }

        public void abrirForm(Form form)
        {
            if (formActivo != null)
            {
                formActivo.Close();
                pan.Update();
                pan.Controls.Clear();

            }

            formActivo = form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            pan.Controls.Add(form);
            pan.Tag = form;
            form.BringToFront();
            form.Show();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestao_de_cliente
{
    class Verificacoes:Constantes
    {

        public bool Vazio(string campo)
        {
            return campo == "";
        }

        public bool Iguais(string txt1, string txt2)
        {
            return txt1.ToLower().Trim() == txt2.ToLower().Trim();           
        }

        public bool AlgumVazio(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is TextBox && ctrl.Text=="")
                {
                    return false;
                }
            }
            return true;
        }

        public bool NomeValido(string nome)
        {
            string[] subNomes = nome.Split(' ');
            bool retorno = true;

            if (subNomes.Length == 1)
                retorno = false;

            for (int i = 0; i < subNomes.Length; i++)
            {
                if (subNomes[0].Length <= 2)
                    retorno= false;

                if (subNomes[i].Length <= 1)
                    retorno = false;
            }

            return retorno;
        }

        public void IntNumber(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        public void ApenasTexto(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ')
                e.Handled = true;
            
        }

        public bool phoneNumber(string num)
        {
            if (num.Length < 2)
                return false;
            return angoPhone.Contains(num.Substring(0,2)) && num.Length == 9;
        }

        public bool SenhaValidar(string senha)
        {
            return senha.Length == 4;
        }
        
    }
}

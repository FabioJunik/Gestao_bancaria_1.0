using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace gestao_de_cliente
{
    class Operacoes
    {
        public string GerarNConta()
        {
            Random a = new Random();

            int nConta = a.Next(1000000,9999999);
            int nConta2 = a.Next(100000,999999);

            return nConta.ToString() + nConta2.ToString();

        }

        public string GerarIBAM(string nConta)
        {
            return "AO0600400000" + nConta;
        }

        public void Substituir(int index, string valor)
        {
            DadosDeContas.saldo.RemoveAt(index);
            DadosDeContas.saldo.Insert(index,valor);
        }

        public void LimparTudo(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text= String.Empty;
                    //MessageBox.Show("TEste 000001");
                }
            }
        }

        public string OrganizarNome(string texto)
        {
            string superTexto= texto[0].ToString().ToUpper();

            for (int i=0;i< texto.Length; i++)
            {
                if(i>0)
                if (texto[i-1] == ' ')
                   superTexto+=texto[i].ToString().ToUpper();
                else
                   superTexto+=texto[i].ToString().ToLower();

            }

            return superTexto;
        }

        public string AbreviarNome(string nome)
        {
            string[] nomeDividido = nome.Split(' ');
            string nomeA = nomeDividido[0];

            for (int i = 0; i < nomeDividido.Length; i++)
            {
                char[] nomeReDividido = nomeDividido[i].ToCharArray();
                if ((i != 0) && (i != nomeDividido.Length - 1))
                {
                    nomeA += " " + nomeReDividido[0] + ".";
                }
            }

            return nomeA + " " + nomeDividido[nomeDividido.Length - 1];
        }

        public int NewBinarySearch(ArrayList lista, string item)
        {
            for (int i = 0; i < lista.Count; i++)
                if (lista[i].ToString() == item)
                    return  i;

            return -1;
        }
    }
}
    


using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace gestao_de_cliente
{
    public static class DadosDeContas
    {
        public static ArrayList nome = new ArrayList();
        public static ArrayList data = new ArrayList();
        public static ArrayList nConta = new ArrayList();
        public static ArrayList IBAN = new ArrayList(); 
        public static ArrayList tel = new ArrayList();
        public static ArrayList saldo = new ArrayList();
        public static ArrayList senha = new ArrayList();

        public static int QuantCadastro(){ return nome.Count; }
        
        public static void Read()
        {
            StreamReader _nome = new StreamReader(@"C:\gestão de cliente\nome.txt", true);
            StreamReader _tel = new StreamReader(@"C:\gestão de cliente\telefone.txt", true);
            StreamReader _data = new StreamReader(@"C:\gestão de cliente\data.txt", true);
            StreamReader _senha = new StreamReader(@"C:\gestão de cliente\senha.txt", true);
            StreamReader _IBAN = new StreamReader(@"C:\gestão de cliente\IBAN.txt", true);
            StreamReader _saldo = new StreamReader(@"C:\gestão de cliente\saldo.txt", true);
            StreamReader _nConta = new StreamReader(@"C:\gestão de cliente\nConta.txt", true);

            nome.Clear();
            data.Clear();
            nConta.Clear();
            IBAN.Clear();
            saldo.Clear();
            senha.Clear();
            tel.Clear();

            while (!_nome.EndOfStream)
            {
                nome.Add(_nome.ReadLine());
                data.Add(_data.ReadLine());
                nConta.Add(_nConta.ReadLine());
                IBAN.Add(_IBAN.ReadLine());
                saldo.Add(_saldo.ReadLine());
                senha.Add(_senha.ReadLine());
                tel.Add(_tel.ReadLine());
            }

            _nome.Close();
            _tel.Close();
            _data.Close();
            _saldo.Close();
            _senha.Close();
            _nConta.Close();
            _IBAN.Close();
        }

        public static void ActualizarFicheiro()
        {
            FileDelete();

            StreamWriter _nome = new StreamWriter(@"C:\gestão de cliente\nome.txt", true);
            StreamWriter _tel = new StreamWriter(@"C:\gestão de cliente\telefone.txt", true);
            StreamWriter _data = new StreamWriter(@"C:\gestão de cliente\data.txt", true);
            StreamWriter _senha = new StreamWriter(@"C:\gestão de cliente\senha.txt", true);
            StreamWriter _IBAN = new StreamWriter(@"C:\gestão de cliente\IBAN.txt", true);
            StreamWriter _saldo = new StreamWriter(@"C:\gestão de cliente\saldo.txt", true);
            StreamWriter _nConta = new StreamWriter(@"C:\gestão de cliente\nConta.txt", true);

            for(int i = 0; i < QuantCadastro(); i++)
            {
                _nome.WriteLine(nome[i]);
                _tel.WriteLine(tel[i]);
                _data.WriteLine(data[i]);
                _saldo.WriteLine(saldo[i]);
                _senha.WriteLine(senha[i]);
                _nConta.WriteLine(nConta[i]);
                _IBAN.WriteLine(IBAN[i]);
            }
            _nome.Close();
            _IBAN.Close();
            _senha.Close();
            _nConta.Close();
            _saldo.Close();
            _data.Close();
            _tel.Close();
        }

        public static void FileDelete()
        {
            File.Delete(@"C:\gestão de cliente\nome.txt");
            File.Delete(@"C:\gestão de cliente\telefone.txt");
            File.Delete(@"C:\gestão de cliente\data.txt");
            File.Delete(@"C:\gestão de cliente\senha.txt");
            File.Delete(@"C:\gestão de cliente\IBAN.txt");
            File.Delete(@"C:\gestão de cliente\saldo.txt");
            File.Delete(@"C:\gestão de cliente\nConta.txt");
        }
    }
}

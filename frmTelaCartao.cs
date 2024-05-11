using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Microsoft.VisualBasic.ApplicationServices;

namespace CartaoVisita
{
    public partial class frmTelaCartao : Form
    {
        string _nome;
        string _idade;
        string _telefone;
        string _email;
        string _endereco;
        public frmTelaCartao(string nome, string idade, string telefone, string email, string endereco)
        {
            InitializeComponent();
            _nome = nome;
            _idade = idade;
            _telefone = telefone;
            _email = email;
            _endereco = endereco;

        }

        private void btnFim_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void frmTelaCartao_load(object sender, EventArgs e)
        {
            txtNome.Text = _nome;
            txtIdade.Text = _idade;
            mtxtTelefone.Text = _telefone;
            txtEmail.Text = _email;
            txtEndereco.Text = _endereco;

            string local = @"C:\Users\Aluno\Desktop\CartaoVisita.csv";

            using (StreamWriter sw = new StreamWriter(local))
            {
                sw.Write(_nome + ",");
                sw.Write(_idade + ",");
                sw.Write(_telefone + ",");
                sw.Write(_email + ",");
                sw.Write(_endereco + ",");
            }
        }
    }
}

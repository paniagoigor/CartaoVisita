namespace CartaoVisita
{
    public partial class frmCartaoVisita : Form
    {
        public frmCartaoVisita()
        {
            InitializeComponent();
        }


        private void btnAvancar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string idade = txtIdade.Text;
            string telefone = mtxtTelefone.Text;
            string email = txtEmail.Text;
            string endereço = txtEndereco.Text;

            frmTelaCartao telaCartao = new frmTelaCartao(nome, idade, telefone, email, endereço);

            this.Hide();

            telaCartao.ShowDialog();

            telaCartao.Closed += (object s, EventArgs ev) => this.Hide();


        }
    }
}
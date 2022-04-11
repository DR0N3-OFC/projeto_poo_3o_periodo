using Matricula.Domain.Models;

namespace WindowsApp
{
    public partial class UsuarioForm : Form
    {
        public UsuarioForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioModel usuario = new UsuarioModel(
                        tbNome.Text, tbEmail.Text, tbLogin.Text, tbSenha.Text
                        );

                lblDados.Visible = true;
                lblLoginTitle.Visible = true;
                lblLogin.Visible = true;
                lblSenha.Visible = true;
                lblSenhaTitle.Visible = true;
                lblDataCadastro.Visible = true;
                lblDataCadastroTitle.Visible = true;

                lblLogin.Text = usuario.Login;
                lblSenha.Text = usuario.Senha;
                lblDataCadastro.Text = usuario.DataCadastro;

                MessageBox.Show("Dados corretos! Verifique-os a seguir.");
            }
            catch (Exception exception)
            {
                MessageBox.Show($"ERRO: {exception.Message}");
            }
        }
    }
}

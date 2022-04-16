using Matricula.Domain.Models;

namespace WindowsApp
{
    public partial class UsuarioForm : Form
    {
        public UsuarioForm()
        {
            InitializeComponent();
            initializeDesign();
        }
        private void initializeDesign()
        {
            Height -= (lbNotifications.Height + 30);
            lbNotifications.Visible = false;
            lblDados.Visible = false;
            lblLoginTitle.Visible = false;
            lblLogin.Visible = false;
            lblSenha.Visible = false;
            lblSenhaTitle.Visible = false;
            lblDataCadastro.Visible = false;
            lblDataCadastroTitle.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            proccessData();
        }

        private void proccessData()
        {
            UsuarioModel usuario = new UsuarioModel(
                                    tbNome.Text, tbEmail.Text, tbLogin.Text, tbSenha.Text
                                    );

            returnDataToUser(usuario);
        }

        private void returnDataToUser(UsuarioModel usuario)
        {
            if (usuario.IsValid)
            {
                dataIsValid(usuario);
            }
            else
            {
                dataIsInvalid(usuario);
            }
        }

        private void dataIsInvalid(UsuarioModel usuario)
        {
            setInvalidDataVisible();

            for (int i = 0; i < usuario.NotificationsCount; i++)
            {
                lbNotifications.Items.Add(usuario.Notifications[i]);
            }
            MessageBox.Show("Verifique a inserção de dados e tente novamente!");
        }

        private void setInvalidDataVisible()
        {
            if (lblDados.Visible)
                Height -= (lbNotifications.Height + 30);

            if (lbNotifications.Visible)
                Height -= lbNotifications.Height + 30;

            lblDados.Visible = false;
            lblLoginTitle.Visible = false;
            lblLogin.Visible = false;
            lblSenha.Visible = false;
            lblSenhaTitle.Visible = false;
            lblDataCadastro.Visible = false;
            lblDataCadastroTitle.Visible = false;

            Height += lbNotifications.Height + 30;
            lbNotifications.Left = 12;
            lbNotifications.Width = 475;

            lbNotifications.Items.Clear();
            lbNotifications.Visible = true;
        }

        private void dataIsValid(UsuarioModel usuario)
        {
            setValidDataVisible();

            lblLogin.Text = usuario.Login;
            lblSenha.Text = usuario.Senha;
            lblDataCadastro.Text = usuario.DataCadastro;

            MessageBox.Show("Dados informados corretamente! Verifique-os a seguir.");
        }

        private void setValidDataVisible()
        {
            if (lbNotifications.Visible)
                Height -= (lbNotifications.Height + 30);

            if (lblDados.Visible)
                Height -= (lbNotifications.Height + 30);

            Height += (lbNotifications.Height + 30);
            lbNotifications.Visible = false;
            lblDados.Visible = true;
            lblLoginTitle.Visible = true;
            lblLogin.Visible = true;
            lblSenha.Visible = true;
            lblSenhaTitle.Visible = true;
            lblDataCadastro.Visible = true;
            lblDataCadastroTitle.Visible = true;
            
        }
    }
}

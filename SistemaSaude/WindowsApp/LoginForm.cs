using System;

namespace WindowsApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                verifyErrors();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void verifyErrors()
        {
            if (tbEmail.Text.Trim() == String.Empty && tbSenha.Text.Trim() == String.Empty)
            {
                MessageBox.Show("E-mail e senha não foram informados.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbEmail.Text.Trim() == String.Empty)
            {
                throw new Exception("Por favor, insira um e-mail!");
            }
            else if (tbSenha.Text.Trim() == String.Empty)
            {
                throw new Exception("Por favor, insira uma senha!");
            }
        }
    }
}

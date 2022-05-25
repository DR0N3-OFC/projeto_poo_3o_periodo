using System;
using Domain.Models;
using Domain.Repository;
using Persistence.DataContext;
using Persistence.Repository;

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
                
                using (var context = new EFDataContext())
                {
                    if (!cbSouMedico.Checked)
                    {
                        var paciente = context.Pacientes
                        .Where(p => p.Email == tbEmail.Text)
                        .FirstOrDefault();

                        verifyLoginErrors(paciente);
                    }
                    else
                    {
                        var medico = context.Medicos
                        .Where(m => m.Email == tbEmail.Text)
                        .FirstOrDefault();
                        verifyLoginErrors(medico);
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void verifyLoginErrors(PessoaModel? usuario)
        {
            if (usuario == null)
            {
                MessageBox.Show("Usuário não foi encontrado.");
            }
            else if (usuario != null && usuario.Senha != tbSenha.Text)
            {
                MessageBox.Show("Senha incorreta.");
            }
            else if (usuario.Senha == tbSenha.Text)
            {
                MessageBox.Show("Dados Corretos.");
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

        private void btCriarConta_Click(object sender, EventArgs e)
        {
            TipoConta criarConta = new TipoConta();

            criarConta.Show();
            Hide();
        }
    }
}

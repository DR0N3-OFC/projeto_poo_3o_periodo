using Domain.Models;
using Domain.Repository;
using Persistence.DataContext;
using Persistence.Repository;

namespace WindowsApp
{
    public partial class LoginForm : Form
    {
        private readonly IRepository<PacienteModel> _pacienteModelRepository = new PacienteModelRepository(new EFDataContext());

        public LoginForm()
        {
            InitializeComponent();
            createAdmin();
            lblTitulo.Select();
        }
        private void createAdmin()
        {
            var dataContext = new EFDataContext();
            var admin = dataContext.Pacientes.Where(a => a.IsAdmin == 1).FirstOrDefault();

            if (admin == null)
                _pacienteModelRepository.Gravar(new("admin", "admin"));
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

                        if (paciente?.IsAdmin == 0)
                        {
                            MainPaForm main = new MainPaForm(paciente);
                            main.Show();
                        }
                        else
                        {
                            MainAdForm main = new MainAdForm();
                            main.Show();
                        }

                        Hide();
                    }
                    else
                    {
                        var medico = context.Medicos
                        .Where(m => m.Email == tbEmail.Text)
                        .FirstOrDefault();

                        verifyLoginErrors(medico);
                        MainMeForm main = new MainMeForm(medico);
                        Hide();
                        main.Show();
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPS!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void verifyLoginErrors(PessoaModel? usuario)
        {
            if (usuario == null)
            {
                throw new Exception("Usuário não foi encontrado.");
            }
            else if (usuario != null && usuario.Senha != tbSenha.Text)
            {
                throw new Exception("Senha incorreta.");
            }
            else if (usuario.Senha == tbSenha.Text)
            {
                MessageBox.Show("Dados Corretos.", "Bem-vindo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void verifyErrors()
        {
            if (tbEmail.Text.Trim() == String.Empty && tbSenha.Text.Trim() == String.Empty)
            {
                throw new Exception("E-mail e senha não foram informados.");
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
            TipoContaForm criarConta = new TipoContaForm();

            criarConta.Show();
            Hide();
        }
    }
}

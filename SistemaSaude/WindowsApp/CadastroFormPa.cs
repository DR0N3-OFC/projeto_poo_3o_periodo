using Domain.Models;
using Domain.Repository;
using Persistence.DataContext;
using Persistence.Repository;

namespace WindowsApp
{
    public partial class CadastroFormPa : Form
    {
        LoginForm login = new LoginForm();
        private readonly IRepository<PacienteModel> _pacienteModelRepository;
        private readonly IRepository<Endereco> _enderecoRepository;
        public CadastroFormPa()
        {
            InitializeComponent();
            initialFormatting();
            var dataContext = new EFDataContext();
            _pacienteModelRepository = new PacienteModelRepository(dataContext);
            _enderecoRepository = new EnderecoRepository(dataContext);
        }

        private void initialFormatting()
        {
            lblTitulo.Select();
            lblTitulo.Left = (Width - lblTitulo.Width) / 2;
            lblDados1.Left = (Width - lblDados1.Width) / 2;
            lblDados2.Left = (Width - lblDados2.Width) / 2;
            lblDados3.Left = (Width - lblDados3.Width) / 2;
            btCadastrar.Left = (Width - btCadastrar.Width) / 2;
        }
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            processData();
        }

        private void processData()
        {
            try
            {
                PacienteModel paciente = new(
                       tbEmail?.Text.Trim(),
                       tbSenha?.Text.Trim(),
                       tbNome?.Text.Trim(),
                       dtDataDeNascimento?.Value.Date,
                       tbTelefone?.Text.Trim(),
                       tbCPF?.Text.Trim(),
                       tbRG?.Text.Trim()
                       );

                _pacienteModelRepository.Gravar(paciente);

                _enderecoRepository.Gravar(new Endereco(tbRua?.Text.Trim(), tbNumero?.Text.Trim(), tbBairro?.Text.Trim(), tbCidade?.Text.Trim(), tbEstado?.Text.Trim(), tbCEP?.Text.Trim(), paciente.PacienteModelID));
                MessageBox.Show("Cadastro realizado com êxito!", "Cadastro realizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                closeForm();
            }
            catch (Exception)
            {
                InCaseOfExceptionStyle();
                MessageBox.Show("Erro no cadastro!", "OPS!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeForm()
        {
            login.SendToBack();
            login.Hide();
            Close();
        }

        private void InCaseOfExceptionStyle()
        {
            #region Personal Data Style
            if (tbEmail.Text == null || tbEmail.Text.Trim().Length == 0) tbEmail.BackColor = Color.RosyBrown;
            else tbEmail.BackColor = Color.White;

            if (tbSenha.Text == null || tbSenha.Text.Trim().Length == 0) tbSenha.BackColor = Color.RosyBrown;
            else tbSenha.BackColor = Color.White;

            if (tbNome.Text == null || tbNome.Text.Trim().Length == 0) tbNome.BackColor = Color.RosyBrown;
            else tbNome.BackColor = Color.White;

            if ((dtDataDeNascimento.Value.Date >= DateTime.Now.Date)) lblDtNascimento.ForeColor = Color.IndianRed;
            else lblDtNascimento.ForeColor = Color.Black;

            if (tbTelefone.Text == null || tbTelefone.Text.Trim().Length == 0) tbTelefone.Text = "(Não informado)";

            if (tbRG.Text == null || tbRG.Text.Trim().Length == 0) tbRG.BackColor = Color.RosyBrown;
            else tbRG.BackColor = Color.White;

            if (tbCPF.Text == null || tbCPF.Text.Trim().Length == 0) tbCPF.BackColor = Color.RosyBrown;
            else tbCPF.BackColor = Color.White;
            #endregion

            #region Address Data Style
            if (tbRua.Text == null || tbRua.Text.Trim().Length == 0) tbRua.BackColor = Color.RosyBrown;
            else tbRua.BackColor = Color.White;

            if (tbNumero.Text == null || tbNumero.Text.Trim().Length == 0) tbNumero.Text = "(N.I.)";

            if (tbBairro.Text == null || tbBairro.Text.Trim().Length == 0) tbBairro.BackColor = Color.RosyBrown;
            else tbBairro.BackColor = Color.White;

            if (tbCidade.Text == null || tbCidade.Text.Trim().Length == 0) tbCidade.BackColor = Color.RosyBrown;
            else tbCidade.BackColor = Color.White;

            if (tbEstado.Text == null || tbEstado.Text.Trim().Length == 0) tbEstado.BackColor = Color.RosyBrown;
            else tbEstado.BackColor = Color.White;

            if (tbCEP.Text == null || tbCEP.Text.Trim().Length == 0) tbCEP.BackColor = Color.RosyBrown;
            else tbCEP.BackColor = Color.White;
            #endregion
        }

        private void CadastroFormPa_Deactivate(object sender, EventArgs e)
        {
            login.Show();
            login.Activate();
        }
    }
}

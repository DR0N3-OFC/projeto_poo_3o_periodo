using Domain.Enumerators;
using Domain.Models;
using Domain.Repository;
using Persistence.DataContext;
using Persistence.Repository;

namespace WindowsApp
{
    public partial class CadastroFormMe : Form
    {
        private readonly IRepository<MedicoModel> _medicoModelRepository;
        public CadastroFormMe()
        {
            InitializeComponent();
            initialFormatting();
            loadEnumItemsWithDescription();

            _medicoModelRepository = new MedicoModelRepository(new EFDataContext());
        }
        private void initialFormatting()
        {
            lblTitulo.Left = (Width - lblTitulo.Width) / 2;
            lblDados1.Left = (Width - lblDados1.Width) / 2;
            lblDados2.Left = (Width - lblDados2.Width) / 2;
            lblDados3.Left = (Width - lblDados3.Width) / 2;
            btCadastrar.Left = (Width - btCadastrar.Width) / 2;
        }
        private void loadEnumItemsWithDescription()
        {
            foreach (EnumEspecialidade especialidade in EnumMethods.EnumToList<EnumEspecialidade>())
            {
                cbEspecialidade.Items.Add(especialidade.GetDescription());
            }
            cbEspecialidade.SelectedIndex = 0;
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            processData();
        }

        private void processData()
        {
            try
            {
                MedicoModel medico = new(
                       tbEmail?.Text,
                       tbSenha?.Text,
                       tbNome?.Text,
                       dtDataDeNascimento?.Value,
                       tbTelefone?.Text,
                       EnumMethods.GetEnumByDescription<EnumEspecialidade>(cbEspecialidade.SelectedItem.ToString()),
                       tbCRM?.Text,
                       tbCPF?.Text,
                       tbRG?.Text
                       );

                _medicoModelRepository.Gravar(medico);
                MessageBox.Show("Cadastro realizado com êxito!", "Cadastro realizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                InCaseOfExceptionStyle();
                MessageBox.Show("Erro no cadastro!", "OPS!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            if (tbTelefone.Text == null || tbTelefone.Text.Trim().Length == 0) tbTelefone.Text = "(Não informado)";

            if (tbRG.Text == null || tbRG.Text.Trim().Length == 0) tbRG.BackColor = Color.RosyBrown;
            else tbRG.BackColor = Color.White;

            if (tbCPF.Text == null || tbCPF.Text.Trim().Length == 0) tbCPF.BackColor = Color.RosyBrown;
            else tbCPF.BackColor = Color.White;
            #endregion

            #region Professional Data Style
            if (cbEspecialidade.SelectedItem == null || cbEspecialidade.SelectedItem.ToString() == "") lblEspecialidade.ForeColor = Color.IndianRed;
            else lblEspecialidade.ForeColor = Color.Black;

            if (tbCRM.Text == null || tbCRM.Text.Trim().Length == 0) tbCRM.BackColor = Color.RosyBrown;
            else tbCRM.BackColor = Color.White;
            #endregion
        }

        private void CadastroFormMe_Deactivate(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            login.Activate();
        }
    }
}

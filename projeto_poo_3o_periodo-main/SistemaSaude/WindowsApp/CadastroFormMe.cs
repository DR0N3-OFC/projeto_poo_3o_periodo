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
            lblTitulo.Select();
            lblTitulo.Left = (Width - lblTitulo.Width) / 2;
            lblDados1.Left = (Width - lblDados1.Width) / 2;
            lblDados2.Left = (Width - lblDados2.Width) / 2;
            lblDados3.Left = (Width - lblDados3.Width) / 2;
            btCadastrar.Left = (Width - btCadastrar.Width) / 2;

            tbCPF.MaxLength = 14;
            tbRG.MaxLength = 12;
            tbTelefone.MaxLength = 14;
            tbCRM.MaxLength = 11;
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

                emailValidation(medico.Email);
                _medicoModelRepository.Gravar(medico);

                MessageBox.Show("Cadastro realizado com êxito!", "Cadastro realizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                InCaseOfExceptionStyle();
                MessageBox.Show(ex.Message == "1" ? "E-mail já cadastrado!" : $"Erro no cadastro!", "OPS!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void emailValidation(string? email)
        {
            var emailExistente = _medicoModelRepository.ObterTodos().Where(e => e.Email == email).ToList();

            if (emailExistente.Count > 0)
            {
                throw new Exception("1");
            }

            if (!(tbEmail.Text.LastIndexOf("@") > -1) || !(tbEmail.Text.LastIndexOf(".") > -1))
            {
                MessageBox.Show("E-mail inválido.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception("O e-mail é inválido!");
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

            if ((dtDataDeNascimento.Value.Date >= DateTime.Now.Date)) lblDtNascimento.ForeColor = Color.IndianRed;
            else lblDtNascimento.ForeColor = Color.Black;

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

        private void CadastroFormMe_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm login = new();
            login.Show();
            login.Activate();
        }

        private void tbCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar != 8)
            {
                if (tbCPF.Text.Trim().Length == 3 || tbCPF.Text.Trim().Length == 7)
                {
                    tbCPF.Text = tbCPF.Text.Trim() + '.';
                }
                else if (tbCPF.TextLength == 11)
                {
                    tbCPF.Text = tbCPF.Text.Trim() + '-';
                }
                tbCPF.SelectionStart = tbCPF.Text.Length;
                tbCPF.SelectionLength = 0;
            }
        }

        private void tbTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar != 8)
            {
                if (tbTelefone.Text.Trim().Length == 0)
                {
                    tbTelefone.Text = tbTelefone.Text.Trim() + '(';
                }
                else if (tbTelefone.Text.Trim().Length == 3)
                {
                    tbTelefone.Text = tbTelefone.Text.Trim() + ')';
                }
                else if (tbTelefone.TextLength == 9)
                {
                    tbTelefone.Text = tbTelefone.Text.Trim() + '-';
                }
                tbTelefone.SelectionStart = tbTelefone.Text.Length;
                tbTelefone.SelectionLength = 0;
            }
        }

        private void tbRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar != 8)
            {
                if (tbRG.Text.Trim().Length == 2 || tbRG.Text.Trim().Length == 6)
                {
                    tbRG.Text = tbRG.Text.Trim() + '.';
                }
                else if (tbRG.TextLength == 10)
                {
                    tbRG.Text = tbRG.Text.Trim() + '-';
                }
                tbRG.SelectionStart = tbRG.Text.Length;
                tbRG.SelectionLength = 0;
            }
        }

        private void tbCRM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && tbCRM.Text.Length < 7)
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && tbCRM.Text.Length >= 7)
            {
                e.Handled = true;
            }
            if (e.KeyChar != 8)
            {
                if (tbCRM.Text.Trim().Length == 6)
                {
                    tbCRM.Text = tbCRM.Text.Trim() + '-';
                }
                else if (tbCRM.TextLength == 8)
                {
                    tbCRM.Text = tbCRM.Text.Trim() + '/';
                }
                tbCRM.SelectionStart = tbCRM.Text.Length;
                tbCRM.SelectionLength = 0;
            }
        }

        private void tbNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !(e.KeyChar == 8) && !(e.KeyChar == 32))
            {
                e.Handled = true;
            }
        }
    }
}
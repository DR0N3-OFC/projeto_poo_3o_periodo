using Domain.Models;

namespace WindowsApp
{
    public partial class CadastroFormMe : Form
    {
        public CadastroFormMe()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                MedicoModel medico = new(
                       tbEmail?.Text,
                       tbSenha?.Text,
                       tbNome?.Text,
                       dtDataDeNascimento?.Value,
                       tbTelefone?.Text,
                       tbEspecialidade?.Text,
                       tbCRM?.Text,
                       tbCPF?.Text,
                       tbRG?.Text
                       );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}

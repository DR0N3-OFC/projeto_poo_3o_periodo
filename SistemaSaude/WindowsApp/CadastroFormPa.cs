using Domain.Models;

namespace WindowsApp
{
    public partial class CadastroFormPa : Form
    {
        public CadastroFormPa()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                PacienteModel paciente = new(
                       tbEmail?.Text,
                       tbSenha?.Text,
                       tbNome?.Text,
                       dtDataDeNascimento?.Value,
                       new Endereco(tbRua?.Text, tbNumero?.Text, tbBairro?.Text, tbCidade?.Text, tbEstado?.Text, tbCEP?.Text),
                       tbTelefone?.Text,
                       tbCPF?.Text,
                       tbRG?.Text
                       );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERRO: {ex.Message}");
            }
        }
    }
}

namespace WindowsApp
{
    public partial class TipoContaForm : Form
    {
        LoginForm login = new LoginForm();
        public TipoContaForm()
        {
            InitializeComponent();
        }

        private void btSouPaciente_Click(object sender, EventArgs e)
        {
            CadastroFormPa paciente = new CadastroFormPa();
            paciente.Show();
            Hide();
            login.Hide();
        }

        private void btSouMedico_Click(object sender, EventArgs e)
        {
            CadastroFormMe medico = new CadastroFormMe();
            medico.Show();
            Hide();
            login.Hide();
        }
        private void TipoConta_Deactivate(object sender, EventArgs e)
        {
            login.Show();
            login.Activate();
        }
    }
}

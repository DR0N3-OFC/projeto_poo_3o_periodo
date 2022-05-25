namespace WindowsApp
{
    public partial class TipoConta : Form
    {
        public TipoConta()
        {
            InitializeComponent();
        }

        private void btSouPaciente_Click(object sender, EventArgs e)
        {
            CadastroFormPa paciente = new CadastroFormPa();
            paciente.Show();
            Hide();
        }

        private void btSouMedico_Click(object sender, EventArgs e)
        {
            CadastroFormMe medico = new CadastroFormMe();
            medico.Show();
            Hide();
        }
        private void TipoConta_Deactivate(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            login.Activate();
            login.SendToBack();
        }
    }
}

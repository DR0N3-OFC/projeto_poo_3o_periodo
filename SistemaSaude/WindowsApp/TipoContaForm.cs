namespace WindowsApp
{
    public partial class TipoContaForm : Form
    {
        public TipoContaForm()
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

        private void TipoContaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm login = new ();
            login.Show();
            login.Activate();
        }
    }
}

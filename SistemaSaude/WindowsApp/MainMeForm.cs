using Domain.Models;

namespace WindowsApp
{
    public partial class MainMeForm : Form
    {
        private MedicoModel _medico;
        public MainMeForm(MedicoModel m)
        {
            InitializeComponent();
            _medico = m;
        }

        private void btConsultasAgendadas_Click(object sender, EventArgs e)
        {
            var consultas = new ConsultasAgendadasMeForm(_medico);
            Hide();
            consultas.Show();
        }

        private void MainMeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm login = new();
            login.Show();
            login.Activate();
        }
    }
}

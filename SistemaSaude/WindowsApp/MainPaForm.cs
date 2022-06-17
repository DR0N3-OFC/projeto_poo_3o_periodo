using Domain.Models;

namespace WindowsApp
{
    public partial class MainPaForm : Form
    {
        private PacienteModel _paciente;
        public MainPaForm(PacienteModel p)
        {
            InitializeComponent();
            _paciente = p;
        }

        private void btAgendar_Click(object sender, EventArgs e)
        {
            var agendamento = new AgendamentoForm(_paciente);
            Hide();
            agendamento.Show();
        }

        private void btReservar_Click(object sender, EventArgs e)
        {
            var reserva = new ReservaForm(_paciente);
            Hide();
            reserva.Show();
        }

        private void MainPaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm login = new();
            login.Show();
            login.Activate();
        }
    }
}

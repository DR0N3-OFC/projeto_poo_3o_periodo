using Domain.Models;

namespace WindowsApp
{
    public partial class MainPaForm : Form
    {
        private Guid? _pacienteID;
        private PacienteModel _paciente;
        public MainPaForm(PacienteModel p)
        {
            InitializeComponent();
            _paciente = p;
            _pacienteID = _paciente.PacienteModelID;
        }

        private void btAgendar_Click(object sender, EventArgs e)
        {
            var agendamento = new AgendamentoForm(_paciente);
            Hide();
            agendamento.Show();
        }
    }
}

using Domain.Enumerators;
using Domain.Models;
using Domain.Repository;
using Persistence.DataContext;
using Persistence.Repository;

namespace WindowsApp
{
    public partial class AgendamentoForm : Form
    {
        private readonly IRepository<Consulta> _consultaRepository;
        private Guid? _medicoID;
        private Guid? _pacienteID;
        private Guid? _consultaID;
        private PacienteModel _paciente;

        public AgendamentoForm(PacienteModel p)
        {
            InitializeComponent();
            initialFormatting();

            var dataContext = new EFDataContext();
            _consultaRepository = new ConsultaRepository(dataContext);

            _paciente = p;
            _pacienteID = _paciente.PacienteModelID;
        }

        private void initialFormatting()
        {
            loadEnumItemsWithDescription();
            lblTitulo.Select();
            dgvUpdate();
            dtData.MinDate = DateTime.Now;
            dtData.CustomFormat = "'Data: ' dd/MM/yyyy ' Horário: ' HH:mm";
        }
        private void dgvUpdate()
        {
            var itemSelecionado = (EnumEspecialidade) Convert.ToInt32(cbEspecialidade.SelectedIndex);

            using(var dataContext = new EFDataContext())
            {
                dgvMedicos.DataSource = dataContext.Medicos?
                        .Where(m => m.Especialidade == itemSelecionado)
                        .ToList();
            }

            dgvMedicos.Columns[0].Visible = false;
            dgvMedicos.Columns[1].Visible = false;
            dgvMedicos.Columns[2].Visible = false;
            dgvMedicos.Columns[3].Visible = false;
            dgvMedicos.Columns[3].DisplayIndex = 0;
            dgvMedicos.Columns[5].Visible = false;
            dgvMedicos.Columns[6].DisplayIndex = 1;
            dgvMedicos.Columns[7].Visible = false;
            dgvMedicos.Columns[8].Visible = false;
            dgvMedicos.Columns[9].Visible = false;
            dgvMedicos.Columns[10].Visible = false;
            dgvMedicos.Columns[11].Visible = false;
            dgvMedicos.Columns[12].Visible = false;

            dgvMedicos.ClearSelection();
        }
        private void loadEnumItemsWithDescription()
        {
            foreach (EnumEspecialidade especialidade in EnumMethods.EnumToList<EnumEspecialidade>())
            {
                cbEspecialidade.Items.Add(especialidade.GetDescription());
            }
            cbEspecialidade.SelectedIndex = -1;
        }
        private void cbEspecialidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvMedicos.DataSource = null;
            dgvUpdate();
            btAgendar.Enabled = false;
        }

        private void processData()
        {
            try
            {
                Consulta consulta = new(
                       dtData.Value.AddSeconds(-(dtData.Value.Second)),
                       _pacienteID,
                       _medicoID
                       );
                dateValidations();
                _consultaRepository.Gravar(consulta);

                dgvAgendadasUpdate();
                btAgendar.Enabled = false;
                MessageBox.Show("Consulta agendada com sucesso. \nConfira na aba \"Consultas Agendadas\"!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "OPS!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateValidations()
        {
            var consultas = _consultaRepository.ObterTodos().Where(m => m.MedicoModelID == _medicoID).ToList();

            if (dtData.Value.Date == DateTime.Now.Date)
                throw new Exception("Por favor, escolha uma data à frente!");

            if (consultas.Count > 0)
            {
                foreach (Consulta consulta in consultas)
                {
                    if (dtData.Value.Date == consulta.Data?.Date && consulta.PacienteModelID == _pacienteID)
                        throw new Exception("Você já possui um agendamento com esse médico para este dia.");

                    if (dtData.Value.AddSeconds(-(dtData.Value.Second)) == consulta.Data)
                        throw new Exception("Uma consulta já está marcada para este horário, agende outro horário.");

                    if (dtData.Value.AddSeconds(-(dtData.Value.Second)) > consulta.Data?.AddMinutes(-30) && dtData.Value.AddSeconds(-(dtData.Value.Second)) < consulta.Data)
                        throw new Exception($"Para uma melhor experiência, recomendamos que agende uma consulta às {consulta.Data?.AddMinutes(-30).ToString("HH:mm")} horas.");

                    if (dtData.Value.AddSeconds(-(dtData.Value.Second)) >= consulta.Data && dtData.Value.AddSeconds(-(dtData.Value.Second)) < consulta.Data?.AddMinutes(29))
                        throw new Exception($"Uma consulta, marcada às {consulta.Data?.ToString("HH:mm")} horas está em andamento, agende um pouquinho mais tarde.");
                }
            }
        }

        private void dgvMedicos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            btAgendar.Enabled = true;

            if (dgvMedicos.SelectedRows != null)
                _medicoID = Guid.Parse(dgvMedicos.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btAgendar_Click(object sender, EventArgs e)
        {
            processData();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            var main = new MainPaForm(_paciente);
            Hide();
            main.Show();
            main.Activate();
        }

        private void dgvAgendadasUpdate()
        {
            var paciente = _consultaRepository.ObterTodos().Where(p => p.PacienteModelID == _pacienteID).ToList();
            dgvAgendadas.DataSource = paciente;

            dgvAgendadas.Columns[0].Visible = false;
            dgvAgendadas.Columns[1].Visible = false;
            dgvAgendadas.Columns[2].Visible = false;
            dgvAgendadas.Columns[3].Visible = false;
            dgvAgendadas.ClearSelection();
            lblTitulo.Select();
            btCancelar.Enabled = false;

            if (dgvAgendadas.Rows.Count == 0)
                Width -= 360;
            else
                Width = 1229;
        }
        private void AgendamentoForm_Load(object sender, EventArgs e)
        {
            dgvAgendadasUpdate();
            dgvAgendadas.ClearSelection();
            dgvMedicos.ClearSelection();
            btAgendar.Enabled = false;
        }

        private void dgvAgendadas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            btCancelar.Enabled = true;

            if (dgvAgendadas.SelectedRows != null)
                _consultaID = Guid.Parse(dgvAgendadas.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            var consulta = _consultaRepository.ObterPorID(_consultaID);
            _consultaRepository.Remover(consulta);

            dgvAgendadasUpdate();
            MessageBox.Show("Consulta cancelada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AgendamentoForm_Deactivate(object sender, EventArgs e)
        {
        }

        private void AgendamentoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var main = new MainPaForm(_paciente);
            Hide();
            main.Show();
            main.Activate();
        }
    }
}

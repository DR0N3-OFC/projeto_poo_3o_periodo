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
        PacienteModel paciente;

        public AgendamentoForm(PacienteModel p)
        {
            InitializeComponent();
            initialFormatting();

            var dataContext = new EFDataContext();
            _consultaRepository = new ConsultaRepository(dataContext);

            paciente = p;
            _pacienteID = paciente.PacienteModelID;
        }

        private void initialFormatting()
        {
            loadEnumItemsWithDescription();
            lblTitulo.Select();
            dgvUpdate();
            dgvMedicos.ClearSelection();
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
        }

        private void processData()
        {
            try
            {
                Consulta consulta = new(
                       dtData.Value,
                       _pacienteID,
                       _medicoID
                       );
                dateValidations();
                _consultaRepository.Gravar(consulta);
                MessageBox.Show("Consulta agendada com sucesso. \nConfira na aba \"Consultas Agendadas\"!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "OPS!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateValidations()
        {
            IEnumerable<Consulta> consultas = _consultaRepository.ObterTodos().Where(m => m.MedicoModelID == _medicoID);

            foreach(Consulta consulta in consultas)
            {
                if (dtData.Value.Date < DateTime.Now.Date)
                    throw new Exception("Escolha uma data à frente!\n\nPS: A máquina do tempo ainda não foi criada hahaha.");

                if (dtData.Value.Date == consulta.Data?.Date && consulta.PacienteModelID == _pacienteID)
                    throw new Exception("Você já possui um agendamento com esse médico para este dia.");

                if (dtData.Value == consulta.Data)
                    throw new Exception("Uma consulta já está marcada para este horário, agende outro horário.");

                if (dtData.Value > consulta.Data?.AddMinutes(-15) && dtData.Value < consulta.Data)
                    throw new Exception("Este horário já possui agendamento. Por favor, escolha outro horário.");

                if (dtData.Value < consulta.Data?.AddMinutes(29))
                    throw new Exception("Uma consulta já está marcada para este horário, agende um pouquinho mais tarde.");
            }
        }

        private void dgvMedicos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMedicos.SelectedRows != null)
                _medicoID = Guid.Parse(dgvMedicos.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btAgendar_Click(object sender, EventArgs e)
        {
            processData();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            var main = new MainPaForm(paciente);
            Hide();
            main.Show();
            main.Activate();
        }
    }
}

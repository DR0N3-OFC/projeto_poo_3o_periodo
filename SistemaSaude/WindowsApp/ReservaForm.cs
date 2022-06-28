using Domain.Enumerators;
using Domain.Models;
using Domain.Repository;
using Persistence.DataContext;
using Persistence.Repository;

namespace WindowsApp
{
    public partial class ReservaForm : Form
    {
        private readonly IRepository<ReservaModel> _reservaModelRepository;
        private readonly IRepository<Remedio> _remedioRepository;
        private Guid? _remedioID;
        private Guid? _pacienteID;
        private Guid? _reservaID;
        private PacienteModel _paciente;
        public ReservaForm(PacienteModel p)
        {
            _reservaModelRepository = new ReservaModelRepository(new EFDataContext());
            _remedioRepository = new RemedioRepository(new EFDataContext());

            _pacienteID = p.PacienteModelID;
            _paciente = p;
            InitializeComponent();
            initialFormatting();
        }

        private void initialFormatting()
        {
            dtData.MinDate = DateTime.Now;
            loadEnumItemsWithDescription();
            lblTitulo.Select();
            dgvReservadosUpdate();
            dgvUpdate();
            btReservar.Enabled = false;
        }

        private void processData()
        {
            try
            {
                ReservaModel reserva = new(
                   dtData.Value,
                   _remedioID,
                   _pacienteID
                   );

                validations();
                _reservaModelRepository.Gravar(reserva);

                dgvUpdate();
                dgvReservadosUpdate();
                MessageBox.Show("Reserva realizada com sucesso. \nConfira na aba \"Reservas\"!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "OPS!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void validations()
        {
            var reservas = _reservaModelRepository.ObterTodos().Where(r => r.RemedioID == _remedioID && r.PacienteID == _pacienteID).ToList();

            foreach (ReservaModel reserva in reservas)
            {
                if (dtData.Value.Date > reserva.DataReserva?.AddMonths(-1) && dtData.Value.Date < reserva.DataReserva?.AddMonths(1))
                    throw new Exception("Você já reservou este remédio para o mesmo mês.");
            }

        }
        private void loadEnumItemsWithDescription()
        {
            foreach (EnumRemedio remedio in EnumMethods.EnumToList<EnumRemedio>())
            {
                cbTipo.Items.Add(remedio.GetDescription());
            }
            cbTipo.SelectedIndex = -1;
        }

        private void dgvUpdate()
        {
            if (cbTipo.SelectedIndex == -1)
            {
                dgvMedicamentos.DataSource = _remedioRepository.ObterTodos();
            } 
            else
            {
                var tipo = EnumMethods.GetEnumByDescription<EnumRemedio>(cbTipo.SelectedItem.ToString()).GetDescription();
                dgvMedicamentos.DataSource = _remedioRepository.ObterTodos().Where(t => t.Tipo == tipo).ToList();
            }

            dgvMedicamentos.Columns[0].Visible = false;
            dgvMedicamentos.ClearSelection();
            lblTitulo.Select();
            btReservar.Enabled = false;
        }

        private void dgvReservadosUpdate()
        {
            var paciente = _reservaModelRepository.ObterTodos().Where(p => p.PacienteID == _pacienteID).ToList();
            dgvReservados.DataSource = paciente;

            dgvReservados.Columns[0].Visible = false;
            dgvReservados.ClearSelection();
            lblTitulo.Select();
            btCancelar.Enabled = false;

            dgvReservados.Columns[0].Visible = false;
            dgvReservados.Columns[1].Visible = false;
            dgvReservados.Columns[2].Visible = false;
            dgvReservados.Columns[5].Visible = false;

            if (dgvReservados.Rows.Count == 0)
                Width -= 360;
            else
                Width = 1229;
        }

        private void cbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            dgvUpdate();
        }

        private void dgvMedicamentos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            btReservar.Enabled = true;

            if (dgvMedicamentos.SelectedRows != null)
                _remedioID = Guid.Parse(dgvMedicamentos.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btReservar_Click(object sender, EventArgs e)
        {
            processData();
        }

        private void ReservaForm_Load(object sender, EventArgs e)
        {
            btReservar.Enabled = false;
            btCancelar.Enabled = false;
            dgvMedicamentos.ClearSelection();
            dgvReservados.ClearSelection();
        }

        private void dgvReservados_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            btCancelar.Enabled = true;

            if (dgvReservados.SelectedRows != null)
                _reservaID = Guid.Parse(dgvReservados.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            var reserva = _reservaModelRepository.ObterPorID(_reservaID);
            _reservaModelRepository.Remover(reserva);

            dgvReservadosUpdate();
            MessageBox.Show("Reserva cancelada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            MainPaForm main = new(_paciente);
            main.Show();
            Hide();
        }

        private void ReservaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainPaForm main = new(_paciente);
            main.Show();
        }
    }
}

using Domain.Models;
using Domain.Repository;
using Persistence.DataContext;
using Persistence.Repository;

namespace WindowsApp
{
    public partial class ConsultasAgendadasMeForm : Form
    {
        private readonly IRepository<Consulta> _consultaRepository;
        private Guid? _medicoID;
        private MedicoModel _medico;
        public ConsultasAgendadasMeForm(MedicoModel m)
        {
            InitializeComponent();

            _medicoID = m.MedicoModelID;
            _medico = m;

            var dataContext = new EFDataContext();
            _consultaRepository = new ConsultaRepository(dataContext);
            initialFormatting();
        }

        private void initialFormatting()
        {
            lblTitulo.Select();
            dtDataInicial.MinDate = DateTime.Now.Date;
            dtDataFinal.MinDate = DateTime.Now.Date;
            dtDataFinal.Value = DateTime.Now.Date.AddDays(7);
            dgvUpdate(); 
            dgvConsultas.ClearSelection();
        }

        private void dgvUpdate()
        {
            dgvConsultas.DataSource = _consultaRepository.ObterTodos().Where(m => m.MedicoModelID == _medicoID).
                Where(c => c.Data?.Date >= dtDataInicial.Value.Date && c.Data?.Date <= dtDataFinal.Value.Date).OrderBy(d => d.Data).ToList();

            dgvConsultas.Columns[0].Visible = false;
            dgvConsultas.Columns[1].Visible = false;
            dgvConsultas.Columns[2].Visible = false;
            dgvConsultas.Columns[4].Visible = false;
        }

        private void dtDataInicial_ValueChanged(object sender, EventArgs e)
        {
            dgvUpdate();
        }

        private void dtDataFinal_ValueChanged(object sender, EventArgs e)
        {
            dgvUpdate();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            var main = new MainMeForm(_medico);
            Hide();
            main.Show();
            main.Activate();
        }
    }
}

using Domain.Enumerators;
using Domain.Models;
using Domain.Repository;
using Persistence.DataContext;
using Persistence.Repository;

namespace WindowsApp
{
    public partial class AdminCatalogoForm : Form
    {
        private readonly IRepository<Remedio> _remedioRepository;
        private Guid? _remedioID;
        public AdminCatalogoForm()
        {
            _remedioRepository = new RemedioRepository(new EFDataContext());

            InitializeComponent();
            initialFormatting();
        }

        private void initialFormatting()
        {
            loadEnumItemsWithDescription();
            lblTitulo.Select();
            dgvUpdate();
        }

        private void loadEnumItemsWithDescription()
        {
            foreach (EnumRemedio remedio in EnumMethods.EnumToList<EnumRemedio>())
            {
                cbTipo.Items.Add(remedio.GetDescription());
            }
            cbTipo.SelectedIndex = -1;
        }

        private void processData()
        {
            try
            {
                Remedio remedio = new(
                       tbNome.Text,
                       EnumMethods.GetEnumByDescription<EnumRemedio>(cbTipo.SelectedItem.ToString()).GetDescription(),
                       dtData.Value
                       );
                validations();
                _remedioRepository.Gravar(remedio);

                dgvUpdate();
                btRemover.Enabled = false;

                MessageBox.Show("Remédio registrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "OPS!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUpdate()
        {
            dgvMedicamentos.DataSource = _remedioRepository.ObterTodos();
            dgvMedicamentos.Columns[0].Visible = false;
            dgvMedicamentos.ClearSelection();

            btRemover.Enabled = false;
            lblTitulo.Select();
        }

        private void validations()
        {
            if (cbTipo.SelectedIndex == -1)
                throw new Exception("Por favor, escolha um tipo de medicamento.");

            if (dtData.Value.Date <= DateTime.Now.Date)
                throw new Exception("Por favor, escolha uma data válida.");

            var nomeExiste = _remedioRepository.ObterTodos().Where(n => n.Nome == tbNome.Text).FirstOrDefault();
            if (nomeExiste != null)
                throw new Exception("Este medicamento já está registrado.");
        }

        private void btCatalogar_Click(object sender, EventArgs e)
        {
            processData();
            tbNome.Text = "";
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            MainAdForm main = new();
            main.Show();
            main.Activate();
            Hide();
        }

        private void dgvMedicamentos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            btRemover.Enabled = true;

            if (dgvMedicamentos.SelectedRows != null)
            {
                _remedioID = Guid.Parse(dgvMedicamentos.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {
            if (tbNome.Text != String.Empty)
                btCatalogar.Enabled = true;
            else
                btCatalogar.Enabled = false;
        }

        private void AdminCatalogoForm_Load(object sender, EventArgs e)
        {
            dgvMedicamentos.ClearSelection();
            btCatalogar.Enabled = false;
            btRemover.Enabled = false;
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            var remedio = _remedioRepository.ObterPorID(_remedioID);
            _remedioRepository.Remover(remedio);

            dgvUpdate();
            MessageBox.Show("Remédio removido com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AdminCatalogoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainAdForm main = new();
            main.Show();
            main.Activate();
            Hide();
        }
    }
}

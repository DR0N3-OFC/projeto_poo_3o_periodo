using Domain.Enumerators;

namespace WindowsApp
{
    public partial class ReservaForm : Form
    {
        public ReservaForm()
        {
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

        private void dgvUpdate()
        {
            dgvMedicamentos.DataSource = _remedioRepository.ObterTodos();
            dgvMedicamentos.Columns[0].Visible = false;
            dgvMedicamentos.ClearSelection();

            btRemover.Enabled = false;
            lblTitulo.Select();
        }
    }
}

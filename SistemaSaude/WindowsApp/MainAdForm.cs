using Domain.Models;

namespace WindowsApp
{
    public partial class MainAdForm : Form
    {
        public MainAdForm()
        {
            InitializeComponent();
        }

        private void btCatalogo_Click(object sender, EventArgs e)
        {
            AdminCatalogoForm catalogo = new AdminCatalogoForm();
            catalogo.Show();
            Hide();
        }

        private void MainAdForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm login = new();
            login.Show();
            login.Activate();
        }
    }
}

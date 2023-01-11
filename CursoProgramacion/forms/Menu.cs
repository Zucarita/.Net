namespace CursoProgramacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            GestionClientes ventanaGestionClientes = new GestionClientes();
            ventanaGestionClientes.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
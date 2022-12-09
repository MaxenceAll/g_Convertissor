namespace g_Convertissor
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void buttonMonnaie_Click(object sender, EventArgs e)
        {
            Monnaies monnaies_convertissor = new Monnaies();
            monnaies_convertissor.Show();
        }
    }
}
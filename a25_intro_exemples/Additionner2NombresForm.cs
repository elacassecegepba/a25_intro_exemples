namespace a25_intro_exemples
{
    public partial class Additionner2NombresForm : Form
    {
        public Additionner2NombresForm()
        {
            InitializeComponent();
        }
        private void Additionner2NombresForm_Load(object sender, EventArgs e)
        {
            resultatTextBox.Enabled = false;
        }

        private void addtitionnerButton_Click(object sender, EventArgs e)
        {
            double nombre1, nombre2, resultat;

            nombre1 = double.Parse(nombre1TextBox.Text);
            nombre2 = double.Parse(nombre2TextBox.Text);
            resultat = nombre1 + nombre2;

            resultatTextBox.Text = resultat.ToString();
        }

    }
}

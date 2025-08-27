namespace a25_intro_exemples
{
    public partial class PairForm : Form
    {
        public PairForm()
        {
            InitializeComponent();
        }

        private void PairForm_Load(object sender, EventArgs e)
        {
            reponseLabel.Text = "";
        }

        private bool EstPair(int nombre)
        {
            return nombre % 2 == 0;
        }

        // Affiche le résultat dans le label
        private void affichageLabelButton_Click(object sender, EventArgs e)
        {
            int nombre = int.Parse(nombreTextBox.Text);

            if (EstPair(nombre))
            {
                reponseLabel.Text = "pair";
            }
            else
            {
                reponseLabel.Text = "impair";
            }
        }

        // Affiche le résultat dans un MessageBox
        private void affichageMessageButton_Click(object sender, EventArgs e)
        {
            int nombre = int.Parse(nombreTextBox.Text);

            if (EstPair(nombre))
            {
                MessageBox.Show("Le nombre est pair");
            }
            else
            {
                MessageBox.Show("Le nombre est impair");
            }
        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {
            reponseLabel.Text = "";
        }
    }
}

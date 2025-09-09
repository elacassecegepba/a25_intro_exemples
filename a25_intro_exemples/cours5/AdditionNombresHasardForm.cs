namespace a25_intro_exemples.cours5
{
    public partial class AdditionNombresHasardForm : Form
    {
        Random random = new Random();

        public AdditionNombresHasardForm()
        {
            InitializeComponent();
        }

        private int GenererNombresHasard()
        {
            int tableMaximum = (int)tableMaximumNumericUpDown.Value;
            return random.Next(1, tableMaximum + 1);
        }

        private void GenererNouveauCalcul()
        {
            nombre1TextBox.Text = GenererNombresHasard().ToString();
            nombre2TextBox.Text = GenererNombresHasard().ToString();
            reponseTextBox.Text = "";
        }

        private void AdditionNombresHasardForm_Load(object sender, EventArgs e)
        {
            // Empêche l'utilisateur de modifier les TextBox
            nombre1TextBox.Enabled = false;
            nombre2TextBox.Enabled = false;

            // Configure le NumericUpDown
            tableMaximumNumericUpDown.Maximum = 12;
            tableMaximumNumericUpDown.Minimum = 1;
            tableMaximumNumericUpDown.Value = 12;

            // Place le curseur dans la TextBox de réponse
            reponseTextBox.Focus();

            // Génère le premier calcul
            GenererNouveauCalcul();
        }


        private bool VerifierReponse(int nombre1, int nombre2, int reponse)
        {
            return (nombre1 + nombre2) == reponse;
        }

        private void GererBonneReponse()
        {
            MessageBox.Show("Bonne réponse!");
            GenererNouveauCalcul();
        }

        private void GererMauvaiseReponse()
        {
            MessageBox.Show("Mauvaise réponse, essayez encore.");
        }

        private bool ReponseEstValide()
        {
            return int.TryParse(reponseTextBox.Text, out _);
        }

        private void verifierReponseButton_Click(object sender, EventArgs e)
        {
            if (ReponseEstValide())
            {
                // Récupère les nombres et la réponse de l'utilisateur
                int nombre1 = int.Parse(nombre1TextBox.Text);
                int nombre2 = int.Parse(nombre2TextBox.Text);
                int reponse = int.Parse(reponseTextBox.Text);

                // Vérifie la réponse de l'utilisateur
                if (VerifierReponse(nombre1, nombre2, reponse))
                {
                    GererBonneReponse();
                }
                else
                {
                    GererMauvaiseReponse();
                }
            }
            else
            {
                MessageBox.Show("La réponse doit être un nombre entier.");
            }

            // Place le curseur dans la TextBox de réponse
            reponseTextBox.Focus();
        }

        private void tableMaximumNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            GenererNouveauCalcul();
        }
    }
}

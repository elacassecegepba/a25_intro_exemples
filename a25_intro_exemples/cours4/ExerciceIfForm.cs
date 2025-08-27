namespace a25_intro_exemples
{
    public partial class ExerciceIfForm : Form
    {
        public ExerciceIfForm()
        {
            InitializeComponent();
        }

        private bool EstUnEntier(TextBox textBox)
        {
            return int.TryParse(textBox.Text, out int entier);
        }

        private bool EstDansIntervalleRequis(int valeur)
        {
            return valeur >= 0 && valeur <= 20;
        }

        private void reussiteButton_Click(object sender, EventArgs e)
        {
            if (EstUnEntier(noteTextBox))
            {
                int note = int.Parse(noteTextBox.Text);
                if (EstDansIntervalleRequis(note))
                {
                    if (note >= 12)
                    {
                        MessageBox.Show("L'étudiant a réussi");
                    }
                    else
                    {
                        MessageBox.Show("L'étudiant a échoué");
                    }
                }
                else
                {
                    MessageBox.Show("La note doit être comprise entre 0 et 20.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer un entier valide pour la note.");
            }
        }

        private void intervalleButton_Click(object sender, EventArgs e)
        {
            if (EstUnEntier(nombreTextBox))
            {
                int nombre = int.Parse(nombreTextBox.Text);
                if (nombre <= 100)
                {
                    if (nombre > 0)
                    {
                        MessageBox.Show("Bon intervalle.");
                    }
                    else
                    {
                        MessageBox.Show("Le nombre doit être plus grand que 0.");
                    }
                }
                else
                {
                    MessageBox.Show("Le nombre doit être plus petit ou égal à 100.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer un entier valide pour le nombre.");
            }
        }

        private void qualifierAgeButton_Click(object sender, EventArgs e)
        {
            string message;
            if (EstUnEntier(ageTextBox))
            {
                int age = int.Parse(ageTextBox.Text);
                if (age >= 18)
                {
                    message = "Est majeur";
                }
                else
                {
                    if (age >= 16)
                    {
                        message = "Peut avoir son permis de conduire";
                    }
                    else
                    {
                        if (age >= 14)
                        {
                            message = "Peut travailler au Qu�bec";
                        }
                        else
                        {
                            message = "Enfant de moins de 14 ans";
                        }
                    }
                }
            }
            else
            {
                message = "Veuillez entrer un entier valide pour l'âge.";
            }

            MessageBox.Show(message);
        }
    }
}

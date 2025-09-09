namespace a25_intro_exemples.cours5
{
    public partial class ExerciceFonctionForm : Form
    {
        public ExerciceFonctionForm()
        {
            InitializeComponent();
        }

        // Faites une fonction LireValeurDUnTextBox qui prend un TextBox en paramètre et qui retourne le nombre à virgule contenu dans ce TextBox.
        private double LireValeurDUnTextBox(TextBox textBox)
        {
            return double.Parse(textBox.Text);
        }

        // Faites une fonction AfficherResultat qui prend un nombre à virgule et un message en paramètre et qui affiche
        // la concaténation du message et du nombre dans un MessageBox.
        private void AfficherResultat(double resultat, string message)
        {
            MessageBox.Show(message + " " + resultat);
        }

        private double CalculerAire(double rayon)
        {
            return Math.PI * rayon * rayon;
        }

        private void aireButton_Click(object sender, EventArgs e)
        {
            // Récupérer la valeur du TextBox avec la fonction LireValeurDUnTextBox
            double rayon = LireValeurDUnTextBox(rayonTextBox);
            // Créer et utiliser une fonction pour calculer l'aire d'un cercle (aire = π * r * r)
            double aire = CalculerAire(rayon);
            // Utiliser la fonction AfficherResultat pour afficher le résultat
            AfficherResultat(aire, "L'aire est : ");
        }

        private double CalculerCirconference(double rayon)
        {
            return 2 * Math.PI * rayon;
        }

        private void circonferenceButton_Click(object sender, EventArgs e)
        {
            // Récupérer la valeur du TextBox avec la fonction LireValeurDUnTextBox
            double rayon = LireValeurDUnTextBox(rayonTextBox);
            // Créer et utiliser une fonction pour calculer la circonférence d'un cercle (circonférence = 2 * π * r)
            double circonference = CalculerCirconference(rayon);
            // Utiliser la fonction AfficherResultat pour afficher le résultat
            AfficherResultat(circonference, "La circonférence est : ");
        }

        private double CalculerCarre(double nombre)
        {
            return nombre * nombre;
        }

        private void carreButton_Click(object sender, EventArgs e)
        {
            // Récupérer la valeur du TextBox avec la fonction LireValeurDUnTextBox
            double nombre = LireValeurDUnTextBox(nombreTextBox);
            // Créer et utiliser une fonction pour calculer le carré d'un nombre (carré = n * n)
            double carre = CalculerCarre(nombre);
            // Utiliser la fonction AfficherResultat pour afficher le résultat
            AfficherResultat(carre, "La carré de ce nombre est : ");
        }
    }
}

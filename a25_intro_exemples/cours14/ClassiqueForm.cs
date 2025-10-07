namespace a25_intro_exemples.cours14;

public partial class ClassiqueForm : Form
{
    public ClassiqueForm()
    {
        InitializeComponent();
    }

    public void DireBonjour(string nom)
    {
        MessageBox.Show("Bonjour " + nom);
    }

    public void AfficherNombre1AX(int fin)
    {
        affichageListBox.Items.Clear();
        int nombre = 1;
        while (nombre <= fin)
        {
            affichageListBox.Items.Add(nombre);
            nombre = nombre + 1;
        }
    }

    private void MettreEnOrdre(ref int petit, ref int moyen, ref int grand)
    {
        List<int> maListe = new List<int>();// Méthode qui sera vue à l'autre session
        maListe.Add(petit);
        maListe.Add(moyen);
        maListe.Add(grand);
        maListe.Sort();
        petit = maListe[0];
        moyen = maListe[1];
        grand = maListe[2];
    }

    private double CalculerPuissance(int laBase, int exposant)
    {
        return Math.Pow(laBase, exposant);
    }

    private double CalculerAire(double rayon)
    {
        return Math.PI * rayon * rayon;
    }

    private void bonjourButton_Click(object sender, EventArgs e)
    {
        // Faites l'appel de la fonction DireBonjour ici.
        // Passer votre nom en paramètre.
        DireBonjour("VotreNom");
    }

    private void afficherNbr1AXButton_Click(object sender, EventArgs e)
    {
        int x = int.Parse(xTextBox.Text);
        // Appelez la fonction
        AfficherNombre1AX(x);
    }

    private void mettreEnOrdreButton_Click(object sender, EventArgs e)
    {
        int petit, moyen, grand;

        petit = 103;
        moyen = 10;
        grand = 22;

        affichageListBox.Items.Clear();

        // Appelez la fonction pour mettre en ordre les trois nombres ici.
        MettreEnOrdre(ref petit, ref moyen, ref grand);

        affichageListBox.Items.Add(petit + " " + moyen + " " + grand);
    }

    private void puissanceButton_Click(object sender, EventArgs e)
    {
        int laBase, exposant;
        double resultat;

        laBase = int.Parse(baseTextBox.Text);
        exposant = int.Parse(exposantTextBox.Text);

        // Appeler la fonction pour calculer la puissance ici.
        resultat = CalculerPuissance(laBase, exposant);

        // Compléter le MessageBox.Show pour afficher le résultat.
        MessageBox.Show("puissance : " + resultat);

        // Autre façon de faire l'appel de la fonction en une ligne :
        MessageBox.Show("puissance : " + CalculerPuissance(laBase, exposant));
    }

    private void aireCercleButton_Click(object sender, EventArgs e)
    {
        double rayon, resultat;

        rayon = double.Parse(rayonTextBox.Text);

        // Appeler la fonction pour calculer l'aire ici.
        resultat = CalculerAire(rayon);

        // Compléter le MessageBox.Show pour afficher le résultat.
        MessageBox.Show("Aire : " + resultat);

        // Autre façon de faire l'appel de la fonction en une ligne :
        MessageBox.Show("Aire : " + CalculerAire(rayon));
    }
}

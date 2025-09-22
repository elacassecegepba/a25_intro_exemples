namespace a25_intro_exemples.cours10;

public partial class AfficherSalutForm : Form
{
    public AfficherSalutForm()
    {
        InitializeComponent();
    }

    /*
    programme tantQueButton_Click
    VAR
	    compteur : entier
    DEBUT
	    compteur = 1
	    Tant Que compteur <= 5
		    Afficher "salut"
		    compteur = compteur + 1
	    FinTantQue
    Fin
    */
    private void tantQueButton_Click(object sender, EventArgs e)
    {
        int compteur = 1;
        while (compteur <= 5)
        {
            affichageListBox.Items.Add("Salut");
            compteur = compteur + 1;
        }

        affichageListBox.Items.Add("-------");
    }

    /*
    programme repeterTantQueButton_Click
    VAR
        compteur : entier
    DEBUT
        compteur = 1
        Répeter
	        Afficher "salut"
            compteur = compteur + 1
        TantQue compteur <= 5
    Fin
    */
    private void repeterTantQueButton_Click(object sender, EventArgs e)
    {
        int compteur = 1;
        do
        {
            affichageListBox.Items.Add("Salut");
            compteur = compteur + 1;
        }
        while (compteur <= 5);

        affichageListBox.Items.Add("-------");
    }

    /*
    programme pourButton_Click
    VAR
        compteur : entier
    DEBUT
        Pour nombreDeSalut de 1 à 5
            Afficher "salut"
        FinPour
    Fin
    */
    private void pourButton_Click(object sender, EventArgs e)
    {
        for (int nombreDeSalut = 1; nombreDeSalut <= 5; nombreDeSalut++)
        {
            affichageListBox.Items.Add("Salut");
        }

        affichageListBox.Items.Add("-------");
    }

    private void viderButton_Click(object sender, EventArgs e)
    {
        affichageListBox.Items.Clear();
    }
}
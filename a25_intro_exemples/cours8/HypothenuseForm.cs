namespace a25_intro_exemples.cours8;

/*
    Ajustez les passages de paramètres pour que les deux appels
    successifs à CalculerHypothenuse produisent une valeur identique.
*/

public partial class HypothenuseForm : Form
{
    public HypothenuseForm()
    {
        InitializeComponent();
    }

    private void hypothenuseButton_Click(object sender, EventArgs e)
    {
        double a;
        double b;

        a = double.Parse(coteATextBox.Text);
        b = double.Parse(coteBTextBox.Text);

        MessageBox.Show("Résultat de l'hypothénuse de A et B " + CalculerHypothenuse(a, b).ToString());
        MessageBox.Show("... plus tard, on réessaie avec le même appel");
        MessageBox.Show("Résultat du 2e appel de l'hypothénuse de A et B " + CalculerHypothenuse(a, b).ToString());
    }

    // L'hypothénuse se calcule en élevant les côtés au carré,
    // en les additionnant et en appliquant la racine carré.
    private double CalculerHypothenuse(double longueurCote1, double longueurCote2)
    {
        double longueurAuCarreCote1, longueurAuCarreCote2;

        longueurAuCarreCote1 = CalculerLeCarre(longueurCote1);
        longueurAuCarreCote2 = CalculerLeCarre(longueurCote2);

        return CalculerRacineCarre(longueurAuCarreCote1 + longueurAuCarreCote2);
    }

    private double CalculerLeCarre(double valeur)
    {
        valeur = valeur * valeur;
        return valeur;
    }

    private double CalculerRacineCarre(double valeur)
    {
        return Math.Sqrt(valeur);
    }
}

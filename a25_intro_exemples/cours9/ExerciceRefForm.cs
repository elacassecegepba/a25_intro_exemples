namespace a25_intro_exemples.cours9;

public partial class ExerciceRefForm : Form
{
    public ExerciceRefForm()
    {
        InitializeComponent();
    }

    private void echangerValeurButton_Click(object sender, EventArgs e)
    {
        int nombre1, nombre2;

        nombre1 = int.Parse(nombre1EchangerTextBox.Text);
        nombre2 = int.Parse(nombre2EchangerTextBox.Text);

        EchangerValeur(ref nombre1, ref nombre2);

        nombre1EchangerTextBox.Text = nombre1.ToString();
        nombre2EchangerTextBox.Text = nombre2.ToString();
    }

    /*
    programme EchangerValeur
    Paramètre
        ref nombre1 : entier
        ref nombre2 : entier
    VAR
        temporaire : entier
    DEBUT
        temporaire = nombre1;
        nombre1 = nombre2;
        nombre2 = temporaire;
    Fin
    */
    private void EchangerValeur(ref int nombre1, ref int nombre2)
    {
        int temporaire;
        temporaire = nombre1;
        nombre1 = nombre2;
        nombre2 = temporaire;
    }

    private void placerEnOrdreButton_Click(object sender, EventArgs e)
    {
        int nombre1, nombre2;

        nombre1 = int.Parse(nombre1OrdreTextBox.Text);
        nombre2 = int.Parse(nombre2OrdreTextBox.Text);

        PlacerEnOrdre(ref nombre1, ref nombre2);

        nombre1OrdreTextBox.Text = nombre1.ToString();
        nombre2OrdreTextBox.Text = nombre2.ToString();
    }

    /*
    programme PlacerEnOrdre
    Paramètre
        ref nombre1 : entier
        ref nombre2 : entier
    VAR
        temporaire : entier
    DEBUT
        Si nombre1 > nombre2
            temporaire = nombre1;
            nombre1 = nombre2;
            nombre2 = temporaire;
        FinSi
    Fin
    */
    private void PlacerEnOrdre(ref int nombre1, ref int nombre2)
    {
        int temporaire;

        if (nombre1 > nombre2)
        {
            temporaire = nombre1;
            nombre1 = nombre2;
            nombre2 = temporaire;
        }
    }

    private void incrementerButton_Click(object sender, EventArgs e)
    {
        int nombre;

        nombre = int.Parse(nombreIncrementerTextBox.Text);

        Incrementer(ref nombre);

        nombreIncrementerTextBox.Text = nombre.ToString();
    }

    /*
    programme Incrementer
    Paramètre
        ref nombre : entier
    DEBUT
        nombre = nombre + 1;
    Fin
    */
    private void Incrementer(ref int nombre)
    {
        nombre = nombre + 1;
    }

    private void incrementerAmeliorerButton_Click(object sender, EventArgs e)
    {
        int nombre, increment;

        nombre = int.Parse(nombreIncrementerAmelioreTextBox.Text);
        increment = int.Parse(incrementIncrementerAmelioreTextBox.Text);

        IncrementerAmeliore(ref nombre, increment);

        nombreIncrementerAmelioreTextBox.Text = nombre.ToString();
    }

    /*
    programme IncrementerAmeliore
    Paramètre
        ref nombre : entier
        increment : entier
    DEBUT
        nombre = nombre + increment;
    Fin
    */
    private void IncrementerAmeliore(ref int nombre, int increment)
    {
        nombre = nombre + increment;
    }
}

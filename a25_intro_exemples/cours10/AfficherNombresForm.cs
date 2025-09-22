namespace a25_intro_exemples.cours10;

public partial class AfficherNombresForm : Form
{
    public AfficherNombresForm()
    {
        InitializeComponent();
    }

    /*
    programme executer1A10Button_Click
    VAR
        nombre : entier
    DEBUT
        nombre = 1
        Tant Que nombre <= 10
            Afficher nombre
            nombre = nombre + 1
        FinTantQue
    Fin
    */
    private void executer1A10Button_Click(object sender, EventArgs e)
    {
        int nombre = 1;
        while (nombre <= 10)
        {
            affichageListBox.Items.Add(nombre);
            nombre = nombre + 1;
        }


        affichageListBox.Items.Add("-------");
    }

    /*
    programme executerXAYButton_Click
    VAR
        x, y : entier
    DEBUT
        x = xTextBox.Text
        y = yTextBox.Text

        Tant Que x <= y
            Afficher x
            x = x + 1
        FinTantQue
    Fin
    */
    private void executerXAYButton_Click(object sender, EventArgs e)
    {
        int x, y;

        x = int.Parse(deTextBox.Text);
        y = int.Parse(aTextBox.Text);

        while (x <= y)
        {
            affichageListBox.Items.Add(x);
            x = x + 1;
        }


        affichageListBox.Items.Add("-------");
    }

    private void viderListBoxButton_Click(object sender, EventArgs e)
    {
        affichageListBox.Items.Clear();
    }
}

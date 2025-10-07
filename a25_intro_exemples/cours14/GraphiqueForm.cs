namespace a25_intro_exemples.cours14;


public partial class GraphiqueForm : Form
{
    PictureBox dernierPictureBox;
    int positionPictureBox = 10;

    public GraphiqueForm()
    {
        InitializeComponent();
    }

    public void CreerPictureBox(Form form, ref PictureBox pictureBox)
    {
        pictureBox = new PictureBox();
        pictureBox.Location = new Point(420, positionPictureBox);
        positionPictureBox = positionPictureBox + 20;
        pictureBox.BackColor = Color.Red;
        pictureBox.Size = new Size(10, 10);
        form.Controls.Add(pictureBox);
    }

    public void ChangerCouleur(PictureBox pictureBox, Color couleur)
    {
        if (pictureBox == null) // Si le PictureBox n'existe pas
        {
            MessageBox.Show("Veuillez créer le PictureBox");
        }
        else
        {
            pictureBox.BackColor = couleur;
        }
    }

    private Color ObtenirLaCouleur(PictureBox pictureBox)
    {
        Color couleur;
        if (dernierPictureBox == null) // Si le PictureBox n'existe pas
        {
            MessageBox.Show("Veuillez créer le PictureBox");
            couleur = Color.Red; // Couleur par défaut
        }
        else
        {
            couleur = pictureBox.BackColor;
        }
        return couleur;
    }

    private void creerPictureBoxButton_Click(object sender, EventArgs e)
    {
        // Appelez la fonction pour créer un PictureBox ici.
        // Utilisez this pour le paramètre du Form.
        // Utilisez dernierPictureBox pour le paramètre du PictureBox.
        CreerPictureBox(this, ref dernierPictureBox);
    }

    private void changerCouleurButton_Click(object sender, EventArgs e)
    {
        // Appelez la fonction pour changer la couleur du dernier PictureBox ici.
        // Pour la couleur, écriver Color. et choisissez une couleur.
        ChangerCouleur(dernierPictureBox, Color.Purple);
    }

    private void donnerCouleurButton_Click(object sender, EventArgs e)
    {
        // Appelez la fonction pour obtenir la couleur du dernier PictureBox ici.
        // Changez la couleur du bouton donnerCouleurButton (donnerCouleurButton.BackColor) avec la couleur obtenue.
        donnerCouleurButton.BackColor = ObtenirLaCouleur(dernierPictureBox);
    }
}

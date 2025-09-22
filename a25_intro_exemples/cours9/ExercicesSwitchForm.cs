namespace a25_intro_exemples.cours9;

public partial class ExercicesSwitchForm : Form
{
    public ExercicesSwitchForm()
    {
        InitializeComponent();
    }

    private void switchButton_Click(object sender, EventArgs e)
    {
        int nombre = int.Parse(nombreTextBox.Text);

        // Ne pas supprimer
        if (nombre == 1)
        {
            affichageListBox.Items.Add("Dimanche");
        }
        else
        {
            if (nombre == 2)
            {
                affichageListBox.Items.Add("Lundi");
            }
            else
            {
                if (nombre == 3)
                {
                    affichageListBox.Items.Add("Mardi");
                }
                else
                {
                    if (nombre == 4)
                    {
                        affichageListBox.Items.Add("Mercredi");
                    }
                    else
                    {
                        if (nombre == 5)
                        {
                            affichageListBox.Items.Add("Jeudi");
                        }
                        else
                        {
                            if (nombre == 6)
                            {
                                affichageListBox.Items.Add("Vendredi");
                            }
                            else
                            {
                                if (nombre == 7)
                                {
                                    affichageListBox.Items.Add("Samedi");
                                }
                                else
                                {
                                    affichageListBox.Items.Add("indéterminé");
                                }
                            }
                        }
                    }
                }
            }
        }

        // Faire version avec elseif (sinon si) ici
        if (nombre == 1)
        {
            affichageListBox.Items.Add("Dimanche");
        }
        else if (nombre == 2)
        {
            affichageListBox.Items.Add("Lundi");
        }
        else if (nombre == 3)
        {
            affichageListBox.Items.Add("Mardi");
        }
        else if (nombre == 4)
        {
            affichageListBox.Items.Add("Mercredi");
        }
        else if (nombre == 5)
        {
            affichageListBox.Items.Add("Jeudi");
        }
        else if (nombre == 6)
        {
            affichageListBox.Items.Add("Vendredi");
        }
        else if (nombre == 7)
        {
            affichageListBox.Items.Add("Samedi");
        }
        else
        {
            affichageListBox.Items.Add("indéterminé");
        }

        // Faire version avec switch (selon que) ici
        switch (nombre)
        {
            case 1:
                affichageListBox.Items.Add("Dimanche");
                break;
            case 2:
                affichageListBox.Items.Add("Lundi");
                break;
            case 3:
                affichageListBox.Items.Add("Mardi");
                break;
            case 4:
                affichageListBox.Items.Add("Mercredi");
                break;
            case 5:
                affichageListBox.Items.Add("Jeudi");
                break;
            case 6:
                affichageListBox.Items.Add("Vendredi");
                break;
            case 7:
                affichageListBox.Items.Add("Samedi");
                break;
            default:
                affichageListBox.Items.Add("indéterminé");
                break;
        }
    }

    private void switchComplexeButton_Click(object sender, EventArgs e)
    {
        int nombre = int.Parse(nombreTextBox.Text);

        // Ne pas supprimer
        if (nombre > 42)
        {
            affichageListBox.Items.Add("nombre plus grand que 42");
        }
        else
        {
            if (nombre >= 21)
            {
                affichageListBox.Items.Add("nombre entre 21 et 42 inclus");
            }
            else
            {
                if (nombre >= 1)
                {
                    affichageListBox.Items.Add("nombre entre 1 et 20 inclus");
                }
                else
                {
                    affichageListBox.Items.Add("nombre négatif ou zéro");
                }
            }
        }

        // Faire version avec elseif (sinon si) ici
        if (nombre > 42)
        {
            affichageListBox.Items.Add("nombre plus grand que 42");
        }
        else if (nombre >= 21)
        {
            affichageListBox.Items.Add("nombre entre 21 et 42 inclus");
        }
        else if (nombre >= 1)
        {
            affichageListBox.Items.Add("nombre entre 1 et 20 inclus");
        }
        else
        {
            affichageListBox.Items.Add("nombre négatif ou zéro");
        }

        // Faire version avec switch (selon que) ici
        switch (nombre)
        {
            case int reponse when nombre > 42:
                affichageListBox.Items.Add("nombre plus grand que 42");
                break;
            case int reponse when nombre >= 21:
                affichageListBox.Items.Add("nombre entre 21 et 42 inclus");
                break;
            case int reponse when nombre >= 1:
                affichageListBox.Items.Add("nombre entre 1 et 20 inclus");
                break;
            default:
                affichageListBox.Items.Add("nombre négatif ou zéro");
                break;
        }

    }
}

namespace a25_intro_exemples.cours7;

public partial class CalculatriceForm : Form
{
    public CalculatriceForm()
    {
        InitializeComponent();
    }

    private void CalculatriceForm_Load(object sender, EventArgs e)
    {
        resultatLabel.Text = "";
    }

    private void effectuerCalculButton_Click(object sender, EventArgs e)
    {
        double nombre1, nombre2, resultat;
        string operateur;

        if (VerifierDonneesDeUtilisateur())
        {
            nombre1 = double.Parse(nombre1TextBox.Text);
            nombre2 = double.Parse(nombre2TextBox.Text);
            operateur = operateurTextBox.Text;

            resultat = FaireCalcul(nombre1, nombre2, operateur);

            resultatLabel.Text = resultat.ToString();
        }
    }

    private bool VerifierDonneesDeUtilisateur()
    {
        bool estValide = true;

        if (EstUnDouble(nombre1TextBox) == false)
        {
            MessageBox.Show("Le 1er nombre doit �tre un r�el. Ex. : 42,0");
            estValide = false;
        }
        else if (EstUnDouble(nombre2TextBox) == false)
        {
            MessageBox.Show("Le 2e nombre doit �tre un r�el. Ex. : 42,0");
            estValide = false;
        }
        else if (EstUnOperateur(operateurTextBox) == false)
        {
            MessageBox.Show("Seuls les op�rateurs +, -, * et / sont support�s");
            estValide = false;
        }
        else if (EstDivisionParZero(operateurTextBox, nombre2TextBox))
        {
            MessageBox.Show("Division par 0");
            estValide = false;
        }

        return estValide;
    }

    private bool EstUnDouble(TextBox textBox)
    {
        return double.TryParse(textBox.Text, out double leDouble);
    }

    private bool EstUnOperateur(TextBox textBox)
    {
        string operateur = textBox.Text;
        bool estUnOperateur = false;

        if (textBox.Text == "+")
        {
            estUnOperateur = true;
        }
        else if (operateur == "-")
        {
            estUnOperateur = true;
        }
        else if (operateur == "*")
        {
            estUnOperateur = true;
        }
        else if (operateur == "/")
        {
            estUnOperateur = true;
        }

        return estUnOperateur;
    }

    private bool EstDivisionParZero(TextBox operateur, TextBox denominateur)
    {
        bool estDivisionParZero = false;

        if (operateur.Text == "/")
        {
            if (double.Parse(denominateur.Text) == 0)
            {
                estDivisionParZero = true;
            }
        }

        return estDivisionParZero;
    }

    private double FaireCalcul(double nombre1, double nombre2, string operateur)
    {
        double resultat;

        if (operateur == "+")
        {
            resultat = nombre1 + nombre2;
        }
        else if (operateur == "-")
        {
            resultat = nombre1 - nombre2;
        }
        else if (operateur == "*")
        {
            resultat = nombre1 * nombre2;
        }
        else
        {
            resultat = nombre1 / nombre2;
        }

        return resultat;
    }

    private void nombre1TextBox_TextChanged(object sender, EventArgs e)
    {
        ViderLabelResultat();
    }

    private void nombre2TextBox_TextChanged(object sender, EventArgs e)
    {
        ViderLabelResultat();
    }

    private void operateurTextBox_TextChanged(object sender, EventArgs e)
    {
        ViderLabelResultat();
    }

    private void ViderLabelResultat()
    {
        resultatLabel.Text = "";
    }
}

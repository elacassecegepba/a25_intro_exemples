namespace a25_intro_exemples.cours11;

public partial class FizzBuzzForm : Form
{
    public FizzBuzzForm()
    {
        InitializeComponent();
    }

    private void fizzBuzzButton_Click(object sender, EventArgs e)
    {
        int nombreMax;
        affichageListBox.Items.Clear();
        if (!int.TryParse(nombreMaxTextBox.Text, out nombreMax) || nombreMax < 1)
        {
            MessageBox.Show("Veuillez entrer un nombre entier positif.");
        }
        else
        {
            FizzBuzz(nombreMax);
            //FizzBuzz2(nombreMax);
        }
    }

    /*
    Programme FizzBuzz
    Paramètre
        nombreMax : entier
    VAR
        resultat : texte
        compteur : entier
    DEBUT
        compteur = 1
        Tant Que compteur <= nombreMax
            resultat = ""
            Si EstMultipleDe(compteur, 3)
                resultat = resultat + "Fizz"
            FinSi
            Si EstMultipleDe(compteur, 5)
                resultat = resultat + "Buzz"
            FinSi
            Si resultat = ""
                resultat = ConvertirEnTexte(compteur)
            FinSi
            Afficher resultat
            compteur = compteur + 1
        FinTantQue
    FIN
    */
    private void FizzBuzz(int nombreMax)
    {
        string resultat;
        int compteur;

        compteur = 1;
        while (compteur <= nombreMax)
        {
            resultat = "";
            if (EstMultipleDe(compteur, 3))
            {
                resultat = resultat + "Fizz";
            }
            if (EstMultipleDe(compteur, 5))
            {
                resultat = resultat + "Buzz";
            }
            if (resultat == "")
            {
                resultat = compteur.ToString();
            }
            affichageListBox.Items.Add(resultat);
            compteur = compteur + 1;
        }
    }

    private bool EstMultipleDe(int nombre, int diviseur)
    {
        return nombre % diviseur == 0;
    }

    /*
    Programme FizzBuzz2
    Paramètre
        nombreMax : entier
    VAR
        compteur : entier
    DEBUT
        compteur = 1
        Tant Que compteur <= nombreMax
            Si EstMultipleDe(compteur, 3)
                Si EstMultipleDe(compteur, 5)
                    Afficher "FizzBuzz"
                Sinon
                    Afficher "Fizz"
            Sinon Si EstMultipleDe(compteur, 5)
                Afficher "Buzz"
            Sinon
                Afficher compteur
            FinSi
            compteur = compteur + 1
        FinTantQue
    FIN
    */
    private void FizzBuzz2(int nombreMax)
    {
        int compteur;

        compteur = 1;
        while (compteur <= nombreMax)
        {
            if (EstMultipleDe(compteur, 3))
            {
                if (EstMultipleDe(compteur, 5))
                {
                    affichageListBox.Items.Add("FizzBuzz");    
                }
                else
                {
                    affichageListBox.Items.Add("Fizz");
                }
            }
            else if (EstMultipleDe(compteur, 5))
            {
                affichageListBox.Items.Add("Buzz");
            }
            else
            {
                affichageListBox.Items.Add(compteur.ToString());
            }
            compteur = compteur + 1;
        }
    }
}

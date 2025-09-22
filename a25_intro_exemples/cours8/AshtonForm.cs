namespace a25_intro_exemples.cours8;

/*
    Chez Ashton, les clients bénéficient d’un rabais
    hivernal basé sur la température extérieure. Peu importe
    la météo, un rabais minimum de 10 % est garanti.
    
    Le programme :
        - Demande la température en Fahrenheit (car le thermomètre utilisé est en Fahrenheit)
        - Convertit cette température en Celsius
        - Calcule et affiche :
            - Le pourcentage de rabais (affiché en valeur négative)
            - Le montant du rabais obtenu par le client
            - Le montant total de la commande

    Faites les modifications nécessaire pour :
        - Toutes les variables utilisées doivent être déclarées localement.
          Donc, déplacez toute déclaration globale dans le corps de l’événement clic du bouton.
        - Identifiez les paramètres nécessaires à chaque fonction.
          Indice : Les variables soulignées en rouge dans votre environnement de développement
                   indiquent celles qui ne sont pas reconnues localement.
        - Pour chaque paramètre, déterminez s’il doit être passé :
            - Par valeur : si la fonction n’a pas besoin de modifier la variable
            - Par référence : si la fonction doit modifier la variable et que cette modification
                              doit être visible après l’appel

    Voici 2 exemples : 
        FarenHeit               : -15
        Montant                 : 10,00
                    Donne
        Équivalent en Celcius   : -26
        % de rabais             : -26
        Rabais                  : 2,60$
        Montant total           : 7,40$

        FarenHeit               : 32
        Montant                 : 10,00
                    Donne
        Équivalent en Celcius   : 0
        % de rabais             : -10
        Rabais                  : 1,00$
        Montant total           : 9,00$
*/

public partial class AshtonForm : Form
{
    public AshtonForm()
    {
        InitializeComponent();
    }

    private void calculerRabaisButton_Click(object sender, EventArgs e)
    {
        int degreEnFahrenheit;
        int degreEnCelcius;
        decimal montantAchat;
        decimal montantRabais;
        decimal pourcentageRabais;
        decimal montantTotal;

        // Récupération des données du Form
        degreEnFahrenheit = int.Parse(fahrenheitTextBox.Text);
        montantAchat = decimal.Parse(montantAchatTextBox.Text);

        // Calcul du montant total
        degreEnCelcius = ConvertirDegreFahrenheitEnCelcius(degreEnFahrenheit);
        pourcentageRabais = CalculerPourcentageRabais(degreEnCelcius);
        montantRabais = CalculerMontantRabais(montantAchat, pourcentageRabais);
        montantTotal = CalculerMontant(montantAchat, montantRabais);

        // Affichage du résultat
        AfficherInformations(degreEnCelcius, pourcentageRabais, montantRabais, montantTotal);
    }

    private int ConvertirDegreFahrenheitEnCelcius(int degreEnFahrenheit)
    {
        // 5.0/9.0 = 0.5555555555555556, sinon 5/9 = 0
        return (int)((degreEnFahrenheit - 32) * 5.0 / 9.0);
    }

    private decimal CalculerPourcentageRabais(int degreEnCelcius)
    {
        decimal pourcentageRabais;

        if (degreEnCelcius > -10)
        {
            pourcentageRabais = -10; // Minimum 10% de rabais
        }
        else
        {
            pourcentageRabais = degreEnCelcius;  // Ex.: -24 degree Celcius donne 24% de rabais
        }

        return pourcentageRabais;
    }

    private decimal CalculerMontantRabais(decimal montantAchat, decimal pourcentageRabais)
    {
        // Le m indique 0.01 est un décimal, sinon par défaut les nombres à virgule sont des double
        return montantAchat * Math.Abs(pourcentageRabais) * 0.01m;
    }

    private decimal CalculerMontant(decimal montantAchat, decimal montantRabais)
    {
        return montantAchat - montantRabais;
    }

    private void AfficherInformations(int degreEnCelcius, decimal pourcentageRabais, decimal montantRabais, decimal montantTotal)
    {
        celciusTextBox.Text = degreEnCelcius.ToString();
        pourcentageRabaisTextBox.Text = pourcentageRabais.ToString();
        montantRabaisTextBox.Text = montantRabais.ToString("C");
        montantTotalTextBox.Text = montantTotal.ToString("C");
    }

    private void fahrenheitTextBox_TextChanged(object sender, EventArgs e)
    {
        ViderTextBoxReponse();
    }

    private void montantAchatTextBox_TextChanged(object sender, EventArgs e)
    {
        ViderTextBoxReponse();
    }

    private void ViderTextBoxReponse()
    {
        celciusTextBox.Text = "";
        pourcentageRabaisTextBox.Text = "";
        montantRabaisTextBox.Text = "";
        montantTotalTextBox.Text = "";
    }
}

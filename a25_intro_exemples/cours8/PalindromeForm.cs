using System.Globalization;
using System.Text;

namespace a25_intro_exemples.cours8;

/*
    Ajustez les passages de paramètres pour que la
    comparaison du texte et de son inverse fonctionne.

    Exemples de palindrome :
        - Civic
        - Anna
        - Non
        - SOS
        - Radar
        - Élu par cette crapule
        - Engage le jeu que je le gagne
        - A man a plan a canal panama
*/


public partial class PalindromeForm : Form
{
    public PalindromeForm()
    {
        InitializeComponent();
    }

    private void palindromeButton_Click(object sender, EventArgs e)
    {
        string texte;
        string texteInverse;

        texte = texteTextBox.Text;
        texte = EnleverLesEspaces(texte);
        texte = RetirerAccents(texte);
        texte = MettreEnMinuscule(texte);
        texteInverse = InverserLeTexte(texte);

        AfficherSiPalindrome(texte, texteInverse);

    }

    private string EnleverLesEspaces(string texte)
    {
        return texte.Replace(" ", "");
    }

    public static string RetirerAccents(string texte)
    {
        string texteSansAccent;
        texteSansAccent = "";

        foreach (char caractere in texte.Normalize(NormalizationForm.FormD))
        {
            if (CharUnicodeInfo.GetUnicodeCategory(caractere) != UnicodeCategory.NonSpacingMark)
            {
                texteSansAccent = texteSansAccent + caractere;
            }
        }

        return texteSansAccent;
    }

    private string MettreEnMinuscule(string texte)
    {
        return texte.ToLower();
    }

    private string InverserLeTexte(string texte)
    {
        string resteDuTexte;
        string denierCharactere;
        string texteInverse;

        texteInverse = "";

        while (texte.Length > 0)
        {
            denierCharactere = texte.Substring(texte.Length - 1, 1);
            resteDuTexte = texte.Substring(0, texte.Length - 1);
            texteInverse = texteInverse + denierCharactere;
            texte = resteDuTexte;
        }

        return texteInverse;
    }

    private void AfficherSiPalindrome(string texte, string texteInverse)
    {
        MessageBox.Show("\"" + texte + "\" inversé donne \"" + texteInverse + "\"");

        if (EstIdentique(texte, texteInverse))
        {
            MessageBox.Show("C'est un palindrome");
        }
        else
        {
            MessageBox.Show("Ce n'est pas un palindrome");
        }
    }

    private bool EstIdentique(string texte1, string texte2)
    {
        return texte1 == texte2;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a25_intro_exemples.cours6
{
    public partial class HasardFormPartie1 : Form
    {
        Random random = new Random();

        public HasardFormPartie1()
        {
            InitializeComponent();
        }

        private void HasardForm_Load(object sender, EventArgs e)
        {
            nombre1TextBox.Enabled = false;
            nombre2TextBox.Enabled = false;

            GenererNouveauCalcul();
        }

        private int GenererNombreHasard()
        {
            int nombreHasard;
            nombreHasard = random.Next(1, 12 + 1);
            return nombreHasard;
        }

        private void GenererNouveauCalcul()
        {
            int nombre1;
            int nombre2;

            nombre1 = GenererNombreHasard();
            nombre2 = GenererNombreHasard();

            nombre1TextBox.Text = nombre1.ToString();
            nombre2TextBox.Text = nombre2.ToString();
        }

        /*
        Programme verifierReponseButton_Click
        VAR 
	        reponseEstBonne : Bool�en
	        nombre1, nombre2, reponse : Entier
        Debut
	        nombre1 = nombre1TextBox.Text
	        nombre2 = nombre2TextBox.Text
	        reponse = reponseTextBox.Text
	
	        reponseEstBonne = VerifierReponse(nombre1, nombre2, reponse)
	
	        Si reponseEstBonne
		        GererBonneReponse()
	        Sinon
		        GererMauvaiseReponse()
        Fin 
        */
        private void verifierReponseButton_Click(object sender, EventArgs e)
        {
            if (EstUnEntier(reponseTextBox))
            {
                bool reponseEstBonne;
                int nombre1, nombre2, reponse;

                nombre1 = int.Parse(nombre1TextBox.Text);
                nombre2 = int.Parse(nombre2TextBox.Text);
                reponse = int.Parse(reponseTextBox.Text);

                reponseEstBonne = VerifierReponse(
                    nombre1, nombre2, reponse
                );

                if (reponseEstBonne)
                {
                    GererBonneReponse();
                }
                else
                {
                    GererMauvaiseReponse();
                }
            }
            else
            {
                MessageBox.Show(
                    "La r�ponse doit �tre un entier"
                );
            }

        }

        /*
        Programme VerifierReponse
        Param�tres
	        nombre1, nombre2, reponse : Entier
        VAR 
	        reponseEstBonne : Bool�en
        Debut
	        Si nombre1 + nombre2 = reponse
		        reponseEstBonne = vrai
	        Sinon
		        reponseEstBonne = faux
	
	        retourne reponseEstBonne
        Fin 
        */
        private bool VerifierReponse(int nombre1, int nombre2, int reponse)
        {
            bool reponseEstBonne;

            if (nombre1 + nombre2 == reponse)
            {
                reponseEstBonne = true;
            }
            else
            {
                reponseEstBonne = false;
            }

            return reponseEstBonne;
        }

        /*
        Programme GererBonneReponse
        Debut
	        Afficher "Bravo!"
	        reponseTextBox.Text = ""
	        GenererNouveauCalcul()
        Fin 
        */
        private void GererBonneReponse()
        {
            MessageBox.Show("Bravo!");
            reponseTextBox.Text = "";
            GenererNouveauCalcul();
        }

        /*
        Programme GererMauvaiseReponse
        Debut
	        Afficher "Mauvaise r�ponse"
        Fin 
        */
        private void GererMauvaiseReponse()
        {
            MessageBox.Show("Mauvaise r�ponse");
        }

        private bool EstUnEntier(TextBox textBox)
        {
            bool estUnEntier;
            int entier;

            estUnEntier = int.TryParse(
                textBox.Text, out entier
            );

            return estUnEntier;
        }
    }
}

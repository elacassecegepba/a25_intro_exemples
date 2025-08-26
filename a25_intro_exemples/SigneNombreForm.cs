namespace a25_intro_exemples
{
    public partial class SigneNombreForm : Form
    {
        public SigneNombreForm()
        {
            InitializeComponent();
        }

        /*
        Programme afficherSigneButton_Click
        VAR
	        nombre : reel
        Debut
	        nombre = nombreTextBox.Text
	
	        si nombre > 0
		        Afficher "Positif"
	        Sinon
			        si nombre < 0
				        Afficher "Négatif"
			        sinon
				        Afficher "Zéro"
			        FinSi
	        FinSi
        Fin
         */
        private void afficherSigneButton_Click(object sender, EventArgs e)
        {
            double nombre;

            nombre = double.Parse(nombreTextBox.Text);

            if (nombre > 0)
            {
                MessageBox.Show("Positif");
            }
            else
            {
                if (nombre < 0)
                {
                    MessageBox.Show("Négatif");
                }
                else
                {
                    MessageBox.Show("Zéro");
                }
            }
        }
    }
}

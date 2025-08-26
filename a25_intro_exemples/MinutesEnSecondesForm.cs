namespace a25_intro_exemples
{
    public partial class MinutesEnSecondesForm : Form
    {
        public MinutesEnSecondesForm()
        {
            InitializeComponent();
        }

        /*
        Programme convertirMinuteSecondeButton_Click
        CONST
            secondesParMinute = 60 : entier
        VAR
            minutes, secondes : entier
        Debut
            minutes = minutesTextBox.Text
	        secondes = minutes * secondesParMinute

            Afficher secondes
        Fin
        */

        private void convertirButton_Click(object sender, EventArgs e)
        {
            const int secondesParMinute = 60;
            int minutes, secondes;

            minutes = int.Parse(minutesTextBox.Text);
            secondes = minutes * secondesParMinute;

            MessageBox.Show($"{minutes} minutes = {secondes} secondes");

            minutesTextBox.Text = "";
            minutesTextBox.Focus();
        }
    }
}

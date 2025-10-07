using a25_intro_exemples.cours10;
using a25_intro_exemples.cours11;
using a25_intro_exemples.cours14;
using a25_intro_exemples.cours5;
using a25_intro_exemples.cours6;
using a25_intro_exemples.cours7;
using a25_intro_exemples.cours8;
using a25_intro_exemples.cours9;

namespace a25_intro_exemples
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(320, 600); // Change la taille du Form pour s'assurer qu'il entre dans l'écran
            cours2GroupBox.Select(); // Scroll en haut du Form
        }

        private void exerciceAddition2NombreButton_Click(object sender, EventArgs e)
        {
            Additionner2NombresForm additionner2NombresForm = new Additionner2NombresForm();
            additionner2NombresForm.ShowDialog();
        }

        private void exempleMinutesEnSecondeButton_Click(object sender, EventArgs e)
        {
            MinutesEnSecondesForm minutesEnSecondesForm = new MinutesEnSecondesForm();
            minutesEnSecondesForm.ShowDialog();
        }

        private void exemplePositifNegatifZeroButton_Click(object sender, EventArgs e)
        {
            SigneNombreForm signeNombreForm = new SigneNombreForm();
            signeNombreForm.ShowDialog();
        }

        private void exempleFonctionEstPairButton_Click(object sender, EventArgs e)
        {
            PairForm pairForm = new PairForm();
            pairForm.ShowDialog();
        }

        private void exerciceIfSimpleButton_Click(object sender, EventArgs e)
        {
            ExerciceIfForm exerciceIfForm = new ExerciceIfForm();
            exerciceIfForm.ShowDialog();
        }

        private void exerciceFonctionButton_Click(object sender, EventArgs e)
        {
            ExerciceFonctionForm exerciceFonctionForm = new ExerciceFonctionForm();
            exerciceFonctionForm.ShowDialog();
        }

        private void additionNombresHasardButton_Click(object sender, EventArgs e)
        {
            AdditionNombresHasardForm additionNombresHasardForm = new AdditionNombresHasardForm();
            additionNombresHasardForm.ShowDialog();
        }

        private void hasardPartie1Button_Click(object sender, EventArgs e)
        {
            HasardFormPartie1 hasardFormPartie1 = new HasardFormPartie1();
            hasardFormPartie1.ShowDialog();
        }

        private void exerciceRecapButton_Click(object sender, EventArgs e)
        {
            CalculatriceForm calculatriceForm = new CalculatriceForm();
            calculatriceForm.ShowDialog();
        }

        private void ashtonButton_Click(object sender, EventArgs e)
        {
            AshtonForm ashtonForm = new AshtonForm();
            ashtonForm.ShowDialog();
        }

        private void hypothenuseButton_Click(object sender, EventArgs e)
        {
            HypothenuseForm hypothenuseForm = new HypothenuseForm();
            hypothenuseForm.ShowDialog();
        }

        private void palindromeButton_Click(object sender, EventArgs e)
        {
            PalindromeForm palindromeForm = new PalindromeForm();
            palindromeForm.ShowDialog();
        }

        private void exerciceRefButton_Click(object sender, EventArgs e)
        {
            ExerciceRefForm exerciceRefForm = new ExerciceRefForm();
            exerciceRefForm.ShowDialog();
        }

        private void exercicesSwitchButton_Click(object sender, EventArgs e)
        {
            ExercicesSwitchForm exercicesSwitchForm = new ExercicesSwitchForm();
            exercicesSwitchForm.ShowDialog();
        }

        private void afficherSalutButton_Click(object sender, EventArgs e)
        {
            AfficherSalutForm afficherSalutForm = new AfficherSalutForm();
            afficherSalutForm.ShowDialog();
        }

        private void affciherNombresButton_Click(object sender, EventArgs e)
        {
            AfficherNombresForm afficherNombresForm = new AfficherNombresForm();
            afficherNombresForm.ShowDialog();
        }

        private void fizzBuzzButton_Click(object sender, EventArgs e)
        {
            FizzBuzzForm fizzBuzzForm = new FizzBuzzForm();
            fizzBuzzForm.ShowDialog();
        }

        private void classiqueButton_Click(object sender, EventArgs e)
        {
            ClassiqueForm classiqueForm = new ClassiqueForm();
            classiqueForm.ShowDialog();
        }

        private void graphiqueButton_Click(object sender, EventArgs e)
        {
            GraphiqueForm graphiqueForm = new GraphiqueForm();
            graphiqueForm.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            ClientSize = new Size(290, 200); // Change la taille du Form pour s'assurer qu'il entre dans l'écran
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
    }
}

namespace a25_intro_exemples.cours14
{
    partial class GraphiqueForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            voidGroupBox = new GroupBox();
            creerPictureBoxButton = new Button();
            changerCouleurButton = new Button();
            resultatGroupBox = new GroupBox();
            donnerCouleurButton = new Button();
            voidGroupBox.SuspendLayout();
            resultatGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // voidGroupBox
            // 
            voidGroupBox.Controls.Add(creerPictureBoxButton);
            voidGroupBox.Controls.Add(changerCouleurButton);
            voidGroupBox.Location = new Point(12, 12);
            voidGroupBox.Name = "voidGroupBox";
            voidGroupBox.Size = new Size(300, 150);
            voidGroupBox.TabIndex = 0;
            voidGroupBox.TabStop = false;
            voidGroupBox.Text = "Fonction graphique void";
            // 
            // creerPictureBoxButton
            // 
            creerPictureBoxButton.Location = new Point(12, 30);
            creerPictureBoxButton.Name = "creerPictureBoxButton";
            creerPictureBoxButton.Size = new Size(271, 34);
            creerPictureBoxButton.TabIndex = 0;
            creerPictureBoxButton.Text = "Créer un PictureBox";
            creerPictureBoxButton.UseVisualStyleBackColor = true;
            creerPictureBoxButton.Click += creerPictureBoxButton_Click;
            // 
            // changerCouleurButton
            // 
            changerCouleurButton.Location = new Point(12, 70);
            changerCouleurButton.Name = "changerCouleurButton";
            changerCouleurButton.Size = new Size(271, 65);
            changerCouleurButton.TabIndex = 1;
            changerCouleurButton.Text = "Changer la couleur du dernier PictureBox";
            changerCouleurButton.UseVisualStyleBackColor = true;
            changerCouleurButton.Click += changerCouleurButton_Click;
            // 
            // resultatGroupBox
            // 
            resultatGroupBox.Controls.Add(donnerCouleurButton);
            resultatGroupBox.Location = new Point(12, 168);
            resultatGroupBox.Name = "resultatGroupBox";
            resultatGroupBox.Size = new Size(300, 118);
            resultatGroupBox.TabIndex = 0;
            resultatGroupBox.TabStop = false;
            resultatGroupBox.Text = "Fonction retournant un résultat";
            // 
            // donnerCouleurButton
            // 
            donnerCouleurButton.Location = new Point(12, 30);
            donnerCouleurButton.Name = "donnerCouleurButton";
            donnerCouleurButton.Size = new Size(271, 73);
            donnerCouleurButton.TabIndex = 2;
            donnerCouleurButton.Text = "Afficher couleur du dernier PictureBox";
            donnerCouleurButton.UseVisualStyleBackColor = true;
            donnerCouleurButton.Click += donnerCouleurButton_Click;
            // 
            // GraphiqueForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 296);
            Controls.Add(resultatGroupBox);
            Controls.Add(voidGroupBox);
            Name = "GraphiqueForm";
            Text = "GraphiqueForm";
            voidGroupBox.ResumeLayout(false);
            resultatGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox voidGroupBox;
        private Button creerPictureBoxButton;
        private Button changerCouleurButton;
        private GroupBox resultatGroupBox;
        private Button donnerCouleurButton;
    }
}
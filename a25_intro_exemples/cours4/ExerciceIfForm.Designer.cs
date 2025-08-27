namespace a25_intro_exemples
{
    partial class ExerciceIfForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            reussiteGroupBox = new GroupBox();
            reussiteButton = new Button();
            noteLabel = new Label();
            noteTextBox = new TextBox();
            intervalleGroupBox = new GroupBox();
            intervalleButton = new Button();
            nombreLabel = new Label();
            nombreTextBox = new TextBox();
            qualifierAgeGroupBox = new GroupBox();
            qualifierAgeButton = new Button();
            ageLabel = new Label();
            ageTextBox = new TextBox();
            reussiteGroupBox.SuspendLayout();
            intervalleGroupBox.SuspendLayout();
            qualifierAgeGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // reussiteGroupBox
            // 
            reussiteGroupBox.Controls.Add(reussiteButton);
            reussiteGroupBox.Controls.Add(noteLabel);
            reussiteGroupBox.Controls.Add(noteTextBox);
            reussiteGroupBox.Location = new Point(12, 12);
            reussiteGroupBox.Name = "reussiteGroupBox";
            reussiteGroupBox.Size = new Size(250, 89);
            reussiteGroupBox.TabIndex = 0;
            reussiteGroupBox.TabStop = false;
            reussiteGroupBox.Text = "Exercice : Réussite";
            // 
            // reussiteButton
            // 
            reussiteButton.Location = new Point(6, 53);
            reussiteButton.Name = "reussiteButton";
            reussiteButton.Size = new Size(238, 29);
            reussiteButton.TabIndex = 3;
            reussiteButton.Text = "Réussite?";
            reussiteButton.UseVisualStyleBackColor = true;
            reussiteButton.Click += reussiteButton_Click;
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Location = new Point(6, 23);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new Size(95, 20);
            noteLabel.TabIndex = 1;
            noteLabel.Text = "Note (sur 20)";
            // 
            // noteTextBox
            // 
            noteTextBox.Location = new Point(119, 20);
            noteTextBox.Name = "noteTextBox";
            noteTextBox.Size = new Size(125, 27);
            noteTextBox.TabIndex = 2;
            // 
            // intervalleGroupBox
            // 
            intervalleGroupBox.Controls.Add(intervalleButton);
            intervalleGroupBox.Controls.Add(nombreLabel);
            intervalleGroupBox.Controls.Add(nombreTextBox);
            intervalleGroupBox.Location = new Point(12, 107);
            intervalleGroupBox.Name = "intervalleGroupBox";
            intervalleGroupBox.Size = new Size(250, 89);
            intervalleGroupBox.TabIndex = 4;
            intervalleGroupBox.TabStop = false;
            intervalleGroupBox.Text = "Exercice : Intervalle";
            // 
            // intervalleButton
            // 
            intervalleButton.Location = new Point(6, 53);
            intervalleButton.Name = "intervalleButton";
            intervalleButton.Size = new Size(238, 29);
            intervalleButton.TabIndex = 3;
            intervalleButton.Text = "Respecte l'intervalle";
            intervalleButton.UseVisualStyleBackColor = true;
            intervalleButton.Click += intervalleButton_Click;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(6, 23);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(64, 20);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre";
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(119, 20);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(125, 27);
            nombreTextBox.TabIndex = 2;
            // 
            // qualifierAgeGroupBox
            // 
            qualifierAgeGroupBox.Controls.Add(qualifierAgeButton);
            qualifierAgeGroupBox.Controls.Add(ageLabel);
            qualifierAgeGroupBox.Controls.Add(ageTextBox);
            qualifierAgeGroupBox.Location = new Point(12, 202);
            qualifierAgeGroupBox.Name = "qualifierAgeGroupBox";
            qualifierAgeGroupBox.Size = new Size(250, 89);
            qualifierAgeGroupBox.TabIndex = 4;
            qualifierAgeGroupBox.TabStop = false;
            qualifierAgeGroupBox.Text = "Exercice : Qualifier âge";
            // 
            // qualifierAgeButton
            // 
            qualifierAgeButton.Location = new Point(6, 53);
            qualifierAgeButton.Name = "qualifierAgeButton";
            qualifierAgeButton.Size = new Size(238, 29);
            qualifierAgeButton.TabIndex = 3;
            qualifierAgeButton.Text = "Qualifier l'âge";
            qualifierAgeButton.UseVisualStyleBackColor = true;
            qualifierAgeButton.Click += qualifierAgeButton_Click;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new Point(6, 23);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(36, 20);
            ageLabel.TabIndex = 1;
            ageLabel.Text = "Âge";
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(119, 20);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(125, 27);
            ageTextBox.TabIndex = 2;
            // 
            // ExerciceIfForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 303);
            Controls.Add(qualifierAgeGroupBox);
            Controls.Add(intervalleGroupBox);
            Controls.Add(reussiteGroupBox);
            Name = "ExerciceIfForm";
            Text = "Exercice sur l'alternative";
            reussiteGroupBox.ResumeLayout(false);
            reussiteGroupBox.PerformLayout();
            intervalleGroupBox.ResumeLayout(false);
            intervalleGroupBox.PerformLayout();
            qualifierAgeGroupBox.ResumeLayout(false);
            qualifierAgeGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox reussiteGroupBox;
        private Button reussiteButton;
        private Label noteLabel;
        private TextBox noteTextBox;
        private GroupBox intervalleGroupBox;
        private Button intervalleButton;
        private Label nombreLabel;
        private TextBox nombreTextBox;
        private GroupBox qualifierAgeGroupBox;
        private Button qualifierAgeButton;
        private Label ageLabel;
        private TextBox ageTextBox;
    }
}
namespace a25_intro_exemples.cours5
{
    partial class ExerciceFonctionForm
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
            rayonLabel = new Label();
            rayonTextBox = new TextBox();
            nombreTextBox = new TextBox();
            nombreLabel = new Label();
            aireButton = new Button();
            circonferenceButton = new Button();
            carreButton = new Button();
            SuspendLayout();
            // 
            // rayonLabel
            // 
            rayonLabel.AutoSize = true;
            rayonLabel.Location = new Point(12, 9);
            rayonLabel.Name = "rayonLabel";
            rayonLabel.Size = new Size(50, 20);
            rayonLabel.TabIndex = 0;
            rayonLabel.Text = "Rayon";
            // 
            // rayonTextBox
            // 
            rayonTextBox.Location = new Point(82, 6);
            rayonTextBox.Name = "rayonTextBox";
            rayonTextBox.Size = new Size(125, 27);
            rayonTextBox.TabIndex = 1;
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(82, 115);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(125, 27);
            nombreTextBox.TabIndex = 2;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(12, 118);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(64, 20);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre";
            // 
            // aireButton
            // 
            aireButton.Location = new Point(12, 39);
            aireButton.Name = "aireButton";
            aireButton.Size = new Size(195, 29);
            aireButton.TabIndex = 4;
            aireButton.Text = "Aire";
            aireButton.UseVisualStyleBackColor = true;
            aireButton.Click += aireButton_Click;
            // 
            // circonferenceButton
            // 
            circonferenceButton.Location = new Point(12, 74);
            circonferenceButton.Name = "circonferenceButton";
            circonferenceButton.Size = new Size(195, 29);
            circonferenceButton.TabIndex = 5;
            circonferenceButton.Text = "Circonférence";
            circonferenceButton.UseVisualStyleBackColor = true;
            circonferenceButton.Click += circonferenceButton_Click;
            // 
            // carreButton
            // 
            carreButton.Location = new Point(12, 148);
            carreButton.Name = "carreButton";
            carreButton.Size = new Size(195, 29);
            carreButton.TabIndex = 6;
            carreButton.Text = "Carré";
            carreButton.UseVisualStyleBackColor = true;
            carreButton.Click += carreButton_Click;
            // 
            // ExerciceFonction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(219, 187);
            Controls.Add(carreButton);
            Controls.Add(circonferenceButton);
            Controls.Add(aireButton);
            Controls.Add(nombreLabel);
            Controls.Add(nombreTextBox);
            Controls.Add(rayonTextBox);
            Controls.Add(rayonLabel);
            Name = "ExerciceFonction";
            Text = "ExerciceFonction";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label rayonLabel;
        private TextBox rayonTextBox;
        private TextBox nombreTextBox;
        private Label nombreLabel;
        private Button aireButton;
        private Button circonferenceButton;
        private Button carreButton;
    }
}
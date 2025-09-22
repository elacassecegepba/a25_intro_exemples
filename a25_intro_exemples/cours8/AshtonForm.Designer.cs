namespace a25_intro_exemples.cours8
{
    partial class AshtonForm
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
            fahrenheitLabel = new Label();
            montantLabel = new Label();
            montantRabaisLabel = new Label();
            pourcentageRabaisLabel = new Label();
            equivalentCelciusLabel = new Label();
            montantTotalLabel = new Label();
            calculerRabaisButton = new Button();
            montantTotalTextBox = new TextBox();
            montantRabaisTextBox = new TextBox();
            pourcentageRabaisTextBox = new TextBox();
            celciusTextBox = new TextBox();
            fahrenheitTextBox = new TextBox();
            montantAchatTextBox = new TextBox();
            SuspendLayout();
            // 
            // fahrenheitLabel
            // 
            fahrenheitLabel.AutoSize = true;
            fahrenheitLabel.Location = new Point(12, 9);
            fahrenheitLabel.Name = "fahrenheitLabel";
            fahrenheitLabel.Size = new Size(77, 20);
            fahrenheitLabel.TabIndex = 0;
            fahrenheitLabel.Text = "Fahrenheit";
            // 
            // montantLabel
            // 
            montantLabel.AutoSize = true;
            montantLabel.Location = new Point(12, 46);
            montantLabel.Name = "montantLabel";
            montantLabel.Size = new Size(65, 20);
            montantLabel.TabIndex = 1;
            montantLabel.Text = "Montant";
            // 
            // montantRabaisLabel
            // 
            montantRabaisLabel.AutoSize = true;
            montantRabaisLabel.Location = new Point(12, 180);
            montantRabaisLabel.Name = "montantRabaisLabel";
            montantRabaisLabel.Size = new Size(109, 20);
            montantRabaisLabel.TabIndex = 2;
            montantRabaisLabel.Text = "Montant rabais";
            // 
            // pourcentageRabaisLabel
            // 
            pourcentageRabaisLabel.AutoSize = true;
            pourcentageRabaisLabel.Location = new Point(12, 147);
            pourcentageRabaisLabel.Name = "pourcentageRabaisLabel";
            pourcentageRabaisLabel.Size = new Size(156, 20);
            pourcentageRabaisLabel.TabIndex = 3;
            pourcentageRabaisLabel.Text = "Pourcentage de rabais";
            // 
            // equivalentCelciusLabel
            // 
            equivalentCelciusLabel.AutoSize = true;
            equivalentCelciusLabel.Location = new Point(12, 114);
            equivalentCelciusLabel.Name = "equivalentCelciusLabel";
            equivalentCelciusLabel.Size = new Size(148, 20);
            equivalentCelciusLabel.TabIndex = 4;
            equivalentCelciusLabel.Text = "Équivalent en Celcius";
            // 
            // montantTotalLabel
            // 
            montantTotalLabel.AutoSize = true;
            montantTotalLabel.Location = new Point(12, 213);
            montantTotalLabel.Name = "montantTotalLabel";
            montantTotalLabel.Size = new Size(100, 20);
            montantTotalLabel.TabIndex = 5;
            montantTotalLabel.Text = "Montant total";
            // 
            // calculerRabaisButton
            // 
            calculerRabaisButton.Location = new Point(12, 76);
            calculerRabaisButton.Name = "calculerRabaisButton";
            calculerRabaisButton.Size = new Size(287, 29);
            calculerRabaisButton.TabIndex = 6;
            calculerRabaisButton.Text = "Calculer rabais";
            calculerRabaisButton.UseVisualStyleBackColor = true;
            calculerRabaisButton.Click += calculerRabaisButton_Click;
            // 
            // montantTotalTextBox
            // 
            montantTotalTextBox.Enabled = false;
            montantTotalTextBox.Location = new Point(174, 210);
            montantTotalTextBox.Name = "montantTotalTextBox";
            montantTotalTextBox.Size = new Size(125, 27);
            montantTotalTextBox.TabIndex = 7;
            // 
            // montantRabaisTextBox
            // 
            montantRabaisTextBox.Enabled = false;
            montantRabaisTextBox.Location = new Point(174, 177);
            montantRabaisTextBox.Name = "montantRabaisTextBox";
            montantRabaisTextBox.Size = new Size(125, 27);
            montantRabaisTextBox.TabIndex = 8;
            // 
            // pourcentageRabaisTextBox
            // 
            pourcentageRabaisTextBox.Enabled = false;
            pourcentageRabaisTextBox.Location = new Point(174, 144);
            pourcentageRabaisTextBox.Name = "pourcentageRabaisTextBox";
            pourcentageRabaisTextBox.Size = new Size(125, 27);
            pourcentageRabaisTextBox.TabIndex = 9;
            // 
            // celciusTextBox
            // 
            celciusTextBox.Enabled = false;
            celciusTextBox.Location = new Point(174, 111);
            celciusTextBox.Name = "celciusTextBox";
            celciusTextBox.Size = new Size(125, 27);
            celciusTextBox.TabIndex = 10;
            // 
            // fahrenheitTextBox
            // 
            fahrenheitTextBox.Location = new Point(174, 6);
            fahrenheitTextBox.Name = "fahrenheitTextBox";
            fahrenheitTextBox.Size = new Size(125, 27);
            fahrenheitTextBox.TabIndex = 11;
            fahrenheitTextBox.Text = "-15";
            fahrenheitTextBox.TextChanged += fahrenheitTextBox_TextChanged;
            // 
            // montantAchatTextBox
            // 
            montantAchatTextBox.Location = new Point(174, 43);
            montantAchatTextBox.Name = "montantAchatTextBox";
            montantAchatTextBox.Size = new Size(125, 27);
            montantAchatTextBox.TabIndex = 12;
            montantAchatTextBox.Text = "10,00";
            montantAchatTextBox.TextChanged += montantAchatTextBox_TextChanged;
            // 
            // AshtonForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 250);
            Controls.Add(montantAchatTextBox);
            Controls.Add(fahrenheitTextBox);
            Controls.Add(celciusTextBox);
            Controls.Add(pourcentageRabaisTextBox);
            Controls.Add(montantRabaisTextBox);
            Controls.Add(montantTotalTextBox);
            Controls.Add(calculerRabaisButton);
            Controls.Add(montantTotalLabel);
            Controls.Add(equivalentCelciusLabel);
            Controls.Add(pourcentageRabaisLabel);
            Controls.Add(montantRabaisLabel);
            Controls.Add(montantLabel);
            Controls.Add(fahrenheitLabel);
            Name = "AshtonForm";
            Text = "Ashton";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fahrenheitLabel;
        private Label montantLabel;
        private Label montantRabaisLabel;
        private Label pourcentageRabaisLabel;
        private Label equivalentCelciusLabel;
        private Label montantTotalLabel;
        private Button calculerRabaisButton;
        private TextBox montantTotalTextBox;
        private TextBox montantRabaisTextBox;
        private TextBox pourcentageRabaisTextBox;
        private TextBox celciusTextBox;
        private TextBox fahrenheitTextBox;
        private TextBox montantAchatTextBox;
    }
}
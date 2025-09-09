namespace a25_intro_exemples.cours6
{
    partial class HasardFormPartie1
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
            nombre1TextBox = new TextBox();
            nombre2TextBox = new TextBox();
            reponseTextBox = new TextBox();
            egalLabel = new Label();
            plusLabel = new Label();
            verifierReponseButton = new Button();
            SuspendLayout();
            // 
            // nombre1TextBox
            // 
            nombre1TextBox.Location = new Point(12, 12);
            nombre1TextBox.Name = "nombre1TextBox";
            nombre1TextBox.Size = new Size(100, 23);
            nombre1TextBox.TabIndex = 0;
            // 
            // nombre2TextBox
            // 
            nombre2TextBox.Location = new Point(139, 12);
            nombre2TextBox.Name = "nombre2TextBox";
            nombre2TextBox.Size = new Size(100, 23);
            nombre2TextBox.TabIndex = 1;
            // 
            // reponseTextBox
            // 
            reponseTextBox.Location = new Point(266, 12);
            reponseTextBox.Name = "reponseTextBox";
            reponseTextBox.Size = new Size(100, 23);
            reponseTextBox.TabIndex = 2;
            // 
            // egalLabel
            // 
            egalLabel.AutoSize = true;
            egalLabel.Location = new Point(245, 15);
            egalLabel.Name = "egalLabel";
            egalLabel.Size = new Size(15, 15);
            egalLabel.TabIndex = 3;
            egalLabel.Text = "=";
            // 
            // plusLabel
            // 
            plusLabel.AutoSize = true;
            plusLabel.Location = new Point(118, 15);
            plusLabel.Name = "plusLabel";
            plusLabel.Size = new Size(15, 15);
            plusLabel.TabIndex = 4;
            plusLabel.Text = "+";
            // 
            // verifierReponseButton
            // 
            verifierReponseButton.Location = new Point(12, 41);
            verifierReponseButton.Name = "verifierReponseButton";
            verifierReponseButton.Size = new Size(352, 23);
            verifierReponseButton.TabIndex = 5;
            verifierReponseButton.Text = "Vérifier réponse";
            verifierReponseButton.UseVisualStyleBackColor = true;
            verifierReponseButton.Click += verifierReponseButton_Click;
            // 
            // HasardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 71);
            Controls.Add(verifierReponseButton);
            Controls.Add(plusLabel);
            Controls.Add(egalLabel);
            Controls.Add(reponseTextBox);
            Controls.Add(nombre2TextBox);
            Controls.Add(nombre1TextBox);
            Name = "HasardForm";
            Text = "Additionner les 2 nombres";
            Load += HasardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nombre1TextBox;
        private TextBox nombre2TextBox;
        private TextBox reponseTextBox;
        private Label egalLabel;
        private Label plusLabel;
        private Button verifierReponseButton;
    }
}
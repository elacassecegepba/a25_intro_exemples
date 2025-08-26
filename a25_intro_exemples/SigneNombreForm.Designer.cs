namespace a25_intro_exemples
{
    partial class SigneNombreForm
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
            afficherSigneButton = new Button();
            nombreTextBox = new TextBox();
            SuspendLayout();
            // 
            // afficherSigneButton
            // 
            afficherSigneButton.Location = new Point(143, 12);
            afficherSigneButton.Name = "afficherSigneButton";
            afficherSigneButton.Size = new Size(123, 29);
            afficherSigneButton.TabIndex = 0;
            afficherSigneButton.Text = "Afficher signe";
            afficherSigneButton.UseVisualStyleBackColor = true;
            afficherSigneButton.Click += afficherSigneButton_Click;
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(12, 12);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.PlaceholderText = "Nombre";
            nombreTextBox.Size = new Size(125, 27);
            nombreTextBox.TabIndex = 1;
            // 
            // SigneNombreForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 50);
            Controls.Add(nombreTextBox);
            Controls.Add(afficherSigneButton);
            Name = "SigneNombreForm";
            Text = "SigneNombre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button afficherSigneButton;
        private TextBox nombreTextBox;
    }
}
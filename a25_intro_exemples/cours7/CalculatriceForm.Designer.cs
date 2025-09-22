namespace a25_intro_exemples.cours7
{
    partial class CalculatriceForm
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
            resultatLabel = new Label();
            effectuerCalculButton = new Button();
            operateurTextBox = new TextBox();
            nombre1TextBox = new TextBox();
            nombre2TextBox = new TextBox();
            SuspendLayout();
            // 
            // resultatLabel
            // 
            resultatLabel.AutoSize = true;
            resultatLabel.Location = new Point(448, 15);
            resultatLabel.Name = "resultatLabel";
            resultatLabel.Size = new Size(58, 20);
            resultatLabel.TabIndex = 0;
            resultatLabel.Text = "résultat";
            // 
            // effectuerCalculButton
            // 
            effectuerCalculButton.Location = new Point(405, 11);
            effectuerCalculButton.Name = "effectuerCalculButton";
            effectuerCalculButton.Size = new Size(37, 29);
            effectuerCalculButton.TabIndex = 1;
            effectuerCalculButton.Text = "=";
            effectuerCalculButton.UseVisualStyleBackColor = true;
            effectuerCalculButton.Click += effectuerCalculButton_Click;
            // 
            // operateurTextBox
            // 
            operateurTextBox.Location = new Point(143, 12);
            operateurTextBox.Name = "operateurTextBox";
            operateurTextBox.PlaceholderText = "+, -, * ou /";
            operateurTextBox.Size = new Size(125, 27);
            operateurTextBox.TabIndex = 2;
            operateurTextBox.TextAlign = HorizontalAlignment.Center;
            operateurTextBox.TextChanged += operateurTextBox_TextChanged;
            // 
            // nombre1TextBox
            // 
            nombre1TextBox.Location = new Point(12, 12);
            nombre1TextBox.Name = "nombre1TextBox";
            nombre1TextBox.PlaceholderText = "0,42";
            nombre1TextBox.Size = new Size(125, 27);
            nombre1TextBox.TabIndex = 3;
            nombre1TextBox.TextAlign = HorizontalAlignment.Center;
            nombre1TextBox.TextChanged += nombre1TextBox_TextChanged;
            // 
            // nombre2TextBox
            // 
            nombre2TextBox.Location = new Point(274, 12);
            nombre2TextBox.Name = "nombre2TextBox";
            nombre2TextBox.PlaceholderText = "42";
            nombre2TextBox.Size = new Size(125, 27);
            nombre2TextBox.TabIndex = 4;
            nombre2TextBox.TextAlign = HorizontalAlignment.Center;
            nombre2TextBox.TextChanged += nombre2TextBox_TextChanged;
            // 
            // CalculatriceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 51);
            Controls.Add(nombre2TextBox);
            Controls.Add(nombre1TextBox);
            Controls.Add(operateurTextBox);
            Controls.Add(effectuerCalculButton);
            Controls.Add(resultatLabel);
            Name = "CalculatriceForm";
            Text = "Calculatrice";
            Load += CalculatriceForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label resultatLabel;
        private Button effectuerCalculButton;
        private TextBox operateurTextBox;
        private TextBox nombre1TextBox;
        private TextBox nombre2TextBox;
    }
}
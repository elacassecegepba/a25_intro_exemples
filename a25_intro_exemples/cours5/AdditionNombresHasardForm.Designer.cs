namespace a25_intro_exemples.cours5
{
    partial class AdditionNombresHasardForm
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
            plusLabel = new Label();
            nombre2TextBox = new TextBox();
            reponseTextBox = new TextBox();
            egalLabel = new Label();
            verifierReponseButton = new Button();
            configurationTableMaximumGroupBox = new GroupBox();
            tableMaximumNumericUpDown = new NumericUpDown();
            tableMaximumLabel = new Label();
            configurationTableMaximumGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableMaximumNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // nombre1TextBox
            // 
            nombre1TextBox.Location = new Point(15, 15);
            nombre1TextBox.Margin = new Padding(4);
            nombre1TextBox.Name = "nombre1TextBox";
            nombre1TextBox.Size = new Size(155, 31);
            nombre1TextBox.TabIndex = 0;
            // 
            // plusLabel
            // 
            plusLabel.AutoSize = true;
            plusLabel.Location = new Point(179, 19);
            plusLabel.Margin = new Padding(4, 0, 4, 0);
            plusLabel.Name = "plusLabel";
            plusLabel.Size = new Size(24, 25);
            plusLabel.TabIndex = 1;
            plusLabel.Text = "+";
            // 
            // nombre2TextBox
            // 
            nombre2TextBox.Location = new Point(210, 15);
            nombre2TextBox.Margin = new Padding(4);
            nombre2TextBox.Name = "nombre2TextBox";
            nombre2TextBox.Size = new Size(155, 31);
            nombre2TextBox.TabIndex = 2;
            // 
            // reponseTextBox
            // 
            reponseTextBox.Location = new Point(405, 15);
            reponseTextBox.Margin = new Padding(4);
            reponseTextBox.Name = "reponseTextBox";
            reponseTextBox.Size = new Size(155, 31);
            reponseTextBox.TabIndex = 3;
            // 
            // egalLabel
            // 
            egalLabel.AutoSize = true;
            egalLabel.Location = new Point(374, 19);
            egalLabel.Margin = new Padding(4, 0, 4, 0);
            egalLabel.Name = "egalLabel";
            egalLabel.Size = new Size(24, 25);
            egalLabel.TabIndex = 4;
            egalLabel.Text = "=";
            // 
            // verifierReponseButton
            // 
            verifierReponseButton.Location = new Point(15, 56);
            verifierReponseButton.Margin = new Padding(4);
            verifierReponseButton.Name = "verifierReponseButton";
            verifierReponseButton.Size = new Size(546, 36);
            verifierReponseButton.TabIndex = 5;
            verifierReponseButton.Text = "Vérifier la réponse";
            verifierReponseButton.UseVisualStyleBackColor = true;
            verifierReponseButton.Click += verifierReponseButton_Click;
            // 
            // configurationTableMaximumGroupBox
            // 
            configurationTableMaximumGroupBox.Controls.Add(tableMaximumNumericUpDown);
            configurationTableMaximumGroupBox.Controls.Add(tableMaximumLabel);
            configurationTableMaximumGroupBox.Location = new Point(15, 99);
            configurationTableMaximumGroupBox.Name = "configurationTableMaximumGroupBox";
            configurationTableMaximumGroupBox.Size = new Size(545, 100);
            configurationTableMaximumGroupBox.TabIndex = 6;
            configurationTableMaximumGroupBox.TabStop = false;
            configurationTableMaximumGroupBox.Text = "Configuration de table maximum";
            // 
            // tableMaximumNumericUpDown
            // 
            tableMaximumNumericUpDown.AllowDrop = true;
            tableMaximumNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableMaximumNumericUpDown.Location = new Point(251, 44);
            tableMaximumNumericUpDown.Name = "tableMaximumNumericUpDown";
            tableMaximumNumericUpDown.Size = new Size(180, 31);
            tableMaximumNumericUpDown.TabIndex = 1;
            tableMaximumNumericUpDown.ValueChanged += tableMaximumNumericUpDown_ValueChanged;
            // 
            // tableMaximumLabel
            // 
            tableMaximumLabel.AllowDrop = true;
            tableMaximumLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableMaximumLabel.AutoSize = true;
            tableMaximumLabel.Location = new Point(114, 46);
            tableMaximumLabel.Name = "tableMaximumLabel";
            tableMaximumLabel.Size = new Size(136, 25);
            tableMaximumLabel.TabIndex = 0;
            tableMaximumLabel.Text = "Table maximum";
            // 
            // AdditionNombresHasardForm
            // 
            AcceptButton = verifierReponseButton;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 211);
            Controls.Add(configurationTableMaximumGroupBox);
            Controls.Add(verifierReponseButton);
            Controls.Add(egalLabel);
            Controls.Add(reponseTextBox);
            Controls.Add(nombre2TextBox);
            Controls.Add(plusLabel);
            Controls.Add(nombre1TextBox);
            Margin = new Padding(4);
            Name = "AdditionNombresHasardForm";
            Text = "Additionner les 2 nombres";
            Load += AdditionNombresHasardForm_Load;
            configurationTableMaximumGroupBox.ResumeLayout(false);
            configurationTableMaximumGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tableMaximumNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nombre1TextBox;
        private Label plusLabel;
        private TextBox nombre2TextBox;
        private TextBox reponseTextBox;
        private Label egalLabel;
        private Button verifierReponseButton;
        private GroupBox configurationTableMaximumGroupBox;
        private NumericUpDown tableMaximumNumericUpDown;
        private Label tableMaximumLabel;
    }
}
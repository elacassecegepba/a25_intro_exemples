namespace a25_intro_exemples
{
    partial class PairForm
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
            nombreTextBox = new TextBox();
            nombreLabel = new Label();
            estLabel = new Label();
            affichageLabelButton = new Button();
            affichageMessageButton = new Button();
            reponseLabel = new Label();
            SuspendLayout();
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(98, 6);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(125, 27);
            nombreTextBox.TabIndex = 0;
            nombreTextBox.Text = "42";
            nombreTextBox.TextAlign = HorizontalAlignment.Center;
            nombreTextBox.TextChanged += nombreTextBox_TextChanged;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(12, 9);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(80, 20);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Le nombre";
            // 
            // estLabel
            // 
            estLabel.AutoSize = true;
            estLabel.Location = new Point(229, 9);
            estLabel.Name = "estLabel";
            estLabel.Size = new Size(28, 20);
            estLabel.TabIndex = 2;
            estLabel.Text = "est";
            // 
            // affichageLabelButton
            // 
            affichageLabelButton.Location = new Point(12, 39);
            affichageLabelButton.Name = "affichageLabelButton";
            affichageLabelButton.Size = new Size(313, 29);
            affichageLabelButton.TabIndex = 3;
            affichageLabelButton.Text = "Nombre pair? (label)";
            affichageLabelButton.UseVisualStyleBackColor = true;
            affichageLabelButton.Click += affichageLabelButton_Click;
            // 
            // affichageMessageButton
            // 
            affichageMessageButton.Location = new Point(12, 74);
            affichageMessageButton.Name = "affichageMessageButton";
            affichageMessageButton.Size = new Size(313, 29);
            affichageMessageButton.TabIndex = 4;
            affichageMessageButton.Text = "Nombre pair? (MessageBox)";
            affichageMessageButton.UseVisualStyleBackColor = true;
            affichageMessageButton.Click += affichageMessageButton_Click;
            // 
            // reponseLabel
            // 
            reponseLabel.AutoSize = true;
            reponseLabel.Location = new Point(263, 9);
            reponseLabel.Name = "reponseLabel";
            reponseLabel.Size = new Size(62, 20);
            reponseLabel.TabIndex = 5;
            reponseLabel.Text = "reponse";
            // 
            // PairForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 113);
            Controls.Add(reponseLabel);
            Controls.Add(affichageMessageButton);
            Controls.Add(affichageLabelButton);
            Controls.Add(estLabel);
            Controls.Add(nombreLabel);
            Controls.Add(nombreTextBox);
            Name = "PairForm";
            Text = "Pair ou impair";
            Load += PairForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nombreTextBox;
        private Label nombreLabel;
        private Label estLabel;
        private Button affichageLabelButton;
        private Button affichageMessageButton;
        private Label reponseLabel;
    }
}
namespace a25_intro_exemples.cours10
{
    partial class AfficherNombresForm
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
            afficherNombres1A10GroupBox = new GroupBox();
            executer1A10Button = new Button();
            afficherNombresXAYGroupBox = new GroupBox();
            executerXAYButton = new Button();
            aLabel = new Label();
            deLabel = new Label();
            deTextBox = new TextBox();
            aTextBox = new TextBox();
            affichageListBox = new ListBox();
            viderListBoxButton = new Button();
            afficherNombres1A10GroupBox.SuspendLayout();
            afficherNombresXAYGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // afficherNombres1A10GroupBox
            // 
            afficherNombres1A10GroupBox.Controls.Add(executer1A10Button);
            afficherNombres1A10GroupBox.Location = new Point(12, 12);
            afficherNombres1A10GroupBox.Name = "afficherNombres1A10GroupBox";
            afficherNombres1A10GroupBox.Size = new Size(321, 78);
            afficherNombres1A10GroupBox.TabIndex = 0;
            afficherNombres1A10GroupBox.TabStop = false;
            afficherNombres1A10GroupBox.Text = "Afficher nombres de 1 à 10";
            // 
            // executer1A10Button
            // 
            executer1A10Button.Location = new Point(6, 30);
            executer1A10Button.Name = "executer1A10Button";
            executer1A10Button.Size = new Size(306, 34);
            executer1A10Button.TabIndex = 1;
            executer1A10Button.Text = "Exécuter";
            executer1A10Button.UseVisualStyleBackColor = true;
            executer1A10Button.Click += executer1A10Button_Click;
            // 
            // afficherNombresXAYGroupBox
            // 
            afficherNombresXAYGroupBox.Controls.Add(executerXAYButton);
            afficherNombresXAYGroupBox.Controls.Add(aLabel);
            afficherNombresXAYGroupBox.Controls.Add(deLabel);
            afficherNombresXAYGroupBox.Controls.Add(deTextBox);
            afficherNombresXAYGroupBox.Controls.Add(aTextBox);
            afficherNombresXAYGroupBox.Location = new Point(12, 103);
            afficherNombresXAYGroupBox.Name = "afficherNombresXAYGroupBox";
            afficherNombresXAYGroupBox.Size = new Size(321, 139);
            afficherNombresXAYGroupBox.TabIndex = 1;
            afficherNombresXAYGroupBox.TabStop = false;
            afficherNombresXAYGroupBox.Text = "Afficher nombres de x à y";
            // 
            // executerXAYButton
            // 
            executerXAYButton.Location = new Point(6, 94);
            executerXAYButton.Name = "executerXAYButton";
            executerXAYButton.Size = new Size(306, 34);
            executerXAYButton.TabIndex = 0;
            executerXAYButton.Text = "Exécuter";
            executerXAYButton.UseVisualStyleBackColor = true;
            executerXAYButton.Click += executerXAYButton_Click;
            // 
            // aLabel
            // 
            aLabel.Location = new Point(162, 27);
            aLabel.Name = "aLabel";
            aLabel.Size = new Size(150, 27);
            aLabel.TabIndex = 5;
            aLabel.Text = "À (inclus)";
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // deLabel
            // 
            deLabel.Location = new Point(6, 27);
            deLabel.Name = "deLabel";
            deLabel.Size = new Size(150, 27);
            deLabel.TabIndex = 4;
            deLabel.Text = "De";
            deLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // deTextBox
            // 
            deTextBox.Location = new Point(6, 57);
            deTextBox.Name = "deTextBox";
            deTextBox.Size = new Size(150, 31);
            deTextBox.TabIndex = 3;
            deTextBox.Text = "1";
            deTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // aTextBox
            // 
            aTextBox.Location = new Point(162, 57);
            aTextBox.Name = "aTextBox";
            aTextBox.Size = new Size(150, 31);
            aTextBox.TabIndex = 2;
            aTextBox.Text = "10";
            aTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // affichageListBox
            // 
            affichageListBox.FormattingEnabled = true;
            affichageListBox.ItemHeight = 25;
            affichageListBox.Location = new Point(339, 12);
            affichageListBox.Name = "affichageListBox";
            affichageListBox.Size = new Size(180, 179);
            affichageListBox.TabIndex = 6;
            // 
            // viderListBoxButton
            // 
            viderListBoxButton.Location = new Point(339, 203);
            viderListBoxButton.Name = "viderListBoxButton";
            viderListBoxButton.Size = new Size(180, 34);
            viderListBoxButton.TabIndex = 7;
            viderListBoxButton.Text = "Vider";
            viderListBoxButton.UseVisualStyleBackColor = true;
            viderListBoxButton.Click += viderListBoxButton_Click;
            // 
            // AfficherNombresForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 249);
            Controls.Add(viderListBoxButton);
            Controls.Add(affichageListBox);
            Controls.Add(afficherNombresXAYGroupBox);
            Controls.Add(afficherNombres1A10GroupBox);
            Name = "AfficherNombresForm";
            Text = "Afficher nombres";
            afficherNombres1A10GroupBox.ResumeLayout(false);
            afficherNombresXAYGroupBox.ResumeLayout(false);
            afficherNombresXAYGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox afficherNombres1A10GroupBox;
        private Button executer1A10Button;
        private GroupBox afficherNombresXAYGroupBox;
        private Label deLabel;
        private TextBox deTextBox;
        private TextBox aTextBox;
        private Button executerXAYButton;
        private Label aLabel;
        private ListBox affichageListBox;
        private Button viderListBoxButton;
    }
}
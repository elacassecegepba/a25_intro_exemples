namespace a25_intro_exemples.cours14
{
    partial class ClassiqueForm
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
            puissanceButton = new Button();
            aireCercleButton = new Button();
            mettreEnOrdreButton = new Button();
            afficherNbr1AXButton = new Button();
            bonjourButton = new Button();
            voidGroupBox = new GroupBox();
            xTextBox = new TextBox();
            xLabel = new Label();
            resultatGroupBox = new GroupBox();
            exposantTextBox = new TextBox();
            rayonTextBox = new TextBox();
            baseTextBox = new TextBox();
            exposantLabel = new Label();
            rayonLabel = new Label();
            baseLabel = new Label();
            affichageListBox = new ListBox();
            voidGroupBox.SuspendLayout();
            resultatGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // puissanceButton
            // 
            puissanceButton.Location = new Point(6, 30);
            puissanceButton.Name = "puissanceButton";
            puissanceButton.Size = new Size(318, 34);
            puissanceButton.TabIndex = 0;
            puissanceButton.Text = "Puissance";
            puissanceButton.UseVisualStyleBackColor = true;
            puissanceButton.Click += puissanceButton_Click;
            // 
            // aireCercleButton
            // 
            aireCercleButton.Location = new Point(6, 147);
            aireCercleButton.Name = "aireCercleButton";
            aireCercleButton.Size = new Size(318, 34);
            aireCercleButton.TabIndex = 1;
            aireCercleButton.Text = "Aire d'un cercle";
            aireCercleButton.UseVisualStyleBackColor = true;
            aireCercleButton.Click += aireCercleButton_Click;
            // 
            // mettreEnOrdreButton
            // 
            mettreEnOrdreButton.Location = new Point(6, 147);
            mettreEnOrdreButton.Name = "mettreEnOrdreButton";
            mettreEnOrdreButton.Size = new Size(288, 34);
            mettreEnOrdreButton.TabIndex = 2;
            mettreEnOrdreButton.Text = "Mettre en ordre (pratique de ref)";
            mettreEnOrdreButton.UseVisualStyleBackColor = true;
            mettreEnOrdreButton.Click += mettreEnOrdreButton_Click;
            // 
            // afficherNbr1AXButton
            // 
            afficherNbr1AXButton.Location = new Point(6, 70);
            afficherNbr1AXButton.Name = "afficherNbr1AXButton";
            afficherNbr1AXButton.Size = new Size(288, 34);
            afficherNbr1AXButton.TabIndex = 3;
            afficherNbr1AXButton.Text = "Afficher les nombres de 1 à X";
            afficherNbr1AXButton.UseVisualStyleBackColor = true;
            afficherNbr1AXButton.Click += afficherNbr1AXButton_Click;
            // 
            // bonjourButton
            // 
            bonjourButton.Location = new Point(6, 30);
            bonjourButton.Name = "bonjourButton";
            bonjourButton.Size = new Size(288, 34);
            bonjourButton.TabIndex = 4;
            bonjourButton.Text = "Dire Bonjour";
            bonjourButton.UseVisualStyleBackColor = true;
            bonjourButton.Click += bonjourButton_Click;
            // 
            // voidGroupBox
            // 
            voidGroupBox.Controls.Add(xTextBox);
            voidGroupBox.Controls.Add(bonjourButton);
            voidGroupBox.Controls.Add(afficherNbr1AXButton);
            voidGroupBox.Controls.Add(xLabel);
            voidGroupBox.Controls.Add(mettreEnOrdreButton);
            voidGroupBox.Location = new Point(12, 12);
            voidGroupBox.Name = "voidGroupBox";
            voidGroupBox.Size = new Size(330, 229);
            voidGroupBox.TabIndex = 5;
            voidGroupBox.TabStop = false;
            voidGroupBox.Text = "Fonction simple void";
            // 
            // xTextBox
            // 
            xTextBox.Location = new Point(44, 110);
            xTextBox.Name = "xTextBox";
            xTextBox.Size = new Size(250, 31);
            xTextBox.TabIndex = 7;
            xTextBox.Text = "5";
            // 
            // xLabel
            // 
            xLabel.AutoSize = true;
            xLabel.Location = new Point(6, 112);
            xLabel.Name = "xLabel";
            xLabel.Size = new Size(23, 25);
            xLabel.TabIndex = 1;
            xLabel.Text = "X";
            // 
            // resultatGroupBox
            // 
            resultatGroupBox.Controls.Add(exposantTextBox);
            resultatGroupBox.Controls.Add(rayonTextBox);
            resultatGroupBox.Controls.Add(baseTextBox);
            resultatGroupBox.Controls.Add(exposantLabel);
            resultatGroupBox.Controls.Add(rayonLabel);
            resultatGroupBox.Controls.Add(baseLabel);
            resultatGroupBox.Controls.Add(puissanceButton);
            resultatGroupBox.Controls.Add(aireCercleButton);
            resultatGroupBox.Location = new Point(537, 12);
            resultatGroupBox.Name = "resultatGroupBox";
            resultatGroupBox.Size = new Size(330, 229);
            resultatGroupBox.TabIndex = 0;
            resultatGroupBox.TabStop = false;
            resultatGroupBox.Text = "Fonction simple retournant un résultat";
            // 
            // exposantTextBox
            // 
            exposantTextBox.Location = new Point(127, 104);
            exposantTextBox.Name = "exposantTextBox";
            exposantTextBox.Size = new Size(197, 31);
            exposantTextBox.TabIndex = 6;
            exposantTextBox.Text = "4";
            // 
            // rayonTextBox
            // 
            rayonTextBox.Location = new Point(127, 184);
            rayonTextBox.Name = "rayonTextBox";
            rayonTextBox.Size = new Size(197, 31);
            rayonTextBox.TabIndex = 5;
            rayonTextBox.Text = "5";
            // 
            // baseTextBox
            // 
            baseTextBox.Location = new Point(127, 67);
            baseTextBox.Name = "baseTextBox";
            baseTextBox.Size = new Size(197, 31);
            baseTextBox.TabIndex = 4;
            baseTextBox.Text = "2";
            // 
            // exposantLabel
            // 
            exposantLabel.AutoSize = true;
            exposantLabel.Location = new Point(6, 107);
            exposantLabel.Name = "exposantLabel";
            exposantLabel.Size = new Size(84, 25);
            exposantLabel.TabIndex = 2;
            exposantLabel.Text = "Exposant";
            // 
            // rayonLabel
            // 
            rayonLabel.AutoSize = true;
            rayonLabel.Location = new Point(6, 187);
            rayonLabel.Name = "rayonLabel";
            rayonLabel.Size = new Size(62, 25);
            rayonLabel.TabIndex = 0;
            rayonLabel.Text = "Rayon";
            // 
            // baseLabel
            // 
            baseLabel.AutoSize = true;
            baseLabel.Location = new Point(6, 70);
            baseLabel.Name = "baseLabel";
            baseLabel.Size = new Size(48, 25);
            baseLabel.TabIndex = 3;
            baseLabel.Text = "Base";
            // 
            // affichageListBox
            // 
            affichageListBox.FormattingEnabled = true;
            affichageListBox.ItemHeight = 25;
            affichageListBox.Location = new Point(351, 12);
            affichageListBox.Name = "affichageListBox";
            affichageListBox.Size = new Size(180, 229);
            affichageListBox.TabIndex = 8;
            // 
            // ClassiqueForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 254);
            Controls.Add(resultatGroupBox);
            Controls.Add(affichageListBox);
            Controls.Add(voidGroupBox);
            Name = "ClassiqueForm";
            Text = "ClassiqueForm";
            voidGroupBox.ResumeLayout(false);
            voidGroupBox.PerformLayout();
            resultatGroupBox.ResumeLayout(false);
            resultatGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button puissanceButton;
        private Button aireCercleButton;
        private Button mettreEnOrdreButton;
        private Button afficherNbr1AXButton;
        private Button bonjourButton;
        private GroupBox voidGroupBox;
        private TextBox xTextBox;
        private Label xLabel;
        private GroupBox resultatGroupBox;
        private TextBox exposantTextBox;
        private TextBox baseTextBox;
        private Label baseLabel;
        private Label exposantLabel;
        private Label rayonLabel;
        private TextBox rayonTextBox;
        private ListBox affichageListBox;
    }
}
namespace a25_intro_exemples
{
    partial class MenuForm
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
            cours4GroupBox = new GroupBox();
            exempleFonctionEstPairButton = new Button();
            exerciceIfSimpleButton = new Button();
            cours3GroupBox = new GroupBox();
            exemplePositifNegatifZeroButton = new Button();
            exempleMinutesEnSecondeButton = new Button();
            cours2GroupBox = new GroupBox();
            exerciceAddition2NombreButton = new Button();
            cours4GroupBox.SuspendLayout();
            cours3GroupBox.SuspendLayout();
            cours2GroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // cours4GroupBox
            // 
            cours4GroupBox.Controls.Add(exempleFonctionEstPairButton);
            cours4GroupBox.Controls.Add(exerciceIfSimpleButton);
            cours4GroupBox.Location = new Point(12, 179);
            cours4GroupBox.Name = "cours4GroupBox";
            cours4GroupBox.Size = new Size(250, 97);
            cours4GroupBox.TabIndex = 0;
            cours4GroupBox.TabStop = false;
            cours4GroupBox.Text = "Cours 4 - If et début fonction";
            // 
            // exempleFonctionEstPairButton
            // 
            exempleFonctionEstPairButton.Location = new Point(6, 26);
            exempleFonctionEstPairButton.Name = "exempleFonctionEstPairButton";
            exempleFonctionEstPairButton.Size = new Size(238, 29);
            exempleFonctionEstPairButton.TabIndex = 1;
            exempleFonctionEstPairButton.Text = "Exemple fonction EstPair";
            exempleFonctionEstPairButton.UseVisualStyleBackColor = true;
            exempleFonctionEstPairButton.Click += exempleFonctionEstPairButton_Click;
            // 
            // exerciceIfSimpleButton
            // 
            exerciceIfSimpleButton.Location = new Point(6, 61);
            exerciceIfSimpleButton.Name = "exerciceIfSimpleButton";
            exerciceIfSimpleButton.Size = new Size(238, 29);
            exerciceIfSimpleButton.TabIndex = 0;
            exerciceIfSimpleButton.Text = "Exercice if simple";
            exerciceIfSimpleButton.UseVisualStyleBackColor = true;
            exerciceIfSimpleButton.Click += exerciceIfSimpleButton_Click;
            // 
            // cours3GroupBox
            // 
            cours3GroupBox.Controls.Add(exemplePositifNegatifZeroButton);
            cours3GroupBox.Controls.Add(exempleMinutesEnSecondeButton);
            cours3GroupBox.Location = new Point(12, 79);
            cours3GroupBox.Name = "cours3GroupBox";
            cours3GroupBox.Size = new Size(250, 94);
            cours3GroupBox.TabIndex = 1;
            cours3GroupBox.TabStop = false;
            cours3GroupBox.Text = "Cours 3 - Début if";
            // 
            // exemplePositifNegatifZeroButton
            // 
            exemplePositifNegatifZeroButton.Location = new Point(6, 58);
            exemplePositifNegatifZeroButton.Name = "exemplePositifNegatifZeroButton";
            exemplePositifNegatifZeroButton.Size = new Size(241, 29);
            exemplePositifNegatifZeroButton.TabIndex = 1;
            exemplePositifNegatifZeroButton.Text = "Exemple positif, negatif ou zéro";
            exemplePositifNegatifZeroButton.UseVisualStyleBackColor = true;
            exemplePositifNegatifZeroButton.Click += exemplePositifNegatifZeroButton_Click;
            // 
            // exempleMinutesEnSecondeButton
            // 
            exempleMinutesEnSecondeButton.Location = new Point(3, 23);
            exempleMinutesEnSecondeButton.Name = "exempleMinutesEnSecondeButton";
            exempleMinutesEnSecondeButton.Size = new Size(241, 29);
            exempleMinutesEnSecondeButton.TabIndex = 0;
            exempleMinutesEnSecondeButton.Text = "Exemple minutes en secondes";
            exempleMinutesEnSecondeButton.UseVisualStyleBackColor = true;
            exempleMinutesEnSecondeButton.Click += exempleMinutesEnSecondeButton_Click;
            // 
            // cours2GroupBox
            // 
            cours2GroupBox.Controls.Add(exerciceAddition2NombreButton);
            cours2GroupBox.Location = new Point(12, 12);
            cours2GroupBox.Name = "cours2GroupBox";
            cours2GroupBox.Size = new Size(250, 61);
            cours2GroupBox.TabIndex = 2;
            cours2GroupBox.TabStop = false;
            cours2GroupBox.Text = "Cours 2 - Algorithme";
            // 
            // exerciceAddition2NombreButton
            // 
            exerciceAddition2NombreButton.Location = new Point(6, 26);
            exerciceAddition2NombreButton.Name = "exerciceAddition2NombreButton";
            exerciceAddition2NombreButton.Size = new Size(238, 29);
            exerciceAddition2NombreButton.TabIndex = 3;
            exerciceAddition2NombreButton.Text = "Exercice addition 2 nombres";
            exerciceAddition2NombreButton.UseVisualStyleBackColor = true;
            exerciceAddition2NombreButton.Click += exerciceAddition2NombreButton_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(272, 643);
            Controls.Add(cours2GroupBox);
            Controls.Add(cours3GroupBox);
            Controls.Add(cours4GroupBox);
            Name = "MenuForm";
            Text = "MenuForm";
            Load += MenuForm_Load;
            cours4GroupBox.ResumeLayout(false);
            cours3GroupBox.ResumeLayout(false);
            cours2GroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox cours4GroupBox;
        private Button exempleFonctionEstPairButton;
        private Button exerciceIfSimpleButton;
        private GroupBox cours3GroupBox;
        private Button exempleMinutesEnSecondeButton;
        private GroupBox cours2GroupBox;
        private Button exerciceAddition2NombreButton;
        private Button exemplePositifNegatifZeroButton;
    }
}
namespace a25_intro_exemples.cours10
{
    partial class AfficherSalutForm
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
            tantQueButton = new Button();
            repeterTantQueButton = new Button();
            pourButton = new Button();
            affichageListBox = new ListBox();
            viderButton = new Button();
            SuspendLayout();
            // 
            // tantQueButton
            // 
            tantQueButton.Location = new Point(12, 12);
            tantQueButton.Name = "tantQueButton";
            tantQueButton.Size = new Size(249, 34);
            tantQueButton.TabIndex = 0;
            tantQueButton.Text = "Tant que (while)";
            tantQueButton.UseVisualStyleBackColor = true;
            tantQueButton.Click += tantQueButton_Click;
            // 
            // repeterTantQueButton
            // 
            repeterTantQueButton.Location = new Point(12, 52);
            repeterTantQueButton.Name = "repeterTantQueButton";
            repeterTantQueButton.Size = new Size(249, 34);
            repeterTantQueButton.TabIndex = 1;
            repeterTantQueButton.Text = "Répéter tant que (do while)";
            repeterTantQueButton.UseVisualStyleBackColor = true;
            repeterTantQueButton.Click += repeterTantQueButton_Click;
            // 
            // pourButton
            // 
            pourButton.Location = new Point(12, 92);
            pourButton.Name = "pourButton";
            pourButton.Size = new Size(249, 34);
            pourButton.TabIndex = 2;
            pourButton.Text = "Pour (for)";
            pourButton.UseVisualStyleBackColor = true;
            pourButton.Click += pourButton_Click;
            // 
            // affichageListBox
            // 
            affichageListBox.FormattingEnabled = true;
            affichageListBox.ItemHeight = 25;
            affichageListBox.Location = new Point(267, 12);
            affichageListBox.Name = "affichageListBox";
            affichageListBox.Size = new Size(180, 229);
            affichageListBox.TabIndex = 3;
            // 
            // viderButton
            // 
            viderButton.Location = new Point(12, 207);
            viderButton.Name = "viderButton";
            viderButton.Size = new Size(249, 34);
            viderButton.TabIndex = 4;
            viderButton.Text = "Vider";
            viderButton.UseVisualStyleBackColor = true;
            viderButton.Click += viderButton_Click;
            // 
            // AfficherSalutForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 257);
            Controls.Add(viderButton);
            Controls.Add(affichageListBox);
            Controls.Add(pourButton);
            Controls.Add(repeterTantQueButton);
            Controls.Add(tantQueButton);
            Name = "AfficherSalutForm";
            Text = "AfficherSalutForm";
            ResumeLayout(false);
        }

        #endregion

        private Button tantQueButton;
        private Button repeterTantQueButton;
        private Button pourButton;
        private ListBox affichageListBox;
        private Button viderButton;
    }
}
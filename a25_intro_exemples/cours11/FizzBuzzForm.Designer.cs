namespace a25_intro_exemples.cours11
{
    partial class FizzBuzzForm
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
            fizzBuzzButton = new Button();
            nombreMaxTextBox = new TextBox();
            affichageListBox = new ListBox();
            SuspendLayout();
            // 
            // fizzBuzzButton
            // 
            fizzBuzzButton.Location = new Point(12, 49);
            fizzBuzzButton.Name = "fizzBuzzButton";
            fizzBuzzButton.Size = new Size(180, 34);
            fizzBuzzButton.TabIndex = 0;
            fizzBuzzButton.Text = "FizzBuzz";
            fizzBuzzButton.UseVisualStyleBackColor = true;
            fizzBuzzButton.Click += fizzBuzzButton_Click;
            // 
            // nombreMaxTextBox
            // 
            nombreMaxTextBox.Location = new Point(12, 12);
            nombreMaxTextBox.Name = "nombreMaxTextBox";
            nombreMaxTextBox.PlaceholderText = "Nombre max";
            nombreMaxTextBox.Size = new Size(180, 31);
            nombreMaxTextBox.TabIndex = 1;
            // 
            // affichageListBox
            // 
            affichageListBox.FormattingEnabled = true;
            affichageListBox.ItemHeight = 25;
            affichageListBox.Location = new Point(12, 89);
            affichageListBox.Name = "affichageListBox";
            affichageListBox.Size = new Size(180, 354);
            affichageListBox.TabIndex = 2;
            // 
            // FizzBuzzForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(205, 450);
            Controls.Add(affichageListBox);
            Controls.Add(nombreMaxTextBox);
            Controls.Add(fizzBuzzButton);
            Name = "FizzBuzzForm";
            Text = "FizzBuzz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button fizzBuzzButton;
        private TextBox nombreMaxTextBox;
        private ListBox affichageListBox;
    }
}
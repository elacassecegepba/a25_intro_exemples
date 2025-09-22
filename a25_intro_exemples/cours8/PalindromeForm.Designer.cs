namespace a25_intro_exemples.cours8
{
    partial class PalindromeForm
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
            texteLabel = new Label();
            texteTextBox = new TextBox();
            palindromeButton = new Button();
            SuspendLayout();
            // 
            // texteLabel
            // 
            texteLabel.AutoSize = true;
            texteLabel.Location = new Point(12, 15);
            texteLabel.Name = "texteLabel";
            texteLabel.Size = new Size(155, 20);
            texteLabel.TabIndex = 0;
            texteLabel.Text = "Un mot ou une phrase";
            // 
            // texteTextBox
            // 
            texteTextBox.Location = new Point(173, 12);
            texteTextBox.Name = "texteTextBox";
            texteTextBox.Size = new Size(615, 27);
            texteTextBox.TabIndex = 1;
            // 
            // palindromeButton
            // 
            palindromeButton.Location = new Point(12, 45);
            palindromeButton.Name = "palindromeButton";
            palindromeButton.Size = new Size(776, 29);
            palindromeButton.TabIndex = 2;
            palindromeButton.Text = "Palindrome?";
            palindromeButton.UseVisualStyleBackColor = true;
            palindromeButton.Click += palindromeButton_Click;
            // 
            // PalindromeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 88);
            Controls.Add(palindromeButton);
            Controls.Add(texteTextBox);
            Controls.Add(texteLabel);
            Name = "PalindromeForm";
            Text = "PalindromeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label texteLabel;
        private TextBox texteTextBox;
        private Button palindromeButton;
    }
}
namespace a25_intro_exemples
{
    partial class MinutesEnSecondesForm
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
            minutesTextBox = new TextBox();
            convertirButton = new Button();
            SuspendLayout();
            // 
            // minutesTextBox
            // 
            minutesTextBox.Location = new Point(12, 12);
            minutesTextBox.Name = "minutesTextBox";
            minutesTextBox.PlaceholderText = "Minutes";
            minutesTextBox.Size = new Size(125, 27);
            minutesTextBox.TabIndex = 0;
            // 
            // convertirButton
            // 
            convertirButton.Location = new Point(143, 10);
            convertirButton.Name = "convertirButton";
            convertirButton.Size = new Size(94, 29);
            convertirButton.TabIndex = 1;
            convertirButton.Text = "Convertir";
            convertirButton.UseVisualStyleBackColor = true;
            convertirButton.Click += convertirButton_Click;
            // 
            // MinutesEnSecondesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(246, 46);
            Controls.Add(convertirButton);
            Controls.Add(minutesTextBox);
            Name = "MinutesEnSecondesForm";
            Text = "Convertion Minutes en Secondes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox minutesTextBox;
        private Button convertirButton;
    }
}

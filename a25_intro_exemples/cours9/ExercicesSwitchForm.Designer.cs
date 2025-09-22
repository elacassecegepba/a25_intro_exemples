namespace a25_intro_exemples.cours9
{
    partial class ExercicesSwitchForm
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
            nombreLabel = new Label();
            nombreTextBox = new TextBox();
            affichageListBox = new ListBox();
            switchComplexeButton = new Button();
            switchButton = new Button();
            SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(12, 15);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(78, 25);
            nombreLabel.TabIndex = 0;
            nombreLabel.Text = "Nombre";
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(145, 12);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(150, 31);
            nombreTextBox.TabIndex = 1;
            // 
            // affichageListBox
            // 
            affichageListBox.FormattingEnabled = true;
            affichageListBox.ItemHeight = 25;
            affichageListBox.Location = new Point(12, 49);
            affichageListBox.Name = "affichageListBox";
            affichageListBox.Size = new Size(283, 204);
            affichageListBox.TabIndex = 2;
            // 
            // switchComplexeButton
            // 
            switchComplexeButton.Location = new Point(12, 299);
            switchComplexeButton.Name = "switchComplexeButton";
            switchComplexeButton.Size = new Size(283, 34);
            switchComplexeButton.TabIndex = 3;
            switchComplexeButton.Text = "Switch complexe";
            switchComplexeButton.UseVisualStyleBackColor = true;
            switchComplexeButton.Click += switchComplexeButton_Click;
            // 
            // switchButton
            // 
            switchButton.Location = new Point(12, 259);
            switchButton.Name = "switchButton";
            switchButton.Size = new Size(283, 34);
            switchButton.TabIndex = 4;
            switchButton.Text = "Switch";
            switchButton.UseVisualStyleBackColor = true;
            switchButton.Click += switchButton_Click;
            // 
            // SwitchForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 344);
            Controls.Add(switchButton);
            Controls.Add(switchComplexeButton);
            Controls.Add(affichageListBox);
            Controls.Add(nombreTextBox);
            Controls.Add(nombreLabel);
            Name = "SwitchForm";
            Text = "Switch";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nombreLabel;
        private TextBox nombreTextBox;
        private ListBox affichageListBox;
        private Button switchComplexeButton;
        private Button switchButton;
    }
}
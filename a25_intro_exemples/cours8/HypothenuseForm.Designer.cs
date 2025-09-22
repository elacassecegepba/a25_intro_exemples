namespace a25_intro_exemples.cours8
{
    partial class HypothenuseForm
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
            label1 = new Label();
            label2 = new Label();
            coteBTextBox = new TextBox();
            coteATextBox = new TextBox();
            hypothenuseButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Côté A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 42);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Côté B";
            // 
            // coteBTextBox
            // 
            coteBTextBox.Location = new Point(68, 39);
            coteBTextBox.Name = "coteBTextBox";
            coteBTextBox.Size = new Size(125, 27);
            coteBTextBox.TabIndex = 2;
            // 
            // coteATextBox
            // 
            coteATextBox.Location = new Point(68, 6);
            coteATextBox.Name = "coteATextBox";
            coteATextBox.Size = new Size(125, 27);
            coteATextBox.TabIndex = 3;
            // 
            // hypothenuseButton
            // 
            hypothenuseButton.Location = new Point(12, 72);
            hypothenuseButton.Name = "hypothenuseButton";
            hypothenuseButton.Size = new Size(181, 29);
            hypothenuseButton.TabIndex = 4;
            hypothenuseButton.Text = "Hypothénuse";
            hypothenuseButton.UseVisualStyleBackColor = true;
            hypothenuseButton.Click += hypothenuseButton_Click;
            // 
            // HypothenuseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(206, 112);
            Controls.Add(hypothenuseButton);
            Controls.Add(coteATextBox);
            Controls.Add(coteBTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HypothenuseForm";
            Text = "HypothenuseForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox coteBTextBox;
        private TextBox coteATextBox;
        private Button hypothenuseButton;
    }
}
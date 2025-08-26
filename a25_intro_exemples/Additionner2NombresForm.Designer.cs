namespace a25_intro_exemples
{
    partial class Additionner2NombresForm
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
            nombre1TextBox = new TextBox();
            nombre2TextBox = new TextBox();
            label1 = new Label();
            addtitionnerButton = new Button();
            resultatTextBox = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // nombre1TextBox
            // 
            nombre1TextBox.Location = new Point(12, 12);
            nombre1TextBox.Name = "nombre1TextBox";
            nombre1TextBox.Size = new Size(125, 27);
            nombre1TextBox.TabIndex = 0;
            // 
            // nombre2TextBox
            // 
            nombre2TextBox.Location = new Point(168, 12);
            nombre2TextBox.Name = "nombre2TextBox";
            nombre2TextBox.Size = new Size(125, 27);
            nombre2TextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 15);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 2;
            label1.Text = "+";
            // 
            // addtitionnerButton
            // 
            addtitionnerButton.Location = new Point(12, 45);
            addtitionnerButton.Name = "addtitionnerButton";
            addtitionnerButton.Size = new Size(436, 29);
            addtitionnerButton.TabIndex = 3;
            addtitionnerButton.Text = "Additionner";
            addtitionnerButton.UseVisualStyleBackColor = true;
            addtitionnerButton.Click += addtitionnerButton_Click;
            // 
            // resultatTextBox
            // 
            resultatTextBox.Location = new Point(324, 12);
            resultatTextBox.Name = "resultatTextBox";
            resultatTextBox.Size = new Size(125, 27);
            resultatTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 14);
            label2.Name = "label2";
            label2.Size = new Size(19, 20);
            label2.TabIndex = 5;
            label2.Text = "=";
            // 
            // Additionner2NombresForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 86);
            Controls.Add(label2);
            Controls.Add(resultatTextBox);
            Controls.Add(addtitionnerButton);
            Controls.Add(label1);
            Controls.Add(nombre2TextBox);
            Controls.Add(nombre1TextBox);
            Name = "Additionner2NombresForm";
            Text = "Addition de 2 nombres";
            Load += Additionner2NombresForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nombre1TextBox;
        private TextBox nombre2TextBox;
        private Label label1;
        private Button addtitionnerButton;
        private TextBox resultatTextBox;
        private Label label2;
    }
}
namespace _014___firstWindowsForm
{
    partial class Form1
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
            userNameLabel = new Label();
            userNameTextBox = new TextBox();
            passTextBox = new TextBox();
            passwordLabel = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(28, 39);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(96, 25);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = "User name";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(130, 36);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(237, 31);
            userNameTextBox.TabIndex = 1;
            // 
            // passTextBox
            // 
            passTextBox.Location = new Point(130, 94);
            passTextBox.Name = "passTextBox";
            passTextBox.Size = new Size(234, 31);
            passTextBox.TabIndex = 3;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(25, 97);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(87, 25);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password";
            // 
            // button1
            // 
            button1.Location = new Point(118, 158);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 226);
            Controls.Add(button1);
            Controls.Add(passTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(userNameTextBox);
            Controls.Add(userNameLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox passTextBox;
        private Label passwordLabel;
        private TextBox userNameTextBox;
        private Label userNameLabel;
        private Button button1;
    }
}

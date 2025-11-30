namespace _014___firstWindowsForm
{
    partial class LogIn
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
            button1 = new Button();
            passTextBox = new TextBox();
            passwordLabel = new Label();
            userNameTextBox = new TextBox();
            userNameLabel = new Label();
            createAccount = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(161, 166);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 9;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // passTextBox
            // 
            passTextBox.Location = new Point(139, 102);
            passTextBox.Name = "passTextBox";
            passTextBox.Size = new Size(234, 31);
            passTextBox.TabIndex = 8;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.ForeColor = SystemColors.HotTrack;
            passwordLabel.Location = new Point(34, 105);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(87, 25);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Password";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(139, 44);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(237, 31);
            userNameTextBox.TabIndex = 6;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.ForeColor = SystemColors.HotTrack;
            userNameLabel.Location = new Point(37, 47);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(96, 25);
            userNameLabel.TabIndex = 5;
            userNameLabel.Text = "User name";
            // 
            // createAccount
            // 
            createAccount.Location = new Point(139, 206);
            createAccount.Name = "createAccount";
            createAccount.Size = new Size(162, 42);
            createAccount.TabIndex = 10;
            createAccount.Text = "Create account";
            createAccount.UseVisualStyleBackColor = true;
            createAccount.Click += createAccount_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(471, 280);
            Controls.Add(createAccount);
            Controls.Add(button1);
            Controls.Add(passTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(userNameTextBox);
            Controls.Add(userNameLabel);
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox passTextBox;
        private Label passwordLabel;
        private TextBox userNameTextBox;
        private Label userNameLabel;
        private Button createAccount;
    }
}
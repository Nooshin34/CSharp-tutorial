namespace _014___firstWindowsForm
{
    partial class CreateFreeAccount
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
            checkBox1 = new CheckBox();
            createFreeAccountButton = new Button();
            SuspendLayout();
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.ForeColor = SystemColors.HotTrack;
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
            passwordLabel.ForeColor = SystemColors.HotTrack;
            passwordLabel.Location = new Point(25, 97);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(87, 25);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(80, 159);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(297, 29);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Accept our terms and conditions";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // createFreeAccountButton
            // 
            createFreeAccountButton.BackColor = SystemColors.HotTrack;
            createFreeAccountButton.ForeColor = SystemColors.ButtonHighlight;
            createFreeAccountButton.Location = new Point(111, 194);
            createFreeAccountButton.Name = "createFreeAccountButton";
            createFreeAccountButton.Size = new Size(220, 42);
            createFreeAccountButton.TabIndex = 6;
            createFreeAccountButton.Text = "Create Free Account";
            createFreeAccountButton.UseVisualStyleBackColor = false;
            createFreeAccountButton.Click += createFreeAccountButton_Click;
            // 
            // CreateFreeAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(466, 295);
            Controls.Add(createFreeAccountButton);
            Controls.Add(checkBox1);
            Controls.Add(passTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(userNameTextBox);
            Controls.Add(userNameLabel);
            Name = "CreateFreeAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox passTextBox;
        private Label passwordLabel;
        private TextBox userNameTextBox;
        private Label userNameLabel;
        private Button createAccount;
        private CheckBox checkBox1;
        private Button createFreeAccount;
        private Button createFreeAccountButton;
    }
}

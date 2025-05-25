namespace University
{
    partial class LoginForm
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
            usernameTextBox = new TextBox();
            passwordTextBox = new MaskedTextBox();
            loginGroupBox = new GroupBox();
            loginButton = new Button();
            passwordLabel = new Label();
            usernameLabel = new Label();
            button1 = new Button();
            loginGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(168, 22);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(266, 23);
            usernameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(168, 51);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(266, 23);
            passwordTextBox.TabIndex = 1;
            // 
            // loginGroupBox
            // 
            loginGroupBox.Anchor = AnchorStyles.None;
            loginGroupBox.Controls.Add(loginButton);
            loginGroupBox.Controls.Add(passwordLabel);
            loginGroupBox.Controls.Add(usernameLabel);
            loginGroupBox.Controls.Add(usernameTextBox);
            loginGroupBox.Controls.Add(passwordTextBox);
            loginGroupBox.Location = new Point(45, 40);
            loginGroupBox.Name = "loginGroupBox";
            loginGroupBox.Size = new Size(510, 132);
            loginGroupBox.TabIndex = 2;
            loginGroupBox.TabStop = false;
            loginGroupBox.Text = "Авторизация";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(168, 80);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 4;
            loginButton.Text = "Войти";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(113, 54);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(49, 15);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Пароль";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(53, 25);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(109, 15);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Имя пользователя";
            // 
            // button1
            // 
            button1.Location = new Point(388, 31);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 211);
            Controls.Add(button1);
            Controls.Add(loginGroupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход";
            loginGroupBox.ResumeLayout(false);
            loginGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox usernameTextBox;
        private MaskedTextBox passwordTextBox;
        private GroupBox loginGroupBox;
        private Label passwordLabel;
        private Label usernameLabel;
        private Button button1;
        private Button loginButton;
    }
}

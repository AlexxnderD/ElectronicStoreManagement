namespace Estore
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            usernameLabel = new Label();
            usernameTextBox = new TextBox();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            RegisterButton = new Button();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(90, 63);
            usernameLabel.Margin = new Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(41, 15);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Логин";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(140, 58);
            usernameTextBox.Margin = new Padding(4, 3, 4, 3);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(233, 23);
            usernameTextBox.TabIndex = 1;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(82, 118);
            passwordLabel.Margin = new Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(49, 15);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Пароль";
            passwordLabel.Click += passwordLabel_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(140, 115);
            passwordTextBox.Margin = new Padding(4, 3, 4, 3);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(233, 23);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(175, 173);
            loginButton.Margin = new Padding(4, 3, 4, 3);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(88, 27);
            loginButton.TabIndex = 4;
            loginButton.Text = "Войти";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += LoginButton_Click;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(12, 194);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(90, 25);
            RegisterButton.TabIndex = 5;
            RegisterButton.Text = "Регистрация";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 231);
            Controls.Add(RegisterButton);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameTextBox);
            Controls.Add(usernameLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход";
            FormClosed += LoginForm_FormClosed;
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private Button RegisterButton;
    }
}

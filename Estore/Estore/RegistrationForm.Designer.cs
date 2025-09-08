namespace Estore
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            emailLabel = new Label();
            emailTextBox = new TextBox();
            usernameLabel = new Label();
            usernameTextBox = new TextBox();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            registerButton = new Button();
            addressTextBox = new TextBox();
            phoneTextBox = new TextBox();
            surnameTextBox = new TextBox();
            nameTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(14, 131);
            emailLabel.Margin = new Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.RightToLeft = RightToLeft.No;
            emailLabel.Size = new Size(36, 15);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(73, 128);
            emailTextBox.Margin = new Padding(4, 3, 4, 3);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(233, 23);
            emailTextBox.TabIndex = 1;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(14, 160);
            usernameLabel.Margin = new Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.RightToLeft = RightToLeft.No;
            usernameLabel.Size = new Size(41, 15);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Логин";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(73, 157);
            usernameTextBox.Margin = new Padding(4, 3, 4, 3);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(233, 23);
            usernameTextBox.TabIndex = 3;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(16, 189);
            passwordLabel.Margin = new Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.RightToLeft = RightToLeft.No;
            passwordLabel.Size = new Size(49, 15);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Пароль";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(73, 186);
            passwordTextBox.Margin = new Padding(4, 3, 4, 3);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(233, 23);
            passwordTextBox.TabIndex = 5;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(112, 230);
            registerButton.Margin = new Padding(4, 3, 4, 3);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(115, 30);
            registerButton.TabIndex = 6;
            registerButton.Text = "Зарегистрировать";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += RegisterButton_Click;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(73, 99);
            addressTextBox.Margin = new Padding(4, 3, 4, 3);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(233, 23);
            addressTextBox.TabIndex = 1;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(73, 70);
            phoneTextBox.Margin = new Padding(4, 3, 4, 3);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(233, 23);
            phoneTextBox.TabIndex = 1;
            // 
            // surnameTextBox
            // 
            surnameTextBox.Location = new Point(73, 41);
            surnameTextBox.Margin = new Padding(4, 3, 4, 3);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(233, 23);
            surnameTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(73, 12);
            nameTextBox.Margin = new Padding(4, 3, 4, 3);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(233, 23);
            nameTextBox.TabIndex = 1;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 102);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Адрес";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 73);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(55, 15);
            label2.TabIndex = 0;
            label2.Text = "Телефон";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 44);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(58, 15);
            label3.TabIndex = 0;
            label3.Text = "Фамилия";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 15);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(31, 15);
            label4.TabIndex = 0;
            label4.Text = "Имя";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 275);
            Controls.Add(registerButton);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameTextBox);
            Controls.Add(usernameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(surnameTextBox);
            Controls.Add(phoneTextBox);
            Controls.Add(addressTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(emailLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация";
            FormClosed += RegistrationForm_FormClosed;
            Load += RegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button registerButton;
        private TextBox addressTextBox;
        private TextBox phoneTextBox;
        private TextBox surnameTextBox;
        private TextBox nameTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}

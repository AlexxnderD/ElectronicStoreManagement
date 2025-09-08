namespace Estore
{
    partial class AddUsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUsersForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnAdd = new Button();
            comboStatus = new ComboBox();
            textPassword = new TextBox();
            textLogin = new TextBox();
            textAddress = new TextBox();
            textPhone = new TextBox();
            textMail = new TextBox();
            textSurname = new TextBox();
            textName = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 15);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 44);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 73);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 1;
            label3.Text = "э-Почта";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 102);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 1;
            label4.Text = "Телефон";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 131);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 1;
            label5.Text = "Адрес";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 160);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 1;
            label6.Text = "Логин";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 189);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 1;
            label7.Text = "Пароль";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 218);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 1;
            label8.Text = "Статус";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(125, 257);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // comboStatus
            // 
            comboStatus.FormattingEnabled = true;
            comboStatus.Items.AddRange(new object[] { "client", "pers", "adm" });
            comboStatus.Location = new Point(82, 215);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(221, 23);
            comboStatus.TabIndex = 3;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(82, 186);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(221, 23);
            textPassword.TabIndex = 4;
            // 
            // textLogin
            // 
            textLogin.Location = new Point(82, 157);
            textLogin.Name = "textLogin";
            textLogin.Size = new Size(221, 23);
            textLogin.TabIndex = 4;
            // 
            // textAddress
            // 
            textAddress.Location = new Point(82, 128);
            textAddress.Name = "textAddress";
            textAddress.Size = new Size(221, 23);
            textAddress.TabIndex = 4;
            textAddress.KeyPress += textAddress_KeyPress;
            // 
            // textPhone
            // 
            textPhone.Location = new Point(82, 99);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(221, 23);
            textPhone.TabIndex = 4;
            textPhone.KeyPress += textPhone_KeyPress;
            // 
            // textMail
            // 
            textMail.Location = new Point(82, 70);
            textMail.Name = "textMail";
            textMail.Size = new Size(221, 23);
            textMail.TabIndex = 4;
            // 
            // textSurname
            // 
            textSurname.Location = new Point(82, 41);
            textSurname.Name = "textSurname";
            textSurname.Size = new Size(221, 23);
            textSurname.TabIndex = 4;
            // 
            // textName
            // 
            textName.Location = new Point(82, 12);
            textName.Name = "textName";
            textName.Size = new Size(221, 23);
            textName.TabIndex = 4;
            textName.TextChanged += textName_TextChanged;
            // 
            // AddUsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 292);
            Controls.Add(textName);
            Controls.Add(textSurname);
            Controls.Add(textMail);
            Controls.Add(textPhone);
            Controls.Add(textAddress);
            Controls.Add(textLogin);
            Controls.Add(textPassword);
            Controls.Add(comboStatus);
            Controls.Add(btnAdd);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AddUsersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление пользователя";
            FormClosing += AddUsersForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnAdd;
        private ComboBox comboStatus;
        private TextBox textPassword;
        private TextBox textLogin;
        private TextBox textAddress;
        private TextBox textPhone;
        private TextBox textMail;
        private TextBox textSurname;
        private TextBox textName;
    }
}
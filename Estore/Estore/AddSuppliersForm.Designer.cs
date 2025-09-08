namespace Estore
{
    partial class AddSuppliersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSuppliersForm));
            btnAdd = new Button();
            textName = new TextBox();
            textAddress = new TextBox();
            textPhone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(165, 183);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // textName
            // 
            textName.Location = new Point(96, 36);
            textName.Name = "textName";
            textName.Size = new Size(274, 23);
            textName.TabIndex = 1;
            textName.Tag = "";
            // 
            // textAddress
            // 
            textAddress.Location = new Point(96, 87);
            textAddress.Name = "textAddress";
            textAddress.Size = new Size(274, 23);
            textAddress.TabIndex = 1;
            // 
            // textPhone
            // 
            textPhone.Location = new Point(96, 137);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(274, 23);
            textPhone.TabIndex = 1;
            textPhone.KeyPress += textPhone_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 39);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 2;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 90);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Адрес";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 140);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Телефон";
            label3.Click += label3_Click;
            // 
            // AddSuppliersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(402, 218);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textPhone);
            Controls.Add(textAddress);
            Controls.Add(textName);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AddSuppliersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление поставщика";
            FormClosing += AddSuppliersForm_FormClosing;
            Load += AddSuppliersForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private TextBox textName;
        private TextBox textAddress;
        private TextBox textPhone;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
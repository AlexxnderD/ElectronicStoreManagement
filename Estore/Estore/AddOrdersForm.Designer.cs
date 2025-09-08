namespace Estore
{
    partial class AddOrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrdersForm));
            comboUsers = new ComboBox();
            dateOrder = new DateTimePicker();
            textSum = new TextBox();
            comboStatus = new ComboBox();
            btnAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            comboProduct = new ComboBox();
            SuspendLayout();
            // 
            // comboUsers
            // 
            comboUsers.FormattingEnabled = true;
            comboUsers.Location = new Point(104, 12);
            comboUsers.Name = "comboUsers";
            comboUsers.Size = new Size(207, 23);
            comboUsers.TabIndex = 0;
            // 
            // dateOrder
            // 
            dateOrder.Location = new Point(104, 41);
            dateOrder.Name = "dateOrder";
            dateOrder.Size = new Size(207, 23);
            dateOrder.TabIndex = 1;
            // 
            // textSum
            // 
            textSum.Location = new Point(104, 70);
            textSum.Name = "textSum";
            textSum.Size = new Size(207, 23);
            textSum.TabIndex = 2;
            textSum.KeyPress += textSum_KeyPress;
            // 
            // comboStatus
            // 
            comboStatus.FormattingEnabled = true;
            comboStatus.Items.AddRange(new object[] { "active", "close" });
            comboStatus.Location = new Point(104, 99);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(207, 23);
            comboStatus.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(123, 170);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 6;
            label1.Text = "Клиент";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 6;
            label2.Text = "Дата заказа";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 73);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 6;
            label3.Text = "Сумма заказа";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 102);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 6;
            label5.Text = "Статус заказа";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 134);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 7;
            label4.Text = "Товар";
            label4.Click += label4_Click;
            // 
            // comboProduct
            // 
            comboProduct.FormattingEnabled = true;
            comboProduct.Items.AddRange(new object[] { "active", "close" });
            comboProduct.Location = new Point(104, 130);
            comboProduct.Name = "comboProduct";
            comboProduct.Size = new Size(207, 23);
            comboProduct.TabIndex = 4;
            // 
            // AddOrdersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(323, 207);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(comboProduct);
            Controls.Add(comboStatus);
            Controls.Add(textSum);
            Controls.Add(dateOrder);
            Controls.Add(comboUsers);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AddOrdersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление заказа";
            FormClosing += AddOrdersForm_FormClosing;
            Load += AddOrdersForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboUsers;
        private DateTimePicker dateOrder;
        private TextBox textSum;
        private ComboBox comboStatus;
        private Button btnAdd;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private ComboBox comboProduct;
    }
}
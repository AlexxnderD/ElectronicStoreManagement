namespace Estore
{
    partial class AddProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductsForm));
            textName = new TextBox();
            textBrend = new TextBox();
            textCategory = new TextBox();
            textPrice = new TextBox();
            textCount = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboSupp = new ComboBox();
            label7 = new Label();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // textName
            // 
            textName.Location = new Point(122, 41);
            textName.Name = "textName";
            textName.Size = new Size(327, 23);
            textName.TabIndex = 0;
            // 
            // textBrend
            // 
            textBrend.Location = new Point(122, 70);
            textBrend.Name = "textBrend";
            textBrend.Size = new Size(327, 23);
            textBrend.TabIndex = 0;
            // 
            // textCategory
            // 
            textCategory.Location = new Point(122, 99);
            textCategory.Name = "textCategory";
            textCategory.Size = new Size(327, 23);
            textCategory.TabIndex = 0;
            // 
            // textPrice
            // 
            textPrice.Location = new Point(122, 128);
            textPrice.Name = "textPrice";
            textPrice.Size = new Size(327, 23);
            textPrice.TabIndex = 0;
            textPrice.KeyPress += textPrice_KeyPress;
            // 
            // textCount
            // 
            textCount.Location = new Point(122, 157);
            textCount.Name = "textCount";
            textCount.Size = new Size(327, 23);
            textCount.TabIndex = 0;
            textCount.KeyPress += textCount_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 44);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 73);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Бренд";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 102);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 1;
            label3.Text = "Категория";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 131);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 1;
            label4.Text = "Цена";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 160);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 1;
            label5.Text = "Количество";
            // 
            // comboSupp
            // 
            comboSupp.FormattingEnabled = true;
            comboSupp.Location = new Point(122, 186);
            comboSupp.Name = "comboSupp";
            comboSupp.Size = new Size(327, 23);
            comboSupp.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 189);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 1;
            label7.Text = "Поставщик";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(190, 243);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 284);
            Controls.Add(btnAdd);
            Controls.Add(comboSupp);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textCount);
            Controls.Add(textPrice);
            Controls.Add(textCategory);
            Controls.Add(textBrend);
            Controls.Add(textName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "AddProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление товара";
            FormClosing += AddProductsForm_FormClosing;
            Load += AddProductsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textName;
        private TextBox textBrend;
        private TextBox textCategory;
        private TextBox textPrice;
        private TextBox textCount;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboSupp;
        private Label label7;
        private Button btnAdd;
    }
}
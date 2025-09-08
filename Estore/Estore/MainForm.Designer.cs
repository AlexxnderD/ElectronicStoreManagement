namespace Estore
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnProducts = new Button();
            btnUsers = new Button();
            btnOrders = new Button();
            btnSuppliers = new Button();
            dataGridView = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnOrder = new Button();
            btnQuery1 = new Button();
            button1 = new Button();
            btnQuery3 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnProducts
            // 
            btnProducts.Enabled = false;
            btnProducts.Location = new Point(14, 14);
            btnProducts.Margin = new Padding(4, 3, 4, 3);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(88, 27);
            btnProducts.TabIndex = 8;
            btnProducts.Text = "Товары";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnUsers
            // 
            btnUsers.Location = new Point(303, 14);
            btnUsers.Margin = new Padding(4, 3, 4, 3);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(99, 27);
            btnUsers.TabIndex = 7;
            btnUsers.Text = "Пользователи";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnOrders
            // 
            btnOrders.Location = new Point(110, 14);
            btnOrders.Margin = new Padding(4, 3, 4, 3);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(88, 27);
            btnOrders.TabIndex = 6;
            btnOrders.Text = "Заказы";
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.Location = new Point(206, 14);
            btnSuppliers.Margin = new Padding(4, 3, 4, 3);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(88, 27);
            btnSuppliers.TabIndex = 5;
            btnSuppliers.Text = "Поставщики";
            btnSuppliers.UseVisualStyleBackColor = true;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Cursor = Cursors.Hand;
            dataGridView.Location = new Point(14, 47);
            dataGridView.Margin = new Padding(4, 3, 4, 3);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.Size = new Size(948, 345);
            dataGridView.TabIndex = 4;
            dataGridView.CellClick += dataGridView_CellClick;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(107, 401);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(88, 27);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(299, 401);
            btnEdit.Margin = new Padding(4, 3, 4, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(102, 27);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Редактировать";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(203, 401);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 27);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(14, 401);
            btnOrder.Margin = new Padding(4, 3, 4, 3);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(88, 27);
            btnOrder.TabIndex = 0;
            btnOrder.Text = "Заказ";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnQuery1
            // 
            btnQuery1.Location = new Point(970, 135);
            btnQuery1.Name = "btnQuery1";
            btnQuery1.Size = new Size(225, 23);
            btnQuery1.TabIndex = 11;
            btnQuery1.Text = "Товары с низким остатком на складе";
            btnQuery1.UseVisualStyleBackColor = true;
            btnQuery1.Click += btnQuery1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(970, 164);
            button1.Name = "button1";
            button1.Size = new Size(225, 40);
            button1.TabIndex = 12;
            button1.Text = "Клиенты, сделавшие заказы за последний месяц";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btnQuery3
            // 
            btnQuery3.Location = new Point(970, 210);
            btnQuery3.Name = "btnQuery3";
            btnQuery3.Size = new Size(225, 23);
            btnQuery3.TabIndex = 13;
            btnQuery3.Text = "Заказ с самой большой суммой";
            btnQuery3.UseVisualStyleBackColor = true;
            btnQuery3.Click += btnQuery3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(970, 239);
            button2.Name = "button2";
            button2.Size = new Size(225, 24);
            button2.TabIndex = 14;
            button2.Text = "Заказы, которые еще не завершены";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(970, 279);
            button3.Name = "button3";
            button3.Size = new Size(109, 23);
            button3.TabIndex = 15;
            button3.Text = "Цены +0.5";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1085, 279);
            button4.Name = "button4";
            button4.Size = new Size(110, 23);
            button4.TabIndex = 16;
            button4.Text = "Скидка 10%";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(986, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 328);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1203, 440);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnQuery3);
            Controls.Add(button1);
            Controls.Add(btnQuery1);
            Controls.Add(pictureBox1);
            Controls.Add(btnOrder);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView);
            Controls.Add(btnSuppliers);
            Controls.Add(btnOrders);
            Controls.Add(btnUsers);
            Controls.Add(btnProducts);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "E-store магазин";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOrder;
        private Button btnQuery1;
        private Button button1;
        private Button btnQuery3;
        private Button button2;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox1;
    }
}

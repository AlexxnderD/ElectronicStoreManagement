using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Reflection.Emit;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Diagnostics;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Estore
{
    public partial class MainForm : Form
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDb)\LocalDBDemo;Initial Catalog=Estore;Integrated Security=True;");
        private int id_client;
        public MainForm(int id_client, int status_client)
        {
            InitializeComponent();
            this.id_client = id_client;
            if (status_client == 3)
            {
                btnAdd.Visible = false;
                btnDelete.Visible = false;
                btnEdit.Visible = false;
                btnSuppliers.Visible = false;
                btnUsers.Visible = false;
                btnOrders.Visible = false;
                btnQuery1.Visible = false;
                btnQuery3.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
            }
            if (status_client == 2)
            {
                pictureBox1.Visible = false;
                btnSuppliers.Visible = false;
                btnUsers.Visible = false;
                btnOrder.Visible = false;

            }
            if (status_client == 1) // adm
            {
                pictureBox1.Visible = false;
                btnOrder.Visible = false;
            }

        }
        private int selectID = 0;
        private void btnProducts_Click(object sender, EventArgs e)
        {
            btnProducts.Enabled = false;
            btnOrders.Enabled = true;

            btnUsers.Enabled = true;
            btnSuppliers.Enabled = true;
            showTableProducts();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            btnProducts.Enabled = true;
            btnOrders.Enabled = true;
            btnUsers.Enabled = false;
            btnSuppliers.Enabled = true;
            showTableUsers();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            btnProducts.Enabled = true;
            btnOrders.Enabled = false;
            btnUsers.Enabled = true;
            btnSuppliers.Enabled = true;
            showTableOrders();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            btnProducts.Enabled = true;
            btnOrders.Enabled = true;
            btnUsers.Enabled = true;
            btnSuppliers.Enabled = false;
            showTableSuppliers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnSuppliers.Enabled == false)
            {
                AddSuppliersForm addSuppliersForm = new AddSuppliersForm(this, 0);

                addSuppliersForm.FormClosed += (s, args) => Application.Exit();
                addSuppliersForm.Show();
                return;
            }
            if (btnProducts.Enabled == false)
            {
                AddProductsForm addProductsForm = new AddProductsForm(this, 0);

                addProductsForm.FormClosed += (s, args) => Application.Exit();
                addProductsForm.Show();
                return;
            }
            if (btnUsers.Enabled == false)
            {
                AddUsersForm addUsersForm = new AddUsersForm(this, 0);

                addUsersForm.FormClosed += (s, args) => Application.Exit();
                addUsersForm.Show();
                return;
            }
            if (btnOrders.Enabled == false)
            {
                AddOrdersForm addOrdersForm = new AddOrdersForm(this, 0);

                addOrdersForm.FormClosed += (s, args) => Application.Exit();
                addOrdersForm.Show();
                return;
            }

            MessageBox.Show("Добавление данных");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (btnUsers.Enabled == false)
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                    int id_user = (int)selectedRow.Cells["id_клиента"].Value;
                    AddUsersForm addUsersForm = new AddUsersForm(this, id_user);

                    addUsersForm.FormClosed += (s, args) => Application.Exit();
                    addUsersForm.Show();
                    return;
                }
                else
                {
                    MessageBox.Show("Ни одна строка не выбрана! Необходимо выбрать всю строку.");
                    return;
                }
            }

            if (btnSuppliers.Enabled == false)
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                    int id_suppler = (int)selectedRow.Cells["id_поставщика"].Value;
                    AddSuppliersForm addSuppliersForm = new AddSuppliersForm(this, id_suppler);

                    addSuppliersForm.FormClosed += (s, args) => Application.Exit();
                    addSuppliersForm.Show();
                    return;
                }
                else
                {
                    MessageBox.Show("Ни одна строка не выбрана! Необходимо выбрать всю строку.");
                    return;
                }

            }
            if (btnProducts.Enabled == false)
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                    int id_product = (int)selectedRow.Cells["ID Товара"].Value;
                    AddProductsForm addProductsForm = new AddProductsForm(this, id_product);

                    addProductsForm.FormClosed += (s, args) => Application.Exit();
                    addProductsForm.Show();
                    return;
                }
                else
                {
                    MessageBox.Show("Ни одна строка не выбрана! Необходимо выбрать всю строку.");
                    return;
                }
            }
            if (btnOrders.Enabled == false)
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                    int id_orders = (int)selectedRow.Cells["ID Заказа"].Value;
                    AddOrdersForm addOrdersForm = new AddOrdersForm(this, id_orders);

                    addOrdersForm.FormClosed += (s, args) => Application.Exit();
                    addOrdersForm.Show();
                    return;
                }
                else
                {
                    MessageBox.Show("Ни одна строка не выбрана! Необходимо выбрать всю строку.");
                    return;
                }
            }
            MessageBox.Show("Редактирование данных");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnSuppliers.Enabled == false)
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    var results = MessageBox.Show("Вы уверены, что хотите удалить выбранного поставщика?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (results == DialogResult.Yes)
                    {
                        DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                        int id_suppler = (int)selectedRow.Cells["id_поставщика"].Value;

                        connection.Open();

                        string query = "DELETE FROM Поставщики WHERE id_поставщика = @id_sup";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id_sup", id_suppler);
                            int result;
                            try
                            {
                                result = command.ExecuteNonQuery();
                            }
                            catch (Exception m)
                            {
                                connection.Close();
                                MessageBox.Show(m.Message);
                                return;
                            }

                            if (result > 0)
                            {
                                MessageBox.Show("Успешное удаление.");
                                connection.Close();
                                showTableSuppliers();
                            }
                            else
                            {
                                connection.Close();
                                MessageBox.Show("Не удалось удалить.");
                            }
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Ни одна строка не выбрана! Необходимо выбрать всю строку.");
                }

                return;
            }


            if (btnOrders.Enabled == false)
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    var results = MessageBox.Show("Вы уверены, что хотите удалить выбранный заказ?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (results == DialogResult.Yes)
                    {
                        DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                        int id_order = (int)selectedRow.Cells["id_заказа"].Value;

                        connection.Open();

                        string query = "DELETE FROM Заказы WHERE id_заказа = @id_ord";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id_ord", id_order);
                            int result;
                            try
                            {
                                result = command.ExecuteNonQuery();
                            }
                            catch (Exception m)
                            {
                                connection.Close();
                                MessageBox.Show(m.Message);
                                return;
                            }

                            if (result > 0)
                            {
                                MessageBox.Show("Успешное удаление.");
                                connection.Close();
                                showTableOrders();
                            }
                            else
                            {
                                connection.Close();
                                MessageBox.Show("Не удалось удалить.");
                            }
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Ни одна строка не выбрана! Необходимо выбрать всю строку.");
                }
                return;
            }

            if (btnUsers.Enabled == false)
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    var results = MessageBox.Show("Вы уверены, что хотите удалить выбранного пользователя?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (results == DialogResult.Yes)
                    {
                        DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                        int id_user = (int)selectedRow.Cells["id_клиента"].Value;

                        connection.Open();

                        string query = "DELETE FROM Клиенты WHERE id_клиента = @id_usr";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id_usr", id_user);
                            int result;
                            // Выполнение команды
                            try
                            {
                                result = command.ExecuteNonQuery();
                            }
                            catch (Exception m)
                            {
                                connection.Close();
                                MessageBox.Show(m.Message);
                                return;
                            }


                            if (result > 0)
                            {
                                MessageBox.Show("Успешное удаление.");
                                connection.Close();
                                showTableUsers();
                            }
                            else
                            {
                                connection.Close();
                                MessageBox.Show("Не удалось удалить.");
                            }
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Ни одна строка не выбрана! Необходимо выбрать всю строку.");
                }
                return;
            }

            if (btnProducts.Enabled == false)
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    var results = MessageBox.Show("Вы уверены, что хотите удалить выбранный товар", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (results == DialogResult.Yes)
                    {
                        DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                        int id_product = (int)selectedRow.Cells["id_товара"].Value;

                        connection.Open();

                        string query = "DELETE FROM Товары WHERE id_товара = @id_pdr";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id_pdr", id_product);
                            int result;

                            try
                            {
                                result = command.ExecuteNonQuery();
                            }
                            catch (Exception m)
                            {
                                connection.Close();
                                MessageBox.Show(m.Message);
                                return;
                            }

                            if (result > 0)
                            {
                                MessageBox.Show("Успешное удаленеи.");
                                connection.Close();
                                showTableProducts();
                            }
                            else
                            {
                                connection.Close();
                                MessageBox.Show("Не удалось удалить.");
                            }
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Ни одна строка не выбрана! Необходимо выбрать всю строку.");
                }
                return;
            }
            MessageBox.Show("Удаление данных");
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var results = MessageBox.Show("Вы уверены, что хотите заказать выбранный товар?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (results == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                    int id_product = (int)selectedRow.Cells["ID Товара"].Value;

                    int countProduct = 0;
                    try
                    {

                        connection.Open();
                        string query2 = $"SELECT КоличествоНаСкладе FROM Товары WHERE id_товара = {id_product};";
                        using (SqlCommand command = new SqlCommand(query2, connection))
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                countProduct = reader.GetInt32(0);
                            }
                        }
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: " + ex.Message);
                    }

                    if (countProduct <= 0)
                    {
                        MessageBox.Show("Данного товара нет в наличии.");
                        return;
                    }

                    decimal sum = (decimal)selectedRow.Cells["Цена"].Value;
                    string query = "INSERT INTO Заказы (id_клиента, ДатаЗаказа, ОбщаяСумма, Статус, id_товара) VALUES (@User, @Date, @Sum, 'active', @product);";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();

                            command.Parameters.AddWithValue("@Date", DateTime.Now);
                            command.Parameters.AddWithValue("@Sum", sum);
                            command.Parameters.AddWithValue("@User", id_client);
                            command.Parameters.AddWithValue("@product", id_product);

                            int rowsAffected = command.ExecuteNonQuery();
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка: " + ex.Message);
                        }
                    }
                    string queryalter = $"UPDATE Товары SET КоличествоНаСкладе = КоличествоНаСкладе - 1 WHERE id_товара = {id_product};";
                    using (SqlCommand command = new SqlCommand(queryalter, connection))
                    {
                        try
                        {
                            connection.Open();

                            int rowsAffected = command.ExecuteNonQuery();

                            connection.Close();
                            showTableProducts();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка: " + ex.Message);
                            connection.Close();
                        }

                    }

                }

            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            showTableProducts();
        }

        public void showTableProducts()
        {
            connection.Open();

            string query = "SELECT \r\n    Товары.id_товара AS 'ID Товара',\r\n    Товары.Название AS 'Название Товара',\r\n    Товары.Бренд AS 'Бренд',\r\n    Товары.Категория AS 'Категория',\r\n    Товары.Цена AS 'Цена',\r\n    Товары.КоличествоНаСкладе AS 'Количество На Складе',\r\n    Поставщики.Название AS 'Название Поставщика'\r\nFROM \r\n    Товары\r\nLEFT JOIN \r\n    Поставщики ON Товары.id_поставщика = Поставщики.id_поставщика;";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                DataTable dataTable = new DataTable();

                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                {
                    dataAdapter.Fill(dataTable);
                }

                dataGridView.DataSource = dataTable;
            }
            connection.Close();
        }
        public void showTableSuppliers()
        {
            connection.Open();

            string query = "SELECT * FROM Поставщики";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                DataTable dataTable = new DataTable();

                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                {
                    dataAdapter.Fill(dataTable);
                }

                dataGridView.DataSource = dataTable;
            }
            connection.Close();
        }

        public void showTableOrders()
        {
            connection.Open();

            string query = "SELECT \r\n    Заказы.id_заказа AS 'ID Заказа',\r\n    Клиенты.Имя + ' ' + Клиенты.Фамилия AS 'Имя Клиента',\r\n    Товары.Название AS 'Название Товара',\r\n    Заказы.ДатаЗаказа AS 'Дата Заказа',\r\n    Заказы.ОбщаяСумма AS 'Общая Сумма',\r\n    Заказы.Статус AS 'Статус Заказа'\r\nFROM \r\n    Заказы\r\nJOIN \r\n    Клиенты ON Заказы.id_клиента = Клиенты.id_клиента\r\nJOIN \r\n    Товары ON Заказы.id_товара = Товары.id_товара;";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                DataTable dataTable = new DataTable();

                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                {
                    dataAdapter.Fill(dataTable);
                }

                dataGridView.DataSource = dataTable;
            }
            connection.Close();
        }


        public void showTableUsers()
        {
            connection.Open();

            string query = "SELECT * FROM Клиенты";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                DataTable dataTable = new DataTable();

                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                {
                    dataAdapter.Fill(dataTable);
                }

                dataGridView.DataSource = dataTable;
            }
            connection.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnQuery1_Click(object sender, EventArgs e)
        {
            connection.Open();

            string query = "SELECT Название, КоличествоНаСкладе FROM Товары WHERE КоличествоНаСкладе < 10;";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                DataTable dataTable = new DataTable();

                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                {
                    dataAdapter.Fill(dataTable);
                }

                dataGridView.DataSource = dataTable;
            }
            connection.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            connection.Open();

            string query = "SELECT Клиенты.Имя, Клиенты.Фамилия, Заказы.ДатаЗаказа FROM Клиенты JOIN Заказы ON Клиенты.id_клиента = Заказы.id_клиента WHERE Заказы.ДатаЗаказа BETWEEN DATEADD(month, -1, GETDATE()) AND GETDATE();";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                DataTable dataTable = new DataTable();

                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                {
                    dataAdapter.Fill(dataTable);
                }

                dataGridView.DataSource = dataTable;
            }
            connection.Close();
        }

        private void btnQuery3_Click(object sender, EventArgs e)
        {
            connection.Open();

            string query = "SELECT TOP 1 id_заказа, ОбщаяСумма FROM Заказы ORDER BY ОбщаяСумма DESC;";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                DataTable dataTable = new DataTable();

                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                {
                    dataAdapter.Fill(dataTable);
                }

                dataGridView.DataSource = dataTable;
            }
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();

            string query = "SELECT id_заказа, id_клиента, ДатаЗаказа, ОбщаяСумма FROM Заказы WHERE Статус = 'active';";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                DataTable dataTable = new DataTable();

                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                {
                    dataAdapter.Fill(dataTable);
                }

                dataGridView.DataSource = dataTable;
            }
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string queryalter = "UPDATE Товары SET Цена = Цена + 0.5;";
            using (SqlCommand command = new SqlCommand(queryalter, connection))
            {
                try
                {
                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    MessageBox.Show("Обновление цен успешно выполнено!");
                    connection.Close();
                    showTableProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                    connection.Close();
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string queryalter = "UPDATE Товары SET Цена = Цена * 0.9;";
            using (SqlCommand command = new SqlCommand(queryalter, connection))
            {
                try
                {
                    // Открытие подключения
                    connection.Open();

                    // Выполнение запроса
                    int rowsAffected = command.ExecuteNonQuery();

                    MessageBox.Show("Обновление цен успешно выполнено!");
                    connection.Close();
                    showTableProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                    connection.Close();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

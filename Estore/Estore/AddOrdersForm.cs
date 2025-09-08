using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Estore.AddProductsForm;

namespace Estore
{
    public partial class AddOrdersForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDb)\LocalDBDemo;Initial Catalog=Estore;Integrated Security=True;");
        private MainForm mainForm;
        private int id_redact = 0;
        public AddOrdersForm(MainForm mForm, int id)
        {
            InitializeComponent();
            mainForm = mForm;
            LoadProduct();
            comboProduct.SelectedIndex = 0;
            LoadUsers();
            comboStatus.SelectedIndex = 0;
            comboUsers.SelectedIndex = 0;
            id_redact = id;
            if (id != 0)
            {
                btnAdd.Text = "Изменить";
                this.Text = $"Редактирование заказа #{id}";
                try
                {

                    connection.Open();
                    string query = "SELECT ДатаЗаказа, ОбщаяСумма FROM Заказы WHERE id_заказа = " + id;
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime orderdate = reader.GetDateTime(0);
                            decimal orderprice = reader.GetDecimal(1);
                            dateOrder.Value = orderdate;
                            textSum.Text = orderprice.ToString();


                        }
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке страницы: " + ex.Message);
                }
            }
        }
        private void LoadUsers()
        {
            comboUsers.Items.Clear();

            try
            {

                connection.Open();
                string query = "SELECT id_клиента, Фамилия FROM Клиенты";
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int supplierId = reader.GetInt32(0);
                        string supplierName = reader.GetString(1);
                        comboUsers.Items.Add(new ComboBoxItem(supplierName, supplierId));
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке клиентов: " + ex.Message);
            }
        }

        private void LoadProduct()
        {
            comboProduct.Items.Clear();

            try
            {
                connection.Open();
                string query = "SELECT id_товара FROM Товары";
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int supplierId = reader.GetInt32(0);
                        comboProduct.Items.Add(supplierId);
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке клиентов: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textSum.Text))
            {
                MessageBox.Show("Введите сумму", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            double summ = Convert.ToDouble(textSum.Text);
            DateTime date = dateOrder.Value;
            string status = comboStatus.Text;
            int product = Convert.ToInt32(comboProduct.Text);


            if (id_redact != 0)
            {
                string queryalter = @"
            UPDATE Заказы
            SET id_клиента = @id_клиента,
                ДатаЗаказа = @ДатаЗаказа,
                ОбщаяСумма = @ОбщаяСумма,
                Статус = @Статус,
                id_товара = @Product
            WHERE id_заказа = @id_заказа";
                using (SqlCommand command = new SqlCommand(queryalter, connection))
                {
                    try
                    {
                        connection.Open();

                         command.Parameters.AddWithValue("@ДатаЗаказа", date);
                        command.Parameters.AddWithValue("@ОбщаяСумма", summ);
                        command.Parameters.AddWithValue("@Статус", status);
                        command.Parameters.AddWithValue("@Product", product);
                        ComboBoxItem selectedItem = (ComboBoxItem)comboUsers.SelectedItem;
                        int selectedUserId = selectedItem.Value;
                        command.Parameters.AddWithValue("@id_клиента", selectedUserId);
                        command.Parameters.AddWithValue("@id_заказа", id_redact);

                         int rowsAffected = command.ExecuteNonQuery();

                        MessageBox.Show($"Добавлено {rowsAffected} строк в таблицу Заказы.");
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: " + ex.Message);
                    }
                }
                mainForm.showTableOrders();
                Close();
                return;
            }




            string query = "INSERT INTO Заказы (id_клиента, ДатаЗаказа, ОбщаяСумма, Статус, id_товара) VALUES (@User, @Date, @Sum, @Status, @Product);";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@Date", date);
                    command.Parameters.AddWithValue("@Sum", summ);
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@Product", product);
                    ComboBoxItem selectedItem = (ComboBoxItem)comboUsers.SelectedItem;
                    int selectedUserId = selectedItem.Value;
                    command.Parameters.AddWithValue("@User", selectedUserId);

                    int rowsAffected = command.ExecuteNonQuery();

                    MessageBox.Show($"Добавлено {rowsAffected} строк в таблицу Заказы.");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
            mainForm.showTableOrders();
            Close();
        }
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public ComboBoxItem(string text, int value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        private void AddOrdersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void textSum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == ',' && (sender as System.Windows.Forms.TextBox).Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddOrdersForm_Load(object sender, EventArgs e)
        {

        }
    }
}

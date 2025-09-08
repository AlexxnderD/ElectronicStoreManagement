using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Estore
{
    public partial class AddProductsForm : Form
    {
        private int id_redact = 0;
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDb)\LocalDBDemo;Initial Catalog=Estore;Integrated Security=True;");
        private MainForm mainForm;

        public AddProductsForm(MainForm mForm, int id)
        {
            InitializeComponent();
            LoadSuppliers();
            mainForm = mForm;
            comboSupp.SelectedIndex = 0;
            id_redact = id;
            if (id != 0)
            {
                btnAdd.Text = "Изменить";
                this.Text = $"Редактирование товара #{id}";
                try
                {

                    connection.Open();
                    string query = "SELECT Название, Бренд, Категория, Цена, КоличествоНаСкладе FROM Товары WHERE id_товара = " + id;
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string productName = reader.GetString(0);
                            string productBrend = reader.GetString(1);
                            string productCategory = reader.GetString(2);
                            decimal productPrice = reader.GetDecimal(3);
                            int productCount = reader.GetInt32(4);
                            textName.Text = productName;
                            textBrend.Text = productBrend;
                            textCategory.Text = productCategory;
                            textPrice.Text = Convert.ToString(productPrice);
                            textCount.Text = Convert.ToString(productCount);

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
        private void LoadSuppliers()
        {
            comboSupp.Items.Clear();

            try
            {

                connection.Open();
                string query = "SELECT id_поставщика, Название FROM Поставщики";
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int supplierId = reader.GetInt32(0);
                        string supplierName = reader.GetString(1);
                        comboSupp.Items.Add(new ComboBoxItem(supplierName, supplierId));
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке поставщиков: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textName.Text))
            {
                MessageBox.Show("Введите имя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (string.IsNullOrEmpty(textBrend.Text))
            {
                MessageBox.Show("Введите бренд", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (string.IsNullOrEmpty(textCategory.Text))
            {
                MessageBox.Show("Введите категорию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            if (string.IsNullOrEmpty(textPrice.Text))
            {
                MessageBox.Show("Введите цену", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            if (string.IsNullOrEmpty(textCount.Text))
            {
                MessageBox.Show("Введите количество", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            string name = textName.Text;
            string brend = textBrend.Text;
            string category = textCategory.Text;
            double price = Convert.ToDouble(textPrice.Text);
            int count = Convert.ToInt32(textCount.Text);
            if (id_redact != 0)
            {
                string queryalter = @"
            UPDATE Товары
            SET Название = @Название,
                Бренд = @Бренд,
                Категория = @Категория,
                Цена = @Цена,
                КоличествоНаСкладе = @КоличествоНаСкладе,
                id_поставщика = @id_поставщика
            WHERE id_товара = @id_товара";
                using (SqlCommand command = new SqlCommand(queryalter, connection))
                {
                    try
                    {
                        connection.Open();

                        command.Parameters.AddWithValue("@Название", name);
                        command.Parameters.AddWithValue("@Бренд", brend);
                        command.Parameters.AddWithValue("@Категория", category);
                        command.Parameters.AddWithValue("@Цена", price);
                        command.Parameters.AddWithValue("@КоличествоНаСкладе", count);
                        ComboBoxItem selectedItem = (ComboBoxItem)comboSupp.SelectedItem;
                        int selectedSupplierId = selectedItem.Value;
                        command.Parameters.AddWithValue("@id_поставщика", selectedSupplierId);
                        command.Parameters.AddWithValue("@id_товара", id_redact);

                        int rowsAffected = command.ExecuteNonQuery();

                        MessageBox.Show($"Изменено {rowsAffected} строк в таблице Товары.");
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: " + ex.Message);
                    }
                }
                mainForm.showTableProducts();
                Close();
                return;
            }



            string query = "INSERT INTO Товары (Название, Бренд, Категория, Цена, КоличествоНаСкладе, id_поставщика) VALUES (@Name, @Brend, @Category, @Price, @Count, @Supp);";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Brend", brend);
                    command.Parameters.AddWithValue("@Category", category);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Count", count);
                    ComboBoxItem selectedItem = (ComboBoxItem)comboSupp.SelectedItem;
                    int selectedSupplierId = selectedItem.Value;
                    command.Parameters.AddWithValue("@Supp", selectedSupplierId);


                    // Выполнение запроса
                    int rowsAffected = command.ExecuteNonQuery();

                    MessageBox.Show($"Добавлено {rowsAffected} строк в таблицу Товары.");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
            mainForm.showTableProducts();
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

        private void AddProductsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void textCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void AddProductsForm_Load(object sender, EventArgs e)
        {

        }
    }
}

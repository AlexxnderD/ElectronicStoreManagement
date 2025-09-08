using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estore
{
    public partial class AddSuppliersForm : Form
    {
        private int id_redact = 0;
        private MainForm mainForm;
        public AddSuppliersForm(MainForm mForm, int id)
        {
            InitializeComponent();
            id_redact = id;
            mainForm = mForm;
            if (id != 0)
            {
                btnAdd.Text = "Изменить";
                this.Text = $"Редактирование поставщика #{id}";
                try
                {

                    connection.Open();
                    string query = "SELECT Название, Адрес, Телефон FROM Поставщики WHERE id_поставщика = " + id;
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string supplierName = reader.GetString(0);
                            string supplierAddress = reader.GetString(1);
                            string supplierPhone = reader.GetString(2);
                            textName.Text = supplierName;
                            textAddress.Text = supplierAddress;
                            textPhone.Text = supplierPhone;
                        }
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке поставщика: " + ex.Message);
                }
            }
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDb)\LocalDBDemo;Initial Catalog=Estore;Integrated Security=True;");
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddSuppliersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textName.Text))
            {
                MessageBox.Show("Введите имя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (string.IsNullOrEmpty(textAddress.Text))
            {
                MessageBox.Show("Введите адрес", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            // Проверяем наличие данных в поле textPhone
            if (string.IsNullOrEmpty(textPhone.Text))
            {
                MessageBox.Show("Введите номер телефона", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            string name = textName.Text;
            string address = textAddress.Text;
            string phone = textPhone.Text;
            if (id_redact != 0)
            {
                  string queryalter = @"
        UPDATE Поставщики
        SET Название = @Название,
            Адрес = @Адрес,
            Телефон = @Телефон
        WHERE id_поставщика = @id_поставщика";

                 using (SqlCommand command = new SqlCommand(queryalter, connection))
                {
                    try
                    {
                        connection.Open();

                        command.Parameters.AddWithValue("@Название", name);
                        command.Parameters.AddWithValue("@Адрес", address);
                        command.Parameters.AddWithValue("@Телефон", phone);
                        command.Parameters.AddWithValue("@id_поставщика", id_redact);

                        int rowsAffected = command.ExecuteNonQuery();

                        MessageBox.Show($"Изменено {rowsAffected} строк в таблице Поставщики.");
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: " + ex.Message);
                    }
                }
                mainForm.showTableSuppliers();

                Close();
                return;
            }
            string query = "INSERT INTO Поставщики (Название, Адрес, Телефон) VALUES (@Name, @Address, @Phone)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@Phone", phone);

                    int rowsAffected = command.ExecuteNonQuery();

                    MessageBox.Show($"Добавлено {rowsAffected} строк в таблицу Поставщики.");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
            mainForm.showTableSuppliers();
            Close();
        }

        private void textPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                 e.Handled = true;
            }
        }

        private void AddSuppliersForm_Load(object sender, EventArgs e)
        {

        }
    }
}

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
using static Estore.AddProductsForm;

namespace Estore
{
    public partial class AddUsersForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDb)\LocalDBDemo;Initial Catalog=Estore;Integrated Security=True;");
        private MainForm mainForm;
        private int id_redact = 0;
        public AddUsersForm(MainForm mForm, int id)
        {
            InitializeComponent();
            comboStatus.SelectedIndex = 0;
            mainForm = mForm;
            id_redact = id;
            if (id != 0)
            {
                btnAdd.Text = "Изменить";
                this.Text = $"Редактирование польз. #{id}";
                try
                {

                    connection.Open();
                    string query = "SELECT Имя, Фамилия, ЭлектроннаяПочта, Телефон, Адрес, Логин, Пароль FROM Клиенты WHERE id_клиента = " + id;
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string userName = reader.GetString(0);
                            string userSurname = reader.GetString(1);
                            string userEmail = reader.GetString(2);
                            string userPhone = reader.GetString(3);
                            string userAddress = reader.GetString(4);
                            string userLogin = reader.GetString(5);
                            string userPassword = reader.GetString(6);
                            textName.Text = userName;
                            textSurname.Text = userSurname;
                            textMail.Text = userEmail;
                            textPhone.Text = userPhone;
                            textAddress.Text = userAddress;
                            textLogin.Text = userLogin;
                            textPassword.Text = userPassword;
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

        private void textAddress_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void AddUsersForm_FormClosing(object sender, FormClosingEventArgs e)
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
            if (string.IsNullOrEmpty(textSurname.Text))
            {
                MessageBox.Show("Введите фамилию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textMail.Text))
            {
                MessageBox.Show("Введите почту", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textPhone.Text))
            {
                MessageBox.Show("Введите телефон", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textAddress.Text))
            {
                MessageBox.Show("Введите адрес", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textLogin.Text))
            {
                MessageBox.Show("Введите логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textPassword.Text))
            {
                MessageBox.Show("Введите пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string name = textName.Text;
            string surname = textSurname.Text;
            string mail = textMail.Text;
            string phone = textPhone.Text;
            string address = textAddress.Text;
            string login = textLogin.Text;
            string password = textPassword.Text;
            string status = comboStatus.Text;
            if (id_redact != 0)
            {
                string queryalter = @"
            UPDATE Клиенты
            SET Имя = @Имя,
                Фамилия = @Фамилия,
                ЭлектроннаяПочта = @ЭлектроннаяПочта,
                Телефон = @Телефон,
                Адрес = @Адрес,
                Логин = @Логин,
                Пароль = @Пароль,
                Статус = @Статус
            WHERE id_клиента = @id_клиента";
                using (SqlCommand command = new SqlCommand(queryalter, connection))
                {
                    try
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@Имя", name);
                        command.Parameters.AddWithValue("@Фамилия", surname);
                        command.Parameters.AddWithValue("@ЭлектроннаяПочта", mail);
                        command.Parameters.AddWithValue("@Телефон", phone);
                        command.Parameters.AddWithValue("@Адрес", address);
                        command.Parameters.AddWithValue("@Логин", login);
                        command.Parameters.AddWithValue("@Пароль", password);
                        command.Parameters.AddWithValue("@Статус", status);
                        command.Parameters.AddWithValue("@id_клиента", id_redact);

                         int rowsAffected = command.ExecuteNonQuery();

                        MessageBox.Show($"Изменено {rowsAffected} строк в таблице Клиенты.");
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: " + ex.Message);
                    }
                }
                mainForm.showTableUsers();
                Close();
                return;
            }
            string query = "INSERT INTO Клиенты (Имя, Фамилия, ЭлектроннаяПочта, Телефон, Адрес, Логин, Пароль, Статус) VALUES (@Name, @Surname, @Mail, @Phone, @Address, @Login, @Password, @Status);";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Surname", surname);
                    command.Parameters.AddWithValue("@Mail", mail);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Status", status);

                    int rowsAffected = command.ExecuteNonQuery();

                    MessageBox.Show($"Добавлено {rowsAffected} строк в таблицу Товары.");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
            mainForm.showTableUsers();
            Close();


        }

        private void textPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

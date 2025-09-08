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
    public partial class LoginForm : Form
    {
        private string connectionStr = @"Data Source=(LocalDb)\LocalDBDemo;Initial Catalog=Estore;Integrated Security=True;";
        public LoginForm()
        {
            InitializeComponent();
            this.FormClosed += LoginForm_FormClosed;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string login = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (ValidateUser(login, password, out int userId, out int userStatus))
            {

                MainForm mainForm = new MainForm(userId, userStatus);


                this.Hide();

                mainForm.FormClosed += (s, args) => Application.Exit();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.");
            }

        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();

            this.Hide();

            registrationForm.FormClosed += (s, args) => Application.Exit();
            registrationForm.Show();
        }

        private bool ValidateUser(string login, string password, out int userId, out int userStatus)
        {
            userId = 0;
            userStatus = 0;

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT id_клиента, Пароль, Статус FROM Клиенты WHERE Логин = @login";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@login", login);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string storedPassword = reader.GetString(1);
                                string status = reader.GetString(2);

                                if (password == storedPassword)
                                {
                                    userId = id;
                                    userStatus = status switch
                                    {
                                        "adm" => 1,
                                        "pers" => 2,
                                        "client" => 3,
                                        _ => 0
                                    };
                                    return true;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при подключении к базе данных: " + ex.Message);
                }
            }

            return false;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace Estore
{
    public partial class RegistrationForm : Form
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDb)\LocalDBDemo;Initial Catalog=Estore;Integrated Security=True;");
        public RegistrationForm()
        {
            InitializeComponent();
            this.FormClosed += RegistrationForm_FormClosed;
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Введите имя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(surnameTextBox.Text))
            {
                MessageBox.Show("Введите фамилию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(emailTextBox.Text))
            {
                MessageBox.Show("Введите почту", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(phoneTextBox.Text))
            {
                MessageBox.Show("Введите телефон", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(addressTextBox.Text))
            {
                MessageBox.Show("Введите адрес", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(usernameTextBox.Text))
            {
                MessageBox.Show("Введите логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show("Введите пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string name = nameTextBox.Text;
            string surname = surnameTextBox.Text;
            string mail = emailTextBox.Text;
            string phone = phoneTextBox.Text;
            string address = addressTextBox.Text;
            string login = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string query = "INSERT INTO Клиенты (Имя, Фамилия, ЭлектроннаяПочта, Телефон, Адрес, Логин, Пароль, Статус) VALUES (@Name, @Surname, @Mail, @Phone, @Address, @Login, @Password, 'client');";
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

                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show("Вы успешно зарегистрировались!");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                    connection.Close();
                    return;
                }
            }

            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();

        }

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}

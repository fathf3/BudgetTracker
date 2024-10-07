using System.Data;
using System.Data.SqlClient;


namespace BudgetTracker
{
    public partial class Form1 : Form
    {
        private readonly string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\F3\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";

        public Form1()
        {
            InitializeComponent();
        }


        public static string username;

        private void button1_Click(object sender, EventArgs e)
        {

            if (login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("Lutfen boş olan bolumlerı doldurunuz!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();
                string selectData = "Select * from users where username = @usern and password = @pass";

                using (SqlCommand command = new SqlCommand(selectData, connection))
                {
                    command.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                    command.Parameters.AddWithValue("@pass", login_password.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    if(table.Rows.Count > 0)
                    {
                            username = login_username.Text;
                        MessageBox.Show("Giriş başaralı", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information );
                        MainForm mainForm = new MainForm();
                            mainForm.Show();
                            this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Giriş hatalı", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = (login_show_password.Checked) ? '\0' : '*';
        }

       

        private void login_registerBtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();

            this.Hide();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

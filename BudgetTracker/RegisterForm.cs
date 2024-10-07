using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace BudgetTracker
{

    public partial class RegisterForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\F3\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30");


        public RegisterForm()
        {
            InitializeComponent();
        }

        public bool checkConnection()
        {
            return (connection.State == ConnectionState.Closed) ? true : false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_show_password.Checked ? '\0' : '*';
            register_password_again.PasswordChar = register_show_password.Checked ? '\0' : '*';
        }

        private void register_loginBtn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Hide();
        }

        private void close_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_signUpBtn_Click(object sender, EventArgs e)
        {
            if (register_username.Text == "" || register_password.Text == "" || register_password_again.Text == "")
            {
                MessageBox.Show("Lutfen kullanıcı adı ve şifre alanlarını doldurunuz!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connection.Open();
                        string selectUsername = "Select * from users Where username = @usern";
                        using (SqlCommand checkUser = new SqlCommand(selectUsername, connection))
                        {
                            checkUser
                                .Parameters
                                .AddWithValue("@usern", register_username.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();

                            if (table.Rows.Count != 0)
                            {
                                string tempUsern = register_username
                                    .Text.Substring(0, 1)
                                    .ToUpper() + register_username
                                    .Text
                                    .Substring(1);
                                MessageBox.Show(tempUsern + " bu kullanıcı adı mevcut", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (register_password.Text != register_password_again.Text)
                            {
                                MessageBox.Show("Şifreler aynı degil", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "Insert into users(username, password, date_create) values(@usern,@pass, @date)";
                                using (SqlCommand insertUser = new SqlCommand(insertData, connection))
                                {
                                    insertUser.Parameters.AddWithValue(@"usern", register_username.Text.Trim());
                                    insertUser.Parameters.AddWithValue(@"pass", register_password.Text.Trim());
                                    DateTime today = DateTime.Now;
                                    insertUser.Parameters.AddWithValue(@"date", today);
                                    insertUser.ExecuteNonQuery();
                                    MessageBox.Show("Kayıt Başarılı", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 loginForm = new Form1();
                                    loginForm.Show();
                                    this.Hide();


                                }
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bağlantı Hatası: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {

                    }
                }
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}

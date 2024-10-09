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
using System.Data;
using System.Data.SqlClient;
using BudgetTracker.Entities;
using BudgetTracker.DataAccess;

namespace BudgetTracker
{
    public partial class ExpensesForm : UserControl
    {

		private readonly string stringConnection = DbBaglanti.connectionString;
		public ExpensesForm()
        {
            InitializeComponent();
            displayExpensesList();
            displayCategoryList();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayExpensesList();
            displayCategoryList();
        }
        public void displayExpensesList()
        {
            ExpensesData data = new ExpensesData();
            List<ExpensesData> list = data.expensesListData();
            dataGridView1.DataSource = list;

        }

        public void displayCategoryList()
        {
            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                conn.Open();
                string selectData = "Select name from categories where type= @type and status = @status";
                using (SqlCommand cmd = new SqlCommand(selectData, conn))
                {
                    cmd.Parameters.AddWithValue("@type", "Gider");
                    cmd.Parameters.AddWithValue("@status", "Aktif");

                    expenses_category.Items.Clear();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        expenses_category.Items.Add(reader["name"].ToString());
                    }

                }
                conn.Close();
            }
        }


        private void expenses_addBtn_Click(object sender, EventArgs e)
        {
            if (expenses_category.SelectedIndex == -1 ||
                expenses_item.Text == "" ||
                expenses_expenses.Text == "" ||
                expenses_description.Text == "")
            {
                MessageBox.Show("Lutfen boş alanları doldurunuz.!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(stringConnection))
                {
                    conn.Open();
                    string insertData = "INSERT INTO expenses (category, item, expenses, description, date_insert ,date_expense) VALUES " +
                        "(@cat, @item, @expenses, @desc, @date_insert, @date_expense)";

                    using (SqlCommand cmd = new SqlCommand(insertData, conn))
                    {
                        cmd.Parameters.AddWithValue("@cat", expenses_category.SelectedItem);
                        cmd.Parameters.AddWithValue("@item", expenses_item.Text);
                        cmd.Parameters.AddWithValue("@expenses", expenses_expenses.Text);
                        cmd.Parameters.AddWithValue("@desc", expenses_description.Text);

                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@date_insert", today);

                        cmd.Parameters.AddWithValue("@date_expense", expenses_date.Value);
                        cmd.ExecuteNonQuery();
                        clearFields();
                        MessageBox.Show("Ekleme başarılı", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


                    displayExpensesList();
                    conn.Close();
                }
            }
        }
        public void clearFields()
        {
            expenses_item.Text = "";
            expenses_category.SelectedIndex = -1;
            expenses_description.Text = "";
            expenses_expenses.Text = "";
        }
        private void expenses_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
        private void expenses_updateBtn_Click(object sender, EventArgs e)
        {
            if (expenses_category.SelectedIndex == -1 ||
                expenses_item.Text == "" ||
                expenses_expenses.Text == "" ||
                expenses_description.Text == "")
            {
                MessageBox.Show("Lutfen Tablodan 1 item seçiniz.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Veriyi Güncellemek İstiyormusunuz ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(stringConnection))
                    {
                        conn.Open();
                        string insertData = "Update expenses set category = @cat, item = @item, expenses = @expenses, description = @desc, date_expense= @date_expense where id = @id";

                        using (SqlCommand cmd = new SqlCommand(insertData, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", getId);
                            cmd.Parameters.AddWithValue("@cat", expenses_category.SelectedItem);
                            cmd.Parameters.AddWithValue("@item", expenses_item.Text);
                            cmd.Parameters.AddWithValue("@expenses", expenses_expenses.Text);
                            cmd.Parameters.AddWithValue("@desc", expenses_description.Text);
                            cmd.Parameters.AddWithValue("@date_expense", expenses_date.Value);

                            cmd.ExecuteNonQuery();
                            clearFields();
                            MessageBox.Show("Ekleme başarılı", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }


                        displayExpensesList();
                        conn.Close();
                    }
                }
            }
        }
        private int getId = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                getId = (int)row.Cells[0].Value;
                expenses_category.SelectedItem = row.Cells[1].Value.ToString();
                expenses_item.Text = row.Cells[2].Value.ToString();
                expenses_expenses.Text = row.Cells[3].Value.ToString();
                expenses_description.Text = row.Cells[4].Value.ToString();
                expenses_date.Value = Convert.ToDateTime(row.Cells[5].Value.ToString());
            }
        }

        private void expenses_deleteBtn_Click(object sender, EventArgs e)
        {
            if (expenses_category.SelectedIndex == -1 ||
               expenses_item.Text == "" ||
               expenses_expenses.Text == "" ||
               expenses_description.Text == "")
            {
                MessageBox.Show("Lutfen Tablodan 1 item seçiniz.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Veriyi Silmek İstiyormusunuz ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(stringConnection))
                    {
                        connection.Open();

                        string insertData = "Delete From expenses where id = @id";

                        using (SqlCommand command = new SqlCommand(insertData, connection))
                        {
                            command.Parameters.AddWithValue("@id", getId);
                            command.ExecuteNonQuery();
                            clearFields();
                            MessageBox.Show("Veri Silindi", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        connection.Close();
                    }
                }
            }
            displayExpensesList();
        }

      
    }
}
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
using BudgetTracker.Entities;
using BudgetTracker.DataAccess;

namespace BudgetTracker
{
    public partial class IncomeForm : UserControl
    {
		private readonly string stringConnection = DbBaglanti.connectionString;
		public IncomeForm()
        {
            InitializeComponent();
            displayCategoryList();
            displayIncomeList();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayCategoryList();
            displayIncomeList();
        }
        public void displayIncomeList()
        {
            IncomeData data = new IncomeData();
            List<IncomeData> list = data.incomeListData();
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
                    cmd.Parameters.AddWithValue("@type", "Gelir");
                    cmd.Parameters.AddWithValue("@status", "Aktif");

                    income_category.Items.Clear();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        income_category.Items.Add(reader["name"].ToString());
                    }

                }
                conn.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void income_addBtn_Click(object sender, EventArgs e)
        {
            if (income_category.SelectedIndex == -1 ||
                income_item.Text == "" ||
                income_income.Text == "" ||
                income_description.Text == "")
            {
                MessageBox.Show("Lutfen boş alanları doldurunuz.!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(stringConnection))
                {
                    conn.Open();
                    string insertData = "INSERT INTO income (category, item, income, description, date_insert ,date_income) VALUES " +
                        "(@cat, @item, @income, @desc, @date_insert, @date_income)";

                    using (SqlCommand cmd = new SqlCommand(insertData, conn))
                    {
                        cmd.Parameters.AddWithValue("@cat", income_category.SelectedItem);
                        cmd.Parameters.AddWithValue("@item", income_item.Text);
                        cmd.Parameters.AddWithValue("@income", income_income.Text);
                        cmd.Parameters.AddWithValue("@desc", income_description.Text);

                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@date_insert", today);

                        cmd.Parameters.AddWithValue("@date_income", income_date.Value);
                        cmd.ExecuteNonQuery();
                        clearFields();
                        MessageBox.Show("Ekleme başarılı", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


                    displayIncomeList();
                    conn.Close();
                }
            }
        }

        public void clearFields()
        {
            income_item.Text = "";
            income_category.SelectedIndex = -1;
            income_description.Text = "";
            income_income.Text = "";
        }
        private void income_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void income_updateBtn_Click(object sender, EventArgs e)
        {
            if (income_category.SelectedIndex == -1 ||
                income_item.Text == "" ||
                income_income.Text == "" ||
                income_description.Text == "")
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
                        string insertData = "Update income set category = @cat, item = @item, income = @income, description = @desc, date_income= @date_income where id = @id";

                        using (SqlCommand cmd = new SqlCommand(insertData, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", getId);
                            cmd.Parameters.AddWithValue("@cat", income_category.SelectedItem);
                            cmd.Parameters.AddWithValue("@item", income_item.Text);
                            cmd.Parameters.AddWithValue("@income", income_income.Text);
                            cmd.Parameters.AddWithValue("@desc", income_description.Text);
                            cmd.Parameters.AddWithValue("@date_income", income_date.Value);

                            cmd.ExecuteNonQuery();
                            clearFields();
                            MessageBox.Show("Ekleme başarılı", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }


                        displayIncomeList();
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
                income_category.SelectedItem = row.Cells[1].Value.ToString();
                income_item.Text = row.Cells[2].Value.ToString();
                income_income.Text = row.Cells[3].Value.ToString();
                income_description.Text = row.Cells[4].Value.ToString();
                income_date.Value = Convert.ToDateTime(row.Cells[5].Value.ToString());
            }
        }

        private void income_deleteBtn_Click(object sender, EventArgs e)
        {
            if (income_category.SelectedIndex == -1 ||
               income_item.Text == "" ||
               income_income.Text == "" ||
               income_description.Text == "")
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

                        string insertData = "Delete From income where id = @id";

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
            displayIncomeList();
        }
    }
}

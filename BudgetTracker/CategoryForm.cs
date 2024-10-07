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


namespace BudgetTracker
{
    public partial class CategoryForm : UserControl
    {
        private readonly string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\F3\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";
        public CategoryForm()
        {
            InitializeComponent();
            displayCategoryList();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayCategoryList();
        }

        public void displayCategoryList()
        {
            CategoryData categoryData = new CategoryData();
            List<CategoryData> categoryDatas = categoryData.categoryListData();

            dataGridView1.DataSource = categoryDatas;
            
        }






        private void category_addBtn_Click(object sender, EventArgs e)
        {
            if (category_category.Text == "" || category_type.SelectedIndex == -1 || category_status.SelectedIndex == -1)
            {
                MessageBox.Show("Boş alanları lütfen dolurun!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    connection.Open();

                    string insertData = "Insert into categories (name, type, status, date_insert) values(@name, @type, @status, @date_insert)";

                    using (SqlCommand command = new SqlCommand(insertData, connection))
                    {
                        command.Parameters.AddWithValue("@name", category_category.Text.Trim());
                        command.Parameters.AddWithValue("@type", category_type.SelectedItem);
                        command.Parameters.AddWithValue("@status", category_status.SelectedItem);
                        DateTime today = DateTime.Today;
                        command.Parameters.AddWithValue("@date_insert", today);
                        command.ExecuteNonQuery();
                        clearFields();
                        MessageBox.Show("Yeni Kategori Eklendi", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    displayCategoryList();
                    connection.Close();
                }
            }
        }

        private int getId = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getId = Convert.ToInt32(row.Cells[0].Value);
                category_category.Text = row.Cells[1].Value.ToString();
                category_status.SelectedItem = row.Cells[2].Value.ToString();
                category_type.SelectedItem = row.Cells[3].Value.ToString();

            }
        }

        private void category_updateBtn_Click(object sender, EventArgs e)
        {
            if (category_category.Text == "" || category_type.SelectedIndex == -1 || category_status.SelectedIndex == -1)
            {
                MessageBox.Show("Kategori Seçilmedi", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Kategori Güncellemek İstiyormusunuz ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    using (SqlConnection connection = new SqlConnection(stringConnection))
                    {
                        connection.Open();

                        string insertData = "Update categories SET name = @name, type = @type, status =@status where id = @id";

                        using (SqlCommand command = new SqlCommand(insertData, connection))
                        {
                            command.Parameters.AddWithValue("@id", getId);
                            command.Parameters.AddWithValue("@name", category_category.Text.Trim());
                            command.Parameters.AddWithValue("@type", category_type.SelectedItem);
                            command.Parameters.AddWithValue("@status", category_status.SelectedItem);

                            command.ExecuteNonQuery();
                            clearFields();
                            MessageBox.Show("Kategori Güncellendi", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        connection.Close();
                    }

                }
            }
            displayCategoryList();
        }

        public void clearFields()
        {
            category_category.Text = "";
            category_status.SelectedIndex = -1;
            category_type.SelectedIndex = -1;

        }

        private void category_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void category_deleteBtn_Click(object sender, EventArgs e)
        {
            if (category_category.Text == "" || category_type.SelectedIndex == -1 || category_status.SelectedIndex == -1)
            {
                MessageBox.Show("Kategori Seçilmedi", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Kategori Silmek İstiyormusunuz ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    using (SqlConnection connection = new SqlConnection(stringConnection))
                    {
                        connection.Open();

                        string insertData = "Delete From categories where id = @id";

                        using (SqlCommand command = new SqlCommand(insertData, connection))
                        {
                            command.Parameters.AddWithValue("@id", getId);
                            command.ExecuteNonQuery();
                            clearFields();
                            MessageBox.Show("Kategori Silindi", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        connection.Close();
                    }

                }
            }
            displayCategoryList();
        }
    }
}

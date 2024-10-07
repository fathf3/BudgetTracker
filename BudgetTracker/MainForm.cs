using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetTracker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            displayUsername();
        }

        public void displayUsername()
        {
            string getUsername = Form1.username;
            dashboard_username.Text = getUsername.Substring(0, 1).ToUpper() + getUsername.Substring(1);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Programı Kapatmak istiyormusun ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = true;
            categoryForm1.Visible = false;
            expensesForm1.Visible = false;
            ıncomeForm1.Visible = false;
            DashboardForm dForm = dashboardForm1 as DashboardForm;
            if(dForm != null )
            {
                dForm.refreshData();
            }
        }

        private void category_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            categoryForm1.Visible = true;
            expensesForm1.Visible = false;
            ıncomeForm1.Visible = false;
            CategoryForm cForm = categoryForm1 as CategoryForm;
            if (cForm != null)
            {
                cForm.refreshData();
            }
        }

        private void income_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            categoryForm1.Visible = false;
            expensesForm1.Visible = false;
            ıncomeForm1.Visible = true;

            IncomeForm dForm = ıncomeForm1 as IncomeForm;
            if (dForm != null)
            {
                dForm.refreshData();
            }
        }

        private void expense_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            categoryForm1.Visible = false;
            expensesForm1.Visible = true;
            ıncomeForm1.Visible = false;

            ExpensesForm dForm = expensesForm1 as ExpensesForm;
            if (dForm != null)
            {
                dForm.refreshData();
            }
        }
    }
}

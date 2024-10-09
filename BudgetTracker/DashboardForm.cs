using System;
using System.Collections;
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
using BudgetTracker.DataAccess;
namespace BudgetTracker
{
	public partial class DashboardForm : UserControl
	{
		private readonly string stringConnection = DbBaglanti.connectionString;
		public DashboardForm()
		{


			InitializeComponent();
			// Incomes
			todayIncome();
			yesterdayIncome();
			thisMonthIncome();
			thisYearIncome();

			// Expenses
			todayExpenses();
			yesterdayExpenses();
			thisMonthExpenses();
			thisYearExpenses();

			// Total
			totalIncome();
			totalExpenses();
		}


		public void refreshData()
		{
			if (InvokeRequired)
			{
				Invoke((MethodInvoker)refreshData);
				return;
			}
			todayIncome();
			yesterdayIncome();
			thisMonthIncome();
			thisYearIncome();

			// Expenses
			todayExpenses();
			yesterdayExpenses();
			thisMonthExpenses();
			thisYearExpenses();

			// Total
			totalIncome();
			totalExpenses();
		}

		// Incomes
		public void todayIncome()
		{
			using (SqlConnection conn = new SqlConnection(stringConnection))
			{
				
				conn.Open();

				string query = "Select Sum(income) from income where date_income = @date_in";
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					DateTime today = DateTime.Today;
					cmd.Parameters.AddWithValue("@date_in", today);

					object result = cmd.ExecuteScalar();
					if (result != DBNull.Value)
					{
						decimal todayCost = Convert.ToDecimal(result);
						dashboard_today_income.Text = todayCost.ToString("C");
					}
					else
					{
						dashboard_today_income.Text = "0.00 ₺";
					}
				}
			}
		}
		public void yesterdayIncome()
		{

			using (SqlConnection conn = new SqlConnection(stringConnection))
			{
				conn.Open();
				string query = "Select sum(income) from income where Convert(Date, date_income) = Dateadd(day, Datediff(day, 0, GetDate()), -1)";

				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					object result = cmd.ExecuteScalar();
					if (result != DBNull.Value)
					{
						decimal yesterdayCost = Convert.ToDecimal(result);
						dashboard_yesterday_income.Text = yesterdayCost.ToString("C");
					}
					else
					{
						dashboard_yesterday_income.Text = "0.00 ₺";
					}
				}
			}
		}
		public void thisMonthIncome()
		{
			using (SqlConnection conn = new SqlConnection(stringConnection))
			{
				conn.Open();

				DateTime today = DateTime.Now.Date;
				DateTime startMonth = new DateTime(today.Year, today.Month, 1);
				DateTime endMonth = startMonth.AddMonths(1).AddDays(-1);

				string query = "Select Sum(income) from income where date_income >= @startMonth and date_income <= @endMonth";

				using (SqlCommand cmd = new SqlCommand(query, conn))
				{

					cmd.Parameters.AddWithValue("@startMonth", startMonth);
					cmd.Parameters.AddWithValue("@endMonth", endMonth);

					object result = cmd.ExecuteScalar();
					if (result != DBNull.Value)
					{
						decimal monthCost = Convert.ToDecimal(result);

						dashboard_month_income.Text = monthCost.ToString("C");
					}
					else
					{
						dashboard_month_income.Text = "0.00 ₺";
					}
				}
			}
		}
		public void thisYearIncome()
		{
			using (SqlConnection conn = new SqlConnection(stringConnection))
			{
				conn.Open();
				DateTime today = DateTime.Now.Date;
				DateTime startYear = new DateTime(today.Year, 1, 1);
				DateTime endYear = startYear.AddYears(1).AddDays(-1);

				string query = "Select Sum(income) from income where date_income >= @startYear and date_income <= @endYear";
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{

					cmd.Parameters.AddWithValue("@startYear", startYear);
					cmd.Parameters.AddWithValue("@endYear", endYear);

					object result = cmd.ExecuteScalar();
					if (result != DBNull.Value)
					{
						decimal yearCost = Convert.ToDecimal(result);
						dashboard_year_income.Text = yearCost.ToString("C");
					}
					else
					{
						dashboard_year_income.Text = "0.00 ₺";
					}
				}
			}
		}

		// Expenses
		public void todayExpenses()
		{
			using (SqlConnection conn = new SqlConnection(stringConnection))
			{
				conn.Open();

				string query = "Select Sum(expenses) from expenses where date_expense = @date_in";
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					DateTime today = DateTime.Today;
					cmd.Parameters.AddWithValue("@date_in", today);

					object result = cmd.ExecuteScalar();
					if (result != DBNull.Value)
					{
						decimal todayCost = Convert.ToDecimal(result);
						dashboard_today_expense.Text = todayCost.ToString("C");
					}
					else
					{
						dashboard_today_expense.Text = "0.00 ₺";
					}
				}
			}
		}
		public void yesterdayExpenses()
		{

			using (SqlConnection conn = new SqlConnection(stringConnection))
			{
				conn.Open();
				string query = "Select sum(expenses) from expenses where Convert(Date, date_expense) = Dateadd(day, Datediff(day, 0, GetDate()), -1)";

				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					object result = cmd.ExecuteScalar();
					if (result != DBNull.Value)
					{
						decimal yesterdayCost = Convert.ToDecimal(result);
						dashboard_yesterday_expense.Text = yesterdayCost.ToString("C");
					}
					else
					{
						dashboard_yesterday_expense.Text = "0.00 ₺";
					}
				}
			}
		}
		public void thisMonthExpenses()
		{
			using (SqlConnection conn = new SqlConnection(stringConnection))
			{
				conn.Open();

				DateTime today = DateTime.Now.Date;
				DateTime startMonth = new DateTime(today.Year, today.Month, 1);
				DateTime endMonth = startMonth.AddMonths(1).AddDays(-1);

				string query = "Select Sum(expenses) from expenses where date_expense >= @startMonth and date_expense <= @endMonth";

				using (SqlCommand cmd = new SqlCommand(query, conn))
				{

					cmd.Parameters.AddWithValue("@startMonth", startMonth);
					cmd.Parameters.AddWithValue("@endMonth", endMonth);

					object result = cmd.ExecuteScalar();
					if (result != DBNull.Value)
					{
						decimal monthCost = Convert.ToDecimal(result);

						dashboard_month_expense.Text = monthCost.ToString("C");
					}
					else
					{
						dashboard_month_expense.Text = "0.00 ₺";
					}
				}
			}
		}
		public void thisYearExpenses()
		{
			using (SqlConnection conn = new SqlConnection(stringConnection))
			{
				conn.Open();
				DateTime today = DateTime.Now.Date;
				DateTime startYear = new DateTime(today.Year, 1, 1);
				DateTime endYear = startYear.AddYears(1).AddDays(-1);

				string query = "Select Sum(expenses) from expenses where date_expense >= @startYear and date_expense <= @endYear";
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{

					cmd.Parameters.AddWithValue("@startYear", startYear);
					cmd.Parameters.AddWithValue("@endYear", endYear);

					object result = cmd.ExecuteScalar();
					if (result != DBNull.Value)
					{
						decimal yearCost = Convert.ToDecimal(result);
						dashboard_year_expense.Text = yearCost.ToString("C");
					}
					else
					{
						dashboard_year_expense.Text = "0.00 ₺";
					}
				}
			}
		}

		// Total Income - Expenses
		public void totalIncome()
		{
			using (SqlConnection conn = new SqlConnection(stringConnection))
			{
				conn.Open();

				string query = "Select Sum(income) from income";
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{

					object result = cmd.ExecuteScalar();
					if (result != DBNull.Value)
					{
						decimal totalCost = Convert.ToDecimal(result);
						dashboard_sum_income.Text = totalCost.ToString("C");
					}
					else
					{
						dashboard_sum_income.Text = "0.00 ₺";
					}
				}
			}
		}
		public void totalExpenses()
		{
			using (SqlConnection conn = new SqlConnection(stringConnection))
			{
				conn.Open();

				string query = "Select Sum(expenses) from expenses";
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{

					object result = cmd.ExecuteScalar();
					if (result != DBNull.Value)
					{
						decimal totalCost = Convert.ToDecimal(result);
						dashboard_sum_expenses.Text = totalCost.ToString("C");
					}
					else
					{
						dashboard_sum_expenses.Text = "0.00 ₺";
					}
				}
			}
		}

		private void dashboard_yesterday_expense_Click(object sender, EventArgs e)
		{

		}
	}
}


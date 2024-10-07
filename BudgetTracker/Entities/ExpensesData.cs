using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker.Entities
{
    public class ExpensesData
    {
        private readonly string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\F3\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";

        public int Id { get; set; }
        public string Kategori { get; set; }
        public string Item { get; set; }
        public string Gider { get; set; }
        public string Aciklama { get; set; }
        public string Tarih { get; set; }



        public List<ExpensesData> expensesListData()
        {
            var listData = new List<ExpensesData>();
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();
                string selectData = "Select *  from expenses";
                using (SqlCommand command = new SqlCommand(selectData, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ExpensesData iData = new ExpensesData();
                        iData.Id = (int)reader["id"];
                        iData.Kategori = reader["category"].ToString();
                        iData.Item = reader["item"].ToString();
                        iData.Gider = reader["expenses"].ToString();
                        iData.Aciklama = reader["description"].ToString();
                        iData.Tarih = ((DateTime)reader["date_expense"]).ToString("dd-MM-yyyy");


                        listData.Add(iData);
                    }
                }

            }

            return listData;
        }
    }
}
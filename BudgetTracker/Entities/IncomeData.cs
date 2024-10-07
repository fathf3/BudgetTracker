using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BudgetTracker.Entities
{
    public class IncomeData
    {
        private readonly string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\F3\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";

        public int Id { get; set; }
        public string Kategori { get; set; }
        public string Item { get; set; }
        public string Gelir { get; set; }
        public string Aciklama { get; set; }
        public string Tarih { get; set; }



        public List<IncomeData> incomeListData()
        {
            var listData = new List<IncomeData>();
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();
                string selectData = "Select *  from income";
                using (SqlCommand command = new SqlCommand(selectData, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        IncomeData iData = new IncomeData();
                        iData.Id = (int)reader["id"];
                        iData.Kategori = reader["category"].ToString();
                        iData.Item = reader["item"].ToString();
                        iData.Gelir = reader["income"].ToString();
                        iData.Aciklama = reader["description"].ToString();
                        iData.Tarih = ((DateTime)reader["date_income"]).ToString("dd-MM-yyyy");


                        listData.Add(iData);
                    }
                }

            }

            return listData;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BudgetTracker.Entities
{
    public class CategoryData
    {
        private readonly string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\F3\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";
       
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string Date { get; set; }

        public List<CategoryData> categoryListData()
        {
            var listData = new List<CategoryData>();
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();
                string selectData = "Select * from categories";
                using(SqlCommand command = new SqlCommand(selectData, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        CategoryData cData  = new CategoryData();
                        cData.Id = (int)reader["id"];
                        cData.Name = reader["name"].ToString();
                        cData.Status = reader["status"].ToString();
                        cData.Type = reader["type"].ToString();
                        cData.Date = ((DateTime)reader["date_insert"]).ToString("dd-MM-yyyy");


                        listData.Add(cData);
                    }
                }

            }

            return listData;
        }
    }
}

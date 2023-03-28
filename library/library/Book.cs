using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    internal class Book
    {
        public static void AddBook(string book_name, int genre_id, string book_publisher)
        {
            string connectionString = "Data Source=library-kckc.mssql.somee.com;Initial Catalog=library-kckc;User ID=kacprodyl_SQLLogin_1;Password=ybqwxa2m4h;";
            string tableName = "Book";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var adapter = new SqlDataAdapter($"SELECT * FROM {tableName}", connection);
                var builder = new SqlCommandBuilder(adapter);
                DataTable table = new DataTable();
                adapter.Fill(table);

                var newRow = table.NewRow();
                newRow["name"] = book_name;
                newRow["id_genre"] = genre_id;
                newRow["publisher"] = book_publisher;
                table.Rows.Add(newRow);

                adapter.Update(table);
            }

        }
    }
}

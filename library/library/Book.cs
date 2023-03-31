using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;
using System.Windows.Forms;

namespace library
{
    internal class Book
    {
        public string Name { get; set; }
        public int GenreId { get; set; }
        public string Publisher { get; set; }
        public string Author { get; set; }
        public int Quantity { get; set; }
        public DateTime ReleaseDate { get; set; }


        public Book(string name, int genreId, string publisher, string author, int quantity, DateTime releaseDate)
        {
            Name = name;
            GenreId = genreId;
            Publisher = publisher;
            Author = author;
            Quantity = quantity;
            ReleaseDate = releaseDate;
        }
        public void AddBook()
        {
            var connection = new SqlConnection(DbCon.ConnectionString);
            try
            {
                connection.Open();

                var adapter = new SqlDataAdapter("AddBook", connection);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                adapter.SelectCommand.Parameters.AddWithValue("@bookName", Name);
                adapter.SelectCommand.Parameters.AddWithValue("@authorName", Author);
                adapter.SelectCommand.Parameters.AddWithValue("@genreId", GenreId);
                adapter.SelectCommand.Parameters.AddWithValue("@publisherName", Publisher);
                adapter.SelectCommand.Parameters.AddWithValue("@quantity", Quantity);
                adapter.SelectCommand.Parameters.AddWithValue("@releaseDate", ReleaseDate);

                var table = new DataTable();

                adapter.Fill(table);
                adapter.Update(table);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { connection.Close(); }
        }
    }
}

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


        public Book(string name, int genreId, string publisher)
        {
            Name = name;
            GenreId = genreId;
            Publisher = publisher;
        }

        public void AddBook()
            // Add book to DB via adapter
        {
            var connection = new SqlConnection(DbCon.ConnectionString);
            try
            {
                connection.Open();
                var adapter = new SqlDataAdapter("SELECT * FROM Book", connection);
                var builder = new SqlCommandBuilder(adapter);
                var table = new DataTable();
                adapter.Fill(table);

                var newRow = table.NewRow();
                newRow["name"] = Name;
                newRow["id_genre"] = GenreId;
                newRow["publisher"] = Publisher;
                table.Rows.Add(newRow);

                adapter.Update(table);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { connection.Close(); }

        }

        public static void DeleteBookAdapter(int id_book)
            // deleting method with using Adapter (does not working)
        {
            var connection = new SqlConnection(DbCon.ConnectionString);
            
            connection.Open();
            var adapter = new SqlDataAdapter("SELECT * FROM Book", connection);
            var builder = new SqlCommandBuilder(adapter);
            var table = new DataTable();
            adapter.Fill(table);

            var rowToDelete = table.Select($"id_book = {id_book}").FirstOrDefault();
            if (rowToDelete != null)
            {
                table.Rows.Remove(rowToDelete);
                adapter.Update(table);
            }
            connection.Close();
        }
        

        public static void DeleteBook(int id_book)
            // Delete book by id_book from DB
        {
            var connection = new SqlConnection(DbCon.ConnectionString);

            try
            {
                connection.Open();
                var command = new SqlCommand("DELETE FROM Book WHERE id_book = @id_book", connection);
                command.Parameters.AddWithValue("@id_book", id_book);
                command.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { connection.Close(); }
        }
    }
}

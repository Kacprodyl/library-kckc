using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    internal class Copy
        
    {
        public int Quantity { get; set; }
        public int IdBook { get; set; }

        /// <summary>
        /// Constructor for creating a Copy object with a given quantity and book id.
        /// </summary>
        /// <param name="quantity">The quantity of this copy.</param>
        /// <param name="idBook">The id of the book associated with this copy.</param>
        public Copy(int quantity, int idBook)
        {
            Quantity = quantity;
            IdBook = idBook;
        }

        /// <summary>
        /// Constructor for creating a Copy object with a given book id.
        /// </summary>
        /// <param name="idBook">The id of the book associated with this copy.</param>
        public Copy(int idBook)
        {
            IdBook = idBook;
        }

        /// <summary>
        /// Updates the quantity of the copy in the database.
        /// </summary>
        public void QuantityUpdate()
        {
            var connection = new SqlConnection(DbCon.ConnectionString);
            try
            {
                connection.Open();
                var command = new SqlCommand("UPDATE Copy SET quantity = @quantity WHERE id_book = @id_book;", connection);
                command.Parameters.AddWithValue("@id_book", IdBook);
                command.Parameters.AddWithValue("@quantity", Quantity);
                command.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { connection.Close(); }
        }

        /// <summary>
        /// Retrieves the id of a copy associated with this book.
        /// </summary>
        /// <returns>The id of a copy associated with this book, or -1 if not found or an error occurred.</returns>
        public int GetCopyId()
        {
            try
            {
                var adapter = new SqlDataAdapter($"SELECT id_copy FROM Copy where id_book = {IdBook}", DbCon.ConnectionString);
                var dataSet = new DataSet();
                adapter.Fill(dataSet);
                int copyId = (int)dataSet.Tables[0].Rows[0]["id_copy"];
                return copyId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Return an invalid value if no copy id was found or an error occurred
            }
        }

        /// <summary>
        /// Updates the quantity of a copy after it has been rented.
        /// </summary>
        /// <param name="copyId">The id of the copy to update.</param>
        public void UpdateCopyAfterRent(int copyId)
        {
            var connection = new SqlConnection(DbCon.ConnectionString);
            try
            {
                connection.Open();
                var command = new SqlCommand("UPDATE Copy SET quantity = quantity -1 WHERE id_copy = @id_copy;", connection);
                command.Parameters.AddWithValue("@id_copy", copyId);
                command.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { connection.Close(); }
        }
    }
}

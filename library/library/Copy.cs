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

        public Copy(int quantity, int idBook)
        {
            Quantity = quantity;
            IdBook = idBook;
        }

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
    }
}

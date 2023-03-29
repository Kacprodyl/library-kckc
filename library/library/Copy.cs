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
        public DateTime ReleaseDate { get; set; }
        public int IdBook { get; set; }

        public Copy(int quantity, DateTime realeseDate, int idBook)
        {
            Quantity = quantity;
            ReleaseDate = realeseDate;
            IdBook = idBook;
        }

        public void AddCopy()
            // Add copy via adapter
        {
            var connection = new SqlConnection(DbCon.ConnectionString);
            try
            {
                connection.Open();
                var adapter = new SqlDataAdapter("SELECT * FROM Copy", connection);
                var builder = new SqlCommandBuilder(adapter);
                var table = new DataTable();
                adapter.Fill(table);

                var newRow = table.NewRow();
                newRow["quantity"] = Quantity;
                newRow["release_date"] = ReleaseDate;
                newRow["id_book"] = IdBook;

                adapter.Update(table);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { connection.Close(); }
        }
    }
}

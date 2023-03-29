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

        public Copy(int idBook)
        {
            IdBook = idBook;
        }

        public void AddCopy()
        {
            try
            {
                var adapter = new SqlDataAdapter("SELECT * FROM Copy", DbCon.ConnectionString);
                var builder = new SqlCommandBuilder(adapter);
                var table = new DataTable();
                adapter.Fill(table);

                var newRow = table.NewRow();
                newRow["quantity"] = Quantity;
                newRow["release_date"] = ReleaseDate;
                newRow["id_book"] = IdBook;
                table.Rows.Add(newRow);

                adapter.Update(table);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public int GetCopyId(int IdBook)
        {
            try
            {
                var adapter = new SqlDataAdapter($"SELECT id_copy FROM Copy WHERE id_book = {IdBook};", DbCon.ConnectionString);
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
    }
}


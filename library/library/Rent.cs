using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    internal class Rent
    {
        public int IdCopy { get; set;}
        public DateTime RentDate { get; set;}
        public DateTime CompletionDate { get; set;}
        public int IdCustomer { get; set; }
        public int Fee { get; set;}

        public Rent(int idCopy, int idCustomer)
        {
            IdCopy = idCopy;
            IdCustomer = idCustomer;
            
        }

        public void AddRent()
        {
            var connection = new SqlConnection(DbCon.ConnectionString);
            try
            {
                var adapter = new SqlDataAdapter("SELECT * FROM Rent", connection);
                var builder = new SqlCommandBuilder(adapter);
                var table = new DataTable();
                adapter.Fill(table);

                var newRow = table.NewRow();
                newRow["rent_date"] = DateTime.Today;
                newRow["completion_date"] = DateTime.Today;
                newRow["fee"] = 0;
                newRow["id_customer"] = IdCustomer;
                newRow["id_copy"] = IdCopy;
                table.Rows.Add(newRow);

                adapter.Update(table);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void UpdateCopyRent()
        {
            using (var connection = new SqlConnection(DbCon.ConnectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var command = new SqlCommand("INSERT INTO CopyRent (id_rent, id_copy) VALUES (@idRent, @idCopy)", connection, transaction);
                        command.Parameters.AddWithValue("@idRent", GetLastRentId());
                        command.Parameters.AddWithValue("@idCopy", IdCopy);
                        command.ExecuteNonQuery();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception(ex.Message);
                    }
                }
                connection.Close();
            }
        }

        public int GetLastRentId()
        {
            try
            {

                var adapter = new SqlDataAdapter("SELECT TOP 1 id_rent FROM Rent ORDER BY id_rent DESC", DbCon.ConnectionString);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);
                var rentId = (int)dataTable.Rows[0]["id_rent"];
                return rentId;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Return an invalid value if no customer id was found or an error occurred
            }
        }

        public static void DeleteRent(int idRent, int idCopy)
        {
            var connection = new SqlConnection(DbCon.ConnectionString);
            try
            {
                connection.Open();

                var adapter = new SqlDataAdapter("DELETE FROM Rent where id_rent = @id_rent AND id_copy = @id_copy", connection);
                adapter.SelectCommand.Parameters.AddWithValue("@id_rent", idRent);
                adapter.SelectCommand.Parameters.AddWithValue("@id_copy", idCopy);

                var table = new DataTable();
                adapter.Fill(table);
                adapter.Update(table);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { connection.Close(); }
        }

        public static void DeleteCopyRent(int idRent, int idCopy)
        {
            var connection = new SqlConnection(DbCon.ConnectionString);
            try
            {
                connection.Open();

                var adapter = new SqlDataAdapter("DELETE FROM CopyRent where id_rent = @id_rent AND id_copy = @id_copy", connection);
                adapter.SelectCommand.Parameters.AddWithValue("@id_rent", idRent);
                adapter.SelectCommand.Parameters.AddWithValue("@id_copy", idCopy);

                var table = new DataTable();
                adapter.Fill(table);
                adapter.Update(table);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally {connection.Close();}

        }
    }
}

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
        public int IdRent { get; set; }
        public int IdCopy { get; set;}
        public DateTime RentDate { get; set;}
        public int IdCustomer { get; set; }
        public int Fee { get; set;}

        public Rent(int idRent, int idCopy, DateTime rentDate)
        {
            /*
            Constructor for Rent object
            Parameters:
            idRent (int): ID of the rent
            idCopy (int): ID of the copy being rented
            rentDate (DateTime): Date the copy is rented
            */

            IdRent = idRent;
            IdCopy = idCopy;
            RentDate = rentDate;
        }

        public Rent(int idCopy, int idCustomer)
        {
            /*
            Constructor for Rent object
            Parameters:
            idCopy (int): ID of the copy being rented
            idCustomer (int): ID of the customer renting the copy
            */

            IdCopy = idCopy;
            IdCustomer = idCustomer;
            
        }

        public void AddRent()
        {
            /*
            Adds a new rent record to the database
            */

            var connection = new SqlConnection(DbCon.ConnectionString);
            try
            {
                var adapter = new SqlDataAdapter("SELECT * FROM Rent", connection);
                var builder = new SqlCommandBuilder(adapter);
                var table = new DataTable();
                adapter.Fill(table);

                var newRow = table.NewRow();
                newRow["rent_date"] = DateTime.Today;
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
            /*
            Updates the CopyRent table with the current rent record
            */

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
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally { connection.Close(); }
                }
            }
        }

        public int GetLastRentId()
        {
            /*
          Gets the ID of the last added rent record from the Rent table
          Returns:
              int: ID of the last added rent record
          */
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

        public void CompleteRent()
        {
            /*
            This method updates the "Rent" table in the database to mark a rental as completed. It sets the completion date
            and fee for the rental based on how many days it was rented.
            If the rental was rented for more than 89 days, a fee of 100 is charged; otherwise, the fee is 0.
             */
            DateTime completionDate = DateTime.Today;
            TimeSpan span = completionDate.Subtract(RentDate);
            int days = (int)span.TotalDays;

            var connection = new SqlConnection(DbCon.ConnectionString);
            try
            {
                connection.Open();
                if (days > 89)
                {
                    var adapter = new SqlDataAdapter($"UPDATE Rent SET completion_date = '{completionDate.ToString("yyyy-MM-dd")}', fee = {100} WHERE id_rent = @id_rent AND id_copy = @id_copy ", connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@id_rent", IdRent);
                    adapter.SelectCommand.Parameters.AddWithValue("@id_copy", IdCopy);

                    var table = new DataTable();
                    adapter.Fill(table);
                    adapter.Update(table);
                }
                else
                {
                    var adapter = new SqlDataAdapter($"UPDATE Rent SET completion_date = '{completionDate.ToString("yyyy-MM-dd")}', fee = {0} WHERE id_rent = @id_rent AND id_copy = @id_copy ", connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@id_rent", IdRent);
                    adapter.SelectCommand.Parameters.AddWithValue("@id_copy", IdCopy);

                    var table = new DataTable();
                    adapter.Fill(table);
                    adapter.Update(table);
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { connection.Close(); }
        }

        public void DeleteCopyRent()
        {
            /*
             This method deletes a record from the "CopyRent" table in the database that associates a copy with a rental.
             It takes the rental ID and copy ID as parameters.
             */
            var connection = new SqlConnection(DbCon.ConnectionString);
            try
            {
                connection.Open();

                var adapter = new SqlDataAdapter("DELETE FROM CopyRent where id_rent = @id_rent AND id_copy = @id_copy", connection);
                adapter.SelectCommand.Parameters.AddWithValue("@id_rent", IdRent);
                adapter.SelectCommand.Parameters.AddWithValue("@id_copy", IdCopy);

                var table = new DataTable();
                adapter.Fill(table);
                adapter.Update(table);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally {connection.Close();}

        }

        public void UpdateCopyAfterComplition()
        {
            /*
             This method updates the "Copy" table in the database to increase the quantity of a copy by 1 after it has been returned from a rental.
             It takes the copy ID as a parameter.
             */
            var connection = new SqlConnection(DbCon.ConnectionString);
            try
            {
                connection.Open();
                var command = new SqlCommand("UPDATE Copy SET quantity = quantity + 1 WHERE id_copy = @id_copy;", connection);
                command.Parameters.AddWithValue("@id_copy", IdCopy);
                command.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { connection.Close(); }
        }
    }
}

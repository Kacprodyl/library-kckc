using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace library
{
    internal class Customer
    {
        public string FirstName { get; set; }
        public string Surrname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Customer(string firstName, string surrname, string phoneNumber, string email)
        {
            FirstName = firstName;
            Surrname = surrname;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public void AddCustomer()
        {
            using (var connection = new SqlConnection(DbCon.ConnectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var command = new SqlCommand("INSERT INTO Customer (first_name, surname, phone_number, email) VALUES (@first_name, @surname, @phone_number, @email)", connection, transaction);
                        command.Parameters.AddWithValue("@first_name", FirstName);
                        command.Parameters.AddWithValue("@surname", Surrname);
                        command.Parameters.AddWithValue("@phone_number", PhoneNumber);
                        command.Parameters.AddWithValue("@email", Email);
                        command.ExecuteNonQuery();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Failed to add customer: " + ex.Message);
                    }
                }
            }
        }

        public int GetCustomerId()
        {
            try
            {
                using (var connection = new SqlConnection(DbCon.ConnectionString))
                {
                    connection.Open();
                    var command = new SqlCommand("SELECT id_customer FROM Customer WHERE first_name = @first_name AND surname = @surname", connection);
                    command.Parameters.AddWithValue("@first_name", FirstName);
                    command.Parameters.AddWithValue("@surname", Surrname);
                    var customerId = (int)command.ExecuteScalar();
                    return customerId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Return an invalid value if no customer id was found or an error occurred
            }
        }
    }
}

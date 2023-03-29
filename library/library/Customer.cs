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
            try
            {
                var adapter = new SqlDataAdapter("SELECT * FROM Customer", DbCon.ConnectionString);
                var builder = new SqlCommandBuilder(adapter);
                var table = new DataTable();
                adapter.Fill(table);

                var newRow = table.NewRow();
                newRow["first_name"] = FirstName;
                newRow["surname"] = Surrname;
                newRow["phone_number"] = PhoneNumber;
                newRow["email"] = Email;
                table.Rows.Add(newRow);

                adapter.Update(table);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public int GetCustomerId(string firstname)
        {
            try
            {
                var adapter = new SqlDataAdapter($"SELECT id_customer FROM Customer where name = {firstname}", DbCon.ConnectionString);
                var dataSet = new DataSet();
                adapter.Fill(dataSet);
                int customerId = (int)dataSet.Tables[0].Rows[0]["id_customer"];
                return customerId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Return an invalid value if no copy id was found or an error occurred
            }
        }
    }
}

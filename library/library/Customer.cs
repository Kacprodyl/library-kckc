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
            var connection = new SqlConnection(DbCon.ConnectionString);
            try
            {
                connection.Open();
                var adapter = new SqlDataAdapter("SELECT * FROM Customer", connection);
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
            finally { connection.Close(); }
        }

        //public int GetCustomerId()
        //{
        //    //var adapter = new 
        //    //string query = "SELECT id_customer FROM customer";
        //    //using (SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString))
        //    //{
        //    //    DataSet dataSet = new DataSet();
        //    //    adapter.Fill(dataSet);
        //    //    if (dataSet.Tables[0].Rows.Count > 0)
        //    //    {
        //    //        int idCustomer = (int)dataSet.Tables[0].Rows[0]["id_customer"];
        //    //        return idCustomer;
        //    //    }
        //    //}
        //    //return -1; // Return an invalid value if no customer id was found
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public class DGV
    {
        /// <summary>
        /// RefreshDGV is a static method that takes two parameters: a DataGridView object and a string containing a SQL SELECT statement.
        /// The method refreshes the data displayed in the DataGridView object by clearing the current data source, retrieving new data from a database using the provided SQL SELECT statement, and setting the data source of the DataGridView object to the newly retrieved data.
        /// </summary>
        /// <param name="dgv">(DataGridView): the DataGridView object that needs to be refreshed.</param>
        /// <param name="sql_select">(string): a SQL SELECT statement used to retrieve data from a database.</param>
        public static void RefreshDGV(DataGridView dgv, string sql_select)
        {
            dgv.DataSource = null;
            dgv.Rows.Clear();
            var dataAdapter = new SqlDataAdapter(sql_select, DbCon.ConnectionString);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Library");
            dgv.DataSource = dataSet.Tables["Library"];            
        }
    }
}

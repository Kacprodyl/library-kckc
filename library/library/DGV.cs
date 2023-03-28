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
        public static void RefreshDGV(DataGridView dgv, string tableName)
            // Refresh DGV by using dgv name and name of the Table in DB
        {
            dgv.DataSource = null;
            dgv.Rows.Clear();
            var dataAdapter = new SqlDataAdapter($"SELECT * FROM {tableName}", DbCon.ConnectionString);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet, tableName);
            dgv.DataSource = dataSet.Tables[tableName];
        }
    }
}

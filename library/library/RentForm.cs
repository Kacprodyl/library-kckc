using library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class RentForm : Form
    {
        public int IdBook { get; }

        public RentForm(int idBook)
        {
            IdBook = idBook;
            InitializeComponent();

            var colRentBack = new DataGridViewButtonColumn
            {
                UseColumnTextForButtonValue = true,
                Text = "Rent Back",
                Name = "RentBack",
                FillWeight = 40
            };
            dataGridView_rent.Columns.Add(colRentBack);
        }


        private void button_rent_Click(object sender, EventArgs e)
        {

            try
            {
                var copy = new Copy(IdBook);
                int copyId = copy.GetCopyId();

                var customer = new Customer(textBox_first_name.Text, textBox_surrname.Text, textBox_phone_number.Text, textBox_email.Text);
                customer.AddCustomer();
                int customerId = customer.GetCustomerId();


                var rent = new Rent(copyId, customerId);
                rent.AddRent();
                rent.UpdateCopyRent();
                copy.UpdateCopyAfterRent(copyId);

                MessageBox.Show($"Rent added for user: {textBox_first_name.Text} {textBox_surrname.Text}");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void RentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_library_kckcDataSet_rent.Rent' table. You can move, or remove it, as needed.
            this.rentTableAdapter.Fill(this._library_kckcDataSet_rent.Rent);

        }

        private void dataGridView_rent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView_rent.Columns[e.ColumnIndex].Name == "RentBack")
                {
                    int index = e.RowIndex;
                    DataGridViewRow selectedRow = dataGridView_rent.Rows[index];
                    int idRent = (int)selectedRow.Cells[0].Value;
                    DateTime rentDate = (DateTime)selectedRow.Cells[1].Value;
                    int idCopy = (int)selectedRow.Cells[5].Value;

                    var rent = new Rent(idRent, idCopy, rentDate);
                    rent.CompleteRent();
                    rent.DeleteCopyRent();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { DGV.RefreshDGV(dataGridView_rent, "SELECT * FROM Rent;"); }
        }
    }
}

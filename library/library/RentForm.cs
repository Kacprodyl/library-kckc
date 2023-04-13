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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            /*
             This method is triggered when the 'Rent' button is clicked. It creates a new Copy object using the 'IdBook' property,
            creates a new Customer object using the values from text boxes, creates a new Rent object using the copy and customer IDs, and performs rent and copy update actions.
            It displays a message box with the name of the customer.
             */
            try
            {
                var copy = new Copy(IdBook);
                int copyId = copy.GetCopyId();

                string first_name = textBox_first_name.Text;
                string surname = textBox_surrname.Text;
                string phone_number = textBox_phone_number.Text;
                string email = textBox_email.Text;

                var customer = new Customer(first_name, surname, phone_number, email);
                customer.AddCustomer();
                int customerId = customer.GetCustomerId();


                var rent = new Rent(copyId, customerId);
                rent.AddRent();
                rent.UpdateCopyRent();
                copy.UpdateCopyAfterRent(copyId);

                MailSender mailSender = new MailSender();
                if(!MailSender.IsValidEmail(email))
                {
                    MessageBox.Show("Invalid email!");
                }
                else
                {
                    mailSender.Send(email, first_name, surname, phone_number);
                    MessageBox.Show($"Rent added for user: {textBox_first_name.Text} {textBox_surrname.Text}");
                }

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
            /*
             This method is triggered when a cell content is clicked in the dataGridView_rent control.
            It checks if the clicked column is the 'RentBack' column and performs rent completion and copy deletion actions accordingly.
            It also refreshes the dataGridView_rent control by calling the RefreshDGV method from the DGV class.
             */
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
                    rent.UpdateCopyAfterComplition();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { DGV.RefreshDGV(dataGridView_rent, "SELECT * FROM Rent;"); }
        }
    }
}

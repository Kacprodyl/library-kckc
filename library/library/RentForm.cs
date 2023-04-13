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
    }
}

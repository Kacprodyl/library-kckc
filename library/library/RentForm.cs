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

        private void button1_Click(object sender, EventArgs e)
        {
            var copy = new Copy(IdBook);
            var customer = new Customer(textBox_first_name.Text, textBox_surrname.Text, textBox_phone_number.Text, textBox_email.Text);
            var rent = new Rent(copy.GetCopyId(), customer.GetCustomerId());
            MessageBox.Show(customer.FirstName, customer.Surrname);
            MessageBox.Show(copy.GetCopyId().ToString());
            MessageBox.Show(customer.GetCustomerId().ToString());
            //customer.AddCustomer();
            //rent.AddRent();
            
        }
    }
}

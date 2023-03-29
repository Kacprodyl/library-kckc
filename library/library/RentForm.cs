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
            var rent = new Rent(copy.GetCopyId(IdBook));
            var customer = new Customer(textBox_first_name.Text, textBox_surrname.Text, textBox_phone_number.Text, textBox_email.Text);
            customer.AddCustomer();
            rent.AddRent(customer.GetCustomerId(textBox_first_name.Text));
            
        }
    }
}

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
    public partial class AddCopy : Form
    {
        public int IdBook { get; }

        public AddCopy(int idBook)
        {
            IdBook = idBook;
            InitializeComponent();
        }

        private void Button_add_copy_Click(object sender, EventArgs e)
        {

            try
            {
                var copy = new Copy(Convert.ToInt32(numericUpDown_quantity.Value), dateTimePicker_realese_date.Value, IdBook);
                copy.AddCopy();
                MessageBox.Show($"Copy with quantity: {copy.Quantity} added");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
    }
}

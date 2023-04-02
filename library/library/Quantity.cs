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
    public partial class Quantity : Form
    {
        public int IdBook { get; }
        public int QuantityBook { get; }
        public string Title { get; }

        public Quantity(int idBook, int quantity, string title)
        {
            IdBook = idBook;
            QuantityBook = quantity;
            Title = title;

            InitializeComponent();

            numericUpDown_quantity.Value = quantity;
            label_book_title.Text = title;
        }

        private void Button_update_q_Click(object sender, EventArgs e)
        {
            int quantity = (int)numericUpDown_quantity.Value;
            try
            {
                var copy = new Copy(Convert.ToInt32(quantity), IdBook);
                copy.QuantityUpdate();
                MessageBox.Show($"{Title} has been updated.");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}

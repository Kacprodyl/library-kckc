using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DGV.RefreshDGV(dataGridViewBooks, "Book");

            // Add button Delete to DGV
            var col = new DataGridViewButtonColumn
            {
                UseColumnTextForButtonValue = true,
                Text = "Delete",
                Name = "Delete",
                FillWeight = 40
            };
            dataGridViewBooks.Columns.Add(col);

            // Create a new data adapter and dataset
            var dataAdapter = new SqlDataAdapter("SELECT * FROM Genre", DbCon.ConnectionString);
            var dataSet = new DataSet();

            // Fill the dataset with data from the database
            dataAdapter.Fill(dataSet, "Genre");

            // Bind the combobox to the dataset
            comboBox_genre.DataSource = dataSet.Tables["Genre"];
            comboBox_genre.DisplayMember = "name";
            comboBox_genre.ValueMember = "id_genre";
            comboBox_genre.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_library_kckcDataSet_genre.Genre' table. You can move, or remove it, as needed.
            this.genreTableAdapter.Fill(this._library_kckcDataSet_genre.Genre);
            // TODO: This line of code loads data into the '_library_kckcDataSet.Author' table. You can move, or remove it, as needed.
            this.authorTableAdapter.Fill(this._library_kckcDataSet.Author);
            // TODO: This line of code loads data into the '_library_kckcDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this._library_kckcDataSet.Book);
        }

        private void ButtonAddBook_Click(object sender, EventArgs e)
            // Add new book to DB
        {
            try
            {
                var book = new Book(textBox_title.Text, Convert.ToInt32(comboBox_genre.SelectedValue), textBox_publisher.Text);
                book.AddBook();
                MessageBox.Show($"Book: {book.Name} added");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { DGV.RefreshDGV(dataGridViewBooks, "Book"); }
        }

        private void DataGridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
            // Remove book from DB by id_book
        {
            try
            {
                if (dataGridViewBooks.Columns[e.ColumnIndex].Name == "Delete")
                {
                    int index = e.RowIndex;
                    DataGridViewRow selectedRow = dataGridViewBooks.Rows[index];
                    int id_book = (int)selectedRow.Cells[0].Value;
                    Book.DeleteBook(id_book);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { DGV.RefreshDGV(dataGridViewBooks, "Book"); }

        }
    }
}

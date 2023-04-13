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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            // Add button Quantity to DGV
            var colCopy = new DataGridViewButtonColumn
            {
                UseColumnTextForButtonValue = true,
                Text = "Quantity",
                Name = "Quantity",
                FillWeight = 60
            };
            dataGridViewBooks.Columns.Add(colCopy);

            var colRent = new DataGridViewButtonColumn
            {
                UseColumnTextForButtonValue = true,
                Text = "Rent",
                Name = "Rent",
                FillWeight = 40
            };
            dataGridViewBooks.Columns.Add(colRent);
            DGV.RefreshDGV(dataGridViewBooks, "EXEC GetBookInfo;");

            // Create a new data adapter and dataset
            var dataAdapter = new SqlDataAdapter("SELECT * FROM Genre", DbCon.ConnectionString);
            var dataSet = new DataSet();
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
            string title = textBox_title.Text;
            int genre_id = Convert.ToInt32(comboBox_genre.SelectedValue);
            string publisher = textBox_publisher.Text;
            string author = textBoxAuthor.Text;
            int quantity = (int)numeric_quantity.Value;
            DateTime release_date = dateTPRealese.Value;
            try
            {
                var book = new Book(title, genre_id, publisher, author, quantity, release_date);
                book.AddBook();
                MessageBox.Show($"Book: {book.Name} added");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { DGV.RefreshDGV(dataGridViewBooks, "EXEC GetBookInfo;"); }
        }

        private void DataGridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
            // Change book quantity by book_id
        {
            try
            {
                if (dataGridViewBooks.Columns[e.ColumnIndex].Name == "Quantity")
                {
                    int index = e.RowIndex;
                    DataGridViewRow selectedRow = dataGridViewBooks.Rows[index];
                    int id_book = (int)selectedRow.Cells[2].Value;
                    string title = (string)selectedRow.Cells[3].Value;
                    int quantity = (int)selectedRow.Cells[7].Value;
                    var qunatity_win = new Quantity(id_book, quantity, title);
                    qunatity_win.ShowDialog();
                }
                else if (dataGridViewBooks.Columns[e.ColumnIndex].Name == "Rent")
                {
                    int index = e.RowIndex;
                    DataGridViewRow selectedRow = dataGridViewBooks.Rows[index];
                    int id_book = (int)selectedRow.Cells[2].Value;

                    var rentWindow = new RentForm(id_book);
                    rentWindow.ShowDialog();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { DGV.RefreshDGV(dataGridViewBooks, "EXEC GetBookInfo;"); }
        }

    }
}

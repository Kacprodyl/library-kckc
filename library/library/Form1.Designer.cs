namespace library
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._library_kckcDataSet = new library._library_kckcDataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_publisher = new System.Windows.Forms.TextBox();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idbookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idgenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.bookTableAdapter = new library._library_kckcDataSetTableAdapters.BookTableAdapter();
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorTableAdapter = new library._library_kckcDataSetTableAdapters.AuthorTableAdapter();
            this._library_kckcDataSet_genre = new library._library_kckcDataSet_genre();
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genreTableAdapter = new library._library_kckcDataSet_genreTableAdapters.GenreTableAdapter();
            this.comboBox_genre = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._library_kckcDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._library_kckcDataSet_genre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this._library_kckcDataSet;
            this.bindingSource1.Position = 0;
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // _library_kckcDataSet
            // 
            this._library_kckcDataSet.DataSetName = "_library_kckcDataSet";
            this._library_kckcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox_genre);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBox_publisher);
            this.tabPage2.Controls.Add(this.textBox_title);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Books";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Publisher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Genre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title";
            // 
            // textBox_publisher
            // 
            this.textBox_publisher.Location = new System.Drawing.Point(353, 307);
            this.textBox_publisher.Name = "textBox_publisher";
            this.textBox_publisher.Size = new System.Drawing.Size(180, 20);
            this.textBox_publisher.TabIndex = 4;
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(353, 216);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(180, 20);
            this.textBox_title.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbookDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.idgenreDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(759, 207);
            this.dataGridView1.TabIndex = 1;
            // 
            // idbookDataGridViewTextBoxColumn
            // 
            this.idbookDataGridViewTextBoxColumn.DataPropertyName = "id_book";
            this.idbookDataGridViewTextBoxColumn.HeaderText = "id_book";
            this.idbookDataGridViewTextBoxColumn.Name = "idbookDataGridViewTextBoxColumn";
            this.idbookDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // idgenreDataGridViewTextBoxColumn
            // 
            this.idgenreDataGridViewTextBoxColumn.DataPropertyName = "id_genre";
            this.idgenreDataGridViewTextBoxColumn.HeaderText = "id_genre";
            this.idgenreDataGridViewTextBoxColumn.Name = "idgenreDataGridViewTextBoxColumn";
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "publisher";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.bindingSource1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // authorBindingSource
            // 
            this.authorBindingSource.DataMember = "Author";
            this.authorBindingSource.DataSource = this.bindingSource1;
            // 
            // authorTableAdapter
            // 
            this.authorTableAdapter.ClearBeforeFill = true;
            // 
            // _library_kckcDataSet_genre
            // 
            this._library_kckcDataSet_genre.DataSetName = "_library_kckcDataSet_genre";
            this._library_kckcDataSet_genre.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // genreBindingSource
            // 
            this.genreBindingSource.DataMember = "Genre";
            this.genreBindingSource.DataSource = this._library_kckcDataSet_genre;
            // 
            // genreTableAdapter
            // 
            this.genreTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox_genre
            // 
            this.comboBox_genre.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.genreBindingSource, "id_genre", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.comboBox_genre.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.genreBindingSource, "id_genre", true));
            this.comboBox_genre.DataSource = this.genreBindingSource;
            this.comboBox_genre.DisplayMember = "name";
            this.comboBox_genre.FormattingEnabled = true;
            this.comboBox_genre.Location = new System.Drawing.Point(353, 261);
            this.comboBox_genre.Name = "comboBox_genre";
            this.comboBox_genre.Size = new System.Drawing.Size(180, 21);
            this.comboBox_genre.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._library_kckcDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._library_kckcDataSet_genre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private _library_kckcDataSet _library_kckcDataSet;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private _library_kckcDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgenreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_publisher;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.BindingSource authorBindingSource;
        private _library_kckcDataSetTableAdapters.AuthorTableAdapter authorTableAdapter;
        private _library_kckcDataSet_genre _library_kckcDataSet_genre;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private _library_kckcDataSet_genreTableAdapters.GenreTableAdapter genreTableAdapter;
        private System.Windows.Forms.ComboBox comboBox_genre;
    }
}


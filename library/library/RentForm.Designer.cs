namespace library
{
    partial class RentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_first_name = new System.Windows.Forms.TextBox();
            this.textBox_surrname = new System.Windows.Forms.TextBox();
            this.textBox_phone_number = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.button_rent = new System.Windows.Forms.Button();
            this.dataGridView_rent = new System.Windows.Forms.DataGridView();
            this._library_kckcDataSet_rent = new library._library_kckcDataSet_rent();
            this.rentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentTableAdapter = new library._library_kckcDataSet_rentTableAdapters.RentTableAdapter();
            this.idrentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completiondateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcopyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_rent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._library_kckcDataSet_rent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surrname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-mail";
            // 
            // textBox_first_name
            // 
            this.textBox_first_name.Location = new System.Drawing.Point(112, 226);
            this.textBox_first_name.Name = "textBox_first_name";
            this.textBox_first_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_first_name.TabIndex = 4;
            // 
            // textBox_surrname
            // 
            this.textBox_surrname.Location = new System.Drawing.Point(112, 262);
            this.textBox_surrname.Name = "textBox_surrname";
            this.textBox_surrname.Size = new System.Drawing.Size(100, 20);
            this.textBox_surrname.TabIndex = 5;
            // 
            // textBox_phone_number
            // 
            this.textBox_phone_number.Location = new System.Drawing.Point(112, 304);
            this.textBox_phone_number.MaxLength = 9;
            this.textBox_phone_number.Name = "textBox_phone_number";
            this.textBox_phone_number.Size = new System.Drawing.Size(100, 20);
            this.textBox_phone_number.TabIndex = 6;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(112, 348);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(100, 20);
            this.textBox_email.TabIndex = 7;
            // 
            // button_rent
            // 
            this.button_rent.Location = new System.Drawing.Point(112, 406);
            this.button_rent.Name = "button_rent";
            this.button_rent.Size = new System.Drawing.Size(100, 41);
            this.button_rent.TabIndex = 8;
            this.button_rent.Text = "Rent for this customer";
            this.button_rent.UseVisualStyleBackColor = true;
            this.button_rent.Click += new System.EventHandler(this.button_rent_Click);
            // 
            // dataGridView_rent
            // 
            this.dataGridView_rent.AutoGenerateColumns = false;
            this.dataGridView_rent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_rent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idrentDataGridViewTextBoxColumn,
            this.rentdateDataGridViewTextBoxColumn,
            this.completiondateDataGridViewTextBoxColumn,
            this.feeDataGridViewTextBoxColumn,
            this.idcustomerDataGridViewTextBoxColumn,
            this.idcopyDataGridViewTextBoxColumn});
            this.dataGridView_rent.DataSource = this.rentBindingSource;
            this.dataGridView_rent.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_rent.Name = "dataGridView_rent";
            this.dataGridView_rent.Size = new System.Drawing.Size(739, 179);
            this.dataGridView_rent.TabIndex = 9;
            this.dataGridView_rent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_rent_CellContentClick);
            // 
            // _library_kckcDataSet_rent
            // 
            this._library_kckcDataSet_rent.DataSetName = "_library_kckcDataSet_rent";
            this._library_kckcDataSet_rent.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentBindingSource
            // 
            this.rentBindingSource.DataMember = "Rent";
            this.rentBindingSource.DataSource = this._library_kckcDataSet_rent;
            // 
            // rentTableAdapter
            // 
            this.rentTableAdapter.ClearBeforeFill = true;
            // 
            // idrentDataGridViewTextBoxColumn
            // 
            this.idrentDataGridViewTextBoxColumn.DataPropertyName = "id_rent";
            this.idrentDataGridViewTextBoxColumn.HeaderText = "id_rent";
            this.idrentDataGridViewTextBoxColumn.Name = "idrentDataGridViewTextBoxColumn";
            this.idrentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rentdateDataGridViewTextBoxColumn
            // 
            this.rentdateDataGridViewTextBoxColumn.DataPropertyName = "rent_date";
            this.rentdateDataGridViewTextBoxColumn.HeaderText = "rent_date";
            this.rentdateDataGridViewTextBoxColumn.Name = "rentdateDataGridViewTextBoxColumn";
            // 
            // completiondateDataGridViewTextBoxColumn
            // 
            this.completiondateDataGridViewTextBoxColumn.DataPropertyName = "completion_date";
            this.completiondateDataGridViewTextBoxColumn.HeaderText = "completion_date";
            this.completiondateDataGridViewTextBoxColumn.Name = "completiondateDataGridViewTextBoxColumn";
            // 
            // feeDataGridViewTextBoxColumn
            // 
            this.feeDataGridViewTextBoxColumn.DataPropertyName = "fee";
            this.feeDataGridViewTextBoxColumn.HeaderText = "fee";
            this.feeDataGridViewTextBoxColumn.Name = "feeDataGridViewTextBoxColumn";
            // 
            // idcustomerDataGridViewTextBoxColumn
            // 
            this.idcustomerDataGridViewTextBoxColumn.DataPropertyName = "id_customer";
            this.idcustomerDataGridViewTextBoxColumn.HeaderText = "id_customer";
            this.idcustomerDataGridViewTextBoxColumn.Name = "idcustomerDataGridViewTextBoxColumn";
            // 
            // idcopyDataGridViewTextBoxColumn
            // 
            this.idcopyDataGridViewTextBoxColumn.DataPropertyName = "id_copy";
            this.idcopyDataGridViewTextBoxColumn.HeaderText = "id_copy";
            this.idcopyDataGridViewTextBoxColumn.Name = "idcopyDataGridViewTextBoxColumn";
            // 
            // RentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 459);
            this.Controls.Add(this.dataGridView_rent);
            this.Controls.Add(this.button_rent);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_phone_number);
            this.Controls.Add(this.textBox_surrname);
            this.Controls.Add(this.textBox_first_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RentForm";
            this.Text = "RentForm";
            this.Load += new System.EventHandler(this.RentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_rent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._library_kckcDataSet_rent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_first_name;
        private System.Windows.Forms.TextBox textBox_surrname;
        private System.Windows.Forms.TextBox textBox_phone_number;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Button button_rent;
        private System.Windows.Forms.DataGridView dataGridView_rent;
        private _library_kckcDataSet_rent _library_kckcDataSet_rent;
        private System.Windows.Forms.BindingSource rentBindingSource;
        private _library_kckcDataSet_rentTableAdapters.RentTableAdapter rentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn completiondateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcopyDataGridViewTextBoxColumn;
    }
}
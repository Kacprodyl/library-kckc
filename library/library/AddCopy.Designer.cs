namespace library
{
    partial class AddCopy
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
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker_realese_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_quantity = new System.Windows.Forms.NumericUpDown();
            this.button_add_copy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Realese date";
            // 
            // dateTimePicker_realese_date
            // 
            this.dateTimePicker_realese_date.Location = new System.Drawing.Point(338, 193);
            this.dateTimePicker_realese_date.Name = "dateTimePicker_realese_date";
            this.dateTimePicker_realese_date.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_realese_date.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "quantity";
            // 
            // numericUpDown_quantity
            // 
            this.numericUpDown_quantity.Location = new System.Drawing.Point(398, 238);
            this.numericUpDown_quantity.Name = "numericUpDown_quantity";
            this.numericUpDown_quantity.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_quantity.TabIndex = 13;
            this.numericUpDown_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_add_copy
            // 
            this.button_add_copy.Location = new System.Drawing.Point(378, 307);
            this.button_add_copy.Name = "button_add_copy";
            this.button_add_copy.Size = new System.Drawing.Size(106, 33);
            this.button_add_copy.TabIndex = 17;
            this.button_add_copy.Text = "Add Copy";
            this.button_add_copy.UseVisualStyleBackColor = true;
            this.button_add_copy.Click += new System.EventHandler(this.button_add_copy_Click);
            // 
            // AddCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_add_copy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker_realese_date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_quantity);
            this.Name = "AddCopy";
            this.Text = "AddCopy";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_realese_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_quantity;
        private System.Windows.Forms.Button button_add_copy;
    }
}
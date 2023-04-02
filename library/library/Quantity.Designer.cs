namespace library
{
    partial class Quantity
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
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_quantity = new System.Windows.Forms.NumericUpDown();
            this.button_update_q = new System.Windows.Forms.Button();
            this.label_book_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Quantity";
            // 
            // numericUpDown_quantity
            // 
            this.numericUpDown_quantity.Location = new System.Drawing.Point(107, 58);
            this.numericUpDown_quantity.Name = "numericUpDown_quantity";
            this.numericUpDown_quantity.Size = new System.Drawing.Size(86, 20);
            this.numericUpDown_quantity.TabIndex = 13;
            this.numericUpDown_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_update_q
            // 
            this.button_update_q.Location = new System.Drawing.Point(58, 84);
            this.button_update_q.Name = "button_update_q";
            this.button_update_q.Size = new System.Drawing.Size(135, 33);
            this.button_update_q.TabIndex = 17;
            this.button_update_q.Text = "Update";
            this.button_update_q.UseVisualStyleBackColor = true;
            this.button_update_q.Click += new System.EventHandler(this.Button_update_q_Click);
            // 
            // label_book_title
            // 
            this.label_book_title.AutoSize = true;
            this.label_book_title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_book_title.Location = new System.Drawing.Point(55, 20);
            this.label_book_title.Name = "label_book_title";
            this.label_book_title.Size = new System.Drawing.Size(35, 13);
            this.label_book_title.TabIndex = 18;
            this.label_book_title.Text = "label1";
            this.label_book_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Quantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 157);
            this.Controls.Add(this.label_book_title);
            this.Controls.Add(this.button_update_q);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_quantity);
            this.Name = "Quantity";
            this.Text = "Quantity";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_quantity;
        private System.Windows.Forms.Button button_update_q;
        private System.Windows.Forms.Label label_book_title;
    }
}
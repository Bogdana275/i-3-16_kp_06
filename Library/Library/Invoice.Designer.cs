namespace Library
{
    partial class Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            this.btExcel = new System.Windows.Forms.Button();
            this.btDeleteBook = new System.Windows.Forms.Button();
            this.btUpdateBook = new System.Windows.Forms.Button();
            this.btInsertBook = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbKol_vo = new System.Windows.Forms.TextBox();
            this.cbBook = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // btExcel
            // 
            this.btExcel.BackgroundImage = global::Library.Properties.Resources.Book_lezh;
            this.btExcel.Location = new System.Drawing.Point(259, 302);
            this.btExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btExcel.Name = "btExcel";
            this.btExcel.Size = new System.Drawing.Size(100, 35);
            this.btExcel.TabIndex = 85;
            this.btExcel.Text = "Вывод в Excel";
            this.btExcel.UseVisualStyleBackColor = true;
            this.btExcel.Click += new System.EventHandler(this.btExcel_Click);
            // 
            // btDeleteBook
            // 
            this.btDeleteBook.BackgroundImage = global::Library.Properties.Resources.Book_lezh3;
            this.btDeleteBook.Location = new System.Drawing.Point(450, 118);
            this.btDeleteBook.Margin = new System.Windows.Forms.Padding(2);
            this.btDeleteBook.Name = "btDeleteBook";
            this.btDeleteBook.Size = new System.Drawing.Size(100, 32);
            this.btDeleteBook.TabIndex = 84;
            this.btDeleteBook.Text = "Удалить";
            this.btDeleteBook.UseVisualStyleBackColor = true;
            this.btDeleteBook.Click += new System.EventHandler(this.btDeleteBook_Click);
            // 
            // btUpdateBook
            // 
            this.btUpdateBook.BackgroundImage = global::Library.Properties.Resources.Book_lezh2;
            this.btUpdateBook.Location = new System.Drawing.Point(450, 78);
            this.btUpdateBook.Margin = new System.Windows.Forms.Padding(2);
            this.btUpdateBook.Name = "btUpdateBook";
            this.btUpdateBook.Size = new System.Drawing.Size(100, 35);
            this.btUpdateBook.TabIndex = 83;
            this.btUpdateBook.Text = "Изменить";
            this.btUpdateBook.UseVisualStyleBackColor = true;
            this.btUpdateBook.Click += new System.EventHandler(this.btUpdateBook_Click);
            // 
            // btInsertBook
            // 
            this.btInsertBook.BackgroundImage = global::Library.Properties.Resources.Book_lezh;
            this.btInsertBook.Location = new System.Drawing.Point(450, 38);
            this.btInsertBook.Margin = new System.Windows.Forms.Padding(2);
            this.btInsertBook.Name = "btInsertBook";
            this.btInsertBook.Size = new System.Drawing.Size(100, 35);
            this.btInsertBook.TabIndex = 82;
            this.btInsertBook.Text = "Добавить";
            this.btInsertBook.UseVisualStyleBackColor = true;
            this.btInsertBook.Click += new System.EventHandler(this.btInsertBook_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "Книга:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Кол-во:";
            // 
            // tbKol_vo
            // 
            this.tbKol_vo.Location = new System.Drawing.Point(355, 124);
            this.tbKol_vo.Margin = new System.Windows.Forms.Padding(2);
            this.tbKol_vo.Name = "tbKol_vo";
            this.tbKol_vo.Size = new System.Drawing.Size(36, 20);
            this.tbKol_vo.TabIndex = 79;
            // 
            // cbBook
            // 
            this.cbBook.FormattingEnabled = true;
            this.cbBook.Location = new System.Drawing.Point(355, 84);
            this.cbBook.Margin = new System.Windows.Forms.Padding(2);
            this.cbBook.Name = "cbBook";
            this.cbBook.Size = new System.Drawing.Size(92, 21);
            this.cbBook.TabIndex = 78;
            this.cbBook.SelectionChangeCommitted += new System.EventHandler(this.cbBook_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "Принял:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Дата:";
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(46, 47);
            this.tbDate.Margin = new System.Windows.Forms.Padding(2);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(76, 20);
            this.tbDate.TabIndex = 72;
            // 
            // cbEmployee
            // 
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(46, 84);
            this.cbEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(92, 21);
            this.cbEmployee.TabIndex = 71;
            this.cbEmployee.SelectionChangeCommitted += new System.EventHandler(this.cbEmployee_SelectionChangeCommitted);
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Location = new System.Drawing.Point(28, 164);
            this.dgvInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.RowTemplate.Height = 24;
            this.dgvInvoice.Size = new System.Drawing.Size(259, 122);
            this.dgvInvoice.TabIndex = 70;
            this.dgvInvoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellClick);
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(334, 164);
            this.dgvBooks.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.Size = new System.Drawing.Size(238, 122);
            this.dgvBooks.TabIndex = 69;
            this.dgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellClick);
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btExcel);
            this.Controls.Add(this.btDeleteBook);
            this.Controls.Add(this.btUpdateBook);
            this.Controls.Add(this.btInsertBook);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbKol_vo);
            this.Controls.Add(this.cbBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.cbEmployee);
            this.Controls.Add(this.dgvInvoice);
            this.Controls.Add(this.dgvBooks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Накладные";
            this.Load += new System.EventHandler(this.Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btExcel;
        private System.Windows.Forms.Button btDeleteBook;
        private System.Windows.Forms.Button btUpdateBook;
        private System.Windows.Forms.Button btInsertBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKol_vo;
        private System.Windows.Forms.ComboBox cbBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.DataGridView dgvBooks;
    }
}
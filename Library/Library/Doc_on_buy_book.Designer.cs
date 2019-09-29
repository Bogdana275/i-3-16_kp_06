namespace Library
{
    partial class Doc_on_buy_book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doc_on_buy_book));
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.dgvDoc_on_buy_book = new System.Windows.Forms.DataGridView();
            this.cbProvider = new System.Windows.Forms.ComboBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbKol_vo = new System.Windows.Forms.TextBox();
            this.cbBook = new System.Windows.Forms.ComboBox();
            this.btExcel = new System.Windows.Forms.Button();
            this.btDeleteBook = new System.Windows.Forms.Button();
            this.btUpdateBook = new System.Windows.Forms.Button();
            this.btInsertBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoc_on_buy_book)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(352, 164);
            this.dgvBooks.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.Size = new System.Drawing.Size(238, 122);
            this.dgvBooks.TabIndex = 0;
            this.dgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellClick);
            // 
            // dgvDoc_on_buy_book
            // 
            this.dgvDoc_on_buy_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoc_on_buy_book.Location = new System.Drawing.Point(46, 164);
            this.dgvDoc_on_buy_book.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDoc_on_buy_book.Name = "dgvDoc_on_buy_book";
            this.dgvDoc_on_buy_book.RowTemplate.Height = 24;
            this.dgvDoc_on_buy_book.Size = new System.Drawing.Size(259, 122);
            this.dgvDoc_on_buy_book.TabIndex = 1;
            this.dgvDoc_on_buy_book.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoc_on_buy_book_CellClick);
            // 
            // cbProvider
            // 
            this.cbProvider.FormattingEnabled = true;
            this.cbProvider.Location = new System.Drawing.Point(132, 118);
            this.cbProvider.Margin = new System.Windows.Forms.Padding(2);
            this.cbProvider.Name = "cbProvider";
            this.cbProvider.Size = new System.Drawing.Size(92, 21);
            this.cbProvider.TabIndex = 2;
            this.cbProvider.SelectionChangeCommitted += new System.EventHandler(this.cbContract_with_provider_SelectionChangeCommitted);
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(132, 81);
            this.tbDate.Margin = new System.Windows.Forms.Padding(2);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(76, 20);
            this.tbDate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Дата:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Поставщик:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Книга:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Кол-во:";
            // 
            // tbKol_vo
            // 
            this.tbKol_vo.Location = new System.Drawing.Point(374, 120);
            this.tbKol_vo.Margin = new System.Windows.Forms.Padding(2);
            this.tbKol_vo.Name = "tbKol_vo";
            this.tbKol_vo.Size = new System.Drawing.Size(36, 20);
            this.tbKol_vo.TabIndex = 62;
            // 
            // cbBook
            // 
            this.cbBook.FormattingEnabled = true;
            this.cbBook.Location = new System.Drawing.Point(374, 80);
            this.cbBook.Margin = new System.Windows.Forms.Padding(2);
            this.cbBook.Name = "cbBook";
            this.cbBook.Size = new System.Drawing.Size(92, 21);
            this.cbBook.TabIndex = 61;
            this.cbBook.SelectionChangeCommitted += new System.EventHandler(this.cbBook_SelectionChangeCommitted);
            // 
            // btExcel
            // 
            this.btExcel.BackgroundImage = global::Library.Properties.Resources.Book_lezh;
            this.btExcel.Location = new System.Drawing.Point(278, 302);
            this.btExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btExcel.Name = "btExcel";
            this.btExcel.Size = new System.Drawing.Size(100, 35);
            this.btExcel.TabIndex = 68;
            this.btExcel.Text = "Вывод в Excel";
            this.btExcel.UseVisualStyleBackColor = true;
            this.btExcel.Click += new System.EventHandler(this.btExcel_Click);
            // 
            // btDeleteBook
            // 
            this.btDeleteBook.BackgroundImage = global::Library.Properties.Resources.Book_lezh3;
            this.btDeleteBook.Location = new System.Drawing.Point(490, 118);
            this.btDeleteBook.Margin = new System.Windows.Forms.Padding(2);
            this.btDeleteBook.Name = "btDeleteBook";
            this.btDeleteBook.Size = new System.Drawing.Size(100, 32);
            this.btDeleteBook.TabIndex = 67;
            this.btDeleteBook.Text = "Удалить";
            this.btDeleteBook.UseVisualStyleBackColor = true;
            this.btDeleteBook.Click += new System.EventHandler(this.btDeleteBook_Click);
            // 
            // btUpdateBook
            // 
            this.btUpdateBook.BackgroundImage = global::Library.Properties.Resources.Book_lezh2;
            this.btUpdateBook.Location = new System.Drawing.Point(490, 78);
            this.btUpdateBook.Margin = new System.Windows.Forms.Padding(2);
            this.btUpdateBook.Name = "btUpdateBook";
            this.btUpdateBook.Size = new System.Drawing.Size(100, 35);
            this.btUpdateBook.TabIndex = 66;
            this.btUpdateBook.Text = "Изменить";
            this.btUpdateBook.UseVisualStyleBackColor = true;
            this.btUpdateBook.Click += new System.EventHandler(this.btUpdateBook_Click);
            // 
            // btInsertBook
            // 
            this.btInsertBook.BackgroundImage = global::Library.Properties.Resources.Book_lezh;
            this.btInsertBook.Location = new System.Drawing.Point(490, 38);
            this.btInsertBook.Margin = new System.Windows.Forms.Padding(2);
            this.btInsertBook.Name = "btInsertBook";
            this.btInsertBook.Size = new System.Drawing.Size(100, 35);
            this.btInsertBook.TabIndex = 65;
            this.btInsertBook.Text = "Добавить";
            this.btInsertBook.UseVisualStyleBackColor = true;
            this.btInsertBook.Click += new System.EventHandler(this.btInsertBook_Click);
            // 
            // Doc_on_buy_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 355);
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
            this.Controls.Add(this.cbProvider);
            this.Controls.Add(this.dgvDoc_on_buy_book);
            this.Controls.Add(this.dgvBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Doc_on_buy_book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Документы на закупку книг";
            this.Load += new System.EventHandler(this.Doc_on_buy_book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoc_on_buy_book)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.DataGridView dgvDoc_on_buy_book;
        private System.Windows.Forms.ComboBox cbProvider;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKol_vo;
        private System.Windows.Forms.ComboBox cbBook;
        private System.Windows.Forms.Button btDeleteBook;
        private System.Windows.Forms.Button btUpdateBook;
        private System.Windows.Forms.Button btInsertBook;
        private System.Windows.Forms.Button btExcel;
    }
}
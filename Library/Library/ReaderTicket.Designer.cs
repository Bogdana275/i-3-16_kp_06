namespace Library
{
    partial class ReaderTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReaderTicket));
            this.dgvReaders = new System.Windows.Forms.DataGridView();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.tbDate_of_issue = new System.Windows.Forms.TextBox();
            this.tbDate_accept = new System.Windows.Forms.TextBox();
            this.cbBooks = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFam = new System.Windows.Forms.TextBox();
            this.tbIm = new System.Windows.Forms.TextBox();
            this.tbOtch = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbSeria = new System.Windows.Forms.TextBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btDeleteReader = new System.Windows.Forms.Button();
            this.btUpdateReader = new System.Windows.Forms.Button();
            this.btInsertReader = new System.Windows.Forms.Button();
            this.btDeleteBook = new System.Windows.Forms.Button();
            this.btUpdateBook = new System.Windows.Forms.Button();
            this.btInsertBook = new System.Windows.Forms.Button();
            this.brWord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReaders
            // 
            this.dgvReaders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReaders.Location = new System.Drawing.Point(11, 134);
            this.dgvReaders.Margin = new System.Windows.Forms.Padding(2);
            this.dgvReaders.Name = "dgvReaders";
            this.dgvReaders.RowTemplate.Height = 24;
            this.dgvReaders.Size = new System.Drawing.Size(309, 163);
            this.dgvReaders.TabIndex = 0;
            this.dgvReaders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReaders_CellClick);
            // 
            // dgvBooks
            // 
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(374, 134);
            this.dgvBooks.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.Size = new System.Drawing.Size(309, 163);
            this.dgvBooks.TabIndex = 1;
            this.dgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellClick);
            // 
            // tbDate_of_issue
            // 
            this.tbDate_of_issue.Location = new System.Drawing.Point(436, 102);
            this.tbDate_of_issue.Margin = new System.Windows.Forms.Padding(2);
            this.tbDate_of_issue.Name = "tbDate_of_issue";
            this.tbDate_of_issue.Size = new System.Drawing.Size(76, 20);
            this.tbDate_of_issue.TabIndex = 2;
            // 
            // tbDate_accept
            // 
            this.tbDate_accept.Location = new System.Drawing.Point(554, 102);
            this.tbDate_accept.Margin = new System.Windows.Forms.Padding(2);
            this.tbDate_accept.Name = "tbDate_accept";
            this.tbDate_accept.Size = new System.Drawing.Size(76, 20);
            this.tbDate_accept.TabIndex = 3;
            // 
            // cbBooks
            // 
            this.cbBooks.FormattingEnabled = true;
            this.cbBooks.Location = new System.Drawing.Point(485, 41);
            this.cbBooks.Margin = new System.Windows.Forms.Padding(2);
            this.cbBooks.Name = "cbBooks";
            this.cbBooks.Size = new System.Drawing.Size(92, 21);
            this.cbBooks.TabIndex = 4;
            this.cbBooks.SelectionChangeCommitted += new System.EventHandler(this.cbBooks_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Книга:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Дата выдачи:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дата принятия книги:";
            // 
            // tbFam
            // 
            this.tbFam.Location = new System.Drawing.Point(19, 30);
            this.tbFam.Margin = new System.Windows.Forms.Padding(2);
            this.tbFam.Name = "tbFam";
            this.tbFam.Size = new System.Drawing.Size(76, 20);
            this.tbFam.TabIndex = 8;
            // 
            // tbIm
            // 
            this.tbIm.Location = new System.Drawing.Point(19, 67);
            this.tbIm.Margin = new System.Windows.Forms.Padding(2);
            this.tbIm.Name = "tbIm";
            this.tbIm.Size = new System.Drawing.Size(76, 20);
            this.tbIm.TabIndex = 9;
            // 
            // tbOtch
            // 
            this.tbOtch.Location = new System.Drawing.Point(19, 102);
            this.tbOtch.Margin = new System.Windows.Forms.Padding(2);
            this.tbOtch.Name = "tbOtch";
            this.tbOtch.Size = new System.Drawing.Size(76, 20);
            this.tbOtch.TabIndex = 10;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(129, 44);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(2);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(76, 20);
            this.tbPhone.TabIndex = 11;
            // 
            // tbSeria
            // 
            this.tbSeria.Location = new System.Drawing.Point(129, 80);
            this.tbSeria.Margin = new System.Windows.Forms.Padding(2);
            this.tbSeria.Name = "tbSeria";
            this.tbSeria.Size = new System.Drawing.Size(33, 20);
            this.tbSeria.TabIndex = 12;
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(170, 80);
            this.tbNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(35, 20);
            this.tbNumber.TabIndex = 13;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(218, 80);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(76, 20);
            this.tbPassword.TabIndex = 14;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(218, 44);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(2);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(76, 20);
            this.tbLogin.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Фамилия:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Имя:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Отчество:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Телефон:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(132, 63);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Паспорт:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Логин:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(218, 64);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Пароль:";
            // 
            // btDeleteReader
            // 
            this.btDeleteReader.BackgroundImage = global::Library.Properties.Resources.Book_lezh3;
            this.btDeleteReader.Location = new System.Drawing.Point(220, 302);
            this.btDeleteReader.Margin = new System.Windows.Forms.Padding(2);
            this.btDeleteReader.Name = "btDeleteReader";
            this.btDeleteReader.Size = new System.Drawing.Size(100, 32);
            this.btDeleteReader.TabIndex = 63;
            this.btDeleteReader.Text = "Удалить";
            this.btDeleteReader.UseVisualStyleBackColor = true;
            this.btDeleteReader.Click += new System.EventHandler(this.btDeleteReader_Click);
            // 
            // btUpdateReader
            // 
            this.btUpdateReader.BackgroundImage = global::Library.Properties.Resources.Book_lezh2;
            this.btUpdateReader.Location = new System.Drawing.Point(116, 302);
            this.btUpdateReader.Margin = new System.Windows.Forms.Padding(2);
            this.btUpdateReader.Name = "btUpdateReader";
            this.btUpdateReader.Size = new System.Drawing.Size(100, 35);
            this.btUpdateReader.TabIndex = 62;
            this.btUpdateReader.Text = "Изменить";
            this.btUpdateReader.UseVisualStyleBackColor = true;
            this.btUpdateReader.Click += new System.EventHandler(this.btUpdateReader_Click);
            // 
            // btInsertReader
            // 
            this.btInsertReader.BackgroundImage = global::Library.Properties.Resources.Book_lezh;
            this.btInsertReader.Location = new System.Drawing.Point(11, 302);
            this.btInsertReader.Margin = new System.Windows.Forms.Padding(2);
            this.btInsertReader.Name = "btInsertReader";
            this.btInsertReader.Size = new System.Drawing.Size(100, 35);
            this.btInsertReader.TabIndex = 61;
            this.btInsertReader.Text = "Добавить";
            this.btInsertReader.UseVisualStyleBackColor = true;
            this.btInsertReader.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // btDeleteBook
            // 
            this.btDeleteBook.BackgroundImage = global::Library.Properties.Resources.Book_lezh3;
            this.btDeleteBook.Location = new System.Drawing.Point(583, 302);
            this.btDeleteBook.Margin = new System.Windows.Forms.Padding(2);
            this.btDeleteBook.Name = "btDeleteBook";
            this.btDeleteBook.Size = new System.Drawing.Size(100, 32);
            this.btDeleteBook.TabIndex = 66;
            this.btDeleteBook.Text = "Удалить";
            this.btDeleteBook.UseVisualStyleBackColor = true;
            this.btDeleteBook.Click += new System.EventHandler(this.btDeleteBook_Click);
            // 
            // btUpdateBook
            // 
            this.btUpdateBook.BackgroundImage = global::Library.Properties.Resources.Book_lezh2;
            this.btUpdateBook.Location = new System.Drawing.Point(478, 302);
            this.btUpdateBook.Margin = new System.Windows.Forms.Padding(2);
            this.btUpdateBook.Name = "btUpdateBook";
            this.btUpdateBook.Size = new System.Drawing.Size(100, 35);
            this.btUpdateBook.TabIndex = 65;
            this.btUpdateBook.Text = "Изменить";
            this.btUpdateBook.UseVisualStyleBackColor = true;
            this.btUpdateBook.Click += new System.EventHandler(this.btUpdateBook_Click);
            // 
            // btInsertBook
            // 
            this.btInsertBook.BackgroundImage = global::Library.Properties.Resources.Book_lezh;
            this.btInsertBook.Location = new System.Drawing.Point(374, 302);
            this.btInsertBook.Margin = new System.Windows.Forms.Padding(2);
            this.btInsertBook.Name = "btInsertBook";
            this.btInsertBook.Size = new System.Drawing.Size(100, 35);
            this.btInsertBook.TabIndex = 64;
            this.btInsertBook.Text = "Добавить";
            this.btInsertBook.UseVisualStyleBackColor = true;
            this.btInsertBook.Click += new System.EventHandler(this.btInsertBook_Click);
            // 
            // brWord
            // 
            this.brWord.BackgroundImage = global::Library.Properties.Resources.Book_lezh;
            this.brWord.Location = new System.Drawing.Point(311, 47);
            this.brWord.Margin = new System.Windows.Forms.Padding(2);
            this.brWord.Name = "brWord";
            this.brWord.Size = new System.Drawing.Size(100, 47);
            this.brWord.TabIndex = 67;
            this.brWord.Text = "Сформировать билет в PDF";
            this.brWord.UseVisualStyleBackColor = true;
            this.brWord.Click += new System.EventHandler(this.brWord_Click);
            // 
            // ReaderTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 349);
            this.Controls.Add(this.brWord);
            this.Controls.Add(this.btDeleteBook);
            this.Controls.Add(this.btUpdateBook);
            this.Controls.Add(this.btInsertBook);
            this.Controls.Add(this.btDeleteReader);
            this.Controls.Add(this.btUpdateReader);
            this.Controls.Add(this.btInsertReader);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.tbSeria);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbOtch);
            this.Controls.Add(this.tbIm);
            this.Controls.Add(this.tbFam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBooks);
            this.Controls.Add(this.tbDate_accept);
            this.Controls.Add(this.tbDate_of_issue);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.dgvReaders);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReaderTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Читательские билеты";
            this.Load += new System.EventHandler(this.ReaderTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReaders;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.TextBox tbDate_of_issue;
        private System.Windows.Forms.TextBox tbDate_accept;
        private System.Windows.Forms.ComboBox cbBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFam;
        private System.Windows.Forms.TextBox tbIm;
        private System.Windows.Forms.TextBox tbOtch;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbSeria;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btDeleteReader;
        private System.Windows.Forms.Button btUpdateReader;
        private System.Windows.Forms.Button btInsertReader;
        private System.Windows.Forms.Button btDeleteBook;
        private System.Windows.Forms.Button btUpdateBook;
        private System.Windows.Forms.Button btInsertBook;
        private System.Windows.Forms.Button brWord;
    }
}
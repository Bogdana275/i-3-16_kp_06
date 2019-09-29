namespace Library
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.label4 = new System.Windows.Forms.Label();
            this.btPrint = new System.Windows.Forms.Button();
            this.tbPoisk = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbView_order = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSotr = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOrder = new System.Windows.Forms.TextBox();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Поиск:";
            // 
            // btPrint
            // 
            this.btPrint.Location = new System.Drawing.Point(468, 63);
            this.btPrint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(99, 56);
            this.btPrint.TabIndex = 48;
            this.btPrint.Text = "Формирование договора в Word";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // tbPoisk
            // 
            this.tbPoisk.Location = new System.Drawing.Point(473, 26);
            this.tbPoisk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPoisk.Name = "tbPoisk";
            this.tbPoisk.Size = new System.Drawing.Size(76, 20);
            this.tbPoisk.TabIndex = 47;
            this.tbPoisk.TextChanged += new System.EventHandler(this.tbPoisk_TextChanged);
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(221, 45);
            this.tbDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(76, 20);
            this.tbDate.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Вид приказа:";
            // 
            // cbView_order
            // 
            this.cbView_order.FormattingEnabled = true;
            this.cbView_order.Location = new System.Drawing.Point(219, 117);
            this.cbView_order.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbView_order.Name = "cbView_order";
            this.cbView_order.Size = new System.Drawing.Size(128, 21);
            this.cbView_order.TabIndex = 44;
            this.cbView_order.SelectionChangeCommitted += new System.EventHandler(this.cbView_order_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Сотрудник:";
            // 
            // cbSotr
            // 
            this.cbSotr.FormattingEnabled = true;
            this.cbSotr.Location = new System.Drawing.Point(219, 79);
            this.cbSotr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSotr.Name = "cbSotr";
            this.cbSotr.Size = new System.Drawing.Size(128, 21);
            this.cbSotr.TabIndex = 42;
            this.cbSotr.SelectionChangeCommitted += new System.EventHandler(this.cbSotr_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Дата приказа:";
            // 
            // tbOrder
            // 
            this.tbOrder.Location = new System.Drawing.Point(20, 31);
            this.tbOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbOrder.Multiline = true;
            this.tbOrder.Name = "tbOrder";
            this.tbOrder.ReadOnly = true;
            this.tbOrder.Size = new System.Drawing.Size(174, 102);
            this.tbOrder.TabIndex = 40;
            // 
            // dgvOrder
            // 
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(13, 150);
            this.dgvOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.Size = new System.Drawing.Size(554, 161);
            this.dgvOrder.TabIndex = 36;
            this.dgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellClick);
            // 
            // btDelete
            // 
            this.btDelete.BackgroundImage = global::Library.Properties.Resources.Book_lezh3;
            this.btDelete.Location = new System.Drawing.Point(356, 102);
            this.btDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(100, 32);
            this.btDelete.TabIndex = 57;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackgroundImage = global::Library.Properties.Resources.Book_lezh2;
            this.btUpdate.Location = new System.Drawing.Point(356, 63);
            this.btUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(100, 35);
            this.btUpdate.TabIndex = 56;
            this.btUpdate.Text = "Изменить";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btInsert
            // 
            this.btInsert.BackgroundImage = global::Library.Properties.Resources.Book_lezh;
            this.btInsert.Location = new System.Drawing.Point(356, 23);
            this.btInsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(100, 35);
            this.btInsert.TabIndex = 55;
            this.btInsert.Text = "Добавить";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 321);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.tbPoisk);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbView_order);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSotr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOrder);
            this.Controls.Add(this.dgvOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приказы";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.TextBox tbPoisk;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbView_order;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSotr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOrder;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btInsert;
    }
}
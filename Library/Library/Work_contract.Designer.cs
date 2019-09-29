namespace Library
{
    partial class Work_contract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Work_contract));
            this.tbDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSotr = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbWork_contract = new System.Windows.Forms.TextBox();
            this.btPrint = new System.Windows.Forms.Button();
            this.lbPoisk = new System.Windows.Forms.Label();
            this.tbPoisk = new System.Windows.Forms.TextBox();
            this.dgvWork_contract = new System.Windows.Forms.DataGridView();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWork_contract)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(187, 64);
            this.tbDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(76, 20);
            this.tbDate.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Сотрудник:";
            // 
            // cbSotr
            // 
            this.cbSotr.FormattingEnabled = true;
            this.cbSotr.Location = new System.Drawing.Point(187, 114);
            this.cbSotr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSotr.Name = "cbSotr";
            this.cbSotr.Size = new System.Drawing.Size(150, 21);
            this.cbSotr.TabIndex = 23;
            this.cbSotr.SelectionChangeCommitted += new System.EventHandler(this.cbSotr_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Дата договора:";
            // 
            // tbWork_contract
            // 
            this.tbWork_contract.Location = new System.Drawing.Point(12, 26);
            this.tbWork_contract.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbWork_contract.Multiline = true;
            this.tbWork_contract.Name = "tbWork_contract";
            this.tbWork_contract.ReadOnly = true;
            this.tbWork_contract.Size = new System.Drawing.Size(160, 120);
            this.tbWork_contract.TabIndex = 21;
            // 
            // btPrint
            // 
            this.btPrint.Location = new System.Drawing.Point(481, 65);
            this.btPrint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(99, 54);
            this.btPrint.TabIndex = 20;
            this.btPrint.Text = "Формирование договора в Word";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // lbPoisk
            // 
            this.lbPoisk.AutoSize = true;
            this.lbPoisk.Location = new System.Drawing.Point(508, 17);
            this.lbPoisk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPoisk.Name = "lbPoisk";
            this.lbPoisk.Size = new System.Drawing.Size(39, 13);
            this.lbPoisk.TabIndex = 19;
            this.lbPoisk.Text = "Поиск";
            // 
            // tbPoisk
            // 
            this.tbPoisk.Location = new System.Drawing.Point(481, 33);
            this.tbPoisk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPoisk.Name = "tbPoisk";
            this.tbPoisk.Size = new System.Drawing.Size(95, 20);
            this.tbPoisk.TabIndex = 18;
            this.tbPoisk.TextChanged += new System.EventHandler(this.tbPoisk_TextChanged);
            // 
            // dgvWork_contract
            // 
            this.dgvWork_contract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWork_contract.Location = new System.Drawing.Point(12, 160);
            this.dgvWork_contract.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvWork_contract.Name = "dgvWork_contract";
            this.dgvWork_contract.RowTemplate.Height = 24;
            this.dgvWork_contract.Size = new System.Drawing.Size(577, 170);
            this.dgvWork_contract.TabIndex = 14;
            this.dgvWork_contract.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWork_contract_CellClick);
            // 
            // btDelete
            // 
            this.btDelete.BackgroundImage = global::Library.Properties.Resources.Book_lezh3;
            this.btDelete.Location = new System.Drawing.Point(355, 105);
            this.btDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(100, 32);
            this.btDelete.TabIndex = 54;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackgroundImage = global::Library.Properties.Resources.Book_lezh2;
            this.btUpdate.Location = new System.Drawing.Point(355, 65);
            this.btUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(100, 35);
            this.btUpdate.TabIndex = 53;
            this.btUpdate.Text = "Изменить";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btInsert
            // 
            this.btInsert.BackgroundImage = global::Library.Properties.Resources.Book_lezh;
            this.btInsert.Location = new System.Drawing.Point(355, 25);
            this.btInsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(100, 35);
            this.btInsert.TabIndex = 52;
            this.btInsert.Text = "Добавить";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // Work_contract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 349);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSotr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbWork_contract);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.lbPoisk);
            this.Controls.Add(this.tbPoisk);
            this.Controls.Add(this.dgvWork_contract);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Work_contract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Трудовой договор";
            this.Load += new System.EventHandler(this.Work_contract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWork_contract)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSotr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbWork_contract;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Label lbPoisk;
        private System.Windows.Forms.TextBox tbPoisk;
        private System.Windows.Forms.DataGridView dgvWork_contract;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btInsert;
    }
}
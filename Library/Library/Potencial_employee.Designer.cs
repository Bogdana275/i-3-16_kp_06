namespace Library
{
    partial class Potencial_employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Potencial_employee));
            this.label8 = new System.Windows.Forms.Label();
            this.tbPoisk = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDolj = new System.Windows.Forms.ComboBox();
            this.cbEducation = new System.Windows.Forms.ComboBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbOtch = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbIm = new System.Windows.Forms.TextBox();
            this.tbFam = new System.Windows.Forms.TextBox();
            this.dgvPotencial_employee = new System.Windows.Forms.DataGridView();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPotencial_employee)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(351, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 53;
            this.label8.Text = "Поиск:";
            // 
            // tbPoisk
            // 
            this.tbPoisk.Location = new System.Drawing.Point(409, 85);
            this.tbPoisk.Name = "tbPoisk";
            this.tbPoisk.Size = new System.Drawing.Size(161, 22);
            this.tbPoisk.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(204, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 17);
            this.label10.TabIndex = 48;
            this.label10.Text = "Образование:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 46;
            this.label7.Text = "Должность:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Телефон:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Дата рождения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Отчество:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Имя:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Фамилия:";
            // 
            // cbDolj
            // 
            this.cbDolj.FormattingEnabled = true;
            this.cbDolj.Location = new System.Drawing.Point(206, 145);
            this.cbDolj.Name = "cbDolj";
            this.cbDolj.Size = new System.Drawing.Size(120, 24);
            this.cbDolj.TabIndex = 38;
            this.cbDolj.SelectionChangeCommitted += new System.EventHandler(this.cbDolj_SelectionChangeCommitted);
            // 
            // cbEducation
            // 
            this.cbEducation.FormattingEnabled = true;
            this.cbEducation.Location = new System.Drawing.Point(206, 85);
            this.cbEducation.Name = "cbEducation";
            this.cbEducation.Size = new System.Drawing.Size(121, 24);
            this.cbEducation.TabIndex = 37;
            this.cbEducation.SelectionChangeCommitted += new System.EventHandler(this.cbEducation_SelectionChangeCommitted);
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(43, 171);
            this.tbDate.MaxLength = 10;
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(100, 22);
            this.tbDate.TabIndex = 34;
            // 
            // tbOtch
            // 
            this.tbOtch.Location = new System.Drawing.Point(43, 121);
            this.tbOtch.Name = "tbOtch";
            this.tbOtch.Size = new System.Drawing.Size(100, 22);
            this.tbOtch.TabIndex = 33;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(207, 31);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(100, 22);
            this.tbPhone.TabIndex = 32;
            // 
            // tbIm
            // 
            this.tbIm.Location = new System.Drawing.Point(43, 76);
            this.tbIm.Name = "tbIm";
            this.tbIm.Size = new System.Drawing.Size(100, 22);
            this.tbIm.TabIndex = 31;
            // 
            // tbFam
            // 
            this.tbFam.Location = new System.Drawing.Point(43, 29);
            this.tbFam.Name = "tbFam";
            this.tbFam.Size = new System.Drawing.Size(100, 22);
            this.tbFam.TabIndex = 30;
            // 
            // dgvPotencial_employee
            // 
            this.dgvPotencial_employee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPotencial_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPotencial_employee.Location = new System.Drawing.Point(22, 223);
            this.dgvPotencial_employee.Name = "dgvPotencial_employee";
            this.dgvPotencial_employee.RowTemplate.Height = 24;
            this.dgvPotencial_employee.Size = new System.Drawing.Size(756, 218);
            this.dgvPotencial_employee.TabIndex = 29;
            this.dgvPotencial_employee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPotencial_employee_CellClick);
            // 
            // btDelete
            // 
            this.btDelete.BackgroundImage = global::Library.Properties.Resources.Book_lezh3;
            this.btDelete.Location = new System.Drawing.Point(607, 129);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(133, 40);
            this.btDelete.TabIndex = 51;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackgroundImage = global::Library.Properties.Resources.Book_lezh2;
            this.btUpdate.Location = new System.Drawing.Point(607, 80);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(133, 43);
            this.btUpdate.TabIndex = 50;
            this.btUpdate.Text = "Изменить";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btInsert
            // 
            this.btInsert.BackgroundImage = global::Library.Properties.Resources.Book_lezh;
            this.btInsert.Location = new System.Drawing.Point(607, 31);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(133, 43);
            this.btInsert.TabIndex = 49;
            this.btInsert.Text = "Добавить";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // Potencial_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbPoisk);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDolj);
            this.Controls.Add(this.cbEducation);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.tbOtch);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbIm);
            this.Controls.Add(this.tbFam);
            this.Controls.Add(this.dgvPotencial_employee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Potencial_employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Потенциальные работники";
            this.Load += new System.EventHandler(this.Potencial_employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPotencial_employee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPoisk;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDolj;
        private System.Windows.Forms.ComboBox cbEducation;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbOtch;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbIm;
        private System.Windows.Forms.TextBox tbFam;
        private System.Windows.Forms.DataGridView dgvPotencial_employee;
    }
}
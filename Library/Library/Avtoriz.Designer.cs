namespace Library
{
    partial class Avtoriz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Avtoriz));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEmployee = new System.Windows.Forms.TabPage();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.btUpdateEmployee = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRoleEmployee = new System.Windows.Forms.ComboBox();
            this.tbPasswordEmployee = new System.Windows.Forms.TextBox();
            this.tbLoginEmployee = new System.Windows.Forms.TextBox();
            this.tabPageReader = new System.Windows.Forms.TabPage();
            this.dgvReaders = new System.Windows.Forms.DataGridView();
            this.btUpdateReader = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbRoleReader = new System.Windows.Forms.ComboBox();
            this.tbPasswordReader = new System.Windows.Forms.TextBox();
            this.tbLoginReader = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPageEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.tabPageReader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaders)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageEmployee);
            this.tabControl1.Controls.Add(this.tabPageReader);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(568, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageEmployee
            // 
            this.tabPageEmployee.Controls.Add(this.dgvEmployee);
            this.tabPageEmployee.Controls.Add(this.btUpdateEmployee);
            this.tabPageEmployee.Controls.Add(this.label3);
            this.tabPageEmployee.Controls.Add(this.label2);
            this.tabPageEmployee.Controls.Add(this.label1);
            this.tabPageEmployee.Controls.Add(this.cbRoleEmployee);
            this.tabPageEmployee.Controls.Add(this.tbPasswordEmployee);
            this.tabPageEmployee.Controls.Add(this.tbLoginEmployee);
            this.tabPageEmployee.Location = new System.Drawing.Point(4, 25);
            this.tabPageEmployee.Name = "tabPageEmployee";
            this.tabPageEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployee.Size = new System.Drawing.Size(560, 421);
            this.tabPageEmployee.TabIndex = 0;
            this.tabPageEmployee.Text = "Сотрудники";
            this.tabPageEmployee.UseVisualStyleBackColor = true;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(8, 182);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.Size = new System.Drawing.Size(544, 233);
            this.dgvEmployee.TabIndex = 14;
            this.dgvEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellClick_1);
            // 
            // btUpdateEmployee
            // 
            this.btUpdateEmployee.BackgroundImage = global::Library.Properties.Resources.Book_lezh2;
            this.btUpdateEmployee.Location = new System.Drawing.Point(325, 75);
            this.btUpdateEmployee.Name = "btUpdateEmployee";
            this.btUpdateEmployee.Size = new System.Drawing.Size(133, 43);
            this.btUpdateEmployee.TabIndex = 12;
            this.btUpdateEmployee.Text = "Изменить";
            this.btUpdateEmployee.UseVisualStyleBackColor = true;
            this.btUpdateEmployee.Click += new System.EventHandler(this.btUpdateEmployee_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Роль:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин:";
            // 
            // cbRoleEmployee
            // 
            this.cbRoleEmployee.FormattingEnabled = true;
            this.cbRoleEmployee.Location = new System.Drawing.Point(171, 89);
            this.cbRoleEmployee.Name = "cbRoleEmployee";
            this.cbRoleEmployee.Size = new System.Drawing.Size(121, 24);
            this.cbRoleEmployee.TabIndex = 3;
            this.cbRoleEmployee.SelectionChangeCommitted += new System.EventHandler(this.cbRoleEmployee_SelectionChangeCommitted);
            // 
            // tbPasswordEmployee
            // 
            this.tbPasswordEmployee.Location = new System.Drawing.Point(38, 115);
            this.tbPasswordEmployee.Name = "tbPasswordEmployee";
            this.tbPasswordEmployee.Size = new System.Drawing.Size(100, 22);
            this.tbPasswordEmployee.TabIndex = 2;
            // 
            // tbLoginEmployee
            // 
            this.tbLoginEmployee.Location = new System.Drawing.Point(38, 63);
            this.tbLoginEmployee.Name = "tbLoginEmployee";
            this.tbLoginEmployee.Size = new System.Drawing.Size(100, 22);
            this.tbLoginEmployee.TabIndex = 1;
            // 
            // tabPageReader
            // 
            this.tabPageReader.Controls.Add(this.dgvReaders);
            this.tabPageReader.Controls.Add(this.btUpdateReader);
            this.tabPageReader.Controls.Add(this.label4);
            this.tabPageReader.Controls.Add(this.label5);
            this.tabPageReader.Controls.Add(this.label6);
            this.tabPageReader.Controls.Add(this.cbRoleReader);
            this.tabPageReader.Controls.Add(this.tbPasswordReader);
            this.tabPageReader.Controls.Add(this.tbLoginReader);
            this.tabPageReader.Location = new System.Drawing.Point(4, 25);
            this.tabPageReader.Name = "tabPageReader";
            this.tabPageReader.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReader.Size = new System.Drawing.Size(560, 421);
            this.tabPageReader.TabIndex = 1;
            this.tabPageReader.Text = "Читатели";
            this.tabPageReader.UseVisualStyleBackColor = true;
            // 
            // dgvReaders
            // 
            this.dgvReaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReaders.Location = new System.Drawing.Point(8, 192);
            this.dgvReaders.Name = "dgvReaders";
            this.dgvReaders.RowTemplate.Height = 24;
            this.dgvReaders.Size = new System.Drawing.Size(544, 221);
            this.dgvReaders.TabIndex = 23;
            this.dgvReaders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReaders_CellClick);
            // 
            // btUpdateReader
            // 
            this.btUpdateReader.BackgroundImage = global::Library.Properties.Resources.Book_lezh2;
            this.btUpdateReader.Location = new System.Drawing.Point(342, 80);
            this.btUpdateReader.Name = "btUpdateReader";
            this.btUpdateReader.Size = new System.Drawing.Size(133, 43);
            this.btUpdateReader.TabIndex = 21;
            this.btUpdateReader.Text = "Изменить";
            this.btUpdateReader.UseVisualStyleBackColor = true;
            this.btUpdateReader.Click += new System.EventHandler(this.btUpdateReader_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Роль:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Пароль:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Логин:";
            // 
            // cbRoleReader
            // 
            this.cbRoleReader.FormattingEnabled = true;
            this.cbRoleReader.Location = new System.Drawing.Point(188, 94);
            this.cbRoleReader.Name = "cbRoleReader";
            this.cbRoleReader.Size = new System.Drawing.Size(121, 24);
            this.cbRoleReader.TabIndex = 16;
            this.cbRoleReader.SelectionChangeCommitted += new System.EventHandler(this.cbRoleReader_SelectionChangeCommitted);
            // 
            // tbPasswordReader
            // 
            this.tbPasswordReader.Location = new System.Drawing.Point(55, 120);
            this.tbPasswordReader.Name = "tbPasswordReader";
            this.tbPasswordReader.Size = new System.Drawing.Size(100, 22);
            this.tbPasswordReader.TabIndex = 15;
            // 
            // tbLoginReader
            // 
            this.tbLoginReader.Location = new System.Drawing.Point(55, 68);
            this.tbLoginReader.Name = "tbLoginReader";
            this.tbLoginReader.Size = new System.Drawing.Size(100, 22);
            this.tbLoginReader.TabIndex = 14;
            // 
            // Avtoriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Avtoriz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Avtoriz_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageEmployee.ResumeLayout(false);
            this.tabPageEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.tabPageReader.ResumeLayout(false);
            this.tabPageReader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEmployee;
        private System.Windows.Forms.TabPage tabPageReader;
        private System.Windows.Forms.DataGridView dgvReader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRoleEmployee;
        private System.Windows.Forms.TextBox tbPasswordEmployee;
        private System.Windows.Forms.TextBox tbLoginEmployee;
        private System.Windows.Forms.Button btUpdateEmployee;
        private System.Windows.Forms.Button btUpdateReader;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbRoleReader;
        private System.Windows.Forms.TextBox tbPasswordReader;
        private System.Windows.Forms.TextBox tbLoginReader;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridView dgvReaders;
    }
}
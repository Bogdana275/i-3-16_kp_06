namespace Library
{
    partial class Move_book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Move_book));
            this.dgvMove_book = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMove_book)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMove_book
            // 
            this.dgvMove_book.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMove_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMove_book.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMove_book.Location = new System.Drawing.Point(0, 0);
            this.dgvMove_book.Name = "dgvMove_book";
            this.dgvMove_book.RowTemplate.Height = 24;
            this.dgvMove_book.Size = new System.Drawing.Size(719, 477);
            this.dgvMove_book.TabIndex = 0;
            // 
            // Move_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 477);
            this.Controls.Add(this.dgvMove_book);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Move_book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Движение книг";
            this.Load += new System.EventHandler(this.Move_book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMove_book)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMove_book;
    }
}
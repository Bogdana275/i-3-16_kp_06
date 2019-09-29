using System;
using System.Windows.Forms;

namespace Library
{
    public partial class Move_book : Form
    {
        public Move_book()
        {
            InitializeComponent();
        }

        private void Move_book_Load(object sender, EventArgs e)
        {
            dgvMove_bookFill();

        }

        private void dgvMove_bookFill()
        {
            Tables data = new Tables();
            data.dtMove_bookFill();
            dgvMove_book.DataSource = data.dtMove_book;
            dgvMove_book.Columns[0].Visible = false;
            dgvMove_book.Columns[1].Visible = false;
            dgvMove_book.Columns[2].Visible = false;
            dgvMove_book.Columns[4].Visible = false;
        }
    }
}

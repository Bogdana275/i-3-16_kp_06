using System;
using System.Windows.Forms;

namespace Library
{
    public partial class Author : Form
    {
        public Author()
        {
            InitializeComponent();
        }
        Int32 id_author;
        Procedures procedure = new Procedures();
        private void btDelete_Click(object sender, EventArgs e)
        {
            switch (tbFam.Text == "" | tbIm.Text == "")
            {
                case (true):
                    MessageBox.Show("Выберите автора!");
                    break;
                case (false):
                    try
                    {
                        if (MessageBox.Show("Вы точно хотите удалить автора?",
                            "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        procedure.spAuthor_delete(id_author);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        tbClear();
                        dgvFill();
                    }
                    break;
            }
        }

        private void Author_Load(object sender, EventArgs e)
        {
            dgvFill();
        }

        private void dgvFill()
        {
            Tables data = new Tables();
            data.dtAuthorFill();
            dgvAuthor.DataSource = data.dtAuthor;
            dgvAuthor.Columns[0].Visible = false;
        }

        private void dgvAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id_author = Convert.ToInt32(dgvAuthor.CurrentRow.Cells[0].Value.ToString());
                tbFam.Text = dgvAuthor.CurrentRow.Cells[1].Value.ToString();
                tbIm.Text = dgvAuthor.CurrentRow.Cells[2].Value.ToString();
                tbOtch.Text = dgvAuthor.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            switch (tbFam.Text == "" | tbIm.Text == "")
            {
                case (true):
                    MessageBox.Show("Не все поля заполнены!");
                    break;
                case (false):
                    try
                    {
                        procedure.spAuthor_insert(tbFam.Text, tbIm.Text, tbOtch.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        tbClear();
                        dgvFill();
                    }
                    break;
            }


        }

        private void tbClear()
        {
            tbFam.Clear();
            tbIm.Clear();
            tbOtch.Clear();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            switch (tbFam.Text == "" | tbIm.Text == "")
            {
                case (true):
                    MessageBox.Show("Выберите сотрудника для изменения!");
                    break;
                case (false):
                    try
                    {
                        procedure.spAuthor_update(tbFam.Text, tbIm.Text, tbOtch.Text, id_author);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        tbClear();
                        dgvFill();
                    }
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

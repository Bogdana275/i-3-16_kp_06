using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }
        SqlCommand command = new SqlCommand("",ConnectionLibrary.ConnectionLibrary.sqlConnection);
        Procedures procedure = new Procedures();
        Int32 id_provider, id_author, id_genre, id_publisher, id_book;
        private void Books_Load(object sender, EventArgs e)
        {
            dgvFill();
            cbAuthorFill();
            cbGenreFill();
            cbProviderFill();
            cbPublisherFill();
            id_provider = Convert.ToInt32(cbProvider.SelectedValue);
            id_publisher = Convert.ToInt32(cbPublisher.SelectedValue);
            id_genre = Convert.ToInt32(cbGenre.SelectedValue);
            id_author = Convert.ToInt32(cbAuthor.SelectedValue);

        }

        private void dgvFill()
        {
            Tables data = new Tables();
            data.dtBookFill();
            dgvBook.DataSource = data.dtBook;
            dgvBook.Columns[0].Visible = false;
            dgvBook.Columns[1].Visible = false;
            dgvBook.Columns[3].Visible = false;
            dgvBook.Columns[6].Visible = false;
            dgvBook.Columns[8].Visible = false;
        }

        private void cbAuthorFill()
        {
            try
            {
                Tables dtAuthor = new Tables();
                command.CommandText = "Select id_author as 'Ключ автора',F_author +' '+ SUBSTRING(I_author,1,1) +'.'+ SUBSTRING(O_author,1,1) + '.' as 'Автор' from Author";
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                dtAuthor.dtFill(dtAuthor.dtAuthor, command.CommandText);
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                cbAuthor.DataSource = dtAuthor.dtAuthor;
                cbAuthor.ValueMember = "Ключ автора";
                cbAuthor.DisplayMember = "Автор";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbGenreFill()
        {
            try
            {
                Tables dtGenre = new Tables();
                dtGenre.dtGenreFill();
                cbGenre.DataSource = dtGenre.dtGenre;
                cbGenre.ValueMember = "Ключ жанра";
                cbGenre.DisplayMember = "Жанр";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbPublisher_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id_publisher = Convert.ToInt32(cbPublisher.SelectedValue);
        }

        private void cbGenre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id_genre = Convert.ToInt32(cbGenre.SelectedValue);
        }

        private void cbAuthor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id_author = Convert.ToInt32(cbAuthor.SelectedValue);
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            switch (tbName_book.Text == ""|tbPrice.Text == ""|nupKol_vo.Value == 0)
            {
                case (true):
                    MessageBox.Show("Не все поля заполнены!");
                    break;
                case (false):
                    try
                    {
                        procedure.spBook_insert(tbName_book.Text, id_provider, id_author, id_publisher, id_genre, Convert.ToInt32(nupKol_vo.Value), Convert.ToDouble(tbPrice.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        tbClear();
                        Books_Load(sender, e);
                    }
                    break;
            }
        }

        private void tbClear()
        {
            tbName_book.Clear();
            tbPrice.Clear();
            nupKol_vo.Value = 0;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            switch (tbName_book.Text == "" | tbPrice.Text == "" | nupKol_vo.Value == 0)
            {
                case (true):
                    MessageBox.Show("Не все поля заполнены!");
                    break;
                case (false):
                    try
                    {
                        procedure.spBook_update(tbName_book.Text, id_provider, id_author, id_publisher, id_genre, Convert.ToInt32(nupKol_vo.Value), Convert.ToDouble(tbPrice.Text), id_book);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        tbClear();
                        Books_Load(sender, e);
                    }
                    break;
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            switch (tbName_book.Text == "" | tbPrice.Text == "" | nupKol_vo.Value == 0)
            {
                case (true):
                    MessageBox.Show("Выберите книгу!");
                    break;
                case (false):
                    try
                    {
                        procedure.spBook_delete(id_book);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        tbClear();
                        Books_Load(sender, e);
                    }
                    break;
            }
        }

        private void tbPoisk_TextChanged(object sender, EventArgs e)
        {
            if (tbPoisk.Text == "")
            {
                Books_Load(sender, e);
            }
            else
            {
                //Tables query = new Tables();
                //command.CommandText = query.qrAuthor +
                //    " where (name_book like '%" + tbName_book.Text + "%') " +
                //    "or ( like '%" + tbPoisk.Text + "%') " +
                //    "or (otchestvo like '%" + tbPoisk.Text + "%') " +
                //    "or (date_of_pricaz like '%" + tbPoisk.Text + "%') " +
                //    "or (vid_pricaz like '%" + tbPoisk.Text + "%') " +
                //    "or (doljnost like '%" + tbPoisk.Text + "%')";


                //DataTable dt = new DataTable();

                //ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                //dt.Load(command.ExecuteReader());
                //dgvBooks.DataSource = dt;
                //ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            }
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id_book = Convert.ToInt32(dgvBook.CurrentRow.Cells[0].Value.ToString());
                id_provider = Convert.ToInt32(dgvBook.CurrentRow.Cells[1].Value.ToString());
                id_author = Convert.ToInt32(dgvBook.CurrentRow.Cells[3].Value.ToString());
                command.CommandText = "Select name_book from book where id_book=" +id_book;
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
               tbName_book.Text = command.ExecuteScalar().ToString();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                id_publisher = Convert.ToInt32(dgvBook.CurrentRow.Cells[6].Value.ToString());
                id_genre = Convert.ToInt32(dgvBook.CurrentRow.Cells[8].Value.ToString());
                nupKol_vo.Value = Convert.ToInt32(dgvBook.CurrentRow.Cells[10].Value.ToString());
                tbPrice.Text = dgvBook.CurrentRow.Cells[11].Value.ToString();
                cbPublisher.SelectedValue = id_publisher;
                cbProvider.SelectedValue = id_provider;
                cbGenre.SelectedValue = id_genre;
                cbAuthor.SelectedValue = id_author;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbProviderFill()
        {
            try
            {
                Tables dtProvider = new Tables();
                dtProvider.dtProviderFill();
                cbProvider.DataSource = dtProvider.dtProvider;
                cbProvider.ValueMember = "Ключ поставщика";
                cbProvider.DisplayMember = "Поставщик";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cbPublisherFill()
        {
            try
            {
                Tables dtPublisher = new Tables();
                dtPublisher.dtPublisherFill();
                cbPublisher.DataSource = dtPublisher.dtPublisher;
                cbPublisher.ValueMember = "Ключ издательства";
                cbPublisher.DisplayMember = "Издательство";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbProvider_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id_provider = Convert.ToInt32(cbProvider.SelectedValue);
        }
    }
}

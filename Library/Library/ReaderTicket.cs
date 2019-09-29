using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using word = Microsoft.Office.Interop.Word;
using System.Drawing;

namespace Library
{
    public partial class ReaderTicket : Form
    {
        public ReaderTicket()
        {
            InitializeComponent();
        }
        Int32 id_reader_ticket, id_book, id_avtoriz, id_move_book;
        Procedures procedure = new Procedures();
        SqlCommand command = new SqlCommand("",ConnectionLibrary.ConnectionLibrary.sqlConnection);
        string path;
        private void ReaderTicket_Load(object sender, EventArgs e)
        {
            dgvReaderFill();
        }

        private void cbBooks_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id_book = Convert.ToInt32(cbBooks.SelectedValue.ToString());
        }

        private void dgvReaders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_reader_ticket = Convert.ToInt32(dgvReaders.CurrentRow.Cells[0].Value.ToString());
            
            tbFam.Text = dgvReaders.CurrentRow.Cells[1].Value.ToString();
            tbIm.Text = dgvReaders.CurrentRow.Cells[2].Value.ToString();
            tbOtch.Text = dgvReaders.CurrentRow.Cells[3].Value.ToString();
            tbSeria.Text = dgvReaders.CurrentRow.Cells[4].Value.ToString();
            tbNumber.Text = dgvReaders.CurrentRow.Cells[5].Value.ToString();
            tbPhone.Text = dgvReaders.CurrentRow.Cells[6].Value.ToString();
            id_avtoriz = Convert.ToInt32(dgvReaders.CurrentRow.Cells[7].Value.ToString());
            tbLogin.Text = dgvReaders.CurrentRow.Cells[8].Value.ToString();
            tbPassword.Text = dgvReaders.CurrentRow.Cells[9].Value.ToString();
            dgvBooksFill();
            cbBooksFill();

        }

        private void cbBooksFill()
        {
            try
            {
                DataTable dt = new DataTable();
                command.CommandText = "Select id_book, Book from View_all_book";
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                dt.Load(command.ExecuteReader());
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                cbBooks.DataSource = dt;
                cbBooks.ValueMember = "id_book";
                cbBooks.DisplayMember = "Book";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvReaderFill()
        {
            Tables data = new Tables();
            data.dtReader_ticketFill();
            dgvReaders.DataSource = data.dtReader_ticket;

            dgvReaders.Columns[0].Visible = false;
            dgvReaders.Columns[7].Visible = false;
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            switch (tbFam.Text == "" | tbIm.Text == "" | tbPhone.Text == "" | tbOtch.Text == "" | tbNumber.Text == "" | tbLogin.Text == "" | tbPassword.Text == "")
            {
                case (true):
                    MessageBox.Show("Не все поля заполнены!");
                    break;
                case (false):
                    try
                    {
                        procedure.spAvtoriz_insert(tbLogin.Text, tbPassword.Text, 6);
                        command.CommandText = "Select id_avtoriz from avtoriz where login='" + tbLogin.Text + "' and password='" + tbPassword.Text + "'";
                        ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                        ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                        id_avtoriz = Convert.ToInt32(command.ExecuteScalar().ToString());
                        ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                        procedure.spReader_ticket_insert(tbFam.Text, tbIm.Text, tbOtch.Text, id_avtoriz, tbSeria.Text, tbNumber.Text, tbPhone.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        tbClear();
                        ReaderTicket_Load(sender, e);
                    }
                    break;
            }
        }

        private void tbClear()
        {
            tbFam.Clear();
            tbIm.Clear();
            tbPhone.Clear();
            tbOtch.Clear();
            tbNumber.Clear();
            tbSeria.Clear();
            tbLogin.Clear();
            tbPassword.Clear();
            tbDate_accept.Clear();
            tbDate_of_issue.Clear();
        }

        private void btUpdateReader_Click(object sender, EventArgs e)
        {
            switch (tbFam.Text == "" | tbIm.Text == "" | tbPhone.Text == "" | tbOtch.Text == "" | tbNumber.Text == "" | tbLogin.Text == "" | tbPassword.Text == "")
            {
                case (true):
                    MessageBox.Show("Выберите читателя!");
                    break;
                case (false):
                    try
                    {
                        ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                        command.CommandText = "Select id_avtoriz from avtoriz where login='" + tbLogin.Text + "' and password='" + tbPassword.Text + "'";
                        
                        ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                        id_avtoriz = Convert.ToInt32(command.ExecuteScalar().ToString());
                        ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                        procedure.spAvtoriz_update(tbLogin.Text, tbPassword.Text, 6, id_avtoriz);
                        
                        procedure.spReader_ticket_update(id_reader_ticket, tbFam.Text, tbIm.Text, tbOtch.Text, id_avtoriz, tbSeria.Text, tbNumber.Text, tbPhone.Text);
            }
                    catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbClear();
                        ReaderTicket_Load(sender, e);
            }
            break;
            }
        }

        private void btDeleteReader_Click(object sender, EventArgs e)
        {
            switch (tbFam.Text == "" | tbIm.Text == "" | tbPhone.Text == "" | tbOtch.Text == "" | tbNumber.Text == "" | tbLogin.Text == "" | tbPassword.Text == "")
            {
                case (true):
                    MessageBox.Show("Выберите читателя!");
                    break;
                case (false):
                    try
                    {
                        procedure.spReader_ticket_delete(id_reader_ticket);
                        command.CommandText = "Select id_avtoriz from avtoriz where login='" + tbLogin.Text + "' and password='" + tbPassword.Text + "'";
                        ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                        ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                        id_avtoriz = Convert.ToInt32(command.ExecuteScalar().ToString());
                        ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                        procedure.spAvtoriz_delete(id_avtoriz);
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        tbClear();
                        ReaderTicket_Load(sender, e);
                    }
                    break;
            }
        }

        private void btInsertBook_Click(object sender, EventArgs e)
        {
            switch (tbDate_of_issue.Text == "")
            {
                case (true):
                    MessageBox.Show("Не все поля заполнены!");
                    break;
                case (false):
                    try
                    {
                        procedure.spMove_book_insert(tbDate_of_issue.Text, tbDate_accept.Text, id_book, id_reader_ticket);
                        dgvBooksFill();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        tbDate_accept.Clear();
                        tbDate_of_issue.Clear();
                        ReaderTicket_Load(sender, e);
                    }
                    break;
            }
        }

        private void btDeleteBook_Click(object sender, EventArgs e)
        {
            switch (tbDate_of_issue.Text == "")
            {
                case (true):
                    MessageBox.Show("Выберите книгу!");
                    break;
                case (false):
                    try
                    {
                        procedure.spMove_book_delete(id_move_book);
                        dgvBooksFill();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        tbDate_accept.Clear();
                        tbDate_of_issue.Clear();
                        ReaderTicket_Load(sender, e);
                    }
                    break;
            }
        }

        private void brWord_Click(object sender, EventArgs e)
        {
            word.Application application = new word.Application();
            word.Document document = application.Documents.Add(Visible: true);
            word.Range range = document.Range(0, 0);
            ConnectionLibrary.ConnectionLibrary.ConfigurationGet();

            try
            {
                document.Sections.PageSetup.LeftMargin
                    = application.CentimetersToPoints(Convert.ToSingle(ConnectionLibrary.ConnectionLibrary.DocLM));
                document.Sections.PageSetup.RightMargin
                    = application.CentimetersToPoints(Convert.ToSingle(ConnectionLibrary.ConnectionLibrary.DocRM));
                document.Sections.PageSetup.TopMargin
                    = application.CentimetersToPoints(Convert.ToSingle(ConnectionLibrary.ConnectionLibrary.DocTM));
                document.Sections.PageSetup.BottomMargin
                    = application.CentimetersToPoints(Convert.ToSingle(ConnectionLibrary.ConnectionLibrary.DocBM));
                document.Paragraphs.Add();
                word.Paragraph Name_Shool = document.Paragraphs.Add();
                Name_Shool.Range.Font.Name = ConnectionLibrary.ConnectionLibrary.DocSFF;
                Name_Shool.Range.Text = ConnectionLibrary.ConnectionLibrary.OrganizationName;
                Name_Shool.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
                Name_Shool.Range.Font.Size = 16;
                Name_Shool.Range.Bold = 3;
                document.Paragraphs.Add();
                word.Paragraph Name_Doc = document.Paragraphs.Add();
                Name_Doc.Range.Font.Name = ConnectionLibrary.ConnectionLibrary.DocSFF;
                Name_Doc.Range.Font.Size = 16;
                Name_Doc.Range.Text = "Читательский билет №" + id_reader_ticket;
                Name_Doc.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
                Name_Shool.Range.Bold = 3;
                document.Paragraphs.Add();
                
                word.Paragraph info1 = document.Paragraphs.Add();
                info1.Range.Font.Name = ConnectionLibrary.ConnectionLibrary.DocSFF;
                info1.Range.Font.Size = 14;
                info1.Range.Text = "ФИО: " + tbFam.Text +" "+ tbIm.Text + " " +tbOtch.Text;
                info1.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphLeft;
                info1.Range.Bold = 0;
                document.Paragraphs.Add();

                word.Paragraph info2 = document.Paragraphs.Add();
                info2.Range.Font.Name = ConnectionLibrary.ConnectionLibrary.DocSFF;
                info2.Range.Font.Size = 14;
                info2.Range.Text = "Паспорт: " + tbSeria.Text +" "+tbNumber.Text;
                info2.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphLeft;
                info2.Range.Bold = 0;
                document.Paragraphs.Add();

                word.Paragraph info3 = document.Paragraphs.Add();
                info3.Range.Font.Name = ConnectionLibrary.ConnectionLibrary.DocSFF;
                info3.Range.Font.Size = 14;
                info3.Range.Text = "Номер телефона: " + tbPhone.Text;
                info3.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphLeft;
                info3.Range.Bold = 0;
                document.Paragraphs.Add();

                word.Paragraph Data_info = document.Paragraphs.Add();
                word.Table tbdata1 = document.Tables.Add(Data_info.Range, dgvBooks.Rows.Count, 3);
                tbdata1.Range.Font.Size = 14;
                tbdata1.Range.Font.Name = ConnectionLibrary.ConnectionLibrary.DocSFF;
                tbdata1.Borders.InsideLineStyle = word.WdLineStyle.wdLineStyleSingle;
                tbdata1.Borders.OutsideLineStyle = word.WdLineStyle.wdLineStyleSingle;


                tbdata1.Cell(1, 1).Range.Text = "Книга";
                tbdata1.Cell(1, 2).Range.Text = "Дата выдачи";
                tbdata1.Cell(1, 3).Range.Text = "Дата принятия";
                for (int i = 0; i < dgvBooks.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvBooks.ColumnCount - 2; j++)
                    {
                        tbdata1.Cell(i + 2, j + 1).Range.Text = Convert.ToString(dgvBooks.Rows[i].Cells[j].Value);
                    }
                }
                tbdata1.Range.Bold = 0;
                document.Paragraphs.Add();
            }
            catch (Exception ex)
            {
                ConnectionLibrary.ConnectionLibrary.error_message += "\n"
                    + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                path = "";
                path = ConnectionLibrary.ConnectionLibrary.DirPath + "\\Читательский билет №" +id_reader_ticket +" "
                    + tbFam.Text +" "+ tbIm.Text + " " + tbOtch.Text;
                document.SaveAs(FileName: path, FileFormat: word.WdExportFormat.wdExportFormatPDF);
                document.Close(document.Saved = false);
                application.Quit();
                MessageBox.Show("");

            }
        }

        private void DgvToArr()
        {
            
          
        }

        private void ArrToTableWord()
        {
            
             
        }

        private void btUpdateBook_Click(object sender, EventArgs e)
        {
            switch (tbDate_of_issue.Text == "")
            {
                case (true):
                    MessageBox.Show("Выберите книгу!");
                    break;
                case (false):
                    try
                    {
                        procedure.spMove_book_update(id_move_book, tbDate_of_issue.Text, tbDate_accept.Text, id_book, id_reader_ticket);
                        dgvBooksFill();
            }
                    catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbDate_accept.Clear();
                        tbDate_of_issue.Clear();
                        ReaderTicket_Load(sender, e);
                    }
                    break;
            }
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_book = Convert.ToInt32(dgvBooks.CurrentRow.Cells[3].Value.ToString());
            id_move_book = Convert.ToInt32(dgvBooks.CurrentRow.Cells[4].Value.ToString());
            cbBooks.SelectedValue = id_book;
            tbDate_accept.Text = dgvBooks.CurrentRow.Cells[2].Value.ToString();
            tbDate_of_issue.Text = dgvBooks.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvBooksFill()
        {

            command.CommandText = "select book as 'Книга', date_of_issue as 'Дата выдачи', date_accept as 'Дата принятия', id_book, id_move_book" +
                " from View_move_book"+
                " where  id_reader_ticket =" + id_reader_ticket;
            DataTable dt = new DataTable();

            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            dt.Load(command.ExecuteReader());
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            dgvBooks.DataSource = dt;
            dgvBooks.Columns[3].Visible = false;
            dgvBooks.Columns[4].Visible = false;
        }


            
    }
}

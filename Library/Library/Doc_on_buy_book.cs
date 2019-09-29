using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using excel = Microsoft.Office.Interop.Excel;

namespace Library
{
    public partial class Doc_on_buy_book : Form
    {
        public Doc_on_buy_book()
        {
            InitializeComponent();
        }
        SqlCommand command = new SqlCommand("",ConnectionLibrary.ConnectionLibrary.sqlConnection);
        List<string>Dates = new List<string>();
        Int32 id_book, id_provider, id_doc_on_buy_book;
        string provider, address;
        Procedures procedure = new Procedures();
        
        private void Doc_on_buy_book_Load(object sender, EventArgs e)
        {
            cbProviderFill();
            dgvDocFill();

        }


        private void cbProviderFill()
        {
            try
            {
                Tables dtContract_with_provider = new Tables();
                dtContract_with_provider.dtContract_with_providerFill();
                cbProvider.DataSource = dtContract_with_provider.dtContract_with_provider;
                cbProvider.ValueMember = "Ключ поставщика";
                cbProvider.DisplayMember = "Поставщик";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDocFill()
        {
            command.CommandText = "Select distinct(date_of_doc_on_buy_book) from Doc_on_buy_book";
            DataTable dtData = new DataTable();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            dtData.Load(command.ExecuteReader());
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            foreach (DataRow row in dtData.Rows)
            {
                Dates.Add(row[0].ToString());

            }

            dgvDoc_on_buy_book.Columns.Add("Даты", "Даты");
            foreach (string str in Dates)
            {
                dgvDoc_on_buy_book.Rows.Add(str);
            }
            dgvDoc_on_buy_book.Columns.Add("Договор с поставщиком", "Договор с поставщиком");
            for (int i = 0; i < dgvDoc_on_buy_book.RowCount - 1; i++)
            {
                for (int j = 1; j < dgvDoc_on_buy_book.ColumnCount; j++)
                {
                    command.CommandText = "Select distinct(provider) from dbo.View_all_providers where date_of_doc_on_buy_book = '"
                        + dgvDoc_on_buy_book[0, i].Value.ToString() + "'";
                    ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                    dgvDoc_on_buy_book[j, i].Value = command.ExecuteScalar().ToString();
                    ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();

                }
            }
            cbProviderFill();
        }

        private void cbContract_with_provider_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id_provider = Convert.ToInt32(cbProvider.SelectedValue.ToString());
            try
            {
                command.CommandText = "Select id_book, Book as 'Книга' from dbo.View_book_for_doc where id_provider=" +
                    id_provider;
                DataTable cbBooks = new DataTable();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                cbBooks.Load(command.ExecuteReader());
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                cbBook.DataSource = cbBooks;
                cbBook.ValueMember = "id_book";
                cbBook.DisplayMember = "Книга";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dgvDocFill();
            }

        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_doc_on_buy_book = Convert.ToInt32(dgvBooks.CurrentRow.Cells[3].Value.ToString());
            id_book = Convert.ToInt32(dgvBooks.CurrentRow.Cells[4].Value.ToString());
            cbBook.SelectedValue = id_book;
            tbKol_vo.Text = dgvBooks.CurrentRow.Cells[1].Value.ToString();
        }

        private void btInsertBook_Click(object sender, EventArgs e)
        {
            if (tbKol_vo.Text == "")
                MessageBox.Show("Введите количество!");
            else
            {
                try
                {
                    procedure.spDoc_on_buy_book_insert(tbDate.Text, id_provider, id_book, Convert.ToInt32(tbKol_vo.Text));
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    dgvBooksFill();
                }
            }
        }

        private void dgvDoc_on_buy_book_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvBooksFill();
            command.CommandText = "Select id_doc_on_buy_book from dbo.View_all_providers where date_of_doc_on_buy_book='" + dgvDoc_on_buy_book.CurrentRow.Cells[0].Value.ToString() +
                "' and provider='" + dgvDoc_on_buy_book.CurrentRow.Cells[1].Value.ToString() + "'";
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            id_doc_on_buy_book = Convert.ToInt32(command.ExecuteScalar());
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.CommandText = "Select id_provider from dbo.View_all_providers where id_doc_on_buy_book=" + id_doc_on_buy_book;
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            id_provider = Convert.ToInt32(command.ExecuteScalar());
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            cbProvider.SelectedValue = id_provider;
            tbDate.Text = dgvDoc_on_buy_book.CurrentRow.Cells[0].Value.ToString();

        }

        private void btUpdateBook_Click(object sender, EventArgs e)
        {
            if (tbKol_vo.Text == "")
                MessageBox.Show("Выберите книгу!");
            else
            {
                try
                {
                    procedure.spDoc_on_buy_book_update(id_doc_on_buy_book, tbDate.Text, id_provider, id_book, Convert.ToInt32(tbKol_vo.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    dgvBooksFill();
                }
            }
        }

        private void btDeleteBook_Click(object sender, EventArgs e)
        {
            if (tbKol_vo.Text == "")
                MessageBox.Show("Выберите книгу!");
            else
            {
                try
                {
                    if ((MessageBox.Show("Вы точно хотите удалить книгу?", "Подтверждение удаления", MessageBoxButtons.YesNo)) == DialogResult.Yes)
                    {
                        procedure.spDoc_on_buy_book_delete(id_doc_on_buy_book);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    dgvBooksFill();
                }
            }
        }

        private void btDeleteDoc_on_buy_book_Click(object sender, EventArgs e)
        {
            if (tbDate.Text == "")
                MessageBox.Show("Выберите документ!");
            else
            {
                try
                {
                    if ((MessageBox.Show("Вы точно хотите удалить документ на закупку книг?", "Подтверждение удаления", MessageBoxButtons.YesNo)) == DialogResult.Yes)
                    {
                        command.CommandText = "delete from Doc_on_buy_book where date_of_doc_on_buy_book='" + dgvDoc_on_buy_book.CurrentRow.Cells[0].Value.ToString() +
                        "' and provider='" + dgvDoc_on_buy_book.CurrentRow.Cells[1].Value.ToString() + "'";
                        command.ExecuteReader();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    dgvBooksFill();
                    dgvDocFill();
                }
            }
        }

        private void cbBook_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id_book = Convert.ToInt32(cbBook.SelectedValue);
            MessageBox.Show(id_book.ToString());
        }

        private void btUpdateDoc_on_buy_book_Click(object sender, EventArgs e)
        {

        }

        private void btInsertDoc_on_buy_book_Click(object sender, EventArgs e)
        {
           
        }

        private void btExcel_Click(object sender, EventArgs e)
        {
            try
            {
                
                command.CommandText = "select Address from View_address_provider where id_provider=" + id_provider;
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                address = command.ExecuteScalar().ToString();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                excel.Application application = new excel.Application();
                excel.Workbook workbook = application.Workbooks.Add();
                excel.Worksheet worksheet =
                    (excel.Worksheet)workbook.ActiveSheet;
                ConnectionLibrary.ConnectionLibrary.ConfigurationGet();
                worksheet.Name = "Документ на закупку книг";
                worksheet.Cells.Font.Size = 12;
                worksheet.Cells.Font.Name = ConnectionLibrary.ConnectionLibrary.DocSFF;
                worksheet.Cells[1, 1] = "Документ на закупку книг";
                command.CommandText = "Select provider from provider where id_provider=" + id_provider;
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                provider = command.ExecuteScalar().ToString();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                worksheet.Cells[2, 1] = "Поставщик: " + provider;

                worksheet.Columns[2].ColumnWidth = 50;
                // заполнение номеров товаров
                for (int k = 1; k < dgvBooks.RowCount; k++)
                {
                    worksheet.Cells[k + 4, 1] = k;


                }

                // заполнение  1- строка, 2 столбец
                for (int k = 0; k < dgvBooks.ColumnCount - 2; k++)
                {
                    // дгв - 1 столбец, 2 строка
                    worksheet.Cells[4, k + 2] = dgvBooks.Columns[k].HeaderText;
                }

                for (int j = 1; j <= dgvBooks.Rows.Count - 1; j++)
                {
                    for (int i = 1; i <= dgvBooks.Columns.Count - 2; i++)
                    {

                        worksheet.Cells[j + 4, i + 1] = dgvBooks.Rows[j - 1].Cells[i - 1].Value.ToString();

                    }

                }

                excel.Range range = worksheet.Range[worksheet.Cells[4, 1], worksheet.Cells[3 + dgvBooks.Rows.Count, dgvBooks.Columns.Count - 1]];

                excel.Borders border = range.Borders;
                border.LineStyle = excel.XlLineStyle.xlContinuous;
                decimal summa = 0;
                for (int i = 5; i < dgvBooks.Rows.Count + 4; i++)
                {
                    summa += Convert.ToDecimal(worksheet.Cells[i, 4].Text.ToString());
                }
                worksheet.Cells[4 + dgvBooks.Rows.Count, 3] = "Итого:";
                worksheet.Cells[4 + dgvBooks.Rows.Count, 4] = summa.ToString();

                worksheet.Cells[5 + dgvBooks.Rows.Count, 1] = "Заказчик:" + ConnectionLibrary.ConnectionLibrary.OrganizationName +", "+ ConnectionLibrary.ConnectionLibrary.Address;
                worksheet.Cells[7 + dgvBooks.Rows.Count, 1] = "Поставщик: " + provider +", "+ address ;

                string path = "";
                path = ConnectionLibrary.ConnectionLibrary.DirPath + "Документ на закупку книг от " + tbDate.Text + ".xlsx";
                workbook.SaveAs(Filename: path, FileFormat: excel.XlFileFormat.xlWorkbookDefault);
                workbook.Close();
                application.Quit();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvBooksFill()
        {
            command.CommandText = "Select  Book as 'Книга', kol_vo_book as 'Кол-во', summa as 'Сумма', id_doc_on_buy_book, id_book from dbo.View_Doc_on_buy_book where date_of_doc_on_buy_book='"
                + dgvDoc_on_buy_book.CurrentRow.Cells[0].Value.ToString() +
                "' and provider='" + dgvDoc_on_buy_book.CurrentRow.Cells[1].Value.ToString() + "'";
            DataTable dtBooks = new DataTable();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            dtBooks.Load(command.ExecuteReader());
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            dgvBooks.DataSource = dtBooks;

            dgvBooks.Columns[2].Visible = false;
            dgvBooks.Columns[3].Visible = false;
            dgvBooks.Columns[4].Visible = false;
            cbBooksFill();
        }

        private void cbBooksFill()
        {
            try
            {
                command.CommandText = "Select id_book, Book as 'Книга' from dbo.View_book_for_doc where provider='" +
                    dgvDoc_on_buy_book.CurrentRow.Cells[1].Value.ToString() + "'";
                DataTable cbBooks = new DataTable();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                cbBooks.Load(command.ExecuteReader());
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                cbBook.DataSource = cbBooks;
                cbBook.ValueMember = "id_book";
                cbBook.DisplayMember = "Книга";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

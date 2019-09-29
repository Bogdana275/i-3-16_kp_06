using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using excel = Microsoft.Office.Interop.Excel;

namespace Library
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }
        SqlCommand command = new SqlCommand("", ConnectionLibrary.ConnectionLibrary.sqlConnection);
        List<string> Dates = new List<string>();
        Int32 id_book, id_provider, id_invoice, id_employee;
        String provider;
        Procedures procedure = new Procedures();

        private void dgvInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            dgvBooksFill();
            command.CommandText = "Select id_invoice from dbo.View_invoice where date_invoice='" + dgvInvoice.CurrentRow.Cells[0].Value.ToString() +
                "' and FIO_employee='" + dgvInvoice.CurrentRow.Cells[1].Value.ToString() + "'";
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            id_invoice = Convert.ToInt32(command.ExecuteScalar());
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.CommandText = "Select id_employee from dbo.View_invoice where FIO_employee='" + dgvInvoice.CurrentRow.Cells[1].Value.ToString()+ "'";
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            id_employee = Convert.ToInt32(command.ExecuteScalar());
           
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            cbEmployee.SelectedValue = id_employee;
            tbDate.Text = dgvInvoice.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgvBooksFill()
        {
            command.CommandText = "Select  Book as 'Книга', kol_vo as 'Кол-во', Summa as 'Сумма' , id_invoice, id_book from dbo.View_invoice where date_invoice='"
                + dgvInvoice.CurrentRow.Cells[0].Value.ToString() +
                "' and FIO_employee='" + dgvInvoice.CurrentRow.Cells[1].Value.ToString() + "'";
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
                command.CommandText = "Select id_provider from View_invoice where date_invoice='" + 
                    dgvInvoice.CurrentRow.Cells[0].Value.ToString() + "' and " +
                    "FIO_employee='" + dgvInvoice.CurrentRow.Cells[1].Value.ToString() + "'";
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                id_provider = Convert.ToInt32(command.ExecuteScalar().ToString());
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                command.CommandText = "Select id_book, Book as 'Книга' from dbo.View_book_for_doc where id_provider=" + id_provider;
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

        private void btInsertBook_Click(object sender, EventArgs e)
        {
            
            
                try
                {
                MessageBox.Show(tbDate.Text + " "+tbKol_vo.Text +" "+id_book +" "+ id_employee);
                    procedure.spInvoice_insert(tbDate.Text, Convert.ToInt32(tbKol_vo.Text),
                        id_book, id_employee);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                Invoice_Load(sender, e);
                }
            
        }

        private void btUpdateBook_Click(object sender, EventArgs e)
        {

            try
            {
                procedure.spInvoice_update(id_invoice, tbDate.Text, Convert.ToInt32(tbKol_vo.Text),
                    id_book, id_employee);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Dates.Clear();
                dgvInvoiceFill();
                dgvBooksFill();

            }
        }

        private void btDeleteBook_Click(object sender, EventArgs e)
        {
            try
            {
                procedure.spInvoice_delete(id_invoice);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Dates.Clear();
                dgvInvoiceFill();
                dgvBooksFill();
            }
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            Dates.Clear();
            dgvInvoiceFill();
            cbBookFill();
            cbEmployeeFill();

        }

        private void cbEmployee_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id_employee = Convert.ToInt32(cbEmployee.SelectedValue.ToString());
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_book = Convert.ToInt32(dgvBooks.CurrentRow.Cells[1].Value.ToString());
            cbBook.SelectedValue = id_book;
            tbKol_vo.Text = dgvBooks.CurrentRow.Cells[3].Value.ToString();
        }

        private void cbBook_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id_book = Convert.ToInt32(cbBook.SelectedValue.ToString());
        }

        private void btExcel_Click(object sender, EventArgs e)
        {
            try
            {
                excel.Application application = new excel.Application();
                excel.Workbook workbook = application.Workbooks.Add();
                excel.Worksheet worksheet =
                    (excel.Worksheet)workbook.ActiveSheet;
                ConnectionLibrary.ConnectionLibrary.ConfigurationGet();
                worksheet.Name = "Накладная";
                worksheet.Cells.Font.Size = 12;
                worksheet.Cells.Font.Name = ConnectionLibrary.ConnectionLibrary.DocSFF;
                worksheet.Cells[1, 1] = "Накладная";
                command.CommandText = "Select provider from provider where id_provider=" + id_provider;
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                provider = command.ExecuteScalar().ToString();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                worksheet.Cells[2, 1] = "Поставщик " + provider;
                worksheet.Cells[3, 1] = "Получил " + dgvInvoice.CurrentRow.Cells[1].Value.ToString();
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

                worksheet.Cells[5 + dgvBooks.Rows.Count, 1] = "Отпустил: ___________________________";
                worksheet.Cells[7 + dgvBooks.Rows.Count, 1] = "Получил: ___________________________";

                string path = "";
                path = ConnectionLibrary.ConnectionLibrary.DirPath + "Накладная от " + tbDate.Text+".xlsx";
                workbook.SaveAs(Filename: path, FileFormat: excel.XlFileFormat.xlWorkbookDefault);
                workbook.Close();
                application.Quit();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        
    }

        private void cbBookFill()
        {
            try
            {
                command.CommandText = "Select id_book, Book as 'Книга' from dbo.View_book_for_doc";
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
            private void cbEmployeeFill()
        {
            try
            {
                command.CommandText = "Select id_employee, FIO from View_all_sotr";
                DataTable dt = new DataTable();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                dt.Load(command.ExecuteReader());
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                cbEmployee.DataSource = dt;
                cbEmployee.ValueMember = "id_employee";
                cbEmployee.DisplayMember = "FIO";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvInvoiceFill()
        {
            command.CommandText = "Select distinct(date_invoice) from Invoice";
            DataTable dtData = new DataTable();
            dgvInvoice.Rows.Clear();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            dtData.Load(command.ExecuteReader());
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            foreach (DataRow row in dtData.Rows)
            {
                Dates.Add(row[0].ToString());

            }

            dgvInvoice.Columns.Add("Даты", "Даты");
            foreach (string str in Dates)
            {
                dgvInvoice.Rows.Add(str);
            }
            dgvInvoice.Columns.Add("Принял", "Принял");
            for (int i = 0; i < dgvInvoice.RowCount - 1; i++)
            {
                for (int j = 1; j < dgvInvoice.ColumnCount; j++)
                {
                    command.CommandText = "Select distinct(FIO_employee) from dbo.View_invoice where date_invoice = '"
                        + dgvInvoice[0, i].Value.ToString() + "'";
                    ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                    dgvInvoice[j, i].Value = command.ExecuteScalar().ToString();
                    ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();

                }
            }
            
        }
    }
}

using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using word = Microsoft.Office.Interop.Word;

namespace Library
{
    public partial class Contract_with_provider : Form
    {
        public Contract_with_provider()
        {
            InitializeComponent();
        }
        Int32 id_provider, id_contract;
        Procedures procedure = new Procedures();
        SqlCommand command = new SqlCommand("", ConnectionLibrary.ConnectionLibrary.sqlConnection);
        string FIO_director, INN, address, path;
        private void Contract_with_provider_Load(object sender, EventArgs e)
        {
            cbProviderFill();
            dgvFill();
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

        private void cbProvider_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id_provider = Convert.ToInt32(cbProvider.SelectedValue.ToString());
        }

        private void dgvContract_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id_contract = Convert.ToInt32(dgvContract.CurrentRow.Cells[0].Value.ToString());
                id_provider = Convert.ToInt32(dgvContract.CurrentRow.Cells[1].Value.ToString());
                tbDate.Text = dgvContract.CurrentRow.Cells[3].Value.ToString();
                cbProvider.SelectedValue = id_provider;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            switch (tbDate.Text == "")
            {
                case (true):
                    MessageBox.Show("Введите дату!");
                    break;
                case (false):
                    try
                    {
                        procedure.spContract_with_provider_insert(tbDate.Text, id_provider);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        tbDate.Clear();
                        Contract_with_provider_Load(sender, e);
                    }
                    break;
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            switch (tbDate.Text == "")
            {
                case (true):
                    MessageBox.Show("Выберите договор!");
                    break;
                case (false):
                    try
                    {
                        procedure.spContract_with_provider_update(tbDate.Text, id_provider, id_contract);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        tbDate.Clear();
                        Contract_with_provider_Load(sender, e);
                    }
                    break;
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            switch (tbDate.Text == "")
            {
                case (true):
                    MessageBox.Show("Выберите договор!");
                    break;
                case (false):
                    try
                    {
                        procedure.spContract_with_provider_delete(id_contract);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        tbDate.Clear();
                        Contract_with_provider_Load(sender, e);
                    }
                    break;
            }
        }

        private void cbProvider_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btWord_Click(object sender, EventArgs e)
        {
            
            command.CommandText = "select F_employee + ' '+SUBSTRING(I_employee,1,1)+'. '+ SUBSTRING(O_employee,1,1) + '.' as Director from employee where id_dolj=1";
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            FIO_director = command.ExecuteScalar().ToString();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.CommandText = "select INN from provider where id_provider=" + id_provider;
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            INN = command.ExecuteScalar().ToString();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.CommandText = "select Address from View_address_provider where id_provider="+ id_provider;
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            address = command.ExecuteScalar().ToString();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
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
                Name_Doc.Range.Text = "Договор с поставщиком №" + id_contract;
                Name_Doc.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
                Name_Shool.Range.Bold = 3;
                document.Paragraphs.Add();
                word.Paragraph Data_info = document.Paragraphs.Add();
                word.Table tbdata1 = document.Tables.Add(Data_info.Range, 1, 2);
                tbdata1.Range.Font.Name = ConnectionLibrary.ConnectionLibrary.DocSFF;
                tbdata1.Range.Font.Size = 14;

                tbdata1.Cell(1, 1).Range.Text = "Дата заключение договора: " + tbDate.Text;
                tbdata1.Cell(1, 2).Range.Text = "Место заключения договора: " + ConnectionLibrary.ConnectionLibrary.Address;
                tbdata1.Range.Bold = 0;
                document.Paragraphs.Add();
                word.Paragraph info1 = document.Paragraphs.Add();
                info1.Range.Font.Name = ConnectionLibrary.ConnectionLibrary.DocSFF;
                info1.Range.Font.Size = 14;
                info1.Range.Text = ConnectionLibrary.ConnectionLibrary.OrganizationName + ", именуемое 'заказчик', в лице директора " + FIO_director + ",с одной стороны, и " +
                    dgvContract.CurrentRow.Cells[2].Value.ToString() + ", ИНН:  " + INN + ", адрес:" + address +
                    ", именуемое 'поставщик' с другой стороны, заключили настоящий договор о поставке книг.";
                info1.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphJustify;
                info1.Range.Bold = 0;
                document.Paragraphs.Add();
                
                word.Paragraph Potpis = document.Paragraphs.Add();
                word.Table tbdata3 = document.Tables.Add(Potpis.Range, 1, 2);
                tbdata3.Range.Font.Size = 14;
                tbdata3.Cell(1, 1).Range.Text = "Заказчик: " + "______________________";
                tbdata3.Cell(1, 2).Range.Text = "Поставщик: " + "______________________";
                tbdata3.Range.Font.Name = ConnectionLibrary.ConnectionLibrary.DocSFF;
                tbdata3.Range.Bold = 0;
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
                path = ConnectionLibrary.ConnectionLibrary.DirPath + "\\Договор с поставщиком №" + id_contract + " " + dgvContract.CurrentRow.Cells[2].Value.ToString() + ".docx";
                document.SaveAs(FileName: path, FileFormat: word.WdSaveFormat.wdFormatDocumentDefault);
                document.Close(document.Saved = false);
                application.Quit();

            }
        }

        private void dgvFill()
        {
            Tables data = new Tables();
            data.dtContract_with_providerFill();
            dgvContract.DataSource = data.dtContract_with_provider;
            dgvContract.Columns[0].Visible = false;
            dgvContract.Columns[1].Visible = false;
        }
    }
}

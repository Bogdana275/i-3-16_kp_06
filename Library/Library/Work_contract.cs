using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using word = Microsoft.Office.Interop.Word;

namespace Library
{
    public partial class Work_contract : Form
    {
        public Work_contract()
        {
            InitializeComponent();
        }
        SqlCommand command = new SqlCommand("",ConnectionLibrary.ConnectionLibrary.sqlConnection);
        Int32 id_employee, id_work_contract;
        string passport, FIO_director, path;
        Procedures procedure = new Procedures();
        private void Work_contract_Load(object sender, EventArgs e)
        {
            try
            {
                dgvWork_contractFill();
                tbWork_contract.Clear();
                cbSotrFill();
                label1.Visible = false;
                label2.Visible = false;
                cbSotr.Visible = false;
                tbDate.Visible = false;
                id_employee = Convert.ToInt32(cbSotr.SelectedValue);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbSotrFill()
        {
            try
            {
                DataTable dt = new DataTable();
                command.CommandText = "Select id_employee, FIO from View_all_sotr";
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                dt.Load(command.ExecuteReader());
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                cbSotr.DataSource = dt;
                cbSotr.ValueMember = "id_employee";
                cbSotr.DisplayMember = "FIO";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvWork_contractFill()
        {
            try
            {
                Tables dtWork_contract = new Tables();
                dtWork_contract.dtWork_contractFill();
                dgvWork_contract.DataSource = dtWork_contract.dtWork_contract;

                dgvWork_contract.Columns[0].Visible = false;
                dgvWork_contract.Columns[2].Visible = false;
                dgvWork_contract.Columns[3].Visible = false;
                dgvWork_contract.Columns[1].HeaderText = "Дата";
                dgvWork_contract.Columns[4].HeaderText = "ФИО";
                dgvWork_contract.Columns[5].HeaderText = "Должность";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btInsert_Click(object sender, EventArgs e)
        {

           
            
                if (label1.Visible & label2.Visible & cbSotr.Visible & tbDate.Visible)
                {
                    switch (tbDate.Text == "")
                    {
                        case (true):
                            MessageBox.Show("Введите дату!");
                            break;
                        case (false):
                            try
                            {
                                procedure.spWork_contract_insert(tbDate.Text, id_employee);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                                tbDate.Clear();
                                Work_contract_Load(sender, e);
                            }
                            break;
                    }
                }
                else
                {
                    label1.Visible = true;
                    label2.Visible = true;
                    cbSotr.Visible = true;
                    tbDate.Visible = true;
                }
            
            
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {

            
                if (label1.Visible & label2.Visible & cbSotr.Visible & tbDate.Visible)

                {
                    switch (tbDate.Text == "")
                    {
                        case (true):
                            MessageBox.Show("Выберите Трудовой договор!");
                            break;
                        case (false):
                            try
                            {
                                procedure.spWork_contract_update(id_work_contract, tbDate.Text, id_employee);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                                tbDate.Clear();
                                Work_contract_Load(sender, e);
                            }
                            break;
                    }
                }
                else
                {
                    label1.Visible = true;
                    label2.Visible = true;
                    cbSotr.Visible = true;
                    tbDate.Visible = true;
                }
                
        }

        private void btDelete_Click(object sender, EventArgs e)
        {

            switch (MessageBox.Show("Вы точно хотите удалить договор?", "Подтверждение удаления", MessageBoxButtons.YesNo))
            {
                case (DialogResult.Yes):
                    switch (tbDate.Text == "")
                    {
                        case (true):
                            MessageBox.Show("Выберите Трудовой договор!");
                            break;
                        case (false):
                            try
                            {
                                procedure.spWork_contract_delete(id_work_contract);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                                tbDate.Clear();
                                Work_contract_Load(sender, e);
                            }
                            break;
                    }
                    break;
            }
            
        }

        private void cbSotr_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id_employee = Convert.ToInt32(cbSotr.SelectedValue.ToString());
        }

        private void tbPoisk_TextChanged(object sender, EventArgs e)
        {
            if (tbPoisk.Text == "")
            {
                Work_contract_Load(sender, e);
            }
            else
            {
                Tables query = new Tables();
                command.CommandText = query.qrWork_contract +
                    " where ('FIO' like '%" + tbPoisk.Text + "%') " +
                    "or (date_work_contract like '%" + tbPoisk.Text + "%') " +
                    "or (dolj like '%" + tbPoisk.Text + "%')";


                DataTable dt = new DataTable();

                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                dt.Load(command.ExecuteReader());
                dgvWork_contract.DataSource = dt;
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            command.CommandText = "select series_passport + ' ' +number_passport as Passport from employee where id_employee="
                 + id_employee;
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            passport = command.ExecuteScalar().ToString();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.CommandText = "select F_employee + ' '+SUBSTRING(I_employee,1,1)+'. '+ SUBSTRING(O_employee,1,1) + '.' as Director from employee where id_dolj=1";
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            FIO_director = command.ExecuteScalar().ToString();
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
                Name_Doc.Range.Text = "Трудовой договор №" + id_work_contract;
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
                info1.Range.Text = ConnectionLibrary.ConnectionLibrary.OrganizationName + ", именуемое 'работодатель', в лице директора " + FIO_director + ",с одной стороны, и " +
                    dgvWork_contract.CurrentRow.Cells[4].Value.ToString() + ", паспорт:  " + passport +
                    ", именуемое 'работник' с другой стороны, заключили настоящий трудовой договор о нижеследующем:";
                info1.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphJustify;
                info1.Range.Bold = 0;
                document.Paragraphs.Add();
                word.Paragraph pravila_inf1 = document.Paragraphs.Add();
                pravila_inf1.Range.Font.Name = ConnectionLibrary.ConnectionLibrary.DocSFF;
                pravila_inf1.Range.Font.Size = 14;
                pravila_inf1.Range.Text = "1) Работник нанимается на работу в должности: " + dgvWork_contract.CurrentRow.Cells[7].Value.ToString();
                pravila_inf1.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphJustify;
                pravila_inf1.Range.Bold = 0;
                document.Paragraphs.Add();
                word.Paragraph pravila_inf2 = document.Paragraphs.Add();
                pravila_inf2.Range.Font.Name = ConnectionLibrary.ConnectionLibrary.DocSFF;
                pravila_inf2.Range.Font.Size = 14;
                pravila_inf2.Range.Text = "2) Работа осуществляется по адресу: " + ConnectionLibrary.ConnectionLibrary.Address;
                pravila_inf2.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphJustify;
                pravila_inf2.Range.Bold = 0;
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                word.Paragraph Potpis = document.Paragraphs.Add();
                word.Table tbdata3 = document.Tables.Add(Potpis.Range, 1, 2);
                tbdata3.Range.Font.Size = 14;
                tbdata3.Cell(1, 1).Range.Text = "Работодатель: " + "______________________";
                tbdata3.Cell(1, 2).Range.Text = "Работник: " + "______________________";
                tbdata3.Range.Font.Name = ConnectionLibrary.ConnectionLibrary.DocSFF;
                tbdata3.Range.Bold = 0;
                document.Paragraphs.Add();
                word.Paragraph data_doc = document.Paragraphs.Add();
                data_doc.Range.Font.Name = ConnectionLibrary.ConnectionLibrary.DocSFF;
                data_doc.Range.Font.Size = 14;
                data_doc.Range.Text = "Дата трудового документа: " + tbDate.Text;
                data_doc.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphJustify;
                data_doc.Range.Bold = 0;

            }
            catch (Exception ex)
            {
                ConnectionLibrary.ConnectionLibrary.error_message += "\n"
                    + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                path = "";
                path = ConnectionLibrary.ConnectionLibrary.DirPath + "\\Трудовой договор №" + id_work_contract + " " + dgvWork_contract.CurrentRow.Cells[4].Value.ToString()+ ".docx";
                document.SaveAs(FileName: path, FileFormat: word.WdSaveFormat.wdFormatDocumentDefault);
                document.Close(document.Saved = false);
                application.Quit();
                
            }
        }

        private void dgvWork_contract_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbWork_contract.Text = "Трудовой договор " + Environment.NewLine + " с сотрудником " + dgvWork_contract.CurrentRow.Cells[4].Value.ToString() + " " +
                " на должность " +
                dgvWork_contract.CurrentRow.Cells[5].Value.ToString() + Environment.NewLine + "Дата: " + dgvWork_contract.CurrentRow.Cells[1].Value.ToString();
                id_work_contract = Convert.ToInt32(dgvWork_contract.CurrentRow.Cells[0].Value.ToString());
                id_employee = Convert.ToInt32(dgvWork_contract.CurrentRow.Cells[2].Value.ToString());
                tbDate.Text = dgvWork_contract.CurrentRow.Cells[1].Value.ToString();
                cbSotr.SelectedValue = id_employee;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

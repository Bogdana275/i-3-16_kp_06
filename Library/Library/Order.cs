using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using word = Microsoft.Office.Interop.Word;

namespace Library
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }
        Int32 id_order, id_employee, id_view_order, id_work_contract;
        Object _missingObj = System.Reflection.Missing.Value;
        SqlCommand command
            = new SqlCommand("",ConnectionLibrary.ConnectionLibrary.sqlConnection);
        Procedures procedure = new Procedures();
        string path;
        private void Order_Load(object sender, EventArgs e)
        {
            try
            {
                OrderFill();
                cbSotrFill();
                cbView_orderFill();
                tbDate.Clear();
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                tbDate.Visible = false;
                cbSotr.Visible = false;
                cbView_order.Visible = false;
                id_employee = Convert.ToInt32(cbSotr.SelectedValue);
                id_view_order = Convert.ToInt32(cbView_order.SelectedValue);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OrderFill()
        {
            Tables data = new Tables();
            data.dtOrderFill();
            dgvOrder.DataSource = data.dtOrder;

            dgvOrder.Columns[0].Visible = false;
            dgvOrder.Columns[1].Visible = false;
            dgvOrder.Columns[3].Visible = false;
            dgvOrder.Columns[5].Visible = false;
            dgvOrder.Columns[2].HeaderText = "ФИО";
            dgvOrder.Columns[6].HeaderText = "Вид приказа";
            dgvOrder.Columns[7].HeaderText = "Дата";
        }

        private void cbSotr_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id_employee = Convert.ToInt32(cbSotr.SelectedValue.ToString());
        }

        private void cbView_order_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id_view_order = Convert.ToInt32(cbView_order.SelectedValue.ToString());
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            switch (tbDate.Visible & cbSotr.Visible & cbView_order.Visible & label1.Visible & label2.Visible & label3.Visible)
            {
                case (true):
                    try
                    {
                        if (tbDate.Text != "")
                        {
                            procedure.spOrder_insert(tbDate.Text, id_employee, id_view_order);
                            Order_Load(sender, e);
                        }
                        else MessageBox.Show("Введите дату!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case (false):
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    tbDate.Visible = true;
                    cbSotr.Visible = true;
                    cbView_order.Visible = true;
                    break;
            }
            
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            switch (tbDate.Visible & cbSotr.Visible & cbView_order.Visible & label1.Visible & label2.Visible & label3.Visible)
            {
                case (true):
                    try
                    {
                        if (tbDate.Text != "")
                        
                        {
                            procedure.spOrder_update(id_order, tbDate.Text, id_employee, id_view_order);
                            Order_Load(sender, e);
                        }
                        else MessageBox.Show("Выберите приказ!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case (false):
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    tbDate.Visible = true;
                    cbSotr.Visible = true;
                    cbView_order.Visible = true;
                    break;
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            switch (tbDate.Visible & cbSotr.Visible & cbView_order.Visible & label1.Visible & label2.Visible & label3.Visible)
            {
                case (true):
                    try
                    {
                        if (tbDate.Text != "")

                        {
                            
                            procedure.spOrder_delete(id_order);
                            Order_Load(sender, e);
                        }
                        else MessageBox.Show("Выберите приказ!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case (false):
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    tbDate.Visible = true;
                    cbSotr.Visible = true;
                    cbView_order.Visible = true;
                    break;
            }
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id_order = Convert.ToInt32(dgvOrder.CurrentRow.Cells[0].Value.ToString());
                id_employee = Convert.ToInt32(dgvOrder.CurrentRow.Cells[1].Value.ToString());
                cbSotr.SelectedValue = id_employee;
                id_view_order = Convert.ToInt32(dgvOrder.CurrentRow.Cells[5].Value.ToString());
                cbView_order.SelectedValue = id_view_order;
                tbDate.Text = dgvOrder.CurrentRow.Cells[7].Value.ToString();
                tbOrder.Text = dgvOrder.CurrentRow.Cells[6].Value.ToString() + "  сотрудника " +
                dgvOrder.CurrentRow.Cells[2].Value.ToString() +" на должность " +
                dgvOrder.CurrentRow.Cells[4].Value.ToString() + 
                Environment.NewLine + "Дата: " + dgvOrder.CurrentRow.Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbPoisk_TextChanged(object sender, EventArgs e)
        {
            if (tbPoisk.Text == "")
            {
                Order_Load(sender, e);
            }
            else
            {
                Tables query = new Tables();
                command.CommandText = query.qrOrder +
                    " where ('FIO' like '%" + tbPoisk.Text + "%') " +
                    "or (date_order like '%" + tbPoisk.Text + "%') " +
                    "or (view_order like '%" + tbPoisk.Text + "%')";


                DataTable dt = new DataTable();

                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                dt.Load(command.ExecuteReader());
                dgvOrder.DataSource = dt;
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            
          
            command.CommandText = "Select id_work_contract from Work_contract where id_employee=" + id_employee;
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            if (command.ExecuteScalar() == null)
                MessageBox.Show("Документ не может сформироваться по причине отсутствия трудового договора на сотрудника.");
            else
            {
                id_work_contract = Convert.ToInt32(command.ExecuteScalar().ToString());
                if (dgvOrder.CurrentRow.Cells[5].Value.ToString() == "1")
                    Pricaz_o_prieme();
                if (dgvOrder.CurrentRow.Cells[5].Value.ToString() == "2")
                    Pricaz_o_uvolen();
            }
            MessageBox.Show("");
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
        }

        public void Pricaz_o_prieme()
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
                Name_Doc.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
                Name_Doc.Range.Font.Name = ConnectionLibrary.ConnectionLibrary.DocSFF;
                Name_Doc.Range.Font.Size = 16;
                Name_Doc.Range.Text = "Приказ о приеме на работу №" + id_order;
                Name_Shool.Range.Bold = 3;
                document.Paragraphs.Add();
                word.Paragraph prinat_inf1 = document.Paragraphs.Add();
                prinat_inf1.Range.Text = "Принять на работу " + dgvOrder.CurrentRow.Cells[2].Value.ToString() + " на должность " + dgvOrder.CurrentRow.Cells[4].Value.ToString();
                prinat_inf1.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphJustify;
                prinat_inf1.Range.Font.Name = ConnectionLibrary.ConnectionLibrary.DocSFF;
                prinat_inf1.Range.Font.Size = 14;
                prinat_inf1.Range.Bold = 0;
                document.Paragraphs.Add();
                word.Paragraph prinat_inf2 = document.Paragraphs.Add();
                prinat_inf2.Range.Text = "Основание: трудовой договор от " + tbDate.Text + " №" + id_work_contract;
                prinat_inf2.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphJustify;
                prinat_inf2.Range.Font.Name = ConnectionLibrary.ConnectionLibrary.DocSFF;
                prinat_inf2.Range.Font.Size = 14;
                prinat_inf2.Range.Bold = 0;
                document.Paragraphs.Add();

                word.Paragraph Potpis = document.Paragraphs.Add();
                word.Table tbdata3 = document.Tables.Add(Potpis.Range, 1, 2);
                tbdata3.Range.Font.Size = 14;
                tbdata3.Cell(1, 1).Range.Text = "Директор: " + "__________________________";
                tbdata3.Cell(1, 2).Range.Text = "Работник: " + "__________________________";
                tbdata3.Range.Font.Size = 14;
                tbdata3.Range.Font.Name = ConnectionLibrary.ConnectionLibrary.DocSFF;
                tbdata3.Range.Bold = 0;
                document.Paragraphs.Add();

                word.Paragraph data_doc = document.Paragraphs.Add();
                data_doc.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphJustify;
                data_doc.Range.Font.Name = ConnectionLibrary.ConnectionLibrary.DocSFF;
                data_doc.Range.Font.Size = 14;
                data_doc.Range.Text = "Дата: " + tbDate.Text;
                data_doc.Range.Bold = 0;


                path = "";
                path = ConnectionLibrary.ConnectionLibrary.DirPath + "\\Приказ №" + id_order +
                    " О приеме на работу работника " + dgvOrder.CurrentRow.Cells[2].Value.ToString() + ".docx";
                document.SaveAs(FileName: path, FileFormat: word.WdSaveFormat.wdFormatDocumentDefault);
                    document.Close(document.Saved = false);
                    application.Quit();
                
            }
            catch (Exception ex)
            {
                ConnectionLibrary.ConnectionLibrary.error_message += "\n"
                    + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
        }

        public void Pricaz_o_uvolen()
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
                Name_Doc.Range.Text = "Приказ об увольнении работника №" + id_order;
                Name_Doc.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
                Name_Doc.Range.Bold = 3;
                document.Paragraphs.Add();
                document.Paragraphs.Add();

                word.Paragraph uvolen_inf1 = document.Paragraphs.Add();
                uvolen_inf1.Range.Font.Name = ConnectionLibrary.ConnectionLibrary.DocSFF;
                uvolen_inf1.Range.Font.Size = 14;
                uvolen_inf1.Range.Text = "Уволить с работы сотрудника " + dgvOrder.CurrentRow.Cells[2].Value.ToString() + "с должности " + dgvOrder.CurrentRow.Cells[4].Value.ToString();
                uvolen_inf1.Range.Bold = 0;
                uvolen_inf1.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphJustify;
                document.Paragraphs.Add();
                word.Paragraph Potpis = document.Paragraphs.Add();
                word.Table tbdata3 = document.Tables.Add(Potpis.Range, 1, 2);
                tbdata3.Range.Font.Size = 14;
                tbdata3.Cell(1, 1).Range.Text = "Директор: " + "__________________________";
                tbdata3.Cell(1, 2).Range.Text = "Работник: " + "__________________________";
                tbdata3.Range.Font.Size = 14;
                tbdata3.Range.Font.Name = ConnectionLibrary.ConnectionLibrary.DocSFF;
                tbdata3.Range.Bold = 0;
                document.Paragraphs.Add();

                word.Paragraph data_doc = document.Paragraphs.Add();
                data_doc.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphJustify;
                data_doc.Range.Font.Name = ConnectionLibrary.ConnectionLibrary.DocSFF;
                data_doc.Range.Font.Size = 14;
                data_doc.Range.Text = "Дата: " +tbDate.Text;
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
                path = ConnectionLibrary.ConnectionLibrary.DirPath + "\\Приказ №" + id_order + " о увольнении работника " 
                    + dgvOrder.CurrentRow.Cells[2].Value.ToString() + ".docx";
                    document.SaveAs(FileName: path, FileFormat: word.WdSaveFormat.wdFormatDocumentDefault);
                    document.Close(document.Saved = false);
                    application.Quit();
                
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

        private void cbView_orderFill()
        {
            try
            {   Tables table_vid_pricaz = new Tables();
                table_vid_pricaz.dtView_orderFill();
                cbView_order.DataSource = table_vid_pricaz.dtView_order;
                cbView_order.ValueMember = "Ключ вида приказа";
                cbView_order.DisplayMember = "Вид приказа";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

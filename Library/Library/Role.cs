using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Role : Form
    {
        public Role()
        {
            InitializeComponent();
        }
        Procedures procedure = new Procedures();
        Int32 id_role, education, author, publisher, provider, genre, employee,
            order, view_order, town, dolj, street, contract_with_provider,
            avtoriz, reader_tickets, doc_on_buy_book, book, role,
            status_employee, work_contract, move_book, potencial_employee,
            book_catalog, reader_ticket, history;

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbRole.Text == "") MessageBox.Show("Выберите роль!");
                else
                {
                    proverka();
                    procedure.spRole_delete(id_role);
                    dgvFill();
                    ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbRole.Text == "") MessageBox.Show("Выберите роль!");
                else
                {
                    proverka();
                    procedure.spRole_update(id_role, tbRole.Text, dolj, status_employee, author, role, publisher, genre, town, street, doc_on_buy_book,
                        contract_with_provider, avtoriz, order, view_order, work_contract, book, reader_tickets, move_book, employee, potencial_employee,
                        education, book_catalog, reader_ticket, provider, history);
                    dgvFill();
                    ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbRole.Text == "") MessageBox.Show("Введите имя роли!");
                else
                {
                    proverka();
                    procedure.spRole_insert(tbRole.Text, dolj, status_employee, author, role, publisher, genre, town, street, doc_on_buy_book,
                        contract_with_provider, avtoriz, order, view_order, work_contract, book, reader_tickets, move_book, employee, potencial_employee, 
                        education, book_catalog, reader_ticket, provider, history);
                    dgvFill();
                    ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Role_Load(object sender, EventArgs e)
        {
            dgvFill();
        }

        private void dgvFill()
        {
            Tables data = new Tables();
            data.dtRoleFill();
            dgvRole.DataSource = data.dtRole;
            dgvRole.Columns[0].Visible = false;
        }

        private void dgvRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id_role = Convert.ToInt32(dgvRole.CurrentRow.Cells[0].Value.ToString());
                tbRole.Text = dgvRole.CurrentRow.Cells[1].Value.ToString();

            
                if (dgvRole.CurrentRow.Cells[2].Value.ToString() == "0") radioButton22.Checked = true;//должность
                else radioButton21.Checked = true;
                if (dgvRole.CurrentRow.Cells[3].Value.ToString() == "0") radioButton30.Checked = true;// статус сотр
                else radioButton29.Checked = true;
                if (dgvRole.CurrentRow.Cells[4].Value.ToString() == "0") radioButton4.Checked = true;//автор
                else radioButton3.Checked = true;
                if (dgvRole.CurrentRow.Cells[5].Value.ToString() == "0") radioButton26.Checked = true;//роль
                else radioButton25.Checked = true;
                if (dgvRole.CurrentRow.Cells[6].Value.ToString() == "0") radioButton6.Checked = true;// издательство
                else radioButton5.Checked = true;
                if (dgvRole.CurrentRow.Cells[7].Value.ToString() == "0") radioButton16.Checked = true;// жанр
                else radioButton15.Checked = true;
                if (dgvRole.CurrentRow.Cells[8].Value.ToString() == "0") radioButton32.Checked = true;// гордо
                else radioButton31.Checked = true;
                if (dgvRole.CurrentRow.Cells[9].Value.ToString() == "0") radioButton24.Checked = true;//улица
                else radioButton23.Checked = true;
                if (dgvRole.CurrentRow.Cells[10].Value.ToString() == "0") radioButton18.Checked = true;//документ на закупку книг
                else radioButton17.Checked = true;
                if (dgvRole.CurrentRow.Cells[11].Value.ToString() == "0") radioButton38.Checked = true;//договор с поставщиком
                else radioButton37.Checked = true;
                if (dgvRole.CurrentRow.Cells[12].Value.ToString() == "0") radioButton36.Checked = true;//авторизация
                else radioButton35.Checked = true;
                if (dgvRole.CurrentRow.Cells[13].Value.ToString() == "0") radioButton12.Checked = true;//приказ
                else radioButton11.Checked = true;
                if (dgvRole.CurrentRow.Cells[14].Value.ToString() == "0") radioButton10.Checked = true;//вид приказа
                else radioButton9.Checked = true;
                if (dgvRole.CurrentRow.Cells[15].Value.ToString() == "0") radioButton28.Checked = true;//трудовой договор 
                else radioButton27.Checked = true;
                if (dgvRole.CurrentRow.Cells[16].Value.ToString() == "0") radioButton40.Checked = true;//книга
                else radioButton39.Checked = true;
                if (dgvRole.CurrentRow.Cells[17].Value.ToString() == "0") radioButton34.Checked = true;//чит билеты
                else radioButton33.Checked = true;
                if (dgvRole.CurrentRow.Cells[18].Value.ToString() == "0") radioButton42.Checked = true;// движ книг
                else radioButton41.Checked = true;
                if (dgvRole.CurrentRow.Cells[19].Value.ToString() == "0") radioButton14.Checked = true;// сотр
                else radioButton13.Checked = true;
                if (dgvRole.CurrentRow.Cells[20].Value.ToString() == "0") radioButton44.Checked = true;// пот сотр
                else radioButton43.Checked = true;
                if (dgvRole.CurrentRow.Cells[21].Value.ToString() == "0") radioButton2.Checked = true;// образование 
                else radioButton1.Checked = true;
                if (dgvRole.CurrentRow.Cells[22].Value.ToString() == "0") radioButton48.Checked = true;// каталог
                else radioButton47.Checked = true;
                if (dgvRole.CurrentRow.Cells[23].Value.ToString() == "0") radioButton46.Checked = true;//лич чит билет
                else radioButton45.Checked = true;
                if (dgvRole.CurrentRow.Cells[24].Value.ToString() == "0") radioButton8.Checked = true;//поставщик 
                else radioButton7.Checked = true;
                if (dgvRole.CurrentRow.Cells[25].Value.ToString() == "0") radioButton20.Checked = true;//история
                else radioButton19.Checked = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            private void proverka()
            {
                if (radioButton2.Checked) education = 0;
                else education = 1;
                if (radioButton4.Checked) author = 0;
                else author = 1;
                if (radioButton6.Checked) publisher = 0;
                else publisher = 1;
                if (radioButton8.Checked) provider = 0;
                else provider = 1;
                if (radioButton16.Checked) genre = 0;
                else genre = 1;
                if (radioButton14.Checked) employee = 0;
                else employee = 1;
                if (radioButton12.Checked) order = 0;
                else order = 1;
                if (radioButton10.Checked) view_order = 0;
                else view_order = 1;
                if (radioButton32.Checked) town = 0;
                else town = 1;
                if (radioButton22.Checked) dolj = 0;
                else dolj = 1;
                if (radioButton24.Checked) street = 0;
                else street = 1;
                if (radioButton38.Checked) contract_with_provider = 0;
                else contract_with_provider = 1;
                if (radioButton36.Checked) avtoriz = 0;
                else avtoriz = 1;
                if (radioButton34.Checked) reader_tickets = 0;
                else reader_tickets = 1;
                if (radioButton18.Checked) doc_on_buy_book = 0;
                else doc_on_buy_book = 1;
                if (radioButton40.Checked) book = 0;
                else book = 1;
                if (radioButton26.Checked) role = 0;
                else role = 1;
                if (radioButton30.Checked) status_employee = 0;
                else status_employee = 1;
                if (radioButton28.Checked) work_contract = 0;
                else work_contract = 1;
                if (radioButton42.Checked) move_book = 0;
                else move_book = 1;
                if (radioButton44.Checked) potencial_employee = 0;
                else potencial_employee = 1;
                if (radioButton48.Checked) book_catalog = 0;
                else book_catalog = 1;
                if (radioButton46.Checked) reader_ticket = 0;
                else reader_ticket = 1;
                if (radioButton20.Checked) history = 0;
                else history = 1;
        }
        }
    }


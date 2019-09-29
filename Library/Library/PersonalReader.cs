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
    public partial class PersonalReader : Form
    {
        public PersonalReader()
        {
            InitializeComponent();
        }
        SqlCommand command = new SqlCommand("",ConnectionLibrary.ConnectionLibrary.sqlConnection);
        Int32 id_reader;
      

        private void dgvBookFill()
        {
            command.CommandText = "Select id_reader_ticket from reader_ticket where id_avtoriz=" + AvtorizUser.id_avtoriz;
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            id_reader = Convert.ToInt32(command.ExecuteScalar().ToString());
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();

            command.CommandText = "select book as 'Книга', date_of_issue as 'Дата выдачи', date_accept as 'Дата принятия', id_book, id_move_book" +
               " from View_move_book" +
               " where  id_reader_ticket =" + id_reader;
            DataTable dt = new DataTable();

            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            dt.Load(command.ExecuteReader());
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            dgvBook.DataSource = dt;
            dgvBook.Columns[3].Visible = false;
            dgvBook.Columns[4].Visible = false;
        }

        private void PersonalReader_Load(object sender, EventArgs e)
        {
            dgvBookFill();
            command.CommandText = "Select FIO from View_avtoriz_reader where id_avtoriz=" + AvtorizUser.id_avtoriz;
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            lblFIO.Text = "ФИО: " + command.ExecuteScalar().ToString();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.CommandText = "Select phone from reader_ticket where id_avtoriz=" + AvtorizUser.id_avtoriz;
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            lblPhone.Text = "Телефон: " + command.ExecuteScalar().ToString();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.CommandText = "Select series_passport +' '+number_passport as passport from reader_ticket where id_avtoriz=" + AvtorizUser.id_avtoriz;
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            lblPass.Text = "Паспорт: " + command.ExecuteScalar().ToString();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
        }
    }
}

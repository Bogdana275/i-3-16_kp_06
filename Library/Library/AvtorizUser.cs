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
    public partial class AvtorizUser : Form
    {
        public AvtorizUser()
        {
            InitializeComponent();
            
        }
        SqlCommand command = new SqlCommand("", ConnectionLibrary.ConnectionLibrary.sqlConnection);
        public static Int32 id_avtoriz, id_role;
        private void btVhod_Click(object sender, EventArgs e)
        {
            if ((TblLogin.Text == "") || (TblPassword.Text == ""))
            {
                if (TblLogin.Text == "")
                {
                    TblLogin.BackColor = System.Drawing.Color.Red;
                    LabelError1.Visible = true;
                    LabelError1.Text = "Пустой логин, введите логин";

                }
                else
                {
                    TblLogin.BackColor = System.Drawing.Color.White;
                    LabelError1.Visible = false;

                }

                if (TblPassword.Text == "")
                {
                    TblPassword.BackColor = System.Drawing.Color.Red;
                    LabelError2.Visible = true;
                    LabelError2.Text = "Пустой пароль, введите пароль";

                }
                else
                {
                    TblPassword.BackColor = System.Drawing.Color.White;
                    LabelError2.Visible = false;

                }
            }
            else
            {

                Authoriz(TblLogin.Text, TblPassword.Text);


            }
        }

        private void Authoriz(string login, string password)
        {
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.CommandText = "Select id_avtoriz " +
                "from avtoriz " +
                "where (login = '" + TblLogin.Text + "') " +
                "and (password = '" + TblPassword.Text + "')";
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            if (command.ExecuteScalar() == null)
                id_avtoriz = 0;
            else id_avtoriz = Convert.ToInt32(command.ExecuteScalar().ToString());
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();

            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.CommandText = "Select id_role " +
                "from avtoriz " +
                "where (login = '" + TblLogin.Text + "') " +
                "and (password = '" + TblPassword.Text + "')";
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            id_role = Convert.ToInt32(command.ExecuteScalar().ToString());

            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            //если нет в отделе кадров
            switch (id_avtoriz)
            {
                case (0):
                    {
                        MessageBox.Show("Данного пользователя нет в системе!");
                    }
                    break;

                default:
                    {
                        
                        check_access_user();
                        Program.Avtoriz_user = true;
                        MainMenu f = new MainMenu();
                        f.Visible_menu();
                        this.Close();
                    }
                    break;
            }

        }

        private void check_access_user()
        {
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            check_access("table_author");
            Program.table_author =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            check_access("table_dolj");
            Program.table_dolj =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            check_access("table_status_employee");
            Program.table_status_employee =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            check_access("table_role");
            Program.table_role =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            check_access("table_genre");
            Program.table_genre =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            check_access("table_town");
            Program.table_town =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            check_access("table_street");
            Program.table_street =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            check_access("table_publisher");
            Program.table_publisher =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            check_access("table_doc_on_buy_book");
            Program.table_doc_on_buy_book =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            check_access("table_contract_with_provider");
            Program.table_contract_with_provider =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            check_access("table_avtoriz");
            Program.table_avtoriz =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            check_access("table_order");
            Program.table_order =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            check_access("table_view_order");
            Program.table_view_order =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            check_access("table_work_contract");
            Program.table_work_contract =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            check_access("table_book");
            Program.table_book =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            check_access("table_reader_ticket");
            Program.table_reader_ticket =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            check_access("table_move_book");
            Program.table_move_book =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            check_access("table_employee");
            Program.table_employee =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            check_access("table_potencial_employee");
            Program.table_potencial_employee =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            check_access("table_education");
            Program.table_education =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            check_access("view_book_catalog");
            Program.view_book_catalog =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            check_access("view_reader_ticket");
            Program.view_reader_ticket =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            check_access("table_provider");
            Program.table_provider =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            check_access("table_history");
            Program.table_history =
            Convert.ToInt32(command.ExecuteScalar().ToString());
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btReg_Click(object sender, EventArgs e)
        {
            this.Close();
            RegForm f = new RegForm();
            f.Show();
        }

        private void check_access(string table)
        {

            command.CommandText = "select [dbo].[role].[" + table + "] " +
            "from [dbo].[avtoriz] join [dbo].[role] " +
            "on [dbo].[avtoriz].[id_role] = [dbo].[role].[id_role] " +
            "where [dbo].[avtoriz].[id_role] = " + id_role.ToString();

        }
    }
}

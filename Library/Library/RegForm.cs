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
using System.Text.RegularExpressions;

namespace Library
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }
        SqlCommand command = new SqlCommand("",ConnectionLibrary.ConnectionLibrary.sqlConnection);
        Procedures procedure = new Procedures();
        string RegPass = @"[^!@%$*&~`'/\|()?]$";
        Int32 id_role, id_avtoriz;
        private void btVhod_Click(object sender, EventArgs e)
        {
            if (tbFam.Text == "" | tbIm.Text == "" | tbOtchestvo.Text == "" | tbSeria.Text == "" | tbNumber.Text == "")
                MessageBox.Show("Не все поля заполнены!");
            if (tbFam.Text == "") tbFam.BackColor = Color.Red;
            if (tbIm.Text == "") tbIm.BackColor = Color.Red;
            if (tbOtchestvo.Text == "") tbOtchestvo.BackColor = Color.Red;
            if (tbSeria.Text == "") tbSeria.BackColor = Color.Red;
            if (tbNumber.Text == "") tbNumber.BackColor = Color.Red;
            else
            {
                tbFam.BackColor = Color.White;
                tbIm.BackColor = Color.White;
                tbOtchestvo.BackColor = Color.White;
                tbNumber.BackColor = Color.White;
                tbSeria.BackColor = Color.White;
                switch (TxbNewLogin.Text == "")
                {
                    case (true):
                        TxbNewLogin.BackColor = System.Drawing.Color.Red;
                        LabelError1.Visible = true;
                        LabelError1.Text = "Логин пуст, введите логин";
                        break;

                    case (false):
                        LabelError1.Visible = false;
                        TxbNewLogin.BackColor = System.Drawing.Color.White;

                        switch (TxbNewPass.Text == "")
                        {
                            case (true):
                                TxbNewPass.BackColor = System.Drawing.Color.Red;
                                LabelError2.Visible = true;
                                LabelError2.Text = "Пароль пуст, введите пароль";
                                if (TxbConfPass.Text == "")
                                {
                                    TxbConfPass.BackColor = System.Drawing.Color.Red;
                                    LabelError3.Visible = true;
                                    LabelError3.Text = "Повторите пароль";
                                }
                                break;

                            case (false):
                                LabelError2.Visible = false;
                                TxbNewPass.BackColor = System.Drawing.Color.White;
                                switch (TxbConfPass.Text == "")
                                {
                                    case (true):
                                        TxbConfPass.BackColor = System.Drawing.Color.Red;
                                        LabelError3.Visible = true;
                                        LabelError3.Text = "Повторите пароль";
                                        break;

                                    case (false):
                                        LabelError3.Visible = false;
                                        TxbConfPass.BackColor = System.Drawing.Color.White;
                                        Int32 haveID = 0;
                                        switch (TxbNewPass.Text == TxbConfPass.Text)
                                        {

                                            case (true):
                                                switch (TxbNewLogin.Text.Length > 15)
                                                {
                                                    case (true):
                                                        LabelError1.Visible = true;
                                                        LabelError1.Text = "Длина логина должна быть меньше 15 символов!";
                                                        TxbNewLogin.BackColor = System.Drawing.Color.Red;
                                                        break;

                                                    case (false):
                                                        LabelError1.Visible = false;
                                                        TxbNewLogin.BackColor = System.Drawing.Color.White;

                                                        switch (TxbNewPass.Text.Length > 15)
                                                        {
                                                            case (true):
                                                                LabelError2.Visible = true;
                                                                LabelError2.Text = "Длина пароля должна быть меньше 15 символов!";
                                                                TxbNewPass.BackColor = System.Drawing.Color.Red;
                                                                break;

                                                            case (false):
                                                                TxbNewPass.BackColor = System.Drawing.Color.White;
                                                                TxbConfPass.BackColor = System.Drawing.Color.White;
                                                                LabelError3.Visible = false;


                                                                command.CommandText = "Select count(*) from [dbo].[avtoriz]" +
                                                                "where [dbo].[avtoriz].[login] = '" + TxbNewLogin.Text + "'";
                                                                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                                                                if (command.ExecuteScalar() != null)
                                                                    haveID = 0;
                                                                else haveID = 1;
                                                                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();

                                                                switch (haveID)
                                                                {
                                                                    case (1):

                                                                        LabelError1.Text = "Пользователь с таким логином уже существует в системе! Введите другой";
                                                                        TxbNewLogin.BackColor = System.Drawing.Color.Red;
                                                                        LabelError1.Visible = true;
                                                                        break;

                                                                    case (0):

                                                                        switch (Regex.IsMatch(TxbNewPass.Text, RegPass))
                                                                        {
                                                                            case (true):
                                                                                TxbNewPass.BackColor = System.Drawing.Color.White;
                                                                                LabelError1.Visible = false;
                                                                                NewUser();

                                                                                break;

                                                                            case (false):
                                                                                LabelError2.Text = "В пароле присутствуют спец символы, которые нельзя использовать! То есть такие как !?@#$%^&*()";
                                                                                TxbNewPass.BackColor = System.Drawing.Color.Red;
                                                                                LabelError2.Visible = true;
                                                                                break;
                                                                        }

                                                                        break;
                                                                }

                                                                break;
                                                        }
                                                        break;
                                                }


                                                break;
                                            case (false):
                                                TxbNewPass.BackColor = System.Drawing.Color.Orange;
                                                TxbConfPass.BackColor = System.Drawing.Color.Orange;
                                                LabelError3.Visible = true;
                                                LabelError3.Text = "Пароли не совпадают!";
                                                break;
                                        }
                                        break;
                                }
                                break;
                        }
                        break;


                }


            }
        }

        private void NewUser()
        {
            command.CommandText = "Select id_role from role where name_role='Гость'";
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            id_role = Convert.ToInt32(command.ExecuteScalar().ToString());
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            procedure.spAvtoriz_insert(TxbNewLogin.Text, TxbNewPass.Text, id_role);
            command.CommandText = "Select id_avtoriz from avtoriz where login='" + TxbNewLogin.Text + "'";
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            id_avtoriz = Convert.ToInt32(command.ExecuteScalar().ToString());
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            procedure.spReader_ticket_insert(tbFam.Text, tbIm.Text, tbOtchestvo.Text, id_avtoriz, tbSeria.Text, tbNumber.Text, tbPhone.Text);
            Program.Reg_user = true;
            this.Close();
            MainMenu f = new MainMenu();
            f.Visible_menu();
        }
    }
}

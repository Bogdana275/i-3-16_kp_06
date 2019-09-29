using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public partial class Avtoriz : Form
    {
        public Avtoriz()
        {
            InitializeComponent();
        }
        SqlCommand command = new SqlCommand("",ConnectionLibrary.ConnectionLibrary.sqlConnection);
        Int32 id_role, id_employee, id_reader, id_avtoriz;
        Procedures procedure = new Procedures();
        private void Avtoriz_Load(object sender, EventArgs e)
        {
            dgvEmployeeFill();
            dgvReaderFill();
            cbRoleEmployeeFill();
            cbRoleReaderFill();
        }

        private void cbRoleEmployeeFill()
        {
            try
            {
                DataTable dtRoleEmployee = new DataTable();
                command.CommandText = "Select id_role, name_role from role";
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                dtRoleEmployee.Load(command.ExecuteReader());
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                cbRoleEmployee.DataSource = dtRoleEmployee;
                cbRoleEmployee.ValueMember = "id_role";
                cbRoleEmployee.DisplayMember = "name_role";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbRoleReaderFill()
        {
            try
            {
                DataTable dtRoleReader = new DataTable();
                command.CommandText = "Select id_role, name_role from role";
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                dtRoleReader.Load(command.ExecuteReader());
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                cbRoleReader.DataSource = dtRoleReader;
                cbRoleReader.ValueMember = "id_role";
                cbRoleReader.DisplayMember = "name_role";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvReader_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvEmployee_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            id_avtoriz = Convert.ToInt32(dgvEmployee.CurrentRow.Cells[0].Value.ToString());
            id_employee = Convert.ToInt32(dgvEmployee.CurrentRow.Cells[1].Value.ToString());
            id_role = Convert.ToInt32(dgvEmployee.CurrentRow.Cells[5].Value.ToString());

            cbRoleEmployee.SelectedValue = id_role;
            tbLoginEmployee.Text = dgvEmployee.CurrentRow.Cells[3].Value.ToString();
            tbPasswordEmployee.Text = dgvEmployee.CurrentRow.Cells[4].Value.ToString();
        }

        private void dgvReaders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_avtoriz = Convert.ToInt32(dgvReaders.CurrentRow.Cells[0].Value.ToString());
            id_reader = Convert.ToInt32(dgvReaders.CurrentRow.Cells[1].Value.ToString());
            id_role = Convert.ToInt32(dgvReaders.CurrentRow.Cells[5].Value.ToString());

            cbRoleReader.SelectedValue = id_role;
            tbLoginReader.Text = dgvReaders.CurrentRow.Cells[3].Value.ToString();
            tbPasswordReader.Text = dgvReaders.CurrentRow.Cells[4].Value.ToString();
        }

        

        private void btUpdateEmployee_Click(object sender, EventArgs e)
        {
            switch (tbLoginEmployee.Text == "" && tbPasswordEmployee.Text == "")
            {
                case (true):
                    MessageBox.Show("Выберите Сотрудника!");
                    break;
                case (false):
                    {
                        switch (tbLoginEmployee.Text == "" || tbPasswordEmployee.Text == "")
                        {
                            case (true):
                                MessageBox.Show("Логин и пароль не должны быть пустыми!");
                                break;
                            case (false):
                                try
                                {
                                    procedure.spAvtoriz_update(tbLoginEmployee.Text, tbPasswordEmployee.Text, id_role, id_avtoriz);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                                finally
                                {
                                    tbLoginEmployee.Clear();
                                    tbPasswordEmployee.Clear();
                                    Avtoriz_Load(sender, e);
                                }
                                break;
                        }
                    }      break;
            }
        }

        private void btUpdateReader_Click(object sender, EventArgs e)
        {
            switch (tbLoginReader.Text == "" && tbPasswordReader.Text == "")
            {
                case (true):
                    MessageBox.Show("Выберите Читателя!");
                    break;
                case (false):
                    {
                        switch (tbLoginReader.Text == "" || tbPasswordReader.Text == "")
                        {
                            case (true):
                                MessageBox.Show("Логин и пароль не должны быть пустыми!");
                                break;
                            case (false):
                                try
                                {
                                    procedure.spAvtoriz_update(tbLoginReader.Text, tbPasswordReader.Text, id_role, id_avtoriz);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                                finally
                                {
                                    tbLoginReader.Clear();
                                    tbPasswordReader.Clear();
                                    Avtoriz_Load(sender, e);
                                }
                                break;
                        }
                    }
                    break;
            }
        }

        private void cbRoleReader_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id_role = Convert.ToInt32(cbRoleReader.SelectedValue.ToString());
        }

        private void cbRoleEmployee_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id_role = Convert.ToInt32(cbRoleEmployee.SelectedValue.ToString());
        }

        private void dgvEmployeeFill()
        {
            DataTable dtEmployee = new DataTable();
            command.CommandText="Select id_avtoriz, id_employee, FIO as 'ФИО', login as 'Логин', password as 'Пароль', id_role, name_role as 'Роль' from View_avtoriz_employee";
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            dtEmployee.Load(command.ExecuteReader());
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            dgvEmployee.DataSource = dtEmployee;
            dgvEmployee.Columns[0].Visible = false;
            dgvEmployee.Columns[1].Visible = false;
            dgvEmployee.Columns[5].Visible = false;
        }

        private void dgvReaderFill()
        {
            DataTable dtReader = new DataTable();
            command.CommandText = "Select id_avtoriz, id_reader_ticket, FIO as 'ФИО', login as 'Логин', password as 'Пароль', id_role, name_role as 'Роль' from View_avtoriz_reader";
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            dtReader.Load(command.ExecuteReader());
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            dgvReaders.DataSource = dtReader;
            dgvReaders.Columns[0].Visible = false;
            dgvReaders.Columns[1].Visible = false;
            dgvReaders.Columns[5].Visible = false;
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

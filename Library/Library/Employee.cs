using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        Int32 id_employee, id_education, id_status_employee, id_dolj, id_avtoriz, id_role;
        Procedures procedure = new Procedures();
        SqlCommand command = new SqlCommand("",ConnectionLibrary.ConnectionLibrary.sqlConnection);
        private void Employee_Load(object sender, EventArgs e)
        {
            dgvFill();
            cbDoljFill();
            cbEducationFill();
            cbStatus_employeeFill();
            id_education = Convert.ToInt32(cbEducation.SelectedValue.ToString());
            id_status_employee = Convert.ToInt32(cbStatus_employee.SelectedValue.ToString());
            id_dolj = Convert.ToInt32(cbDolj.SelectedValue.ToString());
        }

        private void dgvFill()
        {
            Tables data = new Tables();
            data.dtEmployeeFill();
            dgvEmployee.DataSource = data.dtEmployee;
            dgvEmployee.Columns[0].Visible = false;
            dgvEmployee.Columns[4].Visible = false;
            dgvEmployee.Columns[7].Visible = false;
            dgvEmployee.Columns[9].Visible = false;
            dgvEmployee.Columns[15].Visible = false;
        }

        private void cbEducation_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cbStatus_employee_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id_status_employee = Convert.ToInt32(cbStatus_employee.SelectedValue.ToString());
        }

        private void cbDolj_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id_dolj = Convert.ToInt32(cbDolj.SelectedValue.ToString());
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id_employee = Convert.ToInt32(dgvEmployee.CurrentRow.Cells[0].Value.ToString());
                tbFam.Text = dgvEmployee.CurrentRow.Cells[1].Value.ToString();
                tbIm.Text = dgvEmployee.CurrentRow.Cells[2].Value.ToString();
                tbOtch.Text = dgvEmployee.CurrentRow.Cells[3].Value.ToString();

                id_dolj = Convert.ToInt32(dgvEmployee.CurrentRow.Cells[4].Value.ToString());
                id_education = Convert.ToInt32(dgvEmployee.CurrentRow.Cells[7].Value.ToString());
                id_status_employee = Convert.ToInt32(dgvEmployee.CurrentRow.Cells[9].Value.ToString());
                tbDate.Text = dgvEmployee.CurrentRow.Cells[11].Value.ToString();
                tbPhone.Text = dgvEmployee.CurrentRow.Cells[12].Value.ToString();
                tbSeries.Text = dgvEmployee.CurrentRow.Cells[13].Value.ToString();
                tbNumberPass.Text = dgvEmployee.CurrentRow.Cells[14].Value.ToString();
                tbLogin.Text = dgvEmployee.CurrentRow.Cells[16].Value.ToString();
                tbPassword.Text = dgvEmployee.CurrentRow.Cells[17].Value.ToString();

                id_avtoriz = Convert.ToInt32(dgvEmployee.CurrentRow.Cells[15].Value.ToString());

                command.CommandText = "Select id_role from avtoriz where id_avtoriz=" + id_avtoriz;
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                id_role = Convert.ToInt32(command.ExecuteScalar().ToString());
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                cbDolj.SelectedValue = id_dolj;
                cbStatus_employee.SelectedValue = id_status_employee;
                cbEducation.SelectedValue = id_education;

        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void btInsert_Click(object sender, EventArgs e)
        {
            switch (tbFam.Text == "" | tbIm.Text == "" | tbPhone.Text == "" | tbOtch.Text == "" |
                tbSeries.Text == "" | tbNumberPass.Text == "" | tbDate.Text == "" | tbLogin.Text == "" | tbPassword.Text == "")
            {
                case (true):
                    MessageBox.Show("Не все поля заполнены!");
                    break;
                case (false):
                    try
                    {
                        procedure.spAvtoriz_insert(tbLogin.Text, tbPassword.Text, 5);
                        command.CommandText = "Select id_avtoriz from avtoriz where login='" +tbLogin.Text+"' and password='" +tbPassword.Text+"'";
                        ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                        ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                        id_avtoriz = Convert.ToInt32(command.ExecuteScalar().ToString());
                        ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                        procedure.spEmployee_insert(tbFam.Text, tbIm.Text, tbOtch.Text, id_dolj, id_education, id_avtoriz, id_status_employee, tbDate.Text,
                            tbPhone.Text, tbSeries.Text, tbNumberPass.Text);
            }
                    catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbClear();
                        Employee_Load(sender, e);
                    }
                    break;
            }
        }

        private void cbEducation_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id_education = Convert.ToInt32(cbEducation.SelectedValue.ToString());
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            switch (tbFam.Text == "" | tbIm.Text == "" | tbPhone.Text == "" | tbOtch.Text == "" |
                tbSeries.Text == "" | tbNumberPass.Text == "" | tbDate.Text == "" | tbLogin.Text == "" | tbPassword.Text == "")
            {
                case (true):
                    MessageBox.Show("Выберите сотрудника!");
                    break;
                case (false):
                    try
                    {
                        ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                        procedure.spAvtoriz_update(tbLogin.Text, tbPassword.Text, id_role, id_avtoriz);
                        ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                        procedure.spEmployee_update(id_employee,tbFam.Text, tbIm.Text, tbOtch.Text, id_dolj, id_education, id_avtoriz, id_status_employee, tbDate.Text,
                            tbPhone.Text, tbSeries.Text, tbNumberPass.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        tbClear();
                        Employee_Load(sender, e);
                    }
                    break;
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            switch (tbFam.Text == "" | tbIm.Text == "" | tbPhone.Text == "" | tbOtch.Text == "" |
                tbSeries.Text == "" | tbNumberPass.Text == "" | tbDate.Text == "" | tbLogin.Text == "" | tbPassword.Text == "")
            {
                case (true):
                    MessageBox.Show("Выберите сотрудника!");
                    break;
                case (false):
                    try
                    {
                        ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                        procedure.spEmployee_delete(id_employee);
                        ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                        procedure.spAvtoriz_delete(id_avtoriz);
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        tbClear();
                        Employee_Load(sender, e);
                    }
                    break;
            }
        }

        private void tbClear()
        {
            tbFam.Clear();
            tbIm.Clear();
            tbOtch.Clear();
            tbDate.Clear();
            tbPhone.Clear();
            tbSeries.Clear();
            tbNumberPass.Clear();
            tbLogin.Clear();
            tbPassword.Clear();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cbDoljFill()
        {

            try
            {
                Tables dtDolj = new Tables();
                dtDolj.dtDoljFill();
                cbDolj.DataSource = dtDolj.dtDolj;
                cbDolj.ValueMember = "Ключ должности";
                cbDolj.DisplayMember = "Должность";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbEducationFill()
        {
            try
            {
                Tables dtEducation = new Tables();
                dtEducation.dtEducationFill();
                cbEducation.DataSource = dtEducation.dtEducation;
                cbEducation.ValueMember = "Ключ образования";
                cbEducation.DisplayMember = "Образование";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbStatus_employeeFill()
        {
            try
            {
                Tables dtStatus_employee = new Tables();
                dtStatus_employee.dtStatus_employeeFill();
                cbStatus_employee.DataSource = dtStatus_employee.dtStatus_employee;
                cbStatus_employee.ValueMember = "Ключ статуса сотрудника";
                cbStatus_employee.DisplayMember = "Статус сотрудника";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

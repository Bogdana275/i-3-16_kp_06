using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public partial class Potencial_employee : Form
    {
        public Potencial_employee()
        {
            InitializeComponent();
        }
        Procedures procedure = new Procedures();
        SqlCommand command = new SqlCommand("",ConnectionLibrary.ConnectionLibrary.sqlConnection);
        Int32 id_potencial_employee, id_dolj, id_education;
        private void Potencial_employee_Load(object sender, EventArgs e)
        {
            dgvFill();
            cbDoljFill();
            cbEducationFill();
            id_education = Convert.ToInt32(cbEducation.SelectedValue.ToString());
            id_dolj = Convert.ToInt32(cbDolj.SelectedValue.ToString());
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

       

        private void dgvFill()
        {
            Tables data = new Tables();
            data.dtPotencial_employeeFill();
            dgvPotencial_employee.DataSource = data.dtPotencial_employee;
            dgvPotencial_employee.Columns[0].Visible = false;
            dgvPotencial_employee.Columns[6].Visible = false;
            dgvPotencial_employee.Columns[8].Visible = false;
        }

        private void cbEducation_SelectedValueChanged(object sender, EventArgs e)
        {

        }

       

        private void cbDolj_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id_dolj = Convert.ToInt32(cbDolj.SelectedValue.ToString());
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id_potencial_employee = Convert.ToInt32(dgvPotencial_employee.CurrentRow.Cells[0].Value.ToString());
                tbFam.Text = dgvPotencial_employee.CurrentRow.Cells[1].Value.ToString();
                tbIm.Text = dgvPotencial_employee.CurrentRow.Cells[2].Value.ToString();
                tbOtch.Text = dgvPotencial_employee.CurrentRow.Cells[3].Value.ToString();

                id_dolj = Convert.ToInt32(dgvPotencial_employee.CurrentRow.Cells[6].Value.ToString());
                id_education = Convert.ToInt32(dgvPotencial_employee.CurrentRow.Cells[8].Value.ToString());
                tbDate.Text = dgvPotencial_employee.CurrentRow.Cells[4].Value.ToString();
                tbPhone.Text = dgvPotencial_employee.CurrentRow.Cells[5].Value.ToString();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                cbDolj.SelectedValue = id_dolj;
                cbEducation.SelectedValue = id_education;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            switch (tbFam.Text == "" | tbIm.Text == "" | tbPhone.Text == "" | tbOtch.Text == "" | tbDate.Text == "")
            {
                case (true):
                    MessageBox.Show("Не все поля заполнены!");
                    break;
                case (false):
                    try
                    {
                        procedure.spPotencial_employee_insert(tbFam.Text, tbIm.Text, tbOtch.Text, id_dolj, id_education , tbDate.Text,
                            tbPhone.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        tbClear();
                        Potencial_employee_Load(sender, e);
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
            switch (tbFam.Text == "" | tbIm.Text == "" | tbPhone.Text == "" | tbOtch.Text == ""| tbDate.Text == "" )
            {
                case (true):
                    MessageBox.Show("Выберите сотрудника!");
                    break;
                case (false):
                    try
                    {
                        
                        procedure.spPotencial_employee_update(id_potencial_employee, tbFam.Text, tbIm.Text, tbOtch.Text, id_dolj, id_education, tbDate.Text,
                            tbPhone.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        tbClear();
                        Potencial_employee_Load(sender, e);
                    }
                    break;
            }
        }

        private void dgvPotencial_employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id_potencial_employee = Convert.ToInt32(dgvPotencial_employee.CurrentRow.Cells[0].Value.ToString());
                tbFam.Text = dgvPotencial_employee.CurrentRow.Cells[1].Value.ToString();
                tbIm.Text = dgvPotencial_employee.CurrentRow.Cells[2].Value.ToString();
                tbOtch.Text = dgvPotencial_employee.CurrentRow.Cells[3].Value.ToString();

                id_dolj = Convert.ToInt32(dgvPotencial_employee.CurrentRow.Cells[6].Value.ToString());
                id_education = Convert.ToInt32(dgvPotencial_employee.CurrentRow.Cells[8].Value.ToString());
                tbDate.Text = dgvPotencial_employee.CurrentRow.Cells[4].Value.ToString();
                tbPhone.Text = dgvPotencial_employee.CurrentRow.Cells[5].Value.ToString();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                cbDolj.SelectedValue = id_dolj;
                cbEducation.SelectedValue = id_education;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            switch (tbFam.Text == "" | tbIm.Text == "" | tbPhone.Text == "" | tbOtch.Text == "" | tbDate.Text == "")
            {
                case (true):
                    MessageBox.Show("Выберите сотрудника!");
                    break;
                case (false):
                    try
                    {
                        ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                        procedure.spPotencial_employee_delete(id_potencial_employee);
                        

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        tbClear();
                        Potencial_employee_Load(sender, e);
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
        }
    }
}

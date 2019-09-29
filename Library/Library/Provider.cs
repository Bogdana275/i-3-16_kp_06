using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Library
{
    public partial class Provider : Form
    {
        public Provider()
        {
            InitializeComponent();
        }
        Int32 id_provider, id_street, id_town;
        Procedures procedure = new Procedures();
        SqlCommand command = new SqlCommand("",ConnectionLibrary.ConnectionLibrary.sqlConnection);
        private void Provider_Load(object sender, EventArgs e)
        {
            dgvFill();
        }

        private void dgvFill()
        {
            Tables data = new Tables();
            data.dtProviderFill();
            dgvProvider.DataSource = data.dtProvider;
            dgvProvider.Columns[0].Visible = false;
            dgvProvider.Columns[2].Visible = false;
            dgvProvider.Columns[4].Visible = false;
            cbStreetFill();
            cbTownFill();
            id_street = Convert.ToInt32(cbStreet.SelectedValue.ToString());
            id_town = Convert.ToInt32(cbTown.SelectedValue.ToString());
        }

        private void dgvProvider_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                id_provider = Convert.ToInt32(dgvProvider.CurrentRow.Cells[0].Value.ToString());
                tbProvider.Text = dgvProvider.CurrentRow.Cells[1].Value.ToString();

                id_town = Convert.ToInt32(dgvProvider.CurrentRow.Cells[2].Value.ToString());
                id_street = Convert.ToInt32(dgvProvider.CurrentRow.Cells[4].Value.ToString());
                tbHome.Text = dgvProvider.CurrentRow.Cells[6].Value.ToString();
                tbINN.Text = dgvProvider.CurrentRow.Cells[8].Value.ToString();
                tbPhone.Text = dgvProvider.CurrentRow.Cells[7].Value.ToString();
                cbTown.SelectedValue = id_town;
                cbStreet.SelectedValue = id_street;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbTown_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id_town = Convert.ToInt32(cbTown.SelectedValue);
        }

        private void cbStreet_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id_street = Convert.ToInt32(cbStreet.SelectedValue);
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            switch (tbProvider.Text == "" | tbINN.Text == "" | tbPhone.Text == ""| tbHome.Text == "")
            {
                case (true):
                    MessageBox.Show("Не все поля заполнены!");
                    break;
                case (false):
                    try
                    {
                        procedure.spProvider_insert(tbProvider.Text, id_town, id_street, tbPhone.Text, tbINN.Text, tbHome.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        tbClear();
                        Provider_Load(sender, e);
                    }
                    break;
            }
        }

        private void tbClear()
        {
            tbHome.Clear();
            tbPhone.Clear();
            tbProvider.Clear();
            tbINN.Clear();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            switch (tbProvider.Text == "" | tbINN.Text == "" | tbPhone.Text == "" | tbHome.Text == "")
            {
                case (true):
                    MessageBox.Show("Не все поля заполнены!");
                    break;
                case (false):
                    try
                    {
                        procedure.spProvider_update(id_provider, tbProvider.Text, id_town, id_street, tbPhone.Text, tbINN.Text, tbHome.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        tbClear();
                        Provider_Load(sender, e);
                    }
                    break;
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            switch (tbProvider.Text == "" | tbINN.Text == "" | tbPhone.Text == "" | tbHome.Text == "")
            {
                case (true):
                    MessageBox.Show("Не все поля заполнены!");
                    break;
                case (false):
                    try
                    {
                        procedure.spProvider_delete(id_provider);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        tbClear();
                        Provider_Load(sender, e);
                    }
                    break;
            }
        }

        private void tbPoisk_TextChanged(object sender, EventArgs e)
        {
            if (tbPoisk.Text == "")
            {
                Provider_Load(sender, e);
            }
            else
            {
                Tables query = new Tables();
                command.CommandText = query.qrProvider +
                    " where (Provider like '%" + tbProvider.Text + "%') " +
                    "or (street like '%" + dgvProvider.CurrentRow.Cells[5].Value.ToString() + "%') " +
                    "or (town like '%" + dgvProvider.CurrentRow.Cells[3].Value.ToString() + "%') " +
                    "or (INN like '%" + tbINN.Text + "%') " +
                    "or (phone like '%" + tbPhone.Text + "%')";


                DataTable dt = new DataTable();

                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                dt.Load(command.ExecuteReader());
                dgvProvider.DataSource = dt;
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            }
        }

        private void cbStreetFill()
        {
            try
            {
                Tables dtStreet = new Tables();
                dtStreet.dtStreetFill();
                cbStreet.DataSource = dtStreet.dtStreet;
                cbStreet.ValueMember = "Ключ улицы";
                cbStreet.DisplayMember = "Улица";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbTownFill()
        {
            try
            {
                Tables dtTown = new Tables();
                dtTown.dtTownFill();
                cbTown.DataSource = dtTown.dtTown;
                cbTown.ValueMember = "Ключ города";
                cbTown.DisplayMember = ".город";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

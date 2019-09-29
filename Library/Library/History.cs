using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        SqlCommand cmd = new SqlCommand("", ConnectionLibrary.ConnectionLibrary.sqlConnection);

        private void History_Load(object sender, EventArgs e)
        {
            HistoryFill();
        }

        private void HistoryFill()
        {
            Tables data = new Tables();
            data.dtHistoryFill();
            dgvHistory.DataSource = data.dtHistory;
            dgvHistory.Columns[0].Visible = false;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "truncate table history";
            try
            {
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                cmd.ExecuteReader();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                HistoryFill();
            }
            
        }
    }
}

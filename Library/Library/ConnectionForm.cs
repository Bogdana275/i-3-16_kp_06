﻿using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace Library
{
    public partial class ConnectionForm : Form
    {
        public event Action<DataTable> dtServers;
        public event Action<DataTable> dtDatabases;
        public event Action<bool> conState;
        public string cds, cui, cpw;
        public static bool logCon;
        private Int32 status = 1;

        public ConnectionForm()
        {
            InitializeComponent();
        }
        

        private void dtservers(DataTable table)
        {
            status = 0;
            Action action = () =>
            {
                foreach (DataRow r in table.Rows)
                {
                    cbIPServer.Items.Add(r[0]);
                    cbDataSource.Items.Add(r[1]);
                }
                cbIPServer.Enabled = true;
                cbDataSource.Enabled = true;
                tbUserID.Enabled = true;
                tbPassword.Enabled = true;
                btCheck.Enabled = true;
            };
            Invoke(action);
        }

        private void tsslMessage()
        {
            for (int i = 0; i < status;)
            {
                Thread.Sleep(500);
                Action action = () =>
                {
                    switch (status)
                    {
                        case (1):
                            if (tsslStatus.Text != "Поиск серверов...")
                                tsslStatus.Text += ".";
                            else
                                tsslStatus.Text = "Поиск серверов";
                            break;
                        case (2):
                            if (tsslStatus.Text != "Поиск баз данных...")
                                tsslStatus.Text += ".";
                            else
                                tsslStatus.Text = "Поиск баз данных";
                            break;
                        case (0):
                            tsslStatus.Text = "-";
                            tsslStatus.Visible = false;
                            break;
                    }
                };
                Invoke(action);
            }
        }

        private void databases(DataTable table)
        {
            Action action = () =>
            {
                cbInitialCatalog.Items.Clear();
                foreach (DataRow r in table.Rows)
                {
                    cbInitialCatalog.Items.Add(r[0]);
                }
                status = 0;
                cbInitialCatalog.Enabled = true;
                
            };
            Invoke(action);
        }

        private void btCheck_Click(object sender, EventArgs e)
        {

            cds = cbIPServer.Text + @"\" + cbDataSource.Text;
            cui = tbUserID.Text;
            cpw = tbPassword.Text;
            status = 2;
            tsslStatus.Text = "Поиск баз данных";
            tsslStatus.Visible = true;
            dtDatabases += databases;
            Thread threadMessage = new Thread(tsslMessage);
            Thread thread = new Thread(Databases_get);
            threadMessage.Start();
            thread.Start();
        }

        private void btConect_Click(object sender, EventArgs e)
        {

            ConnectionLibrary.ConnectionLibrary.Registry_Set(cbIPServer.Text, cbDataSource.Text, cbInitialCatalog.Text, tbUserID.Text, tbPassword.Text);
            MainMenu menu = new MainMenu();
            menu.Show();
            logCon = true;
            Hide();
        }

        private void ConnectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (logCon)
            {
                case (true):
                    e.Cancel = false;
                    break;
                case (false):
                    Application.Exit();
                    break;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Servers_get()
        {
            SqlDataSourceEnumerator sourceEnumerator
                = SqlDataSourceEnumerator.Instance;
            dtServers(sourceEnumerator.GetDataSources());
        }

        private void ConnectionForm_Load(object sender, EventArgs e)
        {
            switch (logCon)
            {
                case (true):
                    cbIPServer.Text = ConnectionLibrary.ConnectionLibrary.DSIP;
                    cbDataSource.Text = ConnectionLibrary.ConnectionLibrary.DSSN;
                    cbInitialCatalog.Text = ConnectionLibrary.ConnectionLibrary.IC;
                    cbIPServer.Enabled = true;
                    cbDataSource.Enabled = true;
                    cbInitialCatalog.Enabled = true;
                    tbUserID.Enabled = true;
                    tbPassword.Enabled = true;
                    btCheck.Enabled = true;
                    break;
                case (false):
                    status = 1;
                    tsslStatus.Visible = true;
                    tsslStatus.Text = "Поиск серверов";
                    dtServers += dtservers;
                    Thread thread = new Thread(Servers_get);
                    Thread threadMessage = new Thread(tsslMessage);
                    threadMessage.Start();
                    thread.Start();
                    break;
            }
        }

        private void ConnectionForm_Shown(object sender, EventArgs e)
        {
            
        }

        private void cbInitialCatalog_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btConect.Enabled = true;
        }

        public void Databases_get()
        {
            try
            {
                SqlConnection sql = new SqlConnection("Data Source = " + cds +
                    "; Initial Catalog = master; Persist Security Info = true; " +
                    " User ID = " + cui + "; Password = \"" + cpw + "\"");

                SqlCommand command = new SqlCommand("select name from sys.databases " +
                    "where name not in ('master','tempdb','model','msdb')", sql);
                DataTable table = new DataTable();
                sql.Open();
                table.Load(command.ExecuteReader());
                dtDatabases(table);
                sql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            
          
        }

        public void Connection_check()
        {
            ConnectionLibrary.ConnectionLibrary.Registry_Get();
            try
            {
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                conState(true);
                logCon = true;
            }
            catch 
            {
                
                conState(false);
                logCon = false;
            }
            finally
            {
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            }
        }
    }
}

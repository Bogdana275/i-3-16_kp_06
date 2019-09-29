namespace Library
{
    partial class ConnectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionForm));
            this.cbInitialCatalog = new System.Windows.Forms.ComboBox();
            this.lblDataSource = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.lblUsers = new System.Windows.Forms.Label();
            this.cbDataSource = new System.Windows.Forms.ComboBox();
            this.lbServer = new System.Windows.Forms.Label();
            this.cbIPServer = new System.Windows.Forms.ComboBox();
            this.lblServers = new System.Windows.Forms.Label();
            this.pnControl = new System.Windows.Forms.Panel();
            this.btConect = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btCheck = new System.Windows.Forms.Button();
            this.statusConect = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnControl.SuspendLayout();
            this.statusConect.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbInitialCatalog
            // 
            this.cbInitialCatalog.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbInitialCatalog.Enabled = false;
            this.cbInitialCatalog.FormattingEnabled = true;
            this.cbInitialCatalog.Location = new System.Drawing.Point(0, 177);
            this.cbInitialCatalog.Margin = new System.Windows.Forms.Padding(4);
            this.cbInitialCatalog.Name = "cbInitialCatalog";
            this.cbInitialCatalog.Size = new System.Drawing.Size(418, 24);
            this.cbInitialCatalog.TabIndex = 54;
            this.cbInitialCatalog.SelectionChangeCommitted += new System.EventHandler(this.cbInitialCatalog_SelectionChangeCommitted);
            // 
            // lblDataSource
            // 
            this.lblDataSource.AutoSize = true;
            this.lblDataSource.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDataSource.Location = new System.Drawing.Point(0, 160);
            this.lblDataSource.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataSource.Name = "lblDataSource";
            this.lblDataSource.Size = new System.Drawing.Size(191, 17);
            this.lblDataSource.TabIndex = 53;
            this.lblDataSource.Text = "Список источников данных:";
            // 
            // tbPassword
            // 
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPassword.Enabled = false;
            this.tbPassword.Location = new System.Drawing.Point(0, 138);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(418, 22);
            this.tbPassword.TabIndex = 52;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPassword.Location = new System.Drawing.Point(0, 121);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(157, 17);
            this.lblPassword.TabIndex = 51;
            this.lblPassword.Text = "Пароль пользователя:";
            // 
            // tbUserID
            // 
            this.tbUserID.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbUserID.Enabled = false;
            this.tbUserID.Location = new System.Drawing.Point(0, 99);
            this.tbUserID.Margin = new System.Windows.Forms.Padding(4);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.PasswordChar = '*';
            this.tbUserID.Size = new System.Drawing.Size(418, 22);
            this.tbUserID.TabIndex = 50;
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUsers.Location = new System.Drawing.Point(0, 82);
            this.lblUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(163, 17);
            this.lblUsers.TabIndex = 49;
            this.lblUsers.Text = "Пользователь сервера:";
            // 
            // cbDataSource
            // 
            this.cbDataSource.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbDataSource.Enabled = false;
            this.cbDataSource.FormattingEnabled = true;
            this.cbDataSource.Location = new System.Drawing.Point(0, 58);
            this.cbDataSource.Margin = new System.Windows.Forms.Padding(4);
            this.cbDataSource.Name = "cbDataSource";
            this.cbDataSource.Size = new System.Drawing.Size(418, 24);
            this.cbDataSource.TabIndex = 48;
            // 
            // lbServer
            // 
            this.lbServer.AutoSize = true;
            this.lbServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbServer.Location = new System.Drawing.Point(0, 41);
            this.lbServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(130, 17);
            this.lbServer.TabIndex = 47;
            this.lbServer.Text = "Название сервера";
            // 
            // cbIPServer
            // 
            this.cbIPServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbIPServer.Enabled = false;
            this.cbIPServer.FormattingEnabled = true;
            this.cbIPServer.Location = new System.Drawing.Point(0, 17);
            this.cbIPServer.Margin = new System.Windows.Forms.Padding(4);
            this.cbIPServer.Name = "cbIPServer";
            this.cbIPServer.Size = new System.Drawing.Size(418, 24);
            this.cbIPServer.TabIndex = 46;
            // 
            // lblServers
            // 
            this.lblServers.AutoSize = true;
            this.lblServers.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblServers.Location = new System.Drawing.Point(0, 0);
            this.lblServers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServers.Name = "lblServers";
            this.lblServers.Size = new System.Drawing.Size(110, 17);
            this.lblServers.TabIndex = 45;
            this.lblServers.Text = "Адрес сервера:";
            // 
            // pnControl
            // 
            this.pnControl.Controls.Add(this.btConect);
            this.pnControl.Controls.Add(this.btCancel);
            this.pnControl.Controls.Add(this.btCheck);
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnControl.Location = new System.Drawing.Point(0, 238);
            this.pnControl.Margin = new System.Windows.Forms.Padding(4);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(418, 39);
            this.pnControl.TabIndex = 44;
            // 
            // btConect
            // 
            this.btConect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btConect.Enabled = false;
            this.btConect.Location = new System.Drawing.Point(100, 0);
            this.btConect.Margin = new System.Windows.Forms.Padding(4);
            this.btConect.Name = "btConect";
            this.btConect.Size = new System.Drawing.Size(218, 39);
            this.btConect.TabIndex = 13;
            this.btConect.Text = "Подключить";
            this.btConect.UseVisualStyleBackColor = true;
            this.btConect.Click += new System.EventHandler(this.btConect_Click);
            // 
            // btCancel
            // 
            this.btCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCancel.Location = new System.Drawing.Point(318, 0);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(100, 39);
            this.btCancel.TabIndex = 12;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btCheck
            // 
            this.btCheck.Dock = System.Windows.Forms.DockStyle.Left;
            this.btCheck.Enabled = false;
            this.btCheck.Location = new System.Drawing.Point(0, 0);
            this.btCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(100, 39);
            this.btCheck.TabIndex = 10;
            this.btCheck.Text = "Проверка";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // statusConect
            // 
            this.statusConect.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusConect.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus});
            this.statusConect.Location = new System.Drawing.Point(0, 277);
            this.statusConect.Name = "statusConect";
            this.statusConect.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusConect.Size = new System.Drawing.Size(418, 25);
            this.statusConect.TabIndex = 43;
            this.statusConect.Text = "statusStrip1";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(15, 20);
            this.tsslStatus.Text = "-";
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 302);
            this.Controls.Add(this.cbInitialCatalog);
            this.Controls.Add(this.lblDataSource);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbUserID);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.cbDataSource);
            this.Controls.Add(this.lbServer);
            this.Controls.Add(this.cbIPServer);
            this.Controls.Add(this.lblServers);
            this.Controls.Add(this.pnControl);
            this.Controls.Add(this.statusConect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConnectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройка подключения";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConnectionForm_FormClosing);
            this.Load += new System.EventHandler(this.ConnectionForm_Load);
            this.Shown += new System.EventHandler(this.ConnectionForm_Shown);
            this.pnControl.ResumeLayout(false);
            this.statusConect.ResumeLayout(false);
            this.statusConect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbInitialCatalog;
        private System.Windows.Forms.Label lblDataSource;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.ComboBox cbDataSource;
        private System.Windows.Forms.Label lbServer;
        private System.Windows.Forms.ComboBox cbIPServer;
        private System.Windows.Forms.Label lblServers;
        private System.Windows.Forms.Panel pnControl;
        private System.Windows.Forms.Button btConect;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.StatusStrip statusConect;
        public System.Windows.Forms.ToolStripStatusLabel tsslStatus;
    }
}
namespace Library
{
    partial class Settings_doc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings_doc));
            this.label4 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbOrganizationName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnCancel = new System.Windows.Forms.Panel();
            this.btSave = new System.Windows.Forms.Button();
            this.btApplye = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.gbDocumentMerge = new System.Windows.Forms.GroupBox();
            this.pnPage = new System.Windows.Forms.Panel();
            this.pnText = new System.Windows.Forms.Panel();
            this.gbRightMerj = new System.Windows.Forms.GroupBox();
            this.nudRightMerg = new System.Windows.Forms.NumericUpDown();
            this.gbLeftMerg = new System.Windows.Forms.GroupBox();
            this.nudLeftMerg = new System.Windows.Forms.NumericUpDown();
            this.gbBottomMerg = new System.Windows.Forms.GroupBox();
            this.nudBottomMerg = new System.Windows.Forms.NumericUpDown();
            this.gbTopMerg = new System.Windows.Forms.GroupBox();
            this.nudTopMerg = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBoxFontStyle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pnCancel.SuspendLayout();
            this.gbDocumentMerge.SuspendLayout();
            this.pnPage.SuspendLayout();
            this.gbRightMerj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRightMerg)).BeginInit();
            this.gbLeftMerg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLeftMerg)).BeginInit();
            this.gbBottomMerg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBottomMerg)).BeginInit();
            this.gbTopMerg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTopMerg)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Адрес организации:";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(16, 233);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(131, 20);
            this.tbAddress.TabIndex = 20;
            // 
            // tbOrganizationName
            // 
            this.tbOrganizationName.Location = new System.Drawing.Point(15, 184);
            this.tbOrganizationName.Name = "tbOrganizationName";
            this.tbOrganizationName.Size = new System.Drawing.Size(131, 20);
            this.tbOrganizationName.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Название организации";
            // 
            // pnCancel
            // 
            this.pnCancel.Controls.Add(this.btSave);
            this.pnCancel.Controls.Add(this.btApplye);
            this.pnCancel.Controls.Add(this.btCancel);
            this.pnCancel.Location = new System.Drawing.Point(215, 275);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Size = new System.Drawing.Size(286, 49);
            this.pnCancel.TabIndex = 17;
            // 
            // btSave
            // 
            this.btSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSave.Location = new System.Drawing.Point(-2, 0);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(96, 49);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // btApplye
            // 
            this.btApplye.Dock = System.Windows.Forms.DockStyle.Right;
            this.btApplye.Location = new System.Drawing.Point(94, 0);
            this.btApplye.Name = "btApplye";
            this.btApplye.Size = new System.Drawing.Size(96, 49);
            this.btApplye.TabIndex = 1;
            this.btApplye.Text = "Применить";
            this.btApplye.UseVisualStyleBackColor = true;
            this.btApplye.Click += new System.EventHandler(this.btApplye_Click);
            // 
            // btCancel
            // 
            this.btCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCancel.Location = new System.Drawing.Point(190, 0);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(96, 49);
            this.btCancel.TabIndex = 0;
            this.btCancel.Text = "Закрыть";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // gbDocumentMerge
            // 
            this.gbDocumentMerge.Controls.Add(this.pnPage);
            this.gbDocumentMerge.Controls.Add(this.gbRightMerj);
            this.gbDocumentMerge.Controls.Add(this.gbLeftMerg);
            this.gbDocumentMerge.Controls.Add(this.gbBottomMerg);
            this.gbDocumentMerge.Controls.Add(this.gbTopMerg);
            this.gbDocumentMerge.Location = new System.Drawing.Point(193, 10);
            this.gbDocumentMerge.Name = "gbDocumentMerge";
            this.gbDocumentMerge.Size = new System.Drawing.Size(350, 262);
            this.gbDocumentMerge.TabIndex = 16;
            this.gbDocumentMerge.TabStop = false;
            this.gbDocumentMerge.Text = "Отступы в документе";
            // 
            // pnPage
            // 
            this.pnPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPage.Controls.Add(this.pnText);
            this.pnPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPage.Location = new System.Drawing.Point(103, 51);
            this.pnPage.Name = "pnPage";
            this.pnPage.Size = new System.Drawing.Size(144, 173);
            this.pnPage.TabIndex = 4;
            // 
            // pnText
            // 
            this.pnText.BackColor = System.Drawing.Color.Gray;
            this.pnText.Location = new System.Drawing.Point(-1, -1);
            this.pnText.Name = "pnText";
            this.pnText.Size = new System.Drawing.Size(144, 173);
            this.pnText.TabIndex = 0;
            // 
            // gbRightMerj
            // 
            this.gbRightMerj.Controls.Add(this.nudRightMerg);
            this.gbRightMerj.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbRightMerj.Location = new System.Drawing.Point(247, 51);
            this.gbRightMerj.Name = "gbRightMerj";
            this.gbRightMerj.Size = new System.Drawing.Size(100, 173);
            this.gbRightMerj.TabIndex = 3;
            this.gbRightMerj.TabStop = false;
            this.gbRightMerj.Text = "Правый отступ";
            // 
            // nudRightMerg
            // 
            this.nudRightMerg.DecimalPlaces = 1;
            this.nudRightMerg.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudRightMerg.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudRightMerg.Location = new System.Drawing.Point(3, 16);
            this.nudRightMerg.Name = "nudRightMerg";
            this.nudRightMerg.Size = new System.Drawing.Size(94, 20);
            this.nudRightMerg.TabIndex = 0;
            // 
            // gbLeftMerg
            // 
            this.gbLeftMerg.Controls.Add(this.nudLeftMerg);
            this.gbLeftMerg.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbLeftMerg.Location = new System.Drawing.Point(3, 51);
            this.gbLeftMerg.Name = "gbLeftMerg";
            this.gbLeftMerg.Size = new System.Drawing.Size(100, 173);
            this.gbLeftMerg.TabIndex = 2;
            this.gbLeftMerg.TabStop = false;
            this.gbLeftMerg.Text = "Левый отступ";
            // 
            // nudLeftMerg
            // 
            this.nudLeftMerg.DecimalPlaces = 1;
            this.nudLeftMerg.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudLeftMerg.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudLeftMerg.Location = new System.Drawing.Point(3, 16);
            this.nudLeftMerg.Name = "nudLeftMerg";
            this.nudLeftMerg.Size = new System.Drawing.Size(94, 20);
            this.nudLeftMerg.TabIndex = 0;
            // 
            // gbBottomMerg
            // 
            this.gbBottomMerg.Controls.Add(this.nudBottomMerg);
            this.gbBottomMerg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbBottomMerg.Location = new System.Drawing.Point(3, 224);
            this.gbBottomMerg.Name = "gbBottomMerg";
            this.gbBottomMerg.Size = new System.Drawing.Size(344, 35);
            this.gbBottomMerg.TabIndex = 1;
            this.gbBottomMerg.TabStop = false;
            this.gbBottomMerg.Text = "Нижний отступ";
            // 
            // nudBottomMerg
            // 
            this.nudBottomMerg.DecimalPlaces = 1;
            this.nudBottomMerg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nudBottomMerg.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudBottomMerg.Location = new System.Drawing.Point(3, 12);
            this.nudBottomMerg.Name = "nudBottomMerg";
            this.nudBottomMerg.Size = new System.Drawing.Size(338, 20);
            this.nudBottomMerg.TabIndex = 0;
            // 
            // gbTopMerg
            // 
            this.gbTopMerg.Controls.Add(this.nudTopMerg);
            this.gbTopMerg.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTopMerg.Location = new System.Drawing.Point(3, 16);
            this.gbTopMerg.Name = "gbTopMerg";
            this.gbTopMerg.Size = new System.Drawing.Size(344, 35);
            this.gbTopMerg.TabIndex = 0;
            this.gbTopMerg.TabStop = false;
            this.gbTopMerg.Text = "Верхний отступ";
            // 
            // nudTopMerg
            // 
            this.nudTopMerg.DecimalPlaces = 1;
            this.nudTopMerg.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudTopMerg.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudTopMerg.Location = new System.Drawing.Point(3, 16);
            this.nudTopMerg.Name = "nudTopMerg";
            this.nudTopMerg.Size = new System.Drawing.Size(338, 20);
            this.nudTopMerg.TabIndex = 0;
            this.nudTopMerg.ValueChanged += new System.EventHandler(this.nudTopMerg_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Шрифт текста:";
            // 
            // ComboBoxFontStyle
            // 
            this.ComboBoxFontStyle.FormattingEnabled = true;
            this.ComboBoxFontStyle.Location = new System.Drawing.Point(15, 134);
            this.ComboBoxFontStyle.Name = "ComboBoxFontStyle";
            this.ComboBoxFontStyle.Size = new System.Drawing.Size(131, 21);
            this.ComboBoxFontStyle.TabIndex = 14;
            this.ComboBoxFontStyle.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFontStyle_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Путь сохранения файла:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbPath
            // 
            this.tbPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPath.Location = new System.Drawing.Point(15, 88);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(131, 20);
            this.tbPath.TabIndex = 11;
            // 
            // Settings_doc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 337);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbOrganizationName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnCancel);
            this.Controls.Add(this.gbDocumentMerge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboBoxFontStyle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings_doc";
            this.Text = "Настройки документа";
            this.Load += new System.EventHandler(this.Settings_doc_Load);
            this.pnCancel.ResumeLayout(false);
            this.gbDocumentMerge.ResumeLayout(false);
            this.pnPage.ResumeLayout(false);
            this.gbRightMerj.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudRightMerg)).EndInit();
            this.gbLeftMerg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudLeftMerg)).EndInit();
            this.gbBottomMerg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudBottomMerg)).EndInit();
            this.gbTopMerg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTopMerg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbOrganizationName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnCancel;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btApplye;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.GroupBox gbDocumentMerge;
        private System.Windows.Forms.Panel pnPage;
        private System.Windows.Forms.Panel pnText;
        private System.Windows.Forms.GroupBox gbRightMerj;
        private System.Windows.Forms.NumericUpDown nudRightMerg;
        private System.Windows.Forms.GroupBox gbLeftMerg;
        private System.Windows.Forms.NumericUpDown nudLeftMerg;
        private System.Windows.Forms.GroupBox gbBottomMerg;
        private System.Windows.Forms.NumericUpDown nudBottomMerg;
        private System.Windows.Forms.GroupBox gbTopMerg;
        private System.Windows.Forms.NumericUpDown nudTopMerg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBoxFontStyle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}
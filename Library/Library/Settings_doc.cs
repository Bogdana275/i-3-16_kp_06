using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
namespace Library
{
    public partial class Settings_doc : Form
    {
        
        public Settings_doc()
        {
            InitializeComponent();
        }
        decimal TM, RM, BM, LM;
        string SFF;

        private void nudTopMerg_ValueChanged(object sender, EventArgs e)
        {
            if (nudTopMerg.Value > TM)
            {
                pnText.Height -= (int)nudTopMerg.Value;
                pnText.Top += (int)nudTopMerg.Value;
            }
            else
            {
                pnText.Height += (int)nudTopMerg.Value;
                pnText.Top -= (int)nudTopMerg.Value;
            }
            TM = nudTopMerg.Value;
        }

        private void NudRightMerg_ValueChanged(object sender, EventArgs e)
        {
            if (nudRightMerg.Value > RM)
                pnText.Width -= (int)nudRightMerg.Value;
            else
                pnText.Width += (int)nudRightMerg.Value;
            RM = nudRightMerg.Value;
        }

        private void NudBottomMerg_ValueChanged(object sender, EventArgs e)
        {
            if (nudBottomMerg.Value > BM)
                pnText.Height -= (int)nudBottomMerg.Value;
            else
                pnText.Height += (int)nudBottomMerg.Value;
            BM = nudBottomMerg.Value;
        }

        private void NudLeftMerg_ValueChanged(object sender, EventArgs e)
        {
            if (nudLeftMerg.Value > LM)
            {
                pnText.Width -= (int)nudLeftMerg.Value;
                pnText.Left += (int)nudLeftMerg.Value;
            }
            else
            {
                pnText.Width += (int)nudLeftMerg.Value;
                pnText.Left -= (int)nudLeftMerg.Value;
            }
            LM = nudLeftMerg.Value;
        }

        private void ComboBoxFontStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            SFF = ComboBoxFontStyle.SelectedItem.ToString();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public static System.Drawing.Text.InstalledFontCollection fonts = new System.Drawing.Text.InstalledFontCollection();
        private void Settings_doc_Load(object sender, EventArgs e)
        {
            FillComboBoxFont();
            tbPath.Text = ConnectionLibrary.ConnectionLibrary.DirPath;
            ConnectionLibrary.ConnectionLibrary.ConfigurationGet();
            tbOrganizationName.Text = ConnectionLibrary.ConnectionLibrary.OrganizationName;
            tbPath.Text = ConnectionLibrary.ConnectionLibrary.DirPath;
            nudTopMerg.Value = (decimal)ConnectionLibrary.ConnectionLibrary.DocTM;
            nudRightMerg.Value = (decimal)ConnectionLibrary.ConnectionLibrary.DocRM;
            nudBottomMerg.Value = (decimal)ConnectionLibrary.ConnectionLibrary.DocBM;
            nudLeftMerg.Value = (decimal)ConnectionLibrary.ConnectionLibrary.DocLM;
            ComboBoxFontStyle.SelectedItem = ConnectionLibrary.ConnectionLibrary.DocSFF;
            tbAddress.Text = ConnectionLibrary.ConnectionLibrary.Address;
            TM = nudTopMerg.Value;
            RM = nudRightMerg.Value;
            BM = nudBottomMerg.Value;
            LM = nudLeftMerg.Value;
            ConnectionLibrary.ConnectionLibrary.Address = tbAddress.Text;
            pnText.Top += (int)TM * 10;
            pnText.Height -= (int)TM * 10;
            pnText.Width -= (int)RM * 10;
            pnText.Height -= (int)BM * 10;
            pnText.Left += (int)LM * 10;
            pnText.Width -= (int)LM * 10;
            ComboBoxFontStyle.SelectedItem = SFF;
        }

        private void btApplye_Click(object sender, EventArgs e)
        {
            OrganizationSave();
            DocumentSave();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            tbPath.Text = folderBrowserDialog1.SelectedPath + "\\Отчёты\\";
        }

        private void FillComboBoxFont()
        {
            // загрузка стилей шрифта в ComboBox
            foreach (FontFamily font in fonts.Families)
            {
                ComboBoxFontStyle.Items.Add(font.Name);
            }

        }

        private void OrganizationSave()
        {
            ConnectionLibrary.ConnectionLibrary.MajorConfigurationSet(tbOrganizationName.Text);
        }

        private void DocumentSave()
        {
            string document_default_path = "";
            switch (tbPath.Text == "")
            {
                case (true):
                    document_default_path =
                        "C:\\Users\\" + SystemInformation.UserName
                        + "\\Documents\\Отчёты";
                    if (!Directory.Exists(document_default_path))
                        Directory.CreateDirectory(document_default_path);
                    break;
                case (false):
                    document_default_path = tbPath.Text;
                    if (!Directory.Exists(document_default_path))
                        Directory.CreateDirectory(document_default_path);
                    break;
            }
            ConnectionLibrary.ConnectionLibrary.DocumentConfigurationSet(tbPath.Text, nudLeftMerg.Value,
                nudTopMerg.Value,
                nudRightMerg.Value, nudBottomMerg.Value, SFF, tbAddress.Text);
        }
    }
}

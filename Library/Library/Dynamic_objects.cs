using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace Library
{
    class Dynamic_objects
    {

        Procedures procedure = new Procedures();


        Int32 id_education, id_status_employee, id_dolj, id_view_order,
            id_genre, id_street, id_town, id_publisher;
        Thread thread_insert;
        Form RedForm = new Form();
        DataGridView table = new DataGridView();
        MenuStrip menustrip1 = new MenuStrip();
       
        //texbox
        TextBox tb1 = new TextBox();
        TextBox tb2 = new TextBox();
        //picturebox
        PictureBox pictureBox = new PictureBox();
        //label
        Label lbInfo1 = new Label();
        Label lbInfo2 = new Label();
        Label lbInfo3 = new Label();
        Label lbInfo4 = new Label();
        Label lbInfo5 = new Label();
        Label lbInfo6 = new Label();
        Label lbInfo7 = new Label();
        Label lbInfo8 = new Label();
        Label lbInfo9 = new Label();
        Label lbInfo10 = new Label();
        Label lbInfo11 = new Label();
        Label lbInfo12 = new Label();
        Label lbInfo13 = new Label();
        Label lbInfo14 = new Label();
        Label lbInfo15 = new Label();
        Label lbInfo16 = new Label();
        //button
        Button btOk = new Button();
        Button btCancel = new Button();
        Button btInsert = new Button();
        Button btDelete = new Button();
        Button btUpdate = new Button();
        //combobox
        ComboBox cm1 = new ComboBox();
        ComboBox cm2 = new ComboBox();
        ComboBox cm3 = new ComboBox();
        //radiobutton
        RadioButton rb1 = new RadioButton();
        RadioButton rb2 = new RadioButton();
        PictureBox pb1 = new PictureBox();
        MenuStrip ms1 = new MenuStrip();
        StatusStrip st1 = new StatusStrip();
        //Timer timer = new Timer();




        public Form parent;

        public void DefaultFormCreate(string names, string name)
        {
            Action action = () =>
            {
                RedForm.FormBorderStyle = FormBorderStyle.FixedSingle;
                RedForm.StartPosition = FormStartPosition.CenterScreen;
                RedForm.Icon = new Icon("lubrary_icon.ico");
                RedForm.Text = names;
                
                lbInfo1.Text = name + ":";
                lbInfo1.Font = new Font("Tahoma", 10);
                lbInfo1.ForeColor = Color.Black;
                lbInfo1.Location = new Point(185, 30);

                tb1.Location = new Point(185, 60);
                tb1.Width = 100;
                tb1.Height = 20;


                btInsert.Text = "Добавить";

                btInsert.Click += btInsert_Click;
                btInsert.Location = new Point(190, 100);
                btInsert.Width = 90;
                btInsert.Height = 30;
                btInsert.BackgroundImage = new Bitmap("Book_lezh.png");
                btInsert.Font = new Font("Verdena", 10, FontStyle.Regular);
                

                btUpdate.Text = "Изменить";
                btUpdate.Font = new Font("Verdena", 10, FontStyle.Regular);
                btUpdate.Click += btUpdate_Click;
                btUpdate.Location = new Point(190, 135);
                btUpdate.Width = 90;
                btUpdate.Height = 30;
                btUpdate.BackgroundImage = new Bitmap("Book_lezh2.png");
                btDelete.Text = "Удалить";
                btDelete.Font = new Font("Verdena", 10, FontStyle.Regular);

                btDelete.Click += btDelete_Click;
                btDelete.Location = new Point(190, 170);
                btDelete.Width = 90;
                btDelete.Height = 30;
                btDelete.BackgroundImage = new Bitmap("Book_lezh3.png");
                btCancel.Text = "Закрыть";
                btCancel.Font = new Font("Verdena", 10, FontStyle.Regular);
                btCancel.Location = new Point(190, 200);
                btCancel.Width = 90;
                btCancel.Height = 30;


                table.Location = new Point(20, 30);
                table.Width = 150;
                table.Height = 230;
                table.CellClick += table_CellClick;
                table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                RedForm.Load += RedForm_Load;
                RedForm.Size = new Size(320, 320);
                RedForm.Controls.Add(btInsert);
                RedForm.Controls.Add(btUpdate);
                RedForm.Controls.Add(btDelete);
                RedForm.Controls.Add(tb1);
                RedForm.Controls.Add(table);
                RedForm.Controls.Add(lbInfo1);
                RedForm.Show(parent);
                table.AutoResizeColumns();

            };
            parent.Invoke(action);
        }


        private void RedForm_Load(object sender, EventArgs e)
        {

            table_fill(Program.name_form);
            tb1.Clear();


        }
        public void table_fill(string name_table)
        {

            switch (Program.name_form)
            {
                case "Жанр":
                   Tables dtGenre = new Tables();
                    dtGenre.dtGenreFill();
                    table.DataSource = dtGenre.dtGenre;

                    table.Columns[0].Visible = false;
                    table.Columns[1].HeaderText = name_table;
                    table.Columns[1].Width = 40;
                    break;
                case "Издательство":
                    Tables dtPublisher = new Tables();
                    dtPublisher.dtPublisherFill();
                    table.DataSource = dtPublisher.dtPublisher;

                    table.Columns[0].Visible = false;
                    table.Columns[1].HeaderText = name_table;
                    table.Columns[1].Width = 70;
                    break;
                case "Вид приказа":
                    Tables dtView_order = new Tables();
                    dtView_order.dtView_orderFill();
                    table.DataSource = dtView_order.dtView_order;

                    table.Columns[0].Visible = false;
                    table.Columns[1].HeaderText = name_table;
                    table.Columns[1].Width = 100;
                    break;
                case "Статус сотрудника":
                    Tables dtStatus_employee = new Tables();
                    dtStatus_employee.dtStatus_employeeFill();
                    table.DataSource = dtStatus_employee.dtStatus_employee;

                    table.Columns[0].Visible = false;
                    table.Columns[1].HeaderText = name_table;
                    table.Columns[1].Width = 50;
                    break;
                case "Образование":
                    Tables dtEducation = new Tables();
                    dtEducation.dtEducationFill();
                    table.DataSource = dtEducation.dtEducation;

                    table.Columns[0].Visible = false;
                    table.Columns[1].HeaderText = name_table;
                    table.Columns[1].Width = 100;
                    break;
                case "Должность":
                    Tables dtDolj = new Tables();
                    dtDolj.dtDoljFill();
                    table.DataSource = dtDolj.dtDolj;
                    table.Columns[0].Visible = false;
                    tb2.Clear();
                    break;
                case "Город":
                    Tables  dtTown = new Tables();
                    dtTown.dtTownFill();
                    table.DataSource = dtTown.dtTown;
                    table.Columns[0].Visible = false;
                    table.Columns[1].HeaderText = name_table;
                    break;

                case "Улица":
                    Tables dtStreet = new Tables();
                    dtStreet.dtStreetFill();
                    table.DataSource = dtStreet.dtStreet;
                    table.Columns[0].Visible = false;
                    table.Columns[1].HeaderText = name_table;
                    break;
            }

        }

        public void btInsert_Click(object sender, EventArgs e)
        {
            Insert();
            RedForm_Load(sender, e);

        }

        private void Insert()
        {
            switch (Program.name_form)
            {
                case "Жанр":
                    procedure.spGenre_insert(tb1.Text);
                    break;
                case "Издательство":
                    procedure.spPublisher_insert(tb1.Text);
                    break;
                case "Вид приказа":
                    procedure.spView_order_insert(tb1.Text);
                    break;
                case "Статус сотрудника":
                    procedure.spStatus_employee_unsert(tb1.Text);
                    break;
                case "Образование":
                    procedure.spEducation_insert(tb1.Text);
                    break;
                case "Город":
                    procedure.spTown_insert(tb1.Text);
                    break;
                case "Улица":
                    procedure.spStreet_insert(tb1.Text);
                    break;
                case "Должность":
                    procedure.spDolj_insert(tb1.Text, Convert.ToDecimal(tb2.Text));
                    break;

            }


        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            switch (Program.name_form)
            {
                case "Жанр":
                    procedure.spGenre_update(tb1.Text, id_genre);
                    break;
                case "Издательство":
                    procedure.spPublisher_update(tb1.Text, id_publisher);
                    break;
                case "Вид приказа":
                    procedure.spView_order_update(tb1.Text, id_view_order);
                    break;
                case "Статус сотрудника":
                    procedure.spStatus_employee_update(tb1.Text, id_status_employee);
                    break;
                case "Образование":
                    procedure.spEducation_update(tb1.Text, id_education);
                    break;
                case "Город":
                    procedure.spTown_update(tb1.Text, id_town);
                    break;
                case "Улица":
                    procedure.spStreet_update(tb1.Text, id_street);
                    break;
                case "Должность":
                    procedure.spDolj_update(id_dolj, tb1.Text, Convert.ToDecimal(tb2.Text));
                    break;
            }
            RedForm_Load(sender, e);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            switch (Program.name_form)
            {
                case "Жанр":
                    procedure.spGenre_delete(id_genre);
                    break;
                case "Издательство":
                    procedure.spPublisher_delete(id_publisher);
                    break;
                case "Вид приказа":
                    procedure.spView_order_delete(id_view_order);
                    break;
                case "Статус сотрудника":
                    procedure.spStatus_employee_Delete(id_status_employee);
                    break;
                case "Образование":
                    procedure.spEducation_delete(id_education);
                    break;
                case "Город":
                    procedure.spTown_delete(id_town);
                    break;
                case "Улица":
                    procedure.spStreet_delete(id_street);
                    break;
                case "Должность":
                    procedure.spDolj_delete(id_dolj);
                    break;

            }

            RedForm_Load(sender, e);
        }



        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            switch (Program.name_form)
            {
                case "Жанр":
                    tb1.Text = table.CurrentRow.Cells[1].Value.ToString();
                    id_genre = Convert.ToInt32(table.CurrentRow.Cells[0].Value.ToString());
                    break;
                case "Издательство":
                    tb1.Text = table.CurrentRow.Cells[1].Value.ToString();
                    id_publisher = Convert.ToInt32(table.CurrentRow.Cells[0].Value.ToString());
                    break;
                case "Вид приказа":
                    tb1.Text = table.CurrentRow.Cells[1].Value.ToString();
                    id_view_order = Convert.ToInt32(table.CurrentRow.Cells[0].Value.ToString());
                    break;
                case "Статус сотрудника":
                    tb1.Text = table.CurrentRow.Cells[1].Value.ToString();
                    id_status_employee = Convert.ToInt32(table.CurrentRow.Cells[0].Value.ToString());
                    break;
                case "Образование":
                    tb1.Text = table.CurrentRow.Cells[1].Value.ToString();
                    id_education = Convert.ToInt32(table.CurrentRow.Cells[0].Value.ToString());
                    break;
                case "Город":
                    tb1.Text = table.CurrentRow.Cells[1].Value.ToString();
                    id_town = Convert.ToInt32(table.CurrentRow.Cells[0].Value.ToString());
                    break;
                case "Улица":
                    tb1.Text = table.CurrentRow.Cells[1].Value.ToString();
                    id_street = Convert.ToInt32(table.CurrentRow.Cells[0].Value.ToString());
                    break;
                case "Должность":
                    tb1.Text = table.CurrentRow.Cells[1].Value.ToString();
                    tb2.Text = table.CurrentRow.Cells[2].Value.ToString();
                    id_dolj = Convert.ToInt32(table.CurrentRow.Cells[0].Value.ToString());
                    break;

            }


        }

        public void DoljnostFormCreate()
        {
            Action action = () =>
            {
                RedForm.FormBorderStyle = FormBorderStyle.FixedSingle;
                RedForm.StartPosition = FormStartPosition.CenterScreen;
                RedForm.Text = "Должности";
                RedForm.Icon = new Icon("lubrary_icon.ico");
                lbInfo1.Text = "Должности:";
                lbInfo1.Font = new Font("Tahoma", 10);
                lbInfo1.ForeColor = Color.Black;
                lbInfo1.Location = new Point(285, 20);

                lbInfo2.Text = "Оклад:";
                lbInfo2.Font = new Font("Tahoma", 10);
                lbInfo2.ForeColor = Color.Black;
                lbInfo2.Location = new Point(285, 60);

                tb1.Location = new Point(285, 40);
                tb1.Width = 100;
                tb1.Height = 20;

                tb2.Location = new Point(285, 80);
                tb2.Width = 100;
                tb2.Height = 20;


                btInsert.Text = "Добавить";

                btInsert.Click += btInsert_Click;
                btInsert.Location = new Point(290, 110);
                btInsert.Width = 90;
                btInsert.Height = 30;

                btUpdate.Text = "Изменить";

                btUpdate.Click += btUpdate_Click;
                btUpdate.Location = new Point(290, 145);
                btUpdate.Width = 90;
                btUpdate.Height = 30;

                btDelete.Text = "Удалить";

                btDelete.Click += btDelete_Click;
                btDelete.Location = new Point(290, 180);
                btDelete.Width = 90;
                btDelete.Height = 30;

                btCancel.Text = "Закрыть";
                btCancel.Location = new Point(290, 215);
                btCancel.Width = 90;
                btCancel.Height = 30;

                table.Location = new Point(20, 30);
                table.Width = 250;
                table.Height = 230;
                table.CellClick += table_CellClick;
                table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                RedForm.Load += RedForm_Load;
                RedForm.Size = new Size(450, 320);
                RedForm.Controls.Add(btInsert);
                RedForm.Controls.Add(btUpdate);
                RedForm.Controls.Add(btDelete);
                RedForm.Controls.Add(btCancel);
                RedForm.Controls.Add(tb1);
                RedForm.Controls.Add(tb2);
                RedForm.Controls.Add(table);
                RedForm.Controls.Add(lbInfo1);
                RedForm.Controls.Add(lbInfo2);
                RedForm.Show(parent);

                table_fill(Program.name_form);
            };
            parent.Invoke(action);
        }

        private void RedForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            RedForm.Controls.Remove(btInsert);
            RedForm.Controls.Remove(btUpdate);
            RedForm.Controls.Remove(btDelete);
            RedForm.Controls.Remove(btCancel);
            RedForm.Controls.Remove(table);
            RedForm.Controls.Remove(tb1);
            RedForm.Controls.Remove(tb2);

            RedForm.Controls.Remove(table);
            RedForm.Controls.Remove(menustrip1);
            RedForm.Controls.Remove(lbInfo1);
            RedForm.Controls.Remove(lbInfo2);
            table.CellClick -= table_CellClick;
            btDelete.Click -= btDelete_Click;
            btInsert.Click -= btInsert_Click;
            btUpdate.Click -= btUpdate_Click;
            RedForm.Load -= RedForm_Load;
            Program.name_form = "";
            RedForm.Close();
        }

        
    }
}

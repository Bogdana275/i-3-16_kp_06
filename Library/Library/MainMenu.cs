using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        public void MainMenu_Load(object sender, EventArgs e)
        {
            Program.Avtoriz_user= false;
            SetDocToolStripMenuItem.Visible = false;
            
             
        }
        public static SqlCommand command = new SqlCommand("",ConnectionLibrary.ConnectionLibrary.sqlConnection);
        public static Int32 id_employee;
        public static string name_role;
        private void GenreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.name_form = "Жанр";
            Dynamic_objects dyn = new Dynamic_objects();
            dyn.parent = this;
            dyn.DefaultFormCreate("Жанры","Жанр");
        }

        public void Visible_menu()
        {
            if (Program.Avtoriz_user)
            {
                if (Program.table_author == 1) AuthorToolStripMenuItem.Visible = true;
                else AuthorToolStripMenuItem.Visible = false;
                if (Program.table_avtoriz == 1) AvtorizToolStripMenuItem.Visible = true;
                else AvtorizToolStripMenuItem.Visible = false;
                if (Program.table_book == 1) BooksToolStripMenuItem.Visible = true;
                else BooksToolStripMenuItem.Visible = false;
                if (Program.table_contract_with_provider == 1) Contract_with_providerToolStripMenuItem.Visible = true;
                else Contract_with_providerToolStripMenuItem.Visible = false;
                if (Program.table_doc_on_buy_book == 1) Doc_on_buy_bookToolStripMenuItem.Visible = true;
                else Doc_on_buy_bookToolStripMenuItem.Visible = false;
                if (Program.table_dolj == 1) DoljToolStripMenuItem.Visible = true;
                else DoljToolStripMenuItem.Visible = false;
                if (Program.table_education == 1) EducationToolStripMenuItem.Visible = true;
                else EducationToolStripMenuItem.Visible = false;
                if (Program.table_employee == 1) EmployeeToolStripMenuItem.Visible = true;
                else EmployeeToolStripMenuItem.Visible = false;
                if (Program.table_genre == 1) GenreToolStripMenuItem.Visible = true;
                else GenreToolStripMenuItem.Visible = false;
                if (Program.table_history == 1) HistoryToolStripMenuItem.Visible = true;
                else HistoryToolStripMenuItem.Visible = false;
                if (Program.table_move_book == 1) MoveBookToolStripMenuItem.Visible = true;
                else MoveBookToolStripMenuItem.Visible = false;
                if (Program.table_order == 1) OrderToolStripMenuItem.Visible = true;
                else OrderToolStripMenuItem.Visible = false;
                if (Program.table_potencial_employee == 1) PotencialEmployeeToolStripMenuItem.Visible = true;
                else PotencialEmployeeToolStripMenuItem.Visible = false;
                if (Program.table_provider == 1) ProviderToolStripMenuItem.Visible = true;
                else ProviderToolStripMenuItem.Visible = false;
                if (Program.table_publisher == 1) PublisherToolStripMenuItem.Visible = true;
                else PublisherToolStripMenuItem.Visible = false;
                if (Program.table_reader_ticket == 1) ReaderTicketToolStripMenuItem.Visible = true;
                else ReaderTicketToolStripMenuItem.Visible = false;
                if (Program.table_role == 1) RoleToolStripMenuItem.Visible = true;
                else RoleToolStripMenuItem.Visible = false;
                if (Program.table_status_employee == 1) StatusEmployeeToolStripMenuItem.Visible = true;
                else StatusEmployeeToolStripMenuItem.Visible = false;
                if (Program.table_street == 1) StreetToolStripMenuItem.Visible = true;
                else StreetToolStripMenuItem.Visible = false;
                if (Program.table_town == 1) TownToolStripMenuItem.Visible = true;
                else RoleToolStripMenuItem.Visible = false;
                if (Program.table_view_order == 1) View_orderToolStripMenuItem.Visible = true;
                else View_orderToolStripMenuItem.Visible = false;
                if (Program.table_work_contract == 1) WorkContractToolStripMenuItem.Visible = true;
                else WorkContractToolStripMenuItem.Visible = false;
                if (Program.view_book_catalog == 1) Book_catalogToolStripMenuItem.Visible = true;
                else Book_catalogToolStripMenuItem.Visible = false;
                if (Program.view_reader_ticket == 1) PersonalReaderTicketToolStripMenuItem.Visible = true;
                else PersonalReaderTicketToolStripMenuItem.Visible = false;
                SetDocToolStripMenuItem.Visible = true;
            }
            else
            {
                AuthorToolStripMenuItem.Visible = false;
                AvtorizToolStripMenuItem.Visible = false;
                BooksToolStripMenuItem.Visible = false;
                Contract_with_providerToolStripMenuItem.Visible = false;
                Doc_on_buy_bookToolStripMenuItem.Visible = false;
                DoljToolStripMenuItem.Visible = false;
                EducationToolStripMenuItem.Visible = false;
                EmployeeToolStripMenuItem.Visible = false;
                GenreToolStripMenuItem.Visible = false;
                HistoryToolStripMenuItem.Visible = false;
                MoveBookToolStripMenuItem.Visible = false;
                OrderToolStripMenuItem.Visible = false;
                PotencialEmployeeToolStripMenuItem.Visible = false;
                ProviderToolStripMenuItem.Visible = false;
                PublisherToolStripMenuItem.Visible = false;
                ReaderTicketToolStripMenuItem.Visible = false;
                RoleToolStripMenuItem.Visible = false;
                StatusEmployeeToolStripMenuItem.Visible = false;
                StreetToolStripMenuItem.Visible = false;
                RoleToolStripMenuItem.Visible = false;
                View_orderToolStripMenuItem.Visible = false;
                WorkContractToolStripMenuItem.Visible = false;
                Book_catalogToolStripMenuItem.Visible = false;
                PersonalReaderTicketToolStripMenuItem.Visible = false;
            }
            if (Program.Reg_user)
            {
                MessageBox.Show("Ваша учетная запись проверяется администратором. Вам доступен только каталог книг на данный момент.");
                Book_catalogToolStripMenuItem.Visible = true;
                SetDocToolStripMenuItem.Visible = false;
            }

        }
        
        

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void EducationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.name_form = "Образование";
            Dynamic_objects dyn1 = new Dynamic_objects();
            dyn1.parent = this;
            dyn1.DefaultFormCreate(Program.name_form, Program.name_form);
        }

        private void StatusEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Program.name_form = "Статус сотрудника";
            Dynamic_objects dyn2 = new Dynamic_objects();
            dyn2.parent = this;
            dyn2.DefaultFormCreate(Program.name_form, Program.name_form);
        }

        private void PublisherToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Program.name_form = "Издательство";
            Dynamic_objects dyn3 = new Dynamic_objects();
            dyn3.parent = this;
            dyn3.DefaultFormCreate(Program.name_form, Program.name_form);

        }

        private void View_orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.name_form = "Вид приказа";
            Dynamic_objects dyn4 = new Dynamic_objects();
            dyn4.parent = this;
            dyn4.DefaultFormCreate(Program.name_form, Program.name_form);
        }

        private void DoljToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.name_form = "Должность";
            Dynamic_objects dyn4 = new Dynamic_objects();
            dyn4.parent = this;
            dyn4.DoljnostFormCreate();
        }

        private void StreetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.name_form = "Улица";
            Dynamic_objects dyn5 = new Dynamic_objects();
            dyn5.parent = this;
            dyn5.DefaultFormCreate("Улицы", Program.name_form);
        }

        private void TownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.name_form = "Город";
            Dynamic_objects dyn6 = new Dynamic_objects();
            dyn6.parent = this;
            dyn6.DefaultFormCreate("Города", Program.name_form);
        }

        private void AuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Author f = new Author();
            f.Show();
        }

        private void HistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History f = new History();
            f.Show();
        }

        private void BooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books f = new Books();
            f.Show();
        }

        private void ProviderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Provider f = new Provider();
            f.Show();
        }

        private void EmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee f = new Employee();
            f.Show();
        }

        private void PotencialEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Potencial_employee f = new Potencial_employee();
            f.Show();
        }

        private void RoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Role f = new Role();
            f.Show();
        }

        private void AvtorizToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Avtoriz f = new Avtoriz();
            f.Show();
        }

        private void Contract_with_providerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contract_with_provider f = new Contract_with_provider();
            f.Show();
        }

        private void WorkContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Work_contract f = new Work_contract();
            f.Show();
        }

        private void OrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order r = new Order();
            r.Show();
        }

        private void ReaderTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReaderTicket f = new ReaderTicket();
            f.Show();
        }

        private void MoveBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Move_book f = new Move_book();
            f.Show();
        }

        private void Doc_on_buy_bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doc_on_buy_book f = new Doc_on_buy_book();
            f.Show();
        }

        private void InvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invoice h = new Invoice();
            h.Show();
        }

        private void SetDocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings_doc f = new Settings_doc();
            f.Show();
        }

        private void AvtorizUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void справочникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible_menu();
        }

        private void MainMenu_Activated(object sender, EventArgs e)
        {
            

        }

        private void PersonalReaderTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonalReader f = new PersonalReader();
            f.Show();
        }

        private void Book_catalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalog f = new Catalog();
            f.Show();
        }

        private void AvtorizUserToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AvtorizUser f = new AvtorizUser();
            f.Show();
        }
    }
}

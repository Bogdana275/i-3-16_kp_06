using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 
        public static bool Reg_user, Avtoriz_user;
        public static string name_form;
        public static Int32 table_dolj, table_status_employee,
table_author, table_role, table_genre,
table_town, table_street, table_publisher, table_doc_on_buy_book,
table_contract_with_provider, table_avtoriz, table_order,
table_view_order, table_work_contract, table_book,
table_reader_ticket, table_move_book, table_employee,
table_potencial_employee, table_education, view_book_catalog, view_reader_ticket, table_invoice, table_provider, table_history;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ConnectionForm());
        }
    }
}

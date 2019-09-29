using System.Data;
using System.Data.SqlClient;


namespace Library
{
    class Tables
    {
        public SqlCommand command = new SqlCommand("", ConnectionLibrary.ConnectionLibrary.sqlConnection);
        public DataTable dtInvoice = new DataTable("Invoice");
        public DataTable dtAuthor = new DataTable("Author");
        public DataTable dtPublisher = new DataTable("Publisher");
        public DataTable dtGenre = new DataTable("Genre");
        public DataTable dtTown = new DataTable("Town");
        public DataTable dtStreet = new DataTable("Street");
        public DataTable dtProvider = new DataTable("Provider");
        public DataTable dtBook = new DataTable("Book");
        public DataTable dtMove_book = new DataTable("Move_book");
        public DataTable dtDoc_on_buy_book = new DataTable("Doc_on_buy_book");
        public DataTable dtAvtoriz = new DataTable("Avtoriz");
        public DataTable dtContract_with_provider = new DataTable("Contract_with_provider");
        public DataTable dtStatus_employee = new DataTable("Status_employee");
        public DataTable dtWork_contract = new DataTable("Work_contract");
        public DataTable dtPotencial_employee = new DataTable("Potencial_employee");
        public DataTable dtEmployee = new DataTable("Employee");
        public DataTable dtDolj = new DataTable("Dolj");
        public DataTable dtEducation = new DataTable("Education");
        public DataTable dtOrder = new DataTable("Order");
        public DataTable dtReader_ticket = new DataTable("Reader_ticket");
        public DataTable dtView_order = new DataTable("View_order");
        public DataTable dtRole = new DataTable("Role");
        public DataTable dtHistory = new DataTable("History");
        public SqlDependency dependency = new SqlDependency();

        public string qrInvoice = "SELECT dbo.Invoice.id_invoice as 'Ключ накладной', dbo.Invoice.id_employee as 'Ключ сотрудника', dbo.Employee.F_employee +' '+ SUBSTRING(dbo.Employee.I_employee,1,1) +' '+ SUBSTRING(dbo.Employee.O_employee,1,1) as 'Сотрудник'," +
                  " dbo.Invoice.id_book as 'Ключ книги', dbo.Book.id_provider as 'Ключ поставщика', dbo.Provider.provider as 'Поставщик', dbo.Invoice.date_invoice as 'Дата'" +
                  " FROM dbo.Invoice INNER JOIN" +
                  " dbo.Employee ON dbo.Invoice.id_employee = dbo.Employee.id_employee INNER JOIN"+
                  " dbo.Book ON dbo.Invoice.id_book = dbo.Book.id_book INNER JOIN"+
                  " dbo.Publisher ON dbo.Book.id_publisher = dbo.Publisher.id_publisher INNER JOIN"+
                  " dbo.Author ON dbo.Book.id_author = dbo.Author.id_author INNER JOIN"+
                  " dbo.Provider ON dbo.Book.id_provider = dbo.Provider.id_provider",
        qrAuthor = "select id_author as 'Ключ автора', F_author as 'Фамилия автора', I_author as 'Имя автора', O_author as 'Отчество автора' from dbo.Author",
        qrPublisher = "select id_publisher as 'Ключ издательства', publisher as 'Издательство' from dbo.Publisher",
        qrDolj = "select id_dolj as 'Ключ должности', dolj as 'Должность', salary as 'Оклад' from dbo.Dolj",
        qrHistory = "select id_history as 'Ключ истории', time_of_update as 'Время обновления', action as 'Действие', [table] as 'Таблица', id_table as 'Ключ таблицы' from dbo.History",
        qrStreet = "select id_street as 'Ключ улицы', street as 'Улица' from dbo.Street",
        qrTown = "select id_town as 'Ключ города', town as 'Город' from dbo.Town",
        qrProvider = "SELECT dbo.Provider.id_provider as 'Ключ поставщика', dbo.Provider.provider as 'Поставщик', dbo.Provider.id_town as 'Ключ города', dbo.Town.town as 'Город'," +
                  " dbo.Provider.id_street as 'Ключ улицы',  dbo.Street.street as 'Улица', dbo.Provider.home as 'Дом'," +
                  " dbo.Provider.phone as 'Телефон', dbo.Provider.INN as 'ИНН'" +
                  " FROM dbo.Provider INNER JOIN" +
                  " dbo.Street ON dbo.Provider.id_street = dbo.Street.id_street INNER JOIN" +
                  " dbo.Town ON dbo.Provider.id_town = dbo.Town.id_town",
        qrBook = "SELECT dbo.Book.id_book as 'Ключ книги', dbo.Book.id_provider as 'Ключ поставщика', dbo.Provider.provider as 'Поставщик', dbo.Book.id_author  as 'Ключ автора',"+
                    " dbo.Author.F_author+' '+ SUBSTRING(dbo.Author.I_author,1,1)+'. '+SUBSTRING(dbo.Author.O_author,1,1) + '. ' as 'Автор', dbo.Book.name_book as 'Книга'," +
                    " dbo.Book.id_publisher  as 'Ключ издательства', dbo.Publisher.publisher  as 'Издательство'," +
                    " dbo.Book.id_genre  as 'Ключ жанра', dbo.Genre.genre  as 'Жанр', dbo.Book.kol_vo_book  as 'Количество', dbo.Book.price  as 'Цена'" +
                    " FROM dbo.Author INNER JOIN" +
                  " dbo.Book ON dbo.Author.id_author = dbo.Book.id_author INNER JOIN" +
                  " dbo.Provider ON dbo.Book.id_provider = dbo.Provider.id_provider INNER JOIN" +
                  " dbo.Publisher ON dbo.Book.id_publisher = dbo.Publisher.id_publisher INNER JOIN" +
                  " dbo.Genre ON dbo.Book.id_genre = dbo.Genre.id_genre",
        qrMove_book = "SELECT dbo.Move_book.id_move_book as 'Ключ движения книг', dbo.Move_book.id_book  as 'Ключ книги',"+
                    " dbo.Author.id_author  as 'Ключ автора', dbo.Author.F_author +' '+ SUBSTRING(dbo.Author.I_author,1,1) +'. '+ SUBSTRING(dbo.Author.O_author,1,1) + '. ' +dbo.Book.name_book as 'Книга'," +
                    " dbo.Move_book.id_reader_ticket as 'Ключ читательского билета' , dbo.Reader_ticket.F_reader+' '+ SUBSTRING(dbo.Reader_ticket.I_reader,1,1) + '. '+SUBSTRING(dbo.Reader_ticket.O_reader,1,1) + '.' as 'Читатель'," +
                    " dbo.Move_book.date_of_issue  as 'Дата выдачи', dbo.Move_book.date_accept  as 'Дата принятия'" +
                    " FROM dbo.Move_book INNER JOIN" +
                    " dbo.Book ON dbo.Move_book.id_book = dbo.Book.id_book INNER JOIN" +
                    " dbo.Reader_ticket ON dbo.Move_book.id_reader_ticket = dbo.Reader_ticket.id_reader_ticket INNER JOIN" +
                    " dbo.Author ON dbo.Book.id_author = dbo.Author.id_author",
        qrGenre = "select id_genre as 'Ключ жанра', genre as 'Жанр' from dbo.Genre",
        qrDoc_on_buy_book = "SELECT dbo.Doc_on_buy_book.id_doc_on_buy_book as 'Ключ документа на закупку книг', dbo.Doc_on_buy_book.date_of_doc_on_buy_book as 'Дата',"+
         " dbo.Doc_on_buy_book.id_contract_with_provider as 'Ключ договора с поставщиком',"+
         " dbo.Contract_with_provider.id_provider as 'Ключ поставщика', dbo.Provider.provider as 'Поставщик'" +
         " FROM dbo.Doc_on_buy_book INNER JOIN" +
         " dbo.Book ON dbo.Doc_on_buy_book.id_book = dbo.Book.id_book INNER JOIN" +
         " dbo.Author ON dbo.Book.id_author = dbo.Author.id_author INNER JOIN" +
         " dbo.Contract_with_provider ON dbo.Doc_on_buy_book.id_contract_with_provider = dbo.Contract_with_provider.id_contract_with_provider INNER JOIN" +
         " dbo.Provider ON dbo.Book.id_provider = dbo.Provider.id_provider AND dbo.Contract_with_provider.id_provider = dbo.Provider.id_provider",
        qrAvtoriz = "SELECT dbo.Avtoriz.id_avtoriz as 'Ключ авторизации', dbo.Avtoriz.id_role as 'Ключ роли', dbo.Role.name_role as 'Роль', dbo.Avtoriz.login as 'Логин', dbo.Avtoriz.password as 'Пароль'" +
                    " FROM dbo.Avtoriz INNER JOIN"+
                  " dbo.Role ON dbo.Avtoriz.id_role = dbo.Role.id_role",
        qrContract_with_provider = "SELECT dbo.Contract_with_provider.id_contract_with_provider as 'Ключ договора с поставщиком', dbo.Contract_with_provider.id_provider as 'Ключ поставщика', dbo.Provider.provider as 'Поставщик', dbo.Contract_with_provider.date_of_contract as 'Дата'" +
                  " FROM dbo.Contract_with_provider INNER JOIN" +
                  " dbo.Provider ON dbo.Contract_with_provider.id_provider = dbo.Provider.id_provider",
        qrRole = "SELECT id_role as 'Ключ роли', name_role as 'Роль', table_dolj as 'Должность', table_status_employee as 'Статус сотрудника', table_author as 'Автор', table_role as 'Роль', table_publisher as 'Издательство', table_genre as 'Жанр', table_town as 'Город', table_street as 'Улица'," +
            " table_doc_on_buy_book as 'Документ на закупку книг', table_contract_with_provider as 'Договор с поставщиком', table_avtoriz as 'Авторизация', table_order as 'Приказ', table_view_order as 'Вид приказа'," +
            " table_work_contract as 'Трудовой договор', table_book as 'Книга', table_reader_ticket as 'Читательские билеты', table_move_book as 'Движение книг', table_employee as 'Сотрудники', table_potencial_employee as 'Потенциальные сотрудники',"+
            " table_education as 'Образование', view_book_catalog as 'Каталог книг', view_reader_ticket as 'Личный чит. билет', table_provider as 'Поставщик', table_history as 'История'" +
            " FROM dbo.Role",
        qrStatus_employee = "select id_status_employee as 'Ключ статуса сотрудника', status_employee as 'Статус сотрудника' from dbo.Status_employee",
        qrPotencial_employee = "SELECT dbo.Potencial_employee.id_potencial_employee as 'Ключ потенциального работника', dbo.Potencial_employee.F_potencial_employee as 'Фамилия',"+
            " dbo.Potencial_employee.I_potencial_employee as 'Имя', "+
            " dbo.Potencial_employee.O_potencial_employee as 'Отчество', dbo.Potencial_employee.date_birthday as 'Дата рождения', dbo.Potencial_employee.phone as 'Телефон', " +
            " dbo.Potencial_employee.id_dolj as 'Ключ должности', dbo.Dolj.dolj +'('+ CONVERT(varchar, dbo.Dolj.salary) +' руб.)' as 'Должность', dbo.Potencial_employee.id_education as 'Ключ образования', dbo.Education.education as 'Образование'" +
            " FROM dbo.Education INNER JOIN" +
                  " dbo.Potencial_employee ON dbo.Education.id_education = dbo.Potencial_employee.id_education INNER JOIN"+
                  " dbo.Dolj ON dbo.Potencial_employee.id_dolj = dbo.Dolj.id_dolj",
        qrEmployee = "SELECT dbo.Employee.id_employee as 'Ключ сотрудника', dbo.Employee.F_employee as 'Фамилия', dbo.Employee.I_employee as 'Имя', dbo.Employee.O_employee as 'Отчество', dbo.Employee.id_dolj as 'Ключ должности',"+
                " dbo.Dolj.dolj as 'Должность', dbo.Dolj.salary as 'Оклад', dbo.Employee.id_education as 'Ключ образования', dbo.Education.education as 'Образование', dbo.Employee.id_status_employee as 'Ключ статуса сотрудника', "+
                " dbo.Status_employee.status_employee as 'Статус', dbo.Employee.date_birthday as 'Дата рождения', dbo.Employee.phone as 'Телефон', dbo.Employee.Series_passport  as 'Серия', dbo.Employee.Number_passport  as 'Номер', dbo.Employee.id_avtoriz  as 'Ключ авторизации'," +
                " dbo.Avtoriz.login as 'Логин', dbo.Avtoriz.password as 'Пароль', dbo.Avtoriz.id_role as 'Роль'" +
                " FROM dbo.Employee INNER JOIN"+
                  " dbo.Education ON dbo.Employee.id_education = dbo.Education.id_education INNER JOIN"+
                  " dbo.Dolj ON dbo.Employee.id_dolj = dbo.Dolj.id_dolj INNER JOIN"+
                  " dbo.Status_employee ON dbo.Employee.id_status_employee = dbo.Status_employee.id_status_employee inner join"+
                    " dbo.Avtoriz ON dbo.Employee.id_avtoriz = dbo.Avtoriz.id_avtoriz INNER JOIN"+
                    " dbo.Role ON dbo.Avtoriz.id_role = dbo.Role.id_role",
        qrWork_contract = "SELECT dbo.Work_contract.id_work_contract as 'Ключ трудового договора', dbo.Work_contract.date_work_contract, dbo.Work_contract.id_employee as 'Ключ сотрудника'," +
                    " dbo.Employee.id_dolj as 'Ключ должности'," +
                    " dbo.Employee.F_employee +' '+ SUBSTRING(dbo.Employee.I_employee,1,1)+'. '+ SUBSTRING(dbo.Employee.O_employee,1,1) +'.' as 'FIO', dbo.Dolj.dolj" +
                    " FROM dbo.Work_contract INNER JOIN"+
                    " dbo.Employee ON dbo.Work_contract.id_employee = dbo.Employee.id_employee INNER JOIN"+
                    " dbo.Education ON dbo.Employee.id_education = dbo.Education.id_education INNER JOIN"+
                    " dbo.Dolj ON dbo.Employee.id_dolj = dbo.Dolj.id_dolj",
        qrEducation = "select id_education as 'Ключ образования', education as 'Образование' from dbo.Education",
        qrOrder = "SELECT dbo.[Order].id_order as 'Ключ приказа', dbo.[Order].id_employee as 'Ключ сотрудника', dbo.Employee.F_employee +' '+ SUBSTRING(dbo.Employee.I_employee,1,1)+'. '+ " +
                    " SUBSTRING(dbo.Employee.O_employee,1,1) +'.' as 'FIO'," +
                    " dbo.Employee.id_dolj as 'Ключ должности', dbo.Dolj.dolj+' ('+ Convert(varchar, dbo.Dolj.salary) +' руб.)' as 'Должность', dbo.[Order].id_view_order as 'Ключ вида приказа', dbo.View_order.view_order as 'Вид приказа'," +
                    " dbo.[Order].date_order" +
                    " FROM dbo.[Order] INNER JOIN"+
                    " dbo.Employee ON dbo.[Order].id_employee = dbo.Employee.id_employee INNER JOIN"+
                    " dbo.View_order ON dbo.[Order].id_view_order = dbo.View_order.id_view_order INNER JOIN"+
                    " dbo.Dolj ON dbo.Employee.id_dolj = dbo.Dolj.id_dolj",
        qrReader_ticket = "SELECT id_reader_ticket as 'Ключ читательского билета', F_reader as 'Фамилия', I_reader as 'Имя', O_reader as 'Отчество', Series_passport as 'Серия', Number_passport as 'Номер', phone as 'Телефон'," +
            " dbo.Reader_ticket.id_avtoriz, dbo.Avtoriz.login as 'Логин', dbo.Avtoriz.password as 'Пароль'"+
            " FROM dbo.Avtoriz INNER JOIN"+
                  " dbo.Reader_ticket ON dbo.Avtoriz.id_avtoriz = dbo.Reader_ticket.id_avtoriz",
        qrView_order = "select id_view_order as 'Ключ вида приказа', view_order as 'Вид приказа' from dbo.View_order";

        public void dtFill(DataTable table, string query)
        {
           
            command.Notification = null;
            command.CommandText = query;
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            table.Load(command.ExecuteReader());
            
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();

            
        }

        public void dtAuthorFill()
        {
            dtFill(dtAuthor, qrAuthor);
        }

        public void dtAvtorizFill()
        {
            dtFill(dtAvtoriz, qrAvtoriz);
        }

        public void dtBookFill()
        {
            dtFill(dtBook, qrBook);
        }

        public void dtContract_with_providerFill()
        {
            dtFill(dtContract_with_provider, qrContract_with_provider);
        }

        public void dtDoc_on_buy_bookFill()
        {
            dtFill(dtDoc_on_buy_book, qrDoc_on_buy_book);
        }

        public void dtDoljFill()
        {
            dtFill(dtDolj, qrDolj);
        }

        public void dtEducationFill()
        {
            dtFill(dtEducation, qrEducation);
        }

        public void dtEmployeeFill()
        {
            dtFill(dtEmployee, qrEmployee);
        }

        public void dtGenreFill()
        {
            dtFill(dtGenre, qrGenre);
        }

        public void dtHistoryFill()
        {
            dtFill(dtHistory, qrHistory);
        }

        public void dtInvoiceFill()
        {
            dtFill(dtInvoice, qrInvoice);
        }
       public void dtMove_bookFill()
        {
                dtFill(dtMove_book, qrMove_book);
        }

        public void dtOrderFill()
        {
                dtFill(dtOrder, qrOrder);
        }

        public void dtPotencial_employeeFill()
        {
            dtFill(dtPotencial_employee, qrPotencial_employee);
        }
        public void dtProviderFill()
        {
            dtFill(dtProvider, qrProvider);
        }

        public void dtPublisherFill()
        {
            dtFill(dtPublisher, qrPublisher);
        }

        public void dtReader_ticketFill()
        {
            dtFill(dtReader_ticket, qrReader_ticket);
        }
        public void dtRoleFill()
        {
            dtFill(dtRole, qrRole);
        }

        public void dtStatus_employeeFill()
        {
            dtFill(dtStatus_employee, qrStatus_employee);
        }

        public void dtStreetFill()
        {
            dtFill(dtStreet, qrStreet);
        }
        public void dtTownFill()
        {
            dtFill(dtTown, qrTown);
        }

        public void dtView_orderFill()
        {
            dtFill(dtView_order, qrView_order);
        }

        public void dtWork_contractFill()
        {
            dtFill(dtWork_contract, qrWork_contract);
        }

    }
}

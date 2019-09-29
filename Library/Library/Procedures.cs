using System;
using System.Data.SqlClient;

namespace Library
{
    class Procedures
    {

        public static SqlCommand command = new SqlCommand("", ConnectionLibrary.ConnectionLibrary.sqlConnection);
        private void spConfiguration(string spName)
        {
            command.CommandText = spName;
            command.CommandType = System.Data.CommandType.StoredProcedure;
        }

        public void spEducation_insert(string education)
        {
            spConfiguration("education_insert");
            
                command.Parameters.AddWithValue("@education", education);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spEducation_update(string education, Int32 id_education)
        {
            spConfiguration("education_update");
           
                command.Parameters.AddWithValue("@id_education", id_education);
                command.Parameters.AddWithValue("@education", education);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spEducation_delete(Int32 id_education)
        {
            spConfiguration("education_delete");
            
                command.Parameters.AddWithValue("@id_education", id_education);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spView_order_insert(string view_order)
        {
            spConfiguration("view_order_insert");

            command.Parameters.AddWithValue("@view_order", view_order);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spView_order_update(string view_order, Int32 id_view_order)
        {
            spConfiguration("view_order_update");

            command.Parameters.AddWithValue("@id_view_order", id_view_order);
            command.Parameters.AddWithValue("@view_order", view_order);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spView_order_delete(Int32 id_view_order)
        {
            spConfiguration("view_order_delete");

            command.Parameters.AddWithValue("@id_view_order", id_view_order);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spStatus_employee_unsert(string status_employee)
        {
            spConfiguration("status_employee_insert");

            command.Parameters.AddWithValue("@status_employee", status_employee);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spStatus_employee_update(string status_employee, Int32 id_status_employee)
        {
            spConfiguration("status_employee_update");

            command.Parameters.AddWithValue("@id_status_employee", id_status_employee);
            command.Parameters.AddWithValue("@status_employee", status_employee);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spStatus_employee_Delete(Int32 id_status_employee)
        {
            spConfiguration("status_employee_delete");

            command.Parameters.AddWithValue("@id_status_employee", id_status_employee);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spPublisher_insert(string publisher)
        {
            spConfiguration("publisher_insert");

            command.Parameters.AddWithValue("@publisher", publisher);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spPublisher_update(string publisher, Int32 id_publisher)
        {
            spConfiguration("publisher_update");

            command.Parameters.AddWithValue("@id_publisher", id_publisher);
            command.Parameters.AddWithValue("@publisher", publisher);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spPublisher_delete(Int32 id_publisher)
        {
            spConfiguration("publisher_delete");

            command.Parameters.AddWithValue("@id_publisher", id_publisher);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spGenre_insert(string genre)
        {
            spConfiguration("genre_insert");

            command.Parameters.AddWithValue("@genre", genre);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spGenre_update(string genre, Int32 id_genre)
        {
            spConfiguration("genre_update");

            command.Parameters.AddWithValue("@id_genre", id_genre);
            command.Parameters.AddWithValue("@genre", genre);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spGenre_delete(Int32 id_genre)
        {
            spConfiguration("genre_delete");

            command.Parameters.AddWithValue("@id_genre", id_genre);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spTown_insert(string town)
        {
            spConfiguration("town_insert");

            command.Parameters.AddWithValue("@town", town);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spTown_update(string town, Int32 id_town)
        {
            spConfiguration("town_update");

            command.Parameters.AddWithValue("@id_town", id_town);
            command.Parameters.AddWithValue("@town", town);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spTown_delete(Int32 id_town)
        {
            spConfiguration("town_delete");

            command.Parameters.AddWithValue("@id_town", id_town);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spStreet_insert(string street)
        {
            spConfiguration("street_insert");

            command.Parameters.AddWithValue("@street", street);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spStreet_update(string street, Int32 id_street)
        {
            spConfiguration("street_update");

            command.Parameters.AddWithValue("@id_street", id_street);
            command.Parameters.AddWithValue("@street", street);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spStreet_delete(Int32 id_street)
        {
            spConfiguration("street_delete");

            command.Parameters.AddWithValue("@id_street", id_street);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }


        public void spAuthor_insert(string F_author, string I_author, string O_author)
        {
            spConfiguration("author_insert");

            command.Parameters.AddWithValue("@F_author", F_author);
            command.Parameters.AddWithValue("@I_author", I_author);
            command.Parameters.AddWithValue("@O_author", O_author);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spAuthor_update(string F_author, string I_author, string O_author, Int32 id_author)
        {
            spConfiguration("author_update");

            command.Parameters.AddWithValue("@id_author", id_author);
            command.Parameters.AddWithValue("@F_author", F_author);
            command.Parameters.AddWithValue("@I_author", I_author);
            command.Parameters.AddWithValue("@O_author", O_author);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spAuthor_delete(Int32 id_author)
        {
            spConfiguration("author_delete");

            command.Parameters.AddWithValue("@id_author", id_author);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spAvtoriz_insert(string login, string password, Int32 id_role)
        {
            spConfiguration("avtoriz_insert");

            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@id_role", id_role);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spAvtoriz_update(string login, string password, Int32 id_role, Int32 id_avtoriz)
        {
            spConfiguration("avtoriz_update");

            command.Parameters.AddWithValue("@id_avtoriz", id_avtoriz);
            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@id_role", id_role);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spAvtoriz_delete(Int32 id_avtoriz)
        {
            spConfiguration("avtoriz_delete");

            command.Parameters.AddWithValue("@id_avtoriz", id_avtoriz);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spBook_insert(string name_book, Int32 id_provider, Int32 id_author,
            Int32 id_publisher, Int32 id_genre, Int32 kol_vo_book, Double price)
        {
            spConfiguration("book_insert");

            command.Parameters.AddWithValue("@name_book", name_book);
            command.Parameters.AddWithValue("@id_provider", id_provider);
            command.Parameters.AddWithValue("@id_author", id_author);
            command.Parameters.AddWithValue("@id_publisher", id_publisher);
            command.Parameters.AddWithValue("@id_genre", id_genre);
            command.Parameters.AddWithValue("@kol_vo_book", kol_vo_book);
            command.Parameters.AddWithValue("@price", price);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spBook_update(string name_book, Int32 id_provider, Int32 id_author,
            Int32 id_publisher, Int32 id_genre, Int32 kol_vo_book, Double price, Int32 id_book)
        {
            spConfiguration("book_update");

            command.Parameters.AddWithValue("@id_book", id_book);
            command.Parameters.AddWithValue("@name_book", name_book);
            command.Parameters.AddWithValue("@id_provider", id_provider);
            command.Parameters.AddWithValue("@id_author", id_author);
            command.Parameters.AddWithValue("@id_publisher", id_publisher);
            command.Parameters.AddWithValue("@id_genre", id_genre);
            command.Parameters.AddWithValue("@kol_vo_book", kol_vo_book);
            command.Parameters.AddWithValue("@price", price);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spBook_delete(Int32 id_book)
        {
            spConfiguration("book_delete");

            command.Parameters.AddWithValue("@id_book", id_book);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spContract_with_provider_insert(string date_of_contract, Int32 id_provider)
        {
            spConfiguration("contract_with_provider_insert");

            command.Parameters.AddWithValue("@date_of_contract", date_of_contract);
            command.Parameters.AddWithValue("@id_provider", id_provider);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spContract_with_provider_update(string date_of_contract, Int32 id_provider, Int32 id_contract_with_provider)
        {
            spConfiguration("contract_with_provider_update");

            command.Parameters.AddWithValue("@id_contract_with_provider", id_contract_with_provider);
            command.Parameters.AddWithValue("@date_of_contract", date_of_contract);
            command.Parameters.AddWithValue("@id_provider", id_provider);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spContract_with_provider_delete(Int32 id_contract_with_provider)
        {
            spConfiguration("contract_with_provider_delete");

            command.Parameters.AddWithValue("@id_contract_with_provider", id_contract_with_provider);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spDoc_on_buy_book_insert(string date_of_doc_on_buy_book, Int32 id_provider,
            Int32 id_book, Int32 kol_vo_book)
        {
            spConfiguration("doc_on_buy_book_insert");

            command.Parameters.AddWithValue("@date_of_doc_on_buy_book", date_of_doc_on_buy_book);
            command.Parameters.AddWithValue("@id_provider", id_provider);
            command.Parameters.AddWithValue("@kol_vo_book", kol_vo_book);
            command.Parameters.AddWithValue("@id_book", id_book);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spDoc_on_buy_book_update(Int32 id_doc_on_buy_book, string date_of_doc_on_buy_book, Int32 id_provider,
            Int32 id_book, Int32 kol_vo_book)
        {
            spConfiguration("doc_on_buy_book_update");

            command.Parameters.AddWithValue("@id_doc_on_buy_book", id_doc_on_buy_book);
            command.Parameters.AddWithValue("@date_of_doc_on_buy_book", date_of_doc_on_buy_book);
            command.Parameters.AddWithValue("@id_provider", id_provider);
            command.Parameters.AddWithValue("@kol_vo_book", kol_vo_book);
            command.Parameters.AddWithValue("@id_book", id_book);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spDoc_on_buy_book_delete(Int32 id_doc_on_buy_book)
        {
            spConfiguration("doc_on_buy_book_delete");

            command.Parameters.AddWithValue("@id_doc_on_buy_book", id_doc_on_buy_book);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spDolj_insert(string dolj, Decimal salary)
        {
            spConfiguration("dolj_insert");

            command.Parameters.AddWithValue("@dolj", dolj);
            command.Parameters.AddWithValue("@salary", salary);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spDolj_update(Int32 id_dolj, string dolj, Decimal salary)
        {
            spConfiguration("dolj_update");

            command.Parameters.AddWithValue("@id_dolj", id_dolj);
            command.Parameters.AddWithValue("@dolj", dolj);
            command.Parameters.AddWithValue("@salary", salary);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spDolj_delete(Int32 id_dolj)
        {
            spConfiguration("dolj_delete");

            command.Parameters.AddWithValue("@id_dolj", id_dolj);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spEmployee_insert(string F_employee, string I_employee, string O_employee, Int32 id_dolj, Int32 id_education,
        Int32 id_avtoriz, Int32 id_status_employee, string date_birthday, string phone, string series_passport, string number_passport)
        {
            spConfiguration("employee_insert");

            command.Parameters.AddWithValue("@F_employee", F_employee);
            command.Parameters.AddWithValue("@I_employee", I_employee);
            command.Parameters.AddWithValue("@O_employee", O_employee);
            command.Parameters.AddWithValue("@id_dolj", id_dolj);
            command.Parameters.AddWithValue("@id_education", id_education);
            command.Parameters.AddWithValue("@id_avtoriz", id_avtoriz);
            command.Parameters.AddWithValue("@id_status_employee", id_status_employee);
            command.Parameters.AddWithValue("@date_birthday", date_birthday);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@series_passport", series_passport);
            command.Parameters.AddWithValue("@number_passport", number_passport);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spEmployee_update(Int32 id_employee, string F_employee, string I_employee, string O_employee, Int32 id_dolj, Int32 id_education,
        Int32 id_avtoriz, Int32 id_status_employee, string date_birthday, string phone, string series_passport, string number_passport)
        {
            spConfiguration("employee_update");

            command.Parameters.AddWithValue("@id_employee", id_employee);
            command.Parameters.AddWithValue("@F_employee", F_employee);
            command.Parameters.AddWithValue("@I_employee", I_employee);
            command.Parameters.AddWithValue("@O_employee", O_employee);
            command.Parameters.AddWithValue("@id_dolj", id_dolj);
            command.Parameters.AddWithValue("@id_education", id_education);
            command.Parameters.AddWithValue("@id_avtoriz", id_avtoriz);
            command.Parameters.AddWithValue("@id_status_employee", id_status_employee);
            command.Parameters.AddWithValue("@date_birthday", date_birthday);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@series_passport", series_passport);
            command.Parameters.AddWithValue("@number_passport", number_passport);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spEmployee_delete(Int32 id_employee)
        {
            spConfiguration("employee_delete");

            command.Parameters.AddWithValue("@id_employee", id_employee);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spPotencial_employee_insert(string F_employee, string I_employee, string O_employee, Int32 id_dolj, Int32 id_education,
         string date_birthday, string phone)
        {
            spConfiguration("potencial_employee_insert");

            command.Parameters.AddWithValue("@F_potencial_employee", F_employee);
            command.Parameters.AddWithValue("@I_potencial_employee", I_employee);
            command.Parameters.AddWithValue("@O_potencial_employee", O_employee);
            command.Parameters.AddWithValue("@id_dolj", id_dolj);
            command.Parameters.AddWithValue("@id_education", id_education);
            command.Parameters.AddWithValue("@date_birthday", date_birthday);
            command.Parameters.AddWithValue("@phone", phone);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spPotencial_employee_update(Int32 id_potencial_employee, string F_employee, string I_employee, string O_employee, Int32 id_dolj, Int32 id_education,
         string date_birthday, string phone)
        {
            spConfiguration("potencial_employee_update");

            command.Parameters.AddWithValue("@id_potencial_employee", id_potencial_employee);
            command.Parameters.AddWithValue("@F_potencial_employee", F_employee);
            command.Parameters.AddWithValue("@I_potencial_employee", I_employee);
            command.Parameters.AddWithValue("@O_potencial_employee", O_employee);
            command.Parameters.AddWithValue("@id_dolj", id_dolj);
            command.Parameters.AddWithValue("@id_education", id_education);
            command.Parameters.AddWithValue("@date_birthday", date_birthday);
            command.Parameters.AddWithValue("@phone", phone);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spPotencial_employee_delete(Int32 id_potencial_employee)
        {
            spConfiguration("potencial_employee_delete");

            command.Parameters.AddWithValue("@id_potencial_employee", id_potencial_employee);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spProvider_insert(string provider, Int32 id_town, Int32 id_street,
          string phone, string INN, string home)
        {
            spConfiguration("provider_insert");

            command.Parameters.AddWithValue("@provider", provider);
            command.Parameters.AddWithValue("@id_town", id_town);
            command.Parameters.AddWithValue("@id_street", id_street);
            command.Parameters.AddWithValue("@INN", INN);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@home", home);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spProvider_update(Int32 id_provider, string provider, Int32 id_town, Int32 id_street,
          string phone, string INN, string home)
        {
            spConfiguration("provider_update");

            command.Parameters.AddWithValue("@id_provider", id_provider);
            command.Parameters.AddWithValue("@provider", provider);
            command.Parameters.AddWithValue("@id_town", id_town);
            command.Parameters.AddWithValue("@id_street", id_street);
            command.Parameters.AddWithValue("@INN", INN);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@home", home);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spProvider_delete(Int32 id_provider)
        {
            spConfiguration("provider_delete");

            command.Parameters.AddWithValue("@id_provider", id_provider);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spReader_ticket_insert(string F_reader, string I_reader, string O_reader, Int32 id_avtoriz,
         string series_passport, string number_passport, string phone)
        {
            spConfiguration("reader_ticket_insert");

            command.Parameters.AddWithValue("@F_reader", F_reader);
            command.Parameters.AddWithValue("@I_reader", I_reader);
            command.Parameters.AddWithValue("@O_reader", O_reader);
            command.Parameters.AddWithValue("@id_avtoriz", id_avtoriz);
            command.Parameters.AddWithValue("@series_passport", series_passport);
            command.Parameters.AddWithValue("@number_passport", number_passport);
            command.Parameters.AddWithValue("@phone", phone);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spReader_ticket_update(Int32 id_reader_ticket, string F_reader, string I_reader, string O_reader, Int32 id_avtoriz,
         string series_passport, string number_passport, string phone)
        {
            spConfiguration("reader_ticket_update");

            command.Parameters.AddWithValue("@id_reader_ticket", id_reader_ticket);
            command.Parameters.AddWithValue("@F_reader", F_reader);
            command.Parameters.AddWithValue("@I_reader", I_reader);
            command.Parameters.AddWithValue("@O_reader", O_reader);
            command.Parameters.AddWithValue("@id_avtoriz", id_avtoriz);
            command.Parameters.AddWithValue("@series_passport", series_passport);
            command.Parameters.AddWithValue("@number_passport", number_passport);
            command.Parameters.AddWithValue("@phone", phone);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spReader_ticket_delete(Int32 id_reader_ticket)
        {
            spConfiguration("reader_ticket_delete");

            command.Parameters.AddWithValue("@id_reader_ticket", id_reader_ticket);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spRole_insert(string name_role, Int32 table_dolj, Int32 table_status_employee, Int32 table_author,
            Int32 table_role, Int32 table_publisher, Int32 table_genre, Int32 table_town, Int32 table_street, Int32 table_doc_on_buy_book,
            Int32 table_contract_with_provider, Int32 table_avtoriz, Int32 table_order, Int32 table_view_order, Int32 table_work_contract,
            Int32 table_book, Int32 table_reader_ticket, Int32 table_move_book, Int32 table_employee, Int32 table_potencial_employee,
            Int32 table_education, Int32 view_book_catalog, Int32 view_reader_ticket, Int32 table_provider, Int32 table_history)
        {
            spConfiguration("role_insert");

            command.Parameters.AddWithValue("@name_role", name_role);
            command.Parameters.AddWithValue("@table_dolj", table_dolj);
            command.Parameters.AddWithValue("@table_status_employee", table_status_employee);
            command.Parameters.AddWithValue("@table_author", table_author);
            command.Parameters.AddWithValue("@table_role", table_role);
            command.Parameters.AddWithValue("@table_genre", table_genre);
            command.Parameters.AddWithValue("@table_publisher", table_publisher);
            command.Parameters.AddWithValue("@table_town", table_town);
            command.Parameters.AddWithValue("@table_street", table_street);
            command.Parameters.AddWithValue("@table_doc_on_buy_book", table_doc_on_buy_book);
            command.Parameters.AddWithValue("@table_contract_with_provider", table_contract_with_provider);
            command.Parameters.AddWithValue("@table_avtoriz", table_avtoriz);
            command.Parameters.AddWithValue("@table_order", table_order);
            command.Parameters.AddWithValue("@table_view_order", table_view_order);
            command.Parameters.AddWithValue("@table_work_contract", table_work_contract);
            command.Parameters.AddWithValue("@table_book", table_book);
            command.Parameters.AddWithValue("@table_reader_ticket", table_reader_ticket);
            command.Parameters.AddWithValue("@table_move_book", table_move_book);
            command.Parameters.AddWithValue("@table_employee", table_employee);
            command.Parameters.AddWithValue("@table_potencial_employee", table_potencial_employee);
            command.Parameters.AddWithValue("@table_education", table_education);
            command.Parameters.AddWithValue("@view_book_catalog", view_book_catalog);
            command.Parameters.AddWithValue("@view_reader_ticket", view_reader_ticket);
            command.Parameters.AddWithValue("@table_provider", table_provider);
            command.Parameters.AddWithValue("@table_history", table_history);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spRole_update(Int32 id_role, string name_role, Int32 table_dolj, Int32 table_status_employee, Int32 table_author,
            Int32 table_role, Int32 table_publisher, Int32 table_genre, Int32 table_town, Int32 table_street, Int32 table_doc_on_buy_book,
            Int32 table_contract_with_provider, Int32 table_avtoriz, Int32 table_order, Int32 table_view_order, Int32 table_work_contract,
            Int32 table_book, Int32 table_reader_ticket, Int32 table_move_book, Int32 table_employee, Int32 table_potencial_employee,
            Int32 table_education, Int32 view_book_catalog, Int32 view_reader_ticket, Int32 table_provider, Int32 table_history)
        {
            spConfiguration("role_update");

            command.Parameters.AddWithValue("@id_role", id_role);
            command.Parameters.AddWithValue("@name_role", name_role);
            command.Parameters.AddWithValue("@table_dolj", table_dolj);
            command.Parameters.AddWithValue("@table_status_employee", table_status_employee);
            command.Parameters.AddWithValue("@table_author", table_author);
            command.Parameters.AddWithValue("@table_role", table_role);
            command.Parameters.AddWithValue("@table_genre", table_genre);
            command.Parameters.AddWithValue("@table_publisher", table_publisher);
            command.Parameters.AddWithValue("@table_town", table_town);
            command.Parameters.AddWithValue("@table_street", table_street);
            command.Parameters.AddWithValue("@table_doc_on_buy_book", table_doc_on_buy_book);
            command.Parameters.AddWithValue("@table_contract_with_provider", table_contract_with_provider);
            command.Parameters.AddWithValue("@table_avtoriz", table_avtoriz);
            command.Parameters.AddWithValue("@table_order", table_order);
            command.Parameters.AddWithValue("@table_view_order", table_view_order);
            command.Parameters.AddWithValue("@table_work_contract", table_work_contract);
            command.Parameters.AddWithValue("@table_book", table_book);
            command.Parameters.AddWithValue("@table_reader_ticket", table_reader_ticket);
            command.Parameters.AddWithValue("@table_move_book", table_move_book);
            command.Parameters.AddWithValue("@table_employee", table_employee);
            command.Parameters.AddWithValue("@table_potencial_employee", table_potencial_employee);
            command.Parameters.AddWithValue("@table_education", table_education);
            command.Parameters.AddWithValue("@view_book_catalog", view_book_catalog);
            command.Parameters.AddWithValue("@view_reader_ticket", view_reader_ticket);
            command.Parameters.AddWithValue("@table_provider", table_provider);
            command.Parameters.AddWithValue("@table_history", table_history);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spRole_delete(Int32 id_role)
        {
            spConfiguration("role_delete");

            command.Parameters.AddWithValue("@id_role", id_role);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spWork_contract_insert(string date_work_contract, Int32 id_employee)
        {
            spConfiguration("work_contract_insert");

            command.Parameters.AddWithValue("@date_work_contract", date_work_contract);
            command.Parameters.AddWithValue("@id_employee", id_employee);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spWork_contract_update(Int32 id_work_contract, string date_work_contract, Int32 id_employee)
        {
            spConfiguration("work_contract_update");

            command.Parameters.AddWithValue("@id_work_contract", id_work_contract);
            command.Parameters.AddWithValue("@date_work_contract", date_work_contract);
            command.Parameters.AddWithValue("@id_employee", id_employee);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spWork_contract_delete(Int32 id_work_contract)
        {
            spConfiguration("work_contract_delete");

            command.Parameters.AddWithValue("@id_work_contract", id_work_contract);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spOrder_insert(string date_order, Int32 id_employee, Int32 id_view_order)
        {
            spConfiguration("order_insert");

            command.Parameters.AddWithValue("@date_order", date_order);
            command.Parameters.AddWithValue("@id_employee", id_employee);
            command.Parameters.AddWithValue("@id_view_order", id_view_order);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spOrder_update(Int32 id_order, string date_order, Int32 id_employee, Int32 id_view_order)
        {
            spConfiguration("order_update");

            command.Parameters.AddWithValue("@id_order", id_order);
            command.Parameters.AddWithValue("@date_order", date_order);
            command.Parameters.AddWithValue("@id_employee", id_employee);
            command.Parameters.AddWithValue("@id_view_order", id_view_order);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spOrder_delete(Int32 id_order)
        {
            spConfiguration("order_delete");

            command.Parameters.AddWithValue("@id_order", id_order);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spMove_book_insert(string date_of_issue, string date_accept, Int32 id_book, Int32 id_reader_ticket)
        {
            spConfiguration("move_book_insert");

            command.Parameters.AddWithValue("@date_of_issue", date_of_issue);
            command.Parameters.AddWithValue("@date_accept", date_accept);
            command.Parameters.AddWithValue("@id_book", id_book);
            command.Parameters.AddWithValue("@id_reader_ticket", id_reader_ticket);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spMove_book_update(Int32 id_move_book, string date_of_issue, string date_accept,
            Int32 id_book, Int32 id_reader_ticket)
        {
            spConfiguration("move_book_update");

            command.Parameters.AddWithValue("@id_move_book", id_move_book);
            command.Parameters.AddWithValue("@date_of_issue", date_of_issue);
            command.Parameters.AddWithValue("@date_accept", date_accept);
            command.Parameters.AddWithValue("@id_book", id_book);
            command.Parameters.AddWithValue("@id_reader_ticket", id_reader_ticket);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spMove_book_delete(Int32 id_move_book)
        {
            spConfiguration("move_book_delete");

            command.Parameters.AddWithValue("@id_move_book", id_move_book);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spInvoice_insert(string date_invoice, Int32 kol_vo, Int32 id_book, Int32 id_employee)
        {
            spConfiguration("invoice_insert");

            command.Parameters.AddWithValue("@date_invoice", date_invoice);
            command.Parameters.AddWithValue("@kol_vo", kol_vo);
            command.Parameters.AddWithValue("@id_book", id_book);
            command.Parameters.AddWithValue("@id_employee", id_employee);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spInvoice_update(Int32 id_invoice, string date_invoice, Int32 kol_vo,
            Int32 id_book, Int32 id_employee)
        {
            spConfiguration("invoice_update");

            command.Parameters.AddWithValue("@id_invoice", id_invoice);
            command.Parameters.AddWithValue("@date_invoice", date_invoice);
            command.Parameters.AddWithValue("@kol_vo", kol_vo);
            command.Parameters.AddWithValue("@id_book", id_book);
            command.Parameters.AddWithValue("@id_employee", id_employee);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spInvoice_delete(Int32 id_invoice)
        {
            spConfiguration("invoice_delete");

            command.Parameters.AddWithValue("@id_invoice", id_invoice);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }
    }
}

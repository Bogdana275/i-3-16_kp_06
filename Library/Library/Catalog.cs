using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Catalog : Form
    {
        public Catalog()
        {
            InitializeComponent();
        }
        SqlCommand command = new SqlCommand("",ConnectionLibrary.ConnectionLibrary.sqlConnection);
        private void Catalog_Load(object sender, EventArgs e)
        {
            command.CommandText = "SELECT dbo.Author.F_author +' '+ SUBSTRING(dbo.Author.I_author,1,1) + '. '+ " +
                        " SUBSTRING(dbo.Author.O_author, 1, 1) + '. ' + dbo.Book.name_book as 'Книга', "+
                        " dbo.Publisher.publisher as 'Издательство' , dbo.Genre.genre as 'Жанр', dbo.Book.kol_vo_book as 'Кол-во',"+
                        " dbo.Book.id_book, dbo.Book.id_author, dbo.Book.id_publisher, dbo.Book.id_genre "+
                        "FROM dbo.Book INNER JOIN"+
                        " dbo.Genre ON dbo.Book.id_genre = dbo.Genre.id_genre INNER JOIN"+
                        " dbo.Author ON dbo.Book.id_author = dbo.Author.id_author INNER JOIN"+
                        " dbo.Publisher ON dbo.Book.id_publisher = dbo.Publisher.id_publisher";
            DataTable dt = new DataTable();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            dt.Load(command.ExecuteReader());
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }
    }
}

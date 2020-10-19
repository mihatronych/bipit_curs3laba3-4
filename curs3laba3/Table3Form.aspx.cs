using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace curs3laba3
{
    public partial class Table3Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string path = @"Data Source=DESKTOP-F0IABLG\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";
            string path = @"workstation id = epiclibrary.mssql.somee.com; packet size = 4096; user id = Mihail12336_SQLLogin_1; pwd = 1edtmfxeen; data source = epiclibrary.mssql.somee.com; persist security info = False; initial catalog = epiclibrary";
            string readersquery = "SELECT * FROM Readers";
            string booksquery = "SELECT * FROM Readers";
            string query = "SELECT Outputs.o_id, Readers.r_fio, Cast(Readers.r_dt_birth As VarChar(11)), Readers.r_passport, Books.b_name, Books.b_author, Cast(Books.b_publ As VarChar(11)), Cast(Books.b_born  As VarChar(11)), Cast(Outputs.o_dt_out As VarChar(11)), Cast(Outputs.o_dt_in As VarChar(11))," +
                "Year(Outputs.o_dt_in)*12*30+Month(Outputs.o_dt_in)*30+Day(Outputs.o_dt_in)-Year(Outputs.o_dt_out)*12*30-Month(Outputs.o_dt_out)*30-Day(Outputs.o_dt_out) FROM Readers, Books, Outputs where Outputs.R_id = Readers.r_id and Outputs.B_id = Books.b_id";
            DataSet ds = new DataSet();
            DataSet dsR = new DataSet();
            DataSet dsB = new DataSet();
            using (SqlConnection con = new SqlConnection(path))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(ds, "Readers");
                ds.Tables["Readers"].Columns[0].ColumnName = "ID";
                ds.Tables["Readers"].Columns[1].ColumnName = "ФИО Читателя";
                ds.Tables["Readers"].Columns[2].ColumnName = "Год рожд. Чит-ля";
                ds.Tables["Readers"].Columns[3].ColumnName = "Пасспорт Чит-ля";
                ds.Tables["Readers"].Columns[4].ColumnName = "Название Кн.";
                ds.Tables["Readers"].Columns[5].ColumnName = "Автор Кн.";
                ds.Tables["Readers"].Columns[6].ColumnName = "Дата издания";
                ds.Tables["Readers"].Columns[7].ColumnName = "Дата написания";
                ds.Tables["Readers"].Columns[8].ColumnName = "Дата выдачи";
                ds.Tables["Readers"].Columns[9].ColumnName = "Последний срок приема";
                ds.Tables["Readers"].Columns[10].ColumnName = "Дней до просрочки";
                GridView1.DataSource = ds.Tables["Readers"];
                GridView1.DataBind(); 
            }
        }
    }
}
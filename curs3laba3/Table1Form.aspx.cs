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
    public partial class Table1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string path = @"Data Source=DESKTOP-F0IABLG\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";
            string path = @"workstation id = epiclibrary.mssql.somee.com; packet size = 4096; user id = Mihail12336_SQLLogin_1; pwd = 1edtmfxeen; data source = epiclibrary.mssql.somee.com; persist security info = False; initial catalog = epiclibrary";
            string query = "SELECT Readers.r_id, Readers.r_fio, Cast(Readers.r_dt_birth As VarChar(11)), Readers.r_passport FROM Readers";
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(path))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(ds, "Readers");
                ds.Tables["Readers"].Columns[0].ColumnName = "ID";
                ds.Tables["Readers"].Columns[1].ColumnName = "ФИО";
                ds.Tables["Readers"].Columns[2].ColumnName = "Дата рождения";
                ds.Tables["Readers"].Columns[3].ColumnName = "Паспорт";

                GridView1.DataSource = ds.Tables["Readers"];
                GridView1.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
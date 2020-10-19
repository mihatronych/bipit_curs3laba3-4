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
    public partial class Table2Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string path = @"Data Source=DESKTOP-F0IABLG\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";
            string path = @"workstation id = epiclibrary.mssql.somee.com; packet size = 4096; user id = Mihail12336_SQLLogin_1; pwd = 1edtmfxeen; data source = epiclibrary.mssql.somee.com; persist security info = False; initial catalog = epiclibrary";
            string query = "SELECT Books.b_id, Books.b_name, Books.b_author, Cast(Books.b_publ As VarChar(11)), Cast(Books.b_born As VarChar(11)) FROM Books";
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(path))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(ds, "Books");
                ds.Tables["Books"].Columns[0].ColumnName = "ID";
                ds.Tables["Books"].Columns[1].ColumnName = "Название Кн.";
                ds.Tables["Books"].Columns[2].ColumnName = "Автор Кн.";
                ds.Tables["Books"].Columns[3].ColumnName = "Дата издания";
                ds.Tables["Books"].Columns[4].ColumnName = "Дата написания";
                GridView1.DataSource = ds.Tables["Books"];
                GridView1.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Label2_Load(object sender, EventArgs e)
        {
        }
    }
}
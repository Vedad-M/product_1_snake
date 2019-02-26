using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SnakeGameFinal
{
    public partial class ScoreBoard : System.Web.UI.Page
    {
       
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["myDB"].ConnectionString);
        MySqlDataAdapter ada = new MySqlDataAdapter();
        DataSet da = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "select top 10 * from score";
            cmd.Connection = con;
            DataTable dt = new DataTable();
            MySqlDataReader rd = cmd.ExecuteReader();
            StringBuilder table = new StringBuilder();
            table.Append("<center>");
            table.Append("<h1>Score Board Leaders</h1>");
            table.Append("<hr/>");
            table.Append("<table border=1");
            table.Append("<tr>");
            foreach (DataColumn dc in dt.Columns)
            {
                table.Append("<th>");
                table.Append(dc.ColumnName.ToUpper());
                table.Append("</th>");
            }
            table.Append("</tr>");

            foreach(DataRow dr in dt.Rows)
            {
                table.Append("<tr>");
                foreach(DataColumn dc in dt.Columns)
                {
                    table.Append("<th>");
                    table.Append(dr[dc.ColumnName].ToString());
                    table.Append("</th>");
                }
            }
            table.Append("</tr>");
            table.Append("</center>");
            Panel1.Controls.Add(new Label {Text = table.ToString()});
            con.Close();
        }
    }
}
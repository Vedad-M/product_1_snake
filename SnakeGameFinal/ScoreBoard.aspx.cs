using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SnakeGameFinal
{
    public partial class ScoreBoard : System.Web.UI.Page
    {


        StringBuilder table = new StringBuilder();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["myDB"].ConnectionString);
                string scoreQuery = "Select * From scores Order By score DESC Limit 10";
                int rank = 1;
                MySqlCommand cmd = new MySqlCommand(scoreQuery, con);
                con.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable DT = new DataTable();
                sda.Fill(DT);
                table.Append("<h1>Top 10 Highest Scores:");
                table.Append("<center>");
                table.Append("<table border='1'>");
                table.Append("<tr>");
                table.Append("<th>");
                table.Append("Ranking");
                table.Append("</th>");
                foreach (DataColumn dc in DT.Columns)
                {

                    table.Append("<th>");
                    table.Append(dc.ColumnName.ToUpper());
                    table.Append("</th>");
                }
                table.Append("</tr>");
                foreach (DataRow dr in DT.Rows)
                {
                    table.Append("<th>");
                    table.Append(rank);
                    table.Append("</th");
                    table.Append("<tr>");
                    foreach (DataColumn dc in DT.Columns)
                    {

                        table.Append("<th>");
                        table.Append(dr[dc.ColumnName].ToString());
                        table.Append("</th>");
                    }
                    table.Append("</tr>");
                    rank++;
                }
                table.Append("</table>");
                table.Append("</center>");
                Panel1.Controls.Add(new Literal { Text = table.ToString() });
                con.Close();
            }
        }
    }
}

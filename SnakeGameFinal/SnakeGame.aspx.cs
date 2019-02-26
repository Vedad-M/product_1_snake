using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SnakeGameFinal
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["myDB"].ConnectionString);
        MySqlDataAdapter ada = new MySqlDataAdapter();
        DataSet da = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
                con.Open();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
                if (displayScore != null)
                {
                    cmd.CommandText = "Insert Into scores (name, score) Values ('" + nameText.Text + "','" + displayScore.Text + "')";
                    cmd.Connection = con;
                    ada.SelectCommand = cmd;
                    ada.Fill(da, "scores");
                }
        }
    }
}
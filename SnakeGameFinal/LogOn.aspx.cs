using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SnakeGameFinal
{
    public partial class LogOn : System.Web.UI.Page
    {
        MySqlCommand cmd = new MySqlCommand();
        
        MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["myDB"].ConnectionString);
        MySqlDataAdapter ada = new MySqlDataAdapter();
        DataSet da = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
        }
        protected void LogOn_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select * from users where username = '"+txtUser.Text+"' and password = '"+txtPassword.Text+"'";
            cmd.Connection = con;
            ada.SelectCommand = cmd;
            ada.Fill(da, "users");
            if(da.Tables[0].Rows.Count > 0)
            {
                label1.Text = "Users Information was found";
            }
            else
            {
                label1.Text = "The user's information is not an active account";
            }
        }
    }
}
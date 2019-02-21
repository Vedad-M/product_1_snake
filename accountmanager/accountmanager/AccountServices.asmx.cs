using System.Web.Services;

//we need these to talk to mysql
//and we need this to manipulate data from a db
using System.Data;
using System.Data.SqlClient;

namespace accountmanager
{
    /// <summary>
    /// Summary description for AccountServices
    /// </summary>
    [WebService(Namespace = "https://mi3-wsr1.supercp.com")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
	[System.Web.Script.Services.ScriptService]
	public class AccountServices : System.Web.Services.WebService
	{

		[WebMethod]
		public int NumberOfAccounts()
		{
			//here we are grabbing that connection string from our web.config file
			string sqlConnectString = System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
			//here's our query.  A basic select with nothing fancy.
			string sqlSelect = "SELECT * from users";



			//set up our connection object to be ready to use our connection string
			SqlConnection sqlConnection = new SqlConnection(sqlConnectString);
			//set up our command object to use our connection, and our query
			SqlCommand sqlCommand = new SqlCommand(sqlSelect, sqlConnection);


			//a data adapter acts like a bridge between our command object and 
			//the data we are trying to get back and put in a table object
			SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCommand);
			//here's the table we want to fill with the results from our query
			DataTable sqlDt = new DataTable();
			//here we go filling it!
			sqlDa.Fill(sqlDt);
			//return the number of rows we have, that's how many accounts are in the system!
			return sqlDt.Rows.Count;
		}
	}
}

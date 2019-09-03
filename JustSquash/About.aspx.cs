using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace JustSquash
{
    public partial class About : Page
    {
        private string connect_string = "server=den1.mysql5.gear.host;user id=RuntimeError;password=Runner*;persistsecurityinfo=True;database=runtimeerror;SslMode=none";

        private MySqlConnection connection;
        private MySqlCommand command;
        private string query;
        protected void Page_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connect_string);

        }

        protected void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txtFname.Text;
                string lastName = txtLname.Text;
                string id = txtID.Text;
                //string connect_string = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;


                // Database db = new SqlDatabase(ConnectionStr);
                // connection = new MySqlConnection(connect_string);

                command.CommandText = "Book_now";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // command = connect_string.GetStoredProcCommand("Book_now")

                
               
                


                command.Parameters.Add(new MySqlParameter("@id", MySqlDbType.VarChar)).Value = id;
                command.Parameters.Add(new MySqlParameter("@fname", MySqlDbType.VarChar)).Value = firstName;
                command.Parameters.Add(new MySqlParameter("@lname", MySqlDbType.VarChar)).Value = lastName;

                connection.Open();
                command.ExecuteNonQuery();

            }
            catch (Exception )
            {

                
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
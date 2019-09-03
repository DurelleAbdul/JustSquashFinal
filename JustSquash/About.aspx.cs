using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.IO;
using System.Data.Entity;
using System.Data.Common;
using System.Data.SqlClient;

namespace JustSquash
{
    public partial class About : Page
    {
        public string connect_string = "server=den1.mysql5.gear.host;user id=runtimeerror;password=Runner*#;persistsecurityinfo=True;database=runtimeerror;SslMode=none";
        public MySqlConnection connection;
        public MySqlCommand command;


        protected void Page_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connect_string);
        }

        protected void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                //string connect_string = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
               

                // Database db = new SqlDatabase(ConnectionStr);
                connection = new MySqlConnection(connect_string);
                connection.Open();
                command.CommandText = "Book_now";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // command = connect_string.GetStoredProcCommand("Book_now")
                {

                    command.Parameters.Add(new MySqlParameter("@Id_No", MySqlDbType.VarChar)).Value = txtID.Text;
                    command.Parameters.Add(new MySqlParameter("@First_Name", MySqlDbType.VarChar)).Value = txtFname.Text;
                    command.Parameters.Add(new MySqlParameter("@Last_Name", MySqlDbType.VarChar)).Value = txtLname.Text;






                    //connection.Open();
                    command.ExecuteNonQuery();

                   // db.ExecuteNonQuery(dbcmd);
                }
            }
            catch (SqlException Excptn_BookConfirmData)
            {
                throw Excptn_BookConfirmData;
            }


        }
    }
}
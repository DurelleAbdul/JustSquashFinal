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
        private string connect_string = "server=den1.mysql5.gear.host;user id=Runtime Error;password=Runner*#;persistsecurityinfo=True;database=runtimeerror;SslMode=none";

        private MySqlConnection connection;
        private MySqlCommand command;
        private string query;
        protected void Page_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connect_string);

        }

        protected void btnProcess_Click(object sender, EventArgs e)
        {
            string date = calDate.ToString();
            string time = txtTime.Text;
            string venue = txtVenue.Text;
            string memberType = cmdMember.ToString();
            string firstName = txtFname.Text;
            string lastName = txtLname.Text;
            string id = txtID.Text;
            string contactNum = txtContact.Text;
            string email = txtEmail.Text;


           

            date.Substring(0, 10);
           
            try
            {


                command.CommandText = "Insert_booking";
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new MySqlParameter("@bDate", MySqlDbType.VarChar)).Value = date;
                command.Parameters.Add(new MySqlParameter("@time", MySqlDbType.VarChar)).Value = time;
                command.Parameters.Add(new MySqlParameter("@room", MySqlDbType.VarChar)).Value = venue;
                command.Parameters.Add(new MySqlParameter("@member_type", MySqlDbType.VarChar)).Value = memberType;
                
                command.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32)).Value = id;
                command.Parameters.Add(new MySqlParameter("@fname", MySqlDbType.VarChar)).Value = firstName;
                command.Parameters.Add(new MySqlParameter("@lname", MySqlDbType.VarChar)).Value = lastName;
                command.Parameters.Add(new MySqlParameter("@phone", MySqlDbType.VarChar)).Value = contactNum;
                command.Parameters.Add(new MySqlParameter("@email_address", MySqlDbType.VarChar)).Value = email;


                connection.Open();
                command.ExecuteNonQuery();
                
            }
            catch (Exception error)
            {
           
            }
        }
    }
}
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
        MySqlCommand cmd;
        MySqlDataReader reader;
        MySqlDataAdapter adapter;
        String queryStr;
        MySqlConnection conn;



        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection("server =den1.mysql5.gear.host; user id =runtimeerror; database=runtimeerror; password=Runner*");

               



                adapter = new MySqlDataAdapter();
                String sql = "server =den1.mysql5.gear.host; user id =runtimeerror; database=runtimeerror; password=Runner*";

                sql = "Insert into booking(venue,client_type,id_no,first_name,last_name,contact_no,email) values('" + txtVenue.Text + "','"+ cmdMember.Text + "','" + txtID.Text + "','" + txtFname.Text+ "','" + txtLname.Text + "','" + txtContact.Text + "','" + txtEmail.Text + "')";
                conn.Open();


                cmd = new MySqlCommand(sql, conn);
                adapter.InsertCommand = new MySqlCommand(sql, conn);
                adapter.InsertCommand.ExecuteNonQuery();

                cmd.Dispose();





               



                

               

            }
            catch (SystemException)
            {
               
            }

            conn.Close();
        }
    }
}
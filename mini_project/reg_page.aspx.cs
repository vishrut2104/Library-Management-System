using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;

namespace mini_project
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "Execute sp_insert @username, @password, @age, @email, @gender, @type";

            cmd.Parameters.Add("@username", System.Data.SqlDbType.VarChar, 15).Value = txtusername.Text.ToString();
            cmd.Parameters.Add("@password", System.Data.SqlDbType.VarChar, 20).Value = txtpass.Text.ToString();
            cmd.Parameters.Add("@age", System.Data.SqlDbType.VarChar, 3).Value = txtage.Text.ToString();
            cmd.Parameters.Add("@email", System.Data.SqlDbType.VarChar, 20).Value = txtemail.Text.ToString();
            cmd.Parameters.Add("@gender", System.Data.SqlDbType.VarChar, 10).Value = txtgender.Text.ToString();
            cmd.Parameters.Add("@type", System.Data.SqlDbType.VarChar, 10).Value = txttype.Text.ToString();
            


            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alertMessage();", true); 
            
        }
    }
}
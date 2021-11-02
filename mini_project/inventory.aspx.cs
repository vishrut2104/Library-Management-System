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
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "Execute sp_addbook @bauthor, @bpages, @bcopies, @bgenre, @ID, @bname";

            
            cmd.Parameters.Add("@bauthor", System.Data.SqlDbType.VarChar, 20).Value = txtbauthor.Text.ToString();
            cmd.Parameters.Add("@bpages", System.Data.SqlDbType.VarChar, 10).Value = txtbpages.Text.ToString();
            cmd.Parameters.Add("@bcopies", System.Data.SqlDbType.VarChar, 10).Value = txtbcopies.Text.ToString();
            cmd.Parameters.Add("@bgenre", System.Data.SqlDbType.VarChar, 20).Value = txtbgenre.Text.ToString();
            cmd.Parameters.Add("@ID", System.Data.SqlDbType.VarChar, 10).Value = txtbID.Text.ToString();
            cmd.Parameters.Add("@bname", System.Data.SqlDbType.VarChar, 20).Value = txtbname.Text.ToString();
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alertMessage();", true);
           
        }

        protected void grid_Click(object sender, EventArgs e)
        {
           
            
                Response.Redirect("gridview.aspx");
            
        }

        protected void btndel_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "Execute sp_delete   @ID";
            
            cmd.Parameters.Add("@bID", System.Data.SqlDbType.VarChar, 10).Value = txtbID.Text.ToString();
            


            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
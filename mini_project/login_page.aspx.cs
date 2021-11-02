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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = con.CreateCommand();
            
            cmd.CommandText = "select * from account_info where username=@username and password=@password and type=@type";
            
            cmd.Parameters.AddWithValue("@username", txtUname.Text);
            cmd.Parameters.AddWithValue("@password", txtpass.Text);
            cmd.Parameters.AddWithValue("@type", txttype.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            if(dt.Rows.Count > 0) 
                
            {
                if (txttype.SelectedIndex == 2)
                {
                    Response.Redirect("admin_page.aspx");
                }
                else if (txttype.SelectedIndex == 1)
                {
                    Response.Redirect("WebForm9.aspx");
                }
                else
                {
                    
                    Response.Redirect("WebForm9.aspx");
                }
                
            }

            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alertMessage();", true);  
            }
            
        }

      
        }
    }

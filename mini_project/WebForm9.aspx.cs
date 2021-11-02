using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data;
using System.Web.UI.HtmlControls;

namespace mini_project
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = con.CreateCommand();
            con.Open();

        }

        protected void btninventory_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM books"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView2.DataSource = dt;

                          
                            GridView2.DataBind();
                          
                        }
                    }
                }
            }
        }



        protected void btnreturn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from issue where bID = '" + txtbID.Text.Trim() + "'  and username = '" + txtusername.Text.Trim() + "'" ;

            
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
          
            cmd.ExecuteNonQuery();


            if (dt.Rows.Count >= 1)
            {
                SqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "update books set bcopies=bcopies+1 where ID = @bID";
                cmd2.Parameters.Add("@bID", System.Data.SqlDbType.VarChar, 20).Value = txtbID.Text.ToString();
                cmd2.ExecuteNonQuery();

                SqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "Delete from issue where bID = '" + txtbID.Text.Trim() + "' and username = '" + txtusername.Text.Trim() + "'" ;
                cmd3.ExecuteNonQuery();

                ScriptManager.RegisterStartupScript(this, GetType(), "alert", "returnmessage();", true);
            }
        }



        protected void btnissue_Click(object sender, EventArgs e)
        {
            if(showbox.Visible == false){
                showbox.Visible = true;
                showbox.Attributes.Add("style", "display:grid");
            }
            
            else{

            
            
           
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from books where ID = '" + txtbID.Text.Trim() + "' and bcopies>0";
           // SqlCommand cmd = new SqlCommand("select * from books where bID = @bID and bcopies>0 ", con);
          //  cmd.Parameters.Add("@bID,", System.Data.SqlDbType.VarChar, 20).Value = txtbID.Text.ToString();


            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
          
            int i = cmd.ExecuteNonQuery();

       

            if (dt.Rows.Count >= 1)
            {
                SqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "update books set bcopies=bcopies-1 where ID = @bID";
                cmd2.Parameters.Add("@bID", System.Data.SqlDbType.VarChar, 20).Value = txtbID.Text.ToString();
                cmd2.ExecuteNonQuery();
                
                SqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "Execute sp_issue @username, @bID, @member_name, @issue_date";


                cmd3.Parameters.Add("@username", System.Data.SqlDbType.VarChar, 15).Value = txtusername.Text.ToString();
                cmd3.Parameters.Add("@bID", System.Data.SqlDbType.VarChar, 20).Value = txtbID.Text.ToString();
                cmd3.Parameters.Add("@member_name", System.Data.SqlDbType.VarChar, 3).Value = txtname.Text;
                cmd3.Parameters.Add("@issue_date", System.Data.SqlDbType.VarChar, 20).Value = txtdate.Text.ToString();
                cmd3.ExecuteNonQuery();


                ScriptManager.RegisterStartupScript(this, GetType(), "alert", "issuemessage();", true);
            
           }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alert", "notissued();", true);
            }
            }
        }



        protected void btnview_Click(object sender, EventArgs e)
        {
             string constr = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM issue where username=@username"))
                
                    
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                       
                        cmd.Connection = con;
                        cmd.Parameters.Add("@username", System.Data.SqlDbType.VarChar, 15).Value = txtusername.Text.ToString();
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView2.DataSource = dt;
                            
                            GridView2.DataBind();
                         
                        }
                   }
               }
           }

       }

    }
}

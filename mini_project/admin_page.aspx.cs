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

namespace mini_project
{
    public partial class WebForm6 : System.Web.UI.Page
    {

        private SqlConnection conn = new SqlConnection("Data Source=LAPTOP-3K3Q7FR7;Integrated Security=true;Initial Catalog=accounts;  User ID=sa;Password=sa@123");  

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }


        protected void gvbind()
        {


            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from books", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            if (ds.Tables[0].Rows.Count > 0)
            {
                grdinv.DataSource = ds;
                grdinv.DataBind();
               
            }
            //else
            //{
            //    ds.Tables[0].Rows.Add(ds.Tables[0].NewRow());
            //    Grdinv.DataSource = ds;
            //    Grdinv.DataBind();
            //    int columncount = Grdinv.Rows[0].Cells.Count;
            //    Grdinv.Rows[0].Cells.Clear();
            //    Grdinv.Rows[0].Cells.Add(new TableCell());
            //    Grdinv.Rows[0].Cells[0].ColumnSpan = columncount;
            //    Grdinv.Rows[0].Cells[0].Text = "No Records Found";
            //}
        }


        protected void gvaccbind()
        {


            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from account_info", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            if (ds.Tables[0].Rows.Count > 0)
            {
                grdaccount.DataSource = ds;

                grdaccount.DataBind();
            }
            else
            {
                ds.Tables[0].Rows.Add(ds.Tables[0].NewRow());
                grdaccount.DataSource = ds;
                grdaccount.DataBind();
                int columncount = grdaccount.Rows[0].Cells.Count;
                grdaccount.Rows[0].Cells.Clear();
                grdaccount.Rows[0].Cells.Add(new TableCell());
                grdaccount.Rows[0].Cells[0].ColumnSpan = columncount;
                grdaccount.Rows[0].Cells[0].Text = "No Records Found";
            }
        }



        protected void Grdinv_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            GridViewRow row = (GridViewRow)grdinv.Rows[e.RowIndex];
            Label lbldeleteid = (Label)row.FindControl("ID");
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete FROM books where ID='" + Convert.ToInt32(grdinv.DataKeys[e.RowIndex].Value.ToString()) + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            gvbind();
        }




        protected void Gridacc_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = (GridViewRow)grdaccount.Rows[e.RowIndex];
            Label lbldeleteid = (Label)row.FindControl("username");
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete FROM account_info where username='" + (grdaccount.DataKeys[e.RowIndex].Value.ToString()) + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            gvaccbind();
        }


        protected void btnadd_Click(object sender, EventArgs e)
        {
            Response.Redirect("add_admin.aspx");
        }

        protected void btninventory_Click(object sender, EventArgs e)
        {
            Response.Redirect("inventory.aspx");
        }

        protected void btnmanage_Click(object sender, EventArgs e)
        {
            ;
        }

        protected void btnview_Click(object sender, EventArgs e)
        {
            gvbind();
        }



        protected void Grdinv_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdinv.EditIndex = e.NewEditIndex;
            gvbind();
        }

        protected void Gridacc_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdaccount.EditIndex = e.NewEditIndex;
            gvaccbind();
        }



        protected void Grdinv_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int userid = Convert.ToInt32(grdinv.DataKeys[e.RowIndex].Value.ToString());
            GridViewRow row = (GridViewRow)grdinv.Rows[e.RowIndex];
            Label lblID = (Label)row.FindControl("lblID");
            TextBox textauthor = (TextBox)row.Cells[0].Controls[0];
            TextBox textpages = (TextBox)row.Cells[1].Controls[0];
            TextBox textcopies = (TextBox)row.Cells[2].Controls[0];
            TextBox textgenre = (TextBox)row.Cells[3].Controls[0];
            TextBox textname = (TextBox)row.Cells[4].Controls[0];
            grdinv.EditIndex = -1;
            conn.Open();
            SqlCommand cmd = new SqlCommand("update books set bauthor='" + textauthor.Text + "',bpages='" + textpages.Text + "',bcopies='" + textcopies.Text + "', bgenre='" + textgenre.Text + "',bname='" + textname.Text + "' where ID='" + userid + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            gvbind(); 
        }

        protected void Gridacc_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string userid = grdaccount.DataKeys[e.RowIndex].Value.ToString();
            GridViewRow row = (GridViewRow)grdaccount.Rows[e.RowIndex];
            Label lblID = (Label)row.FindControl("username");
            TextBox textusername = (TextBox)row.Cells[0].Controls[0];
            TextBox textpassword = (TextBox)row.Cells[1].Controls[0];
            TextBox textage = (TextBox)row.Cells[2].Controls[0];
            TextBox textemail= (TextBox)row.Cells[3].Controls[0];
            TextBox textgender = (TextBox)row.Cells[4].Controls[0];
            TextBox texttype = (TextBox)row.Cells[5].Controls[0];
            grdaccount.EditIndex = -1;
            conn.Open();
            SqlCommand cmd = new SqlCommand("update account_info set username='" + textusername.Text + "',password='" + textpassword.Text + "',age='" + textage.Text + "', email='" + textemail.Text + "',type='" + texttype.Text + "' where username='" + userid + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            gvaccbind();
        }



        protected void Grdinv_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdinv.PageIndex = e.NewPageIndex;
            gvbind();
        }
        protected void Grdinv_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdinv.EditIndex = -1;
            gvbind();
        }


        protected void Gridacc_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdaccount.PageIndex = e.NewPageIndex;
            gvaccbind();
        }
        protected void Gridacc_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdaccount.EditIndex = -1;
            gvaccbind();
        }

        protected void btnaccounts_Click(object sender, EventArgs e)
        {
            gvaccbind();
        }
}
}



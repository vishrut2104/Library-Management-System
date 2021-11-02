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
    public partial class WebForm4 : System.Web.UI.Page
    {
        private SqlConnection conn = new SqlConnection("Data Source=LAPTOP-3K3Q7FR7;Integrated Security=true;Initial Catalog=accounts;  User ID=sa;Password=sa@123"); 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                gvbind();
            }

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
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            else
            {
                ds.Tables[0].Rows.Add(ds.Tables[0].NewRow());
                GridView1.DataSource = ds;
                GridView1.DataBind();
                int columncount = GridView1.Rows[0].Cells.Count;
                GridView1.Rows[0].Cells.Clear();
                GridView1.Rows[0].Cells.Add(new TableCell());
                GridView1.Rows[0].Cells[0].ColumnSpan = columncount;
                GridView1.Rows[0].Cells[0].Text = "No Records Found";
            }
        }



        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
            Label lbldeleteid = (Label)row.FindControl("ID");
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete FROM books where ID='" + Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString()) + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            gvbind();
        }



        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            gvbind();
        }



        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int userid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
            Label lblID = (Label)row.FindControl("lblID");
            //TextBox txtname=(TextBox)gr.cell[].control[];  
            TextBox textauthor = (TextBox)row.Cells[0].Controls[0];
            TextBox textpages = (TextBox)row.Cells[1].Controls[0];
            TextBox textcopies = (TextBox)row.Cells[2].Controls[0];
            TextBox textgenre = (TextBox)row.Cells[3].Controls[0];
            TextBox textname = (TextBox)row.Cells[4].Controls[0];
            //TextBox textadd = (TextBox)row.FindControl("txtadd");  
            //TextBox textc = (TextBox)row.FindControl("txtc");  
            GridView1.EditIndex = -1;
            conn.Open();
            //SqlCommand cmd = new SqlCommand("SELECT * FROM detail", conn);  
            SqlCommand cmd = new SqlCommand("update books set bauthor='" + textauthor.Text + "',bpages='" + textpages.Text + "',bcopies='" + textcopies.Text + "', bgenre='" + textgenre.Text + "',bname='" + textname.Text + "' where ID='" + userid + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            gvbind();
            //GridView1.DataBind();  

        }



        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            gvbind();
        }


       

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            gvbind();
        }  
        


    }

}

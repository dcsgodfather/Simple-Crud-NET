using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-UM409B6F;Initial Catalog=tbl_student;User ID=sa;Password=sa123");
    protected void btninsert_Click(object sender, EventArgs e)
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tblcat values('" + TextBox1.Text + "')", con);
            cmd.ExecuteNonQuery();
            GridView1.DataBind();
            con.Close();
            TextBox1.Text = "";
        }
        catch(Exception ex)
        {
            Response.Write(ex.Message);
        }
       
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label2.Text= GridView1.SelectedRow.Cells[1].Text;
        TextBox1.Text = GridView1.SelectedRow.Cells[2].Text;
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            con.Open();
            int id = Convert.ToInt32(Label2.Text);
            SqlCommand cmd = new SqlCommand("update tblcat set cname='" + TextBox1.Text + "' where cid='"+ id + "'", con);
            cmd.ExecuteNonQuery();
            GridView1.DataBind();
            con.Close();
            TextBox1.Text = "";
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    protected void btndelete_Click(object sender, EventArgs e)
    {
        try
        {
            con.Open();
            int id = Convert.ToInt32(Label2.Text);
            SqlCommand cmd = new SqlCommand("delete from tblcat where cid='" + id + "'", con);
            cmd.ExecuteNonQuery();
            GridView1.DataBind();
            con.Close();
            TextBox1.Text = "";
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("report.aspx");
    }
}
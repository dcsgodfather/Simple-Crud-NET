using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class report : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-UM409B6F;Initial Catalog=tbl_student;User ID=sa;Password=sa123");
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlDataAdapter da = new SqlDataAdapter("select * from tblsubcat where cid='"+DropDownList1.SelectedValue+"'", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
    }
}
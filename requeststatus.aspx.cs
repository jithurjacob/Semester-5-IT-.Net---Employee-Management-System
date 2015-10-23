using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class requeststatus : System.Web.UI.Page
{
    Dbacess d1 = new Dbacess();
    protected void Page_Load(object sender, EventArgs e)
    {
        try {
            string cmd1 = "select * from policyrequest where empname='" + Session["username"].ToString() +"';";
         SqlCommand cmd = new SqlCommand(cmd1, d1.con);
            DataTable dt=new DataTable();
            d1.con.Open();
            SqlDataReader  reader;
            reader = cmd.ExecuteReader();
            dt.Load(reader);
            if (dt.Rows.Count == 0)
                Label1.Text = "You donot have any requests ... ";
            GridView1.AutoGenerateColumns=true;
            GridView1.DataSource = dt;
            GridView1.DataBind();
            reader.Close();
            d1.con.Close();
        }
        catch (Exception ex) {
            Label1.Text = ex.ToString();
            Response.Redirect("default.aspx");

        }
    }
}
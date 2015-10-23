using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class admin_policyrequest : System.Web.UI.Page
{
    Dbacess d1 = new Dbacess();
    protected void Page_Load(object sender, EventArgs e)
    {

        try
        {
            string cmd1 = "select * from policyrequest where status='pending' ;";
            SqlCommand cmd = new SqlCommand(cmd1, d1.con);
            DataTable dt = new DataTable();
            d1.con.Open();
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            dt.Load(reader);
            if (dt.Rows.Count == 0)
                Label1.Text = "You donot have any pending requests to validate... ";
            GridView1.AutoGenerateColumns = true;
            GridView1.DataSource = dt;
            GridView1.DataBind();
            reader.Close();
            d1.con.Close();
        }
        catch (Exception ex)
        {
            Label1.Text = ex.ToString();
            Response.Redirect("default.aspx");

        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        // reject 
        try {
            DataTable dt;
            string sql5 = "select * from policyrequest where status='pending' ;";
            dt = d1.GetData(sql5);
            string i = (dt.Rows[e.RowIndex][0]).ToString();
            
            string cmd = "update policyrequest set status='reject' where id= "+i +";";
         int b =  d1.Updatedata(cmd );
        if (b > 0)
        {
            
            Label1.Text = "Request rejected successfully..." ;
            Response.Redirect("admin_policyrequest.aspx");
        }

        else
            Label1.Text = "Request rejection  Failed..." ;
    
        }
        catch (Exception ex)
        {
            Label1.Text = "Error in rejecting the request...."+ex.ToString();
        }
       
    }
    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {//accept
        try
        {
            DataTable dt,dt1;
            string sql5 = "select * from policyrequest where status='pending' ;";
            dt = d1.GetData(sql5);
            string i = (dt.Rows[e.NewSelectedIndex][0]).ToString();

            string cmd = "update policyrequest set status='accept' where id= " + i + ";";
            string cmd2 = "select * from policyrequest where id='"+i+"'";
            dt1 = d1.GetData(cmd2);
            string sql1 = "Select max(id)+1 as count from emp_policy";
            dt = d1.GetData(sql1);
           string  id_ = (dt.Rows[0][0]).ToString();

            string cmd3 = "insert into emp_policy values("+id_ +",'"+dt1.Rows[0][1].ToString()+"','"+ dt1.Rows[0][2].ToString()+"',"+dt1.Rows[0][3]+");";
            int b1 = d1.InsertData(cmd3);
            int b = d1.Updatedata(cmd);
            if (b > 0)
            {

                Label1.Text = "Request accepted successfully...";
                Response.Redirect("admin_policyrequest.aspx");
            }

            else
                Label1.Text = "Request accepting  Failed...";

        }
        catch (Exception ex) {
            Label1.Text = "Error in accepting the request..."+ex.ToString();
        }
    }
}
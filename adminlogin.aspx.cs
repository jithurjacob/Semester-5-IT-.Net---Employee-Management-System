using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class adminlogin : System.Web.UI.Page
{

    Dbacess d1 = new Dbacess();
     string username;
     string pwd;
      protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Focus();

    }
    
    protected void Button1_Click1(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            username = TextBox1.Text;
            pwd = TextBox2.Text;

            if (!(string.IsNullOrEmpty(username) || (string.IsNullOrEmpty(pwd))))
            {
                // Response.Redirect("home.aspx");
                string sql5 = "Select * from adminlogin";
                DataTable dt;
                dt = d1.GetData(sql5);
                string usernam_db = (dt.Rows[0][0]).ToString();
                string pwd_db = (dt.Rows[0][1]).ToString();
                if (username == usernam_db && pwd == pwd_db)
                    Response.Redirect("admincontrol.aspx");
                else
                    Label1.Text = "Invalid login ";
            }
            else
                Label1.Text = "Please fill all fields... ";
        }
    }
}
   
    

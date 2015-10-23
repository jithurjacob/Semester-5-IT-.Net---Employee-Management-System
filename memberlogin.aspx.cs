using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class memberlogin : System.Web.UI.Page
{
    string username, pwd;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    Dbacess d1 = new Dbacess();
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            username = TextBox1.Text;
            pwd = TextBox2.Text;

            if (!(string.IsNullOrEmpty(username) || (string.IsNullOrEmpty(pwd))))
            {
                // Response.Redirect("home.aspx");
                string sql5 = "Select * from employee where username='"+username +"' and password='"+pwd+"'";
                DataTable dt;
                dt = d1.GetData(sql5);
                if (dt.Rows.Count != 1)
                    Label1.Text = "Invalid Login...";
                else
                {
                    string usernam_db = (dt.Rows[0][4]).ToString();
                    string pwd_db = (dt.Rows[0][5]).ToString();
                    if (username == usernam_db && pwd == pwd_db)
                    {
                        
                       // HttpCookie co = new HttpCookie("login");
                      //  co["username"] = username;
                      //  Response.Cookies.Add(co);
                        Session["username"] = username;
                        Response.Redirect("updateempform.aspx");
                    }
                    else
                        Label1.Text = "Wrong Password "+usernam_db+pwd_db ;
                }
            }
            else
                Label1.Text = "Please fill all fields... ";
        }
    }
}
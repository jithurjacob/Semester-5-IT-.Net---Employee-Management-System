using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class updateempform : System.Web.UI.Page
{
    Dbacess d1 = new Dbacess();
    protected void Page_Load(object sender, EventArgs e)
    {//  HttpCookie co = Request.Cookies["co"];
        try
        {
            if (!Page.IsPostBack)
            {
                string username = Session["username"].ToString();// co["username"];
                string sql5 = "Select * from employee where username='" + username + "' ";
                DataTable dt;
                dt = d1.GetData(sql5);
                if (dt.Rows.Count != 1)
                    Label1.Text = "Invalid Login...";
                else
                {
                    string usernam_db = (dt.Rows[0][4]).ToString();

                    TextBox1.Text = dt.Rows[0][1].ToString();
                    TextBox2.Text = dt.Rows[0][2].ToString();
                    TextBox3.Text = dt.Rows[0][4].ToString();
                    TextBox4.Text  = dt.Rows[0][5].ToString();
                    TextBox5.Text = dt.Rows[0][7].ToString();
                    TextBox6.Text = dt.Rows[0][3].ToString();
                    TextBox7.Text = dt.Rows[0][6].ToString();
                    TextBox8.Text = dt.Rows[0][8].ToString();
                    TextBox9.Text = dt.Rows[0][9].ToString();

                }
            }
        }
        catch (Exception ex)
        {
            Label1.Text = ex.ToString();
            Response.Redirect("default.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string fname,empid,  lname, addr, username, pwd, contactno, city, salary, desg;

        fname = TextBox1.Text;
        lname = TextBox2.Text;
        username = TextBox3.Text;
        pwd = TextBox4.Text;
        city = TextBox5.Text;
        addr  = TextBox6.Text;
        contactno  = TextBox7.Text;
        salary  = TextBox8.Text;
        desg  = TextBox9.Text;
        DataTable dt, dt1;

        string sql3 = "update  employee set firstname='" + fname + "',lastname='" + lname + "',address='" + addr + "',password='" + pwd + "',contactno='" + contactno + "',city='" + city + "',salary=" + salary + ",designation='" + desg + "' where (username='"+username +"');";
      //  Label1.Text = sql3;
        int b =  d1.Updatedata(sql3);
        if (b > 0)
        {

            Label1.Text = "Profile updated successfully..." ;
        }

        else
            Label1.Text = "Profile updation  Failed...";
    }
}
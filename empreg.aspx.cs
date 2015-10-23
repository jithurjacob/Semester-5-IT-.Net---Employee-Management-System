using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class empreg : System.Web.UI.Page
{
    Dbacess d1 = new Dbacess();


    protected void Button1_Click(object sender, EventArgs e)
    {
        string fname,empid, lname, addr, username, pwd,contactno,city,salary,desg;
        
        fname = TextBox1.Text;
        lname = TextBox2.Text;
        username = TextBox3.Text;
        pwd = TextBox4.Text;
        city = TextBox5.Text;
        salary = TextBox6.Text;
        desg = TextBox7.Text;
        addr = TextBox8.Text;
        contactno = TextBox9.Text;
        DataTable dt,dt1;
        if (fname.Equals("") || lname.Equals("") || username.Equals("") || pwd.Equals("") || city.Equals("") || salary.Equals("") || desg.Equals("") || addr.Equals("") || contactno.Equals(""))
        {
            Label1.Text = "All fields are required....";
            return;
        }
        
        string sql5 = "Select max(empid)+1 as count from employee";
        dt = d1.GetData(sql5);
        empid = (dt.Rows[0][0]).ToString();
        Boolean  valid = true ;
        string sql1 = "select username from employee where username='"+username +"'";
        dt1 = d1.GetData(sql1);
        if (dt1.Rows.Count > 0)
            valid = false;

        if (empid == "")
            empid = "1";
        if (valid)
        {
            string sql3 = "insert into employee values('" + empid + "','" + fname + "','" + lname + "','" + addr + "','" + username + "','" + pwd + "','" + contactno + "','" + city + "','" + salary + "','" + desg + "');";
            //Label1.Text = sql3;
            int b = d1.InsertData(sql3);
            if (b > 0)
            {

                Label1.Text = "Registered";
                TextBox1.Text = "";
                TextBox2.Text="";
                TextBox3.Text="";
                TextBox4.Text="";
                TextBox5.Text="";
                TextBox6.Text="";
                TextBox7.Text="";
                TextBox8.Text="";
                TextBox9.Text="";
            }

            else
                Label1.Text = " Registration Failed";
            
        }
        else
            Label1.Text = "Username was already used...";
    }


    protected void Page_Load(object sender, EventArgs e)
    {

    }
}